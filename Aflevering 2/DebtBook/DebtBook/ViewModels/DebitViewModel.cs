using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using DebtBook.Events;
using Prism.Mvvm;
using DebtBook.Model;

namespace DebtBook.ViewModels
{
    class DebitViewModel : BindableBase
    {



        //public List<Debitor> Debitors { get; set; }


        //public string name  { get; set; }
        //public double debting { get; set; }
        //public int id { get; set; }
        //public double gaeld = 50;

        private Debitor _currentDebitor;
        private string _name = "test";
        private List<Debt> _debts;
        private int _id;

        //public string Text
        //{
        //    get { return _text; }
        //    set { SetProperty(ref _text, value); }
        //}

        //private int _id = 1;

        //public int Id
        //{
        //    get { return _id; }
        //    set { SetProperty(ref _id, value); }
        //}
        //ShowDebitorEvent.Instance.Subscribe(ShowDebitorEvent);
        public DebitViewModel()
        {
            //MessageBox.Show("hej");
            ShowDebitorEvent.Instance.Subscribe(RegisterDebitor);


            //Text = "Hans";    
            //debts_.Add(new DebitorModel() { id = 1, name = "Hans" , debting = 50 });
        }

        void RegisterDebitor(Debitor debitor)
        {
            Name = debitor.Name;
            Debts = debitor.Debts;
            Id = debitor.Id;

            //MessageBox.Show(debitor.Name);
            //_currentDebitor = debitor;
        }

        public List<Debt> Debts
        {
            get
            {
                //Lav en ny liste hvis der er nul
                return _debts;

            }
            set { SetProperty(ref _debts, value); }
        }

        //public Debitor CurrentDebitor
        //{
        //    get
        //    {
        //        MessageBox.Show(_currentDebitor.Name);
        //        return _currentDebitor;
        //    }
        //    set
        //    {
        //        MessageBox.Show(_currentDebitor.Name);
        //        SetProperty(ref _currentDebitor, value);
        //    }
        //}

        public string Name
        {
            get
            {
                //MessageBox.Show(CurrentDebitor.Name);
                return _name;
            }
            set
            {
                //_name = value;
                SetProperty(ref _name, value);
                //MessageBox.Show("name set");
            }
        }

        public int Id
        {
            get
            {
                //MessageBox.Show(CurrentDebitor.Name);
                return _id;
            }
            set
            {
                //_name = value;
                SetProperty(ref _id, value);
                //MessageBox.Show("name set");
            }
        }
        //public DebitorModel Model { get; set; }

        //private ObservableCollection<DebitorModel> debts_;

        //public ObservableCollection<DebitorModel> Debts
        //{
        //    get { return debts_; }
        //    set { debts_ = value; RaisePropertyChanged(); }
        //}

    }
}
