namespace Aflevering_1
{
    class Stock : Subject
    {
        private string _name;
        Stock(string name)
        {
            _name = name;
        }
        public float Value { get; set; }

                
    }
}