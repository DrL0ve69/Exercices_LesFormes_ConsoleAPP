using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices_LesFormes_ConsoleAPP
{
    public class FormePoint
    {
        public double X { get; set; }
        public double Y { get; set; }
        public FormePoint(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double Distance(FormePoint p)
        {
            return Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));
        }
        public override string ToString()
        {
            string x = X + "";
            string y = Y + "";
            return $"P({x.Replace(",",".")}, {y.Replace(",",".")})\n";
        }
    }
}
