using System;

namespace MCDemo.Models
{
    //波片
    class WavePlate
    {
        private double _length;
        private double _width;
        private double _thinkness;
        private int _num;
        private double _weight;
        private double _density;

        public double Thinkness
        {
            get { return _thinkness; }
            private set {}
        }

        public WavePlate(double thinkness, double density, double length = 1000, double width = 250)
        {
            _length = length;
            _width = width;
            _thinkness = thinkness;
            _density = density;
        }
        public double GetWeight(int num)
        {
            _num = num;
            double ret = (_length / 1000) * (_width / 1000) * (0.6 / 1000) * _density * 1000 * _num;
            _weight = ret;
            return ret;
        }
    }
    //弯板的类型
    enum BPType
    {
        None,
        T60 = 60,
        T50 = 50,
        T45 = 45,
        T40 = 40,
        T28 = 28
    }
    //弯板
    class BendingPlate
    {
        private BPType _type;
        private int _num;
        private double _weight;
        public BPType Type 
        {
            get
            {
                return _type;
            }
            private set { } 
        }
        public BendingPlate(BPType type)
        {
            _type = type;
        }
        public double GetWeight(int num, double weight = 19)
        {
            _num = num;
            _weight = weight;
            double ret = weight / 1000 * num;

            return ret;
        }
    }
    //穿杆
    class Threading
    {
        private int _num;
        private double _weight;

        public int Num
        {
            get { return _num; }
            private set {}
        }

        public Threading(int num = 6, double weight = 0.09)
        {
            _num = num;
            _weight = weight;
        }
        public double GetWeight()
        {
            double ret = _weight * _num;
            return ret;
        }
    }
    //螺母
    class Nut
    {
        private int _num;
        private double _weight;
        public Nut(int num = 12, double weight = 0.001)
        {
            _num = num;
            _weight = weight;
        }
        public double GetWeight()
        {
            double ret = _weight * _num;
            return ret;
        }
    }
    //收水器
    class MCWaterCollectorModel
    {
        private WavePlate _wavePlate;
        private BendingPlate _bendingPlate;
        private Threading _tHreading;
        private Nut _nut;
        public MCWaterCollectorModel(double wpThinkness, double wpDensity, BPType bPType)
        {
            _wavePlate = new WavePlate(wpThinkness, wpDensity);
            _bendingPlate = new BendingPlate(bPType);
            _tHreading = new Threading();
            _nut = new Nut();
        }

        public double WeightCalculate()
        {
            //double numTemp = (1000.0f - _wavePlate.Thinkness) / ((double)_bendingPlate.Type + _wavePlate.Thinkness) + 1;
            double numTemp = (1000.0f - _wavePlate.Thinkness) / ((double)_bendingPlate.Type + _wavePlate.Thinkness);
            int wavePlate = (int)Math.Floor(numTemp + 0.5f);
            double ret = _wavePlate.GetWeight(wavePlate) + _bendingPlate.GetWeight((wavePlate - 1) * (_tHreading.Num / 2)) + _tHreading.GetWeight() + _nut.GetWeight();
            return ret;
        }
    }
}
