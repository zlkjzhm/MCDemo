using Caliburn.Micro;
using MCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MCDemo.ViewModels
{
    class MCMainViewModel : PropertyChangedBase
    {
        private MCFillingModel _filling;
        private double _fillingResult;

        public double FillingResult
        {
            get { return _fillingResult; }
            set 
            {
                _fillingResult = value;
                NotifyOfPropertyChange(() => FillingResult);
            }
        }

        public MCMainViewModel()
        {
            _filling = new MCFillingModel(1000, 500, 1.45, 0.45, 34);
            _fillingResult = 2000;
        }
        public void FillingCalculate()
        {
            // _fillingResult = _filling.MassCalculate();
            FillingResult = _filling.MassCalculate();
            //MessageBox.Show(_fillingResult.ToString());
        }
    }
}
