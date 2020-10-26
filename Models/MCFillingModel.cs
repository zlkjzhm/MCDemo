using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCDemo.Models
{
    class MCFillingModel
    {
        //填料片属性
        private double _length;         //单位：mm
        private double _width;          //单位：mm
        private double _density;        //单位：g/cm3
        private double _thickness;      //单位：mm
        private double _waveDistance;   //单位：mm
        public MCFillingModel(double length, double width, double density, double thickness, double waveDistance)
        {
            //_length = 1000;
            //_width = 500;
            //_density = 1.45;
            //_thickness = 0.45;
            //_waveDistance = 34;
            _length = length;
            _width = width;
            _density = density;
            _thickness = thickness;
            _waveDistance = waveDistance;

        }

        public double MassCalculate()
        {
            double res = (_length / 1000) * (_width / 1000) * (_thickness / 1000) * (_density * 1000) * 59;
            return res;
        }
    }
}
