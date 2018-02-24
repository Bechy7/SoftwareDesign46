namespace Aflevering_1
{
    class Stock : Subject
    {
        private string _name;
        private double _value;
        public Stock(string name, double value)
        {
            _name = name;
            _value = value;
        }

        public Stock(string name)
        {
            _name = name;
            _value = 0;
        }

        public double Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    Notify();
                }
            }
        }

        public string Name
        {
            get { return _name; }
        }            
    }
}