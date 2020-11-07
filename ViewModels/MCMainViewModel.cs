using Caliburn.Micro;
using MCDemo.Models;
using System.Windows;

namespace MCDemo.ViewModels
{
    class MCMainViewModel : Conductor<IScreen>
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

        public MCMainViewModel()
        {
            _filling = new MCFillingModel();
            _waterCollector = new MCWaterCollectorModel(BPType.T60, 0.6);
            _fillingResult = 0;
            _fillingThinkness = 0;

            
        }
        
        public void FillingCalculate()
        {
            //FillingResult = _filling.WeightCalculate(1000, 500, 1.45, _fillingThinkness, 34);
            FillingResult = _waterCollector.WeightCalculate();

            //MessageBox.Show(_fillingResult.ToString());
        }

        private void FillingButton(object sender, RoutedEventArgs e)
        {
            ActivateItem(new MCFillingViewModel());
        }

        private void WaterCollectorButton(object sender, RoutedEventArgs e)
        {
            ActivateItem(new MCWaterCollectorViewModel());

        }
    }
}
