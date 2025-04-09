using System.ComponentModel;
using System.Runtime.CompilerServices;
using NCalc;
namespace Integrate
{
    public enum Method { MiddleRect, Trapezoid, Simpson };
    public class IntegralData 
    {
        /*var expr = new NCalc.Expression("Cos(x)");
            expr.Parameters.Add("x", Math.PI);
            var res = expr.Evaluate();
            MessageBox.Show(res.ToString());*/
        public static double IntegrateByMiddleRect(Expression func, double a, double b, int parts)
        {
            double area = 0.0;
            double h = (b - a) / parts;
            for (int i = 0; i < parts;i++)
            {
                func.Parameters.Clear();
                func.Parameters.Add("x",a+h*(i+0.5));
                func.Parameters.Add("X", a + h * (i + 0.5));
                area += h * (double)func.Evaluate();
            }
            return area;
        }

        public static double IntegrateByTrapezoid(Expression func, double a, double b, int parts)
        {
            return 0.0;
        }

        public static double IntegrateBySimpson(Expression func, double a, double b, int parts)
        {
            return 0.0;
        }
    }
}
