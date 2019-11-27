using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquations.Core.Services
{
    public interface IQuadraticEquationService
    {
        double GetQuadraticEq(double a, double b, double c, bool suma);
    }
}
