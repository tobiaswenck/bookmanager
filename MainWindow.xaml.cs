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

namespace BookManager
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Book HarryPotter = new Book("Harry Potter und der Stein der Weisen", "Joanne K. Rowling", 9789604533084, 335, "Carlsen", 15.99, 1997, "Fiction", "Gebunden", true);
        public MainWindow()
        {
            InitializeComponent();
            Title.Text = HarryPotter.title;  
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
