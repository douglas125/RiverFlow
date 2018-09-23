using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VazaoRio
{
    public partial class Form1 : Form
    {
        /// <summary>Number of divisions in flow curve</summary>
        public int NDIVSCURVAQ = 1157;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbRugosidade.SelectedIndex = 0;

            //zedCurvaVazao.GraphPane.Title.Text = "Curva de vazão";
            zedCurvaVazao.GraphPane.Title.Text = "River Flow Chart";
            zedCurvaVazao.GraphPane.YAxis.Title.Text = "h (m)";
            zedCurvaVazao.GraphPane.XAxis.Title.Text = "Q (m³/s)";


            //zedPerfil.GraphPane.Title.Text = "Perfil do Rio";
            zedPerfil.GraphPane.Title.Text = "River Profile";
            zedPerfil.GraphPane.XAxis.Title.Text = "x (m)";
            zedPerfil.GraphPane.YAxis.Title.Text = "h (m)";
            btnAtualizar_Click(sender, e);
            
            SortedList<double, double> lst = new SortedList<double, double>();
            int N = 1000;
            for (int i = 0; i < N; i++)
            {
                double tt = 10*i / (double)(N - 1);
                //lst.Add(tt, 4 / 3 * tt * tt * tt - tt);
                //lst.Add(tt, Math.Sin(3 * tt) * Math.Exp(-tt));
                //lst.Add(tt, tt);
                lst.Add(tt, Math.Sin(tt));
            }

            List<double> x = lst.Keys.ToList();
            List<double> y = lst.Values.ToList();

            double perim;
            double a = AreaPerimeter.GetArea(lst, 0, new double[] { 0.1 }, new double[] { 0.9 }, out perim);

            //double[] sols = AreaPerimeter.Solve(lst, 0.2);
        }

        #region Visualizacao do perfil
        SortedList<double, double> lstProfile;
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            lstProfile = ReadRiverProfile(txtProfile.Text);

            DesenhaPerfil();
        }

        private SortedList<double, double> ReadRiverProfile(string profileData)
        {
            SortedList<double, double> profile = new SortedList<double, double>();
            string sepDec = (1.5).ToString().Substring(1, 1);

            string[] ss = profileData.Replace(".",sepDec).Replace(",",sepDec).Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in ss)
            {
                string[] coords = s.Split(new string[] { "\t", " ", ";" }, StringSplitOptions.RemoveEmptyEntries);

                if (coords.Length == 2)
                {
                    double x, y;
                    bool parsed = true;
                    parsed = double.TryParse(coords[0], out x) ? parsed : false;
                    parsed = double.TryParse(coords[1], out y) ? parsed : false;

                    if (parsed && !profile.ContainsKey(x)) profile.Add(x, y);
                }
            }

            return profile;
        }

        private void DesenhaPerfil()
        {
            zedPerfil.GraphPane.CurveList.Clear();
            zedPerfil.GraphPane.GraphObjList.Clear();


            double h = (double)numH.Value;
            double[] sols = AreaPerimeter.Solve(lstProfile, h);

            if (sols.Length % 2 == 0)
            {
                double[] start = new double[sols.Length>>1];
                double[] stop = new double[sols.Length>>1];
                double totalLength = 0;
                for (int k = 0; k < sols.Length; k += 2)
                {
                    start[k >> 1] = sols[k];
                    stop[k >> 1] = sols[k + 1];
                    totalLength += sols[k + 1] - sols[k];

                    double[] xx = new double[] { sols[k], sols[k + 1] };
                    double[] yy = new double[] { h, h };
                    //ZedGraph.LineItem li3 = zedPerfil.GraphPane.AddCurve(k == 0 ? "Nível de água" : "", xx, yy, Color.LightBlue, ZedGraph.SymbolType.None);
                    ZedGraph.LineItem li3 = zedPerfil.GraphPane.AddCurve(k == 0 ? "Water level" : "", xx, yy, Color.LightBlue, ZedGraph.SymbolType.None);
                    li3.Line.Width = 3;
                }

                double p2;
                double area = AreaPerimeter.GetArea(lstProfile, h, start, stop, out p2);

                lblArea.Text = Math.Round(area,3).ToString();
                lblPerim.Text = Math.Round(p2,3).ToString();
                lblSurfLen.Text = Math.Round(totalLength, 3).ToString();
            }



            #region Graficos
            double[] x = lstProfile.Keys.ToArray();
            double[] y = lstProfile.Values.ToArray();

            ZedGraph.LineItem li = zedPerfil.GraphPane.AddCurve("", x, y, Color.SandyBrown);
            li.Line.Width = 3;


            double[] xNivel = new double[] { 10, 20 };
            double[] yNivel = new double[] { -1, -1 };
            //ZedGraph.LineItem li2 = zedPerfil.GraphPane.AddCurve("", xNivel, yNivel, Color.LightBlue); //, ZedGraph.SymbolType.None);
            //li2.Line.Fill = new ZedGraph.Fill(Color.Blue, Color.Blue, 45F);

            List<ZedGraph.PointD> lstPt = new List<ZedGraph.PointD>();
            lstPt.Add(new ZedGraph.PointD(2, -1));
            lstPt.Add(new ZedGraph.PointD(8, -1));
            lstPt.Add(new ZedGraph.PointD(9, -3));
            lstPt.Add(new ZedGraph.PointD(0, -3.5));

            ZedGraph.PolyObj pObj = new ZedGraph.PolyObj(lstPt.ToArray(), Color.LightBlue, Color.Blue, Color.Blue);
            //zedPerfil.GraphPane.GraphObjList.Add(pObj);

            zedPerfil.AxisChange();
            zedPerfil.Refresh();
            #endregion
        }
        
        private void numH_ValueChanged(object sender, EventArgs e)
        {
            DesenhaPerfil();
        }
        private void txtProfile_Leave(object sender, EventArgs e)
        {
            btnAtualizar_Click(sender, e);
        }
        
        private void btnCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string s = System.IO.File.ReadAllText(ofd.FileName);
                txtProfile.Text = s;
                btnAtualizar_Click(sender, e);
            }
        }
        #endregion

        #region Calculo de vazao
        private void cmbRugosidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sepDec = (1.5).ToString().Substring(1, 1);
            string[] s = cmbRugosidade.Items[cmbRugosidade.SelectedIndex].ToString().Split(new string[] { " ", "-" }, StringSplitOptions.RemoveEmptyEntries);

            double n;
            if (double.TryParse(s[0], out n))
            {
                numRugosidade.Enabled = false;
                numRugosidade.Value = (decimal)n;
            }
            else
            {
                numRugosidade.Enabled = true;
                numRugosidade.Focus();
            }
        }


        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            List<double> lstQ = new List<double>();
            List<double> lsth = new List<double>();

            double n = (double)numRugosidade.Value;
            double S = (double)numInclinacao.Value;


            double[] x = lstProfile.Keys.ToArray();
            double[] y = lstProfile.Values.ToArray();

            double hMax = y[0], hMin = y[0];
            for (int k = 0; k < y.Length; k++)
            {
                hMax = Math.Max(hMax, y[k]);
                hMin = Math.Min(hMin, y[k]);
            }

            List<double> lstH = new List<double>();
            double curH = hMin;
            double hStep = (hMax - hMin) / NDIVSCURVAQ;

            while (curH < hMax)
            {
                double[] sols = AreaPerimeter.Solve(lstProfile, curH);

                if ((sols.Length & 1) == 0)
                {
                    double[] start = new double[sols.Length >> 1];
                    double[] stop = new double[sols.Length >> 1];
                    for (int k = 0; k < start.Length; k++)
                    {
                        start[k] = sols[(k << 1)];
                        stop[k] = sols[1 + (k << 1)];
                    }

                    double a, p;
                    a = AreaPerimeter.GetArea(lstProfile, curH, start, stop, out p);

                    lsth.Add(curH);
                    lstQ.Add(Manning(a, p, S, n));
                }

                curH += hStep;
            }

            //Graphs
            zedCurvaVazao.GraphPane.CurveList.Clear();

            zedCurvaVazao.GraphPane.AddCurve("", lstQ.ToArray(), lsth.ToArray(), Color.Black, ZedGraph.SymbolType.None);

            zedCurvaVazao.AxisChange();
            zedCurvaVazao.Refresh();
        }

        private double Manning(double A, double p, double S, double n)
        {
            double R = A / p;
            return A / n * Math.Pow(R, 0.666666666666666666) * Math.Sqrt(S);
        }
        
        private void numInclinacao_ValueChanged(object sender, EventArgs e)
        {
            btnRecalcular_Click(sender, e);
        }

        private void numRugosidade_ValueChanged(object sender, EventArgs e)
        {
            btnRecalcular_Click(sender, e);
        }
        #endregion









    }
}
