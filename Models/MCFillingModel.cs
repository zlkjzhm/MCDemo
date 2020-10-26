using System;

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
        public MCFillingModel()
        {
            //_length = 1000;
            //_width = 500;
            //_density = 1.45;
            //_thickness = 0.45;
            //_waveDistance = 34;


        }

        public double MassCalculate(double length, double width, double density, double thickness, double waveDistance)
        {
            //保存数据
            _length = length;
            _width = width;
            _density = density;
            _thickness = thickness;
            _waveDistance = waveDistance;
            //每立方米的片数
            double NumOfSlices = Math.Floor(2000 / waveDistance + 0.5f); //四舍五入 
            double res = (length / 1000) * (width / 1000) * (thickness / 1000) * (density * 1000) * NumOfSlices;
            return res;
        }
    }
}
