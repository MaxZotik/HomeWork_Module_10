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
using System.Xml.Linq;

namespace Task_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Consultant consultant;
        public MainWindow()
        {
            InitializeComponent();

            //consultant = new Consultant();
            //userTextBlock.Text = consultant.Name;

            //DataContext = new AppViewModel();
            //clientListView.DataContext = new AppViewModel();
            //clientListView.ItemsSource = new AppViewModel().ClientsList;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
