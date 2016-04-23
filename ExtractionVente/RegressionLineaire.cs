using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractionVente
{
    public static class RegressionLineaire
    {
        static public void exemple()
        {
            var points = new List<PointD>()
            {
                new PointD{X=1,Y=8},
                new PointD{X=3,Y=1},
                new PointD{X=2,Y=4}
            };

            var a = Variance(points, p => p.X, p => p.Y) / Variance(points, p => p.X, p => p.X);
            var b = points.Average(p => p.Y) - a * points.Average(p => p.X);
        }

        public static double Variance<T>(this IEnumerable<T> list, Func<T, double> selectA, Func<T, double> selectB)
        {
            return list.Average(p => selectA(p) * selectB(p)) - (list.Average(p => selectA(p)) * list.Average(p => selectB(p)));
        }

        public struct PointD
        {
            public double X { get; set; }
            public double Y { get; set; }
        }

        public static double regression(List<PointD> points, int x) {
            var a = Variance(points, p => p.X, p => p.Y) / Variance(points, p => p.X, p => p.X);
            var b = points.Average(p => p.Y) - a * points.Average(p => p.X);

            return Math.Round(a * x + b);
        }
    }


}
