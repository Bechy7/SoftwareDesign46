using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DebtBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Person> users = new List<Person>();
            users.Add(new Person() { Id = 1, Name = "John Doe", Surname = "Martino", Debt = 50, Occupation = "Martina" });
            users.Add(new Person() { Id = 2, Name = "Jane Doe", Surname = "Martina", Debt = 50, Occupation = "Herpina"});
            users.Add(new Person() { Id = 3, Name = "Sammy Doe", Surname = "Fatima", Debt = 50, Occupation = "Hehe"});

            Debitors.ItemsSource = users;

        }
        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public double Debt { get; set; }
            public string Occupation { get; set; }
        }

    }

}
