using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VazaoRio
{

    public class AreaPerimeter
    {
        /// <summary>Computes area in region: Sums start[i] to end[i]</summary>
        /// <param name="riverProfile">Margin distance in meters vs height in meters</param>
        /// <param name="height">River fill height</param>
        /// <param name="start">X start coordinates</param>
        /// <param name="stop">X stop coordinates</param>
        /// <returns></returns>
        public static double GetArea(SortedList<double, double> riverProfile, double height, double[] start, double[] stop, out double perimeter)
        {
            if (start.Length != stop.Length) throw new Exception("Number of start points must match number of stop points");

            List<double> x = riverProfile.Keys.ToList();
            List<double> y = riverProfile.Values.ToList();

            for (int k = 0; k < y.Count; k++) y[k] = height - y[k];

            double area = 0;
            double perim = 0;
            for (int i = 0; i < start.Length; i++)
            {
                double y0, x0 = start[i];
                int j0 = FindNumber(x, x0, y, out y0);

                double yf, xf = stop[i];
                int jf = FindNumber(x, xf, y, out yf) - 1;

                double curArea = 0, curPerim = 0;
                if (jf >= j0)
                {
                    curArea += (y0 + y[j0]) * (x[j0] - x0);
                    curPerim += Math.Sqrt((y[j0] - y0) * (y[j0] - y0) + (x[j0] - x0) * (x[j0] - x0));

                    for (int j = j0; j < jf; j++)
                    {
                        curArea += (y[j + 1] + y[j]) * (x[j + 1] - x[j]);
                        curPerim += Math.Sqrt((y[j + 1] - y[j]) * (y[j + 1] - y[j]) + (x[j + 1] - x[j]) * (x[j + 1] - x[j]));
                    }

                    curArea += (yf + y[jf]) * (xf - x[jf]);
                    curPerim += Math.Sqrt((yf - y[jf]) * (yf - y[jf]) + (xf - x[jf]) * (xf - x[jf]));
                }
                else if (jf == j0 - 1)
                {
                    curArea = (yf + y0) * (xf - x0);
                    curPerim += Math.Sqrt((yf - y0) * (yf - y0) + (xf - x0) * (xf - x0));
                }

                curArea *= 0.5;
                area += curArea;
                perim += curPerim;
            }

            perimeter = perim;
            return area;
        }

        /// <summary>Finds index to insert targetX in x</summary>
        /// <param name="x">x array</param>
        /// <param name="targetX">Target x</param>
        /// <param name="y">y values associated with x</param>
        /// <param name="yVal">y value of target x</param>
        /// <returns></returns>
        public static int FindNumber(List<double> x, double targetX, List<double> y, out double yVal)
        {
            int ipos = x.BinarySearch(targetX);

            if (ipos >= 0)
            {
                // exact target found at position "ipos"
                yVal = y[ipos];
                return ipos + 1;
            }
            else
            {
                // Exact key not found: BinarySearch returns negative when the 
                // exact target is not found, which is the bitwise complement 
                // of the next index in the list larger than the target.
                ipos = ~ipos;
                if (ipos >= 0 && ipos < x.Count)
                {
                    if (ipos > 0)
                    {
                        // target is between positions "ipos-1" and "ipos"
                        double t = (targetX - x[ipos - 1]) / (x[ipos] - x[ipos - 1]);
                        yVal = y[ipos] * t + (1 - t) * y[ipos - 1];
                        return ipos;
                    }
                    else
                    {
                        // target is below position "ipos"
                        yVal = y[0];
                        return 0;
                    }
                }
                else
                {
                    // target is above position "ipos"
                    yVal = y[x.Count - 1];
                    return x.Count - 1;
                }
            }
        }

        /// <summary>Finds points where height of river is h</summary>
        /// <param name="riverProfile">River profile</param>
        /// <param name="h">Desired height</param>
        /// <returns></returns>
        public static double[] Solve(SortedList<double, double> riverProfile, double h)
        {
            List<double> sols = new List<double>();

            List<double> x = riverProfile.Keys.ToList();
            List<double> y = riverProfile.Values.ToList();

            y[0] -= h;

            for (int i = 0; i < x.Count - 1; i++)
            {
                y[i + 1] -= h;
                if ((y[i] >= 0 && y[i + 1] < 0) || (y[i] <= 0 && y[i + 1] > 0))
                {
                    sols.Add((x[i] * y[i + 1] - x[i + 1] * y[i]) / (y[i + 1] - y[i]));
                }
            }


            return sols.ToArray();
        }
    }
}
