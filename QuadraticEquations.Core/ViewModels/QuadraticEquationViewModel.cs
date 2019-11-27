using MvvmCross.Commands;
using MvvmCross.ViewModels;
using QuadraticEquations.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquations.Core.ViewModels
{
    public class QuadraticEquationViewModel : MvxViewModel
    {
        private readonly IQuadraticEquationService _quadraticEquationService;
        private double _a, _b, _c, _x1, _x2;
        private MvxCommand _calculateCommand;

        public QuadraticEquationViewModel(IQuadraticEquationService quadraticEquationService)
        {
            _quadraticEquationService = quadraticEquationService;
        }
        public double A
        {
            get => _a;
            set => SetProperty(ref _a, value);
        }

        public double B
        {
            get => _b;
            set => SetProperty(ref _b, value);
        }

        public double C
        {
            get => _c;
            set => SetProperty(ref _c, value);
        }

        public double X1
        {
            get => _x1;
            set => SetProperty(ref _x1, value);
        }

        public double X2
        {
            get => _x2;
            set => SetProperty(ref _x2, value);
        }

        public MvxCommand CalculateCommand
        {
            get
            {
                _calculateCommand = _calculateCommand ?? new MvxCommand(Calculate);
                return _calculateCommand;
            }
        }

        private void Calculate()
        {
            X1 = _quadraticEquationService.GetQuadraticEq(A, B, C, true);
            X2 = _quadraticEquationService.GetQuadraticEq(A, B, C, false);
        }
    }
}
