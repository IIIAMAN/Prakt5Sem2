using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    public partial class Page1 : Page
    {
        public string kek;
        public Page1(int chislo, string datepicker, string vau)
        {
            InitializeComponent();
            MainWindow main = new MainWindow();
            Number_and_month.Content = "Date: " + datepicker;
            kek = vau;
            main.smenadate(chislo, datepicker);

            Vibor one = new Vibor();
            one.Name.Content = "Завтрак";
            Uri absolute = new Uri("C:\\Users\\Илья\\Desktop\\Учеба проекты\\С#\\Prakt5\\Prakticheskaya5\\завтрак.png", UriKind.Absolute);
            one.Image.Source = new BitmapImage(absolute);

            Vibor two = new Vibor();
            two.Name.Content = "Обед";
            Uri absolute1 = new Uri("C:\\Users\\Илья\\Desktop\\Учеба проекты\\С#\\Prakt5\\Prakticheskaya5\\обед.png", UriKind.Absolute);
            two.Image.Source = new BitmapImage(absolute1);

            Vibor three = new Vibor();
            three.Name.Content = "Ужин";
            Uri absolute2 = new Uri("C:\\Users\\Илья\\Desktop\\Учеба проекты\\С#\\Prakt5\\Prakticheskaya5\\ужин.png", UriKind.Absolute);
            three.Image.Source = new BitmapImage(absolute2);

            Vibor four = new Vibor();
            four.Name.Content = "Послушать музыку";
            Uri absolute3 = new Uri("C:\\Users\\Илья\\Desktop\\Учеба проекты\\С#\\Prakt5\\Prakticheskaya5\\Music.png", UriKind.Absolute);
            four.Image.Source = new BitmapImage(absolute3);

            Vibor five = new Vibor();
            five.Name.Content = "Убраться дома";
            Uri absolute4 = new Uri("C:\\Users\\Илья\\Desktop\\Учеба проекты\\С#\\Prakt5\\Prakticheskaya5\\Uborka.png", UriKind.Absolute);
            five.Image.Source = new BitmapImage(absolute4);

            Vibor six = new Vibor();
            six.Name.Content = "Выполнить задание по программированию";
            Uri absolute5 = new Uri("C:\\Users\\Илья\\Desktop\\Учеба проекты\\С#\\Prakt5\\Prakticheskaya5\\Program.png", UriKind.Absolute);
            six.Image.Source = new BitmapImage(absolute5);

            List<Vibor> vibors = new List<Vibor>() {one, two, three, four, five };
            SpisokDel.ItemsSource = vibors;
        }

        private void SpisokDel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = Application.Current.MainWindow as MainWindow;

            main.obratno(kek);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = Application.Current.MainWindow as MainWindow;

            main.obratno(kek);
        }
    }
}
