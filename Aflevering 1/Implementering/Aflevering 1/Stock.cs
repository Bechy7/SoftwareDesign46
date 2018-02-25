namespace Aflevering_1
{
    class Stock : Subject
    {
        public Stock(string name, double value)
            : base(name, value)
        {

        }

        public virtual void Attach(IObserver observer)
        {
            base.Attach(observer);
            ((Portfolio)observer).AddStock(this);
        }

        public virtual void Detach(IObserver observer)
        {
            base.Detach(observer);
            ((Portfolio)observer).RemoveStock(this);
        }

    }
}