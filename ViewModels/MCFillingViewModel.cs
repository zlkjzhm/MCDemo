using Caliburn.Micro;
using MCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCDemo.ViewModels
{
    class MCFillingViewModel : Screen
    {
        private MCFillingModel _filling;
        private MCWaterCollectorModel _waterCollector;
        private double _fillingResult;
        private double _fillingThinkness;

        public double FillingThinkness
        {
            get { return _fillingThinkness; }
            set
            {
                _fillingThinkness = value;
                NotifyOfPropertyChange(() => FillingThinkness);

            }
        }

        public double FillingResult
        {
            get { return _fillingResult; }
            set
            {
                _fillingResult = value;
                NotifyOfPropertyChange(() => FillingResult);
            }
        }

        public MCFillingViewModel()
        {
            _filling = new MCFillingModel();
            _waterCollector = new MCWaterCollectorModel(BPType.T60, 0.6);
            _fillingResult = 0;
            _fillingThinkness = 0;
        }
        public void FillingCalculate()
        {
            FillingResult = _filling.WeightCalculate(1000, 500, 1.45, _fillingThinkness, 34);
            //FillingResult = _waterCollector.WeightCalculate();

            //MessageBox.Show(_fillingResult.ToString());
        }
    }
}
