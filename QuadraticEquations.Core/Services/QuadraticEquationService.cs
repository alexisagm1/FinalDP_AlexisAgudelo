using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquations.Core.Services
{
    public class QuadraticEquationService : IQuadraticEquationService
    {
        public double GetQuadraticEq(double a, double b, double c, bool suma)
        {
            if (suma == true)
            {
                return (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            }
            else
            {
                return (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            }
        }
    }
}
