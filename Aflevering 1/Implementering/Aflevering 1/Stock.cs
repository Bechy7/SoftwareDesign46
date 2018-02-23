namespace Aflevering_1
{
    class Stock : Subject
    {
        private string _name;
        private float _value;
        Stock(string name, float value)
        {
            _name = name;
            _value = value;
        }

        public void SetValue(float value)
        {
            _value = value;
            Notify();
        }
        

                
    }
}