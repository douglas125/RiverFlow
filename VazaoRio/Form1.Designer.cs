namespace VazaoRio
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numH = new System.Windows.Forms.NumericUpDown();
            this.lblPerim = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zedPerfil = new ZedGraph.ZedGraphControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtProfile = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.zedCurvaVazao = new ZedGraph.ZedGraphControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRecalcular = new System.Windows.Forms.Button();
            this.cmbRugosidade = new System.Windows.Forms.ComboBox();
            this.numRugosidade = new System.Windows.Forms.NumericUpDown();
            this.numInclinacao = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSurfLen = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRugosidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInclinacao)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(874, 538);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(866, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Profile";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblSurfLen);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.numH);
            this.groupBox2.Controls.Add(this.lblPerim);
            this.groupBox2.Controls.Add(this.lblArea);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.zedPerfil);
            this.groupBox2.Location = new System.Drawing.Point(193, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 500);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profile Visualization";
            // 
            // numH
            // 
            this.numH.DecimalPlaces = 2;
            this.numH.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numH.Location = new System.Drawing.Point(67, 22);
            this.numH.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numH.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numH.Name = "numH";
            this.numH.Size = new System.Drawing.Size(73, 20);
            this.numH.TabIndex = 2;
            this.numH.Value = new decimal(new int[] {
            351,
            0,
            0,
            -2147352576});
            this.numH.ValueChanged += new System.EventHandler(this.numH_ValueChanged);
            // 
            // lblPerim
            // 
            this.lblPerim.AutoSize = true;
            this.lblPerim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPerim.Location = new System.Drawing.Point(401, 24);
            this.lblPerim.Name = "lblPerim";
            this.lblPerim.Size = new System.Drawing.Size(15, 15);
            this.lblPerim.TabIndex = 1;
            this.lblPerim.Text = "0";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArea.Location = new System.Drawing.Point(224, 24);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(15, 15);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Perimeter (m):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Area (m²):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Height (m):";
            // 
            // zedPerfil
            // 
            this.zedPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedPerfil.Location = new System.Drawing.Point(6, 48);
            this.zedPerfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zedPerfil.Name = "zedPerfil";
            this.zedPerfil.ScrollGrace = 0D;
            this.zedPerfil.ScrollMaxX = 0D;
            this.zedPerfil.ScrollMaxY = 0D;
            this.zedPerfil.ScrollMaxY2 = 0D;
            this.zedPerfil.ScrollMinX = 0D;
            this.zedPerfil.ScrollMinY = 0D;
            this.zedPerfil.ScrollMinY2 = 0D;
            this.zedPerfil.Size = new System.Drawing.Size(655, 446);
            this.zedPerfil.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnCarregar);
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.txtProfile);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 500);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Height data";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(87, 19);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(88, 23);
            this.btnCarregar.TabIndex = 2;
            this.btnCarregar.Text = "&Load...";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(6, 19);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "&Update";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtProfile
            // 
            this.txtProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtProfile.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfile.Location = new System.Drawing.Point(6, 48);
            this.txtProfile.Multiline = true;
            this.txtProfile.Name = "txtProfile";
            this.txtProfile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtProfile.Size = new System.Drawing.Size(169, 435);
            this.txtProfile.TabIndex = 0;
            this.txtProfile.Text = resources.GetString("txtProfile.Text");
            this.txtProfile.Leave += new System.EventHandler(this.txtProfile_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(866, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Flow Curve";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.zedCurvaVazao);
            this.groupBox4.Location = new System.Drawing.Point(6, 110);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(854, 396);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gráfico da curva de vazão";
            // 
            // zedCurvaVazao
            // 
            this.zedCurvaVazao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedCurvaVazao.Location = new System.Drawing.Point(9, 19);
            this.zedCurvaVazao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zedCurvaVazao.Name = "zedCurvaVazao";
            this.zedCurvaVazao.ScrollGrace = 0D;
            this.zedCurvaVazao.ScrollMaxX = 0D;
            this.zedCurvaVazao.ScrollMaxY = 0D;
            this.zedCurvaVazao.ScrollMaxY2 = 0D;
            this.zedCurvaVazao.ScrollMinX = 0D;
            this.zedCurvaVazao.ScrollMinY = 0D;
            this.zedCurvaVazao.ScrollMinY2 = 0D;
            this.zedCurvaVazao.Size = new System.Drawing.Size(826, 361);
            this.zedCurvaVazao.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRecalcular);
            this.groupBox3.Controls.Add(this.cmbRugosidade);
            this.groupBox3.Controls.Add(this.numRugosidade);
            this.groupBox3.Controls.Add(this.numInclinacao);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(740, 98);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parâmetros";
            // 
            // btnRecalcular
            // 
            this.btnRecalcular.Location = new System.Drawing.Point(6, 67);
            this.btnRecalcular.Name = "btnRecalcular";
            this.btnRecalcular.Size = new System.Drawing.Size(150, 23);
            this.btnRecalcular.TabIndex = 5;
            this.btnRecalcular.Text = "&Recompute";
            this.btnRecalcular.UseVisualStyleBackColor = true;
            this.btnRecalcular.Click += new System.EventHandler(this.btnRecalcular_Click);
            // 
            // cmbRugosidade
            // 
            this.cmbRugosidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRugosidade.FormattingEnabled = true;
            this.cmbRugosidade.Items.AddRange(new object[] {
            "35E-2 - Large rivers",
            "30E-2 - Clean plain rivers",
            "40E-2 - Muddy or wrinkled rivers",
            "Others"});
            this.cmbRugosidade.Location = new System.Drawing.Point(531, 18);
            this.cmbRugosidade.Name = "cmbRugosidade";
            this.cmbRugosidade.Size = new System.Drawing.Size(189, 21);
            this.cmbRugosidade.TabIndex = 4;
            this.cmbRugosidade.SelectedIndexChanged += new System.EventHandler(this.cmbRugosidade_SelectedIndexChanged);
            // 
            // numRugosidade
            // 
            this.numRugosidade.DecimalPlaces = 3;
            this.numRugosidade.Enabled = false;
            this.numRugosidade.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numRugosidade.Location = new System.Drawing.Point(559, 45);
            this.numRugosidade.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRugosidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numRugosidade.Name = "numRugosidade";
            this.numRugosidade.Size = new System.Drawing.Size(162, 20);
            this.numRugosidade.TabIndex = 3;
            this.numRugosidade.Value = new decimal(new int[] {
            35,
            0,
            0,
            196608});
            this.numRugosidade.ValueChanged += new System.EventHandler(this.numRugosidade_ValueChanged);
            // 
            // numInclinacao
            // 
            this.numInclinacao.DecimalPlaces = 7;
            this.numInclinacao.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numInclinacao.Location = new System.Drawing.Point(558, 71);
            this.numInclinacao.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numInclinacao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.numInclinacao.Name = "numInclinacao";
            this.numInclinacao.Size = new System.Drawing.Size(162, 20);
            this.numInclinacao.TabIndex = 3;
            this.numInclinacao.Value = new decimal(new int[] {
            21,
            0,
            0,
            262144});
            this.numInclinacao.ValueChanged += new System.EventHandler(this.numInclinacao_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(529, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "n = ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(529, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "S = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "S = river slope (m/m)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "R = hydraulic radius (m) = area/perimeter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "n = rugosity coefficient";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Q = flow (m³/s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "A = river area (m²)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Q = A / n * R^(2/3) * S ^ (1/2)";
            // 
            // lblSurfLen
            // 
            this.lblSurfLen.AutoSize = true;
            this.lblSurfLen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSurfLen.Location = new System.Drawing.Point(570, 24);
            this.lblSurfLen.Name = "lblSurfLen";
            this.lblSurfLen.Size = new System.Drawing.Size(15, 15);
            this.lblSurfLen.TabIndex = 3;
            this.lblSurfLen.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(468, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Surface length (m):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 562);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "River flow";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRugosidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInclinacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private ZedGraph.ZedGraphControl zedPerfil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtProfile;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.NumericUpDown numH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPerim;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbRugosidade;
        private System.Windows.Forms.NumericUpDown numRugosidade;
        private System.Windows.Forms.NumericUpDown numInclinacao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRecalcular;
        private ZedGraph.ZedGraphControl zedCurvaVazao;
        private System.Windows.Forms.Label lblSurfLen;
        private System.Windows.Forms.Label label13;
    }
}

