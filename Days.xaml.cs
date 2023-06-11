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

namespace Prakticheskaya5
{
    public partial class Days : UserControl
    {
        public Days()
        {
            InitializeComponent();
        }

        private void Knopka_Click(object sender, RoutedEventArgs e)
        {

            MainWindow main = Application.Current.MainWindow as MainWindow;
            int number = Convert.ToInt32(NumberText.Content);

            main.smena(number);
        }
    }
}
