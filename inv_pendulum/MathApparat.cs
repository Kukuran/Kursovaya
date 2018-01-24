using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equalizer
{
    public static class MathApparat
    {
        public static double yTrianglePos(double x0, double x1, double x2, double x)
        {
            double yT = 0;
            if (x == x1)
            {
                yT = 1;
            }
            if (x > x0 && x < x1)
            {
                yT = (1.0 / (x1 - x0)) * x + (-x0 / (x1 - x0 + 0.0));
            }
            if (x > x1 && x < x2)
            {
                yT = (1.0 / (x2 - x1)) * x + (-x1 / (x2 - x1 + 0.0));
            }
            return yT;
        }
        public static double yTriangleNeg(double x0, double x1, double x2, double x)
        {
            double yT = 0;
            if (x == x1)
            {
                yT = 1;
            }
            if (x < x0 && x > x1)
            {
                yT = (1.0 / (x1 - x0)) * x + (-x0 / (x1 - x0 + 0.0));
            }
            if (x < x1 && x > x2)
            {
                yT = (1.0 / (x2 - x1)) * x + (-x1 / (x2 - x1 + 0.0));
            }
            return yT;
        }
        public static double yTriangleHalf(double x1, double x0, double x)
        {

            double y = 0;
            if (((x1 < x0) && (x == x1)) || ((x1 > x0) && (x == x1)))
            {
                y = 1;
            }
            if (((x > x1) && (x < x0)) || ((x < x1) && (x > x0)))
            {
                y = (1.0 / (x1 - x0)) * x + (-x0 / (x1 - x0 + 0.0));
            }
            return y;
        }
    }
}
