using Caliburn.Micro;
using MCDemo.Models;

namespace MCDemo.ViewModels
{
    class MCMainViewModel : PropertyChangedBase
    {
        private MCFillingModel _filling;
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

        public MCMainViewModel()
        {
            _filling = new MCFillingModel();
            _fillingResult = 0;
            _fillingThinkness = 0;
        }
        public void FillingCalculate()
        {
            // _fillingResult = _filling.MassCalculate();
            FillingResult = _filling.MassCalculate(1000, 500, 1.45, _fillingThinkness, 34);
            //MessageBox.Show(_fillingResult.ToString());
        }
    }
}
