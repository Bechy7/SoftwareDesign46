namespace Aflevering_1
{
    class Stock
    {
        public virtual void SetValue(float x)
        {
            _value = x;
        }

        //public float GetValue()
        //{
        //    return _value;
        //}

        private float _value;
    }
}