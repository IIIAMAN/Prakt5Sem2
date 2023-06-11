using MaterialDesignThemes.Wpf;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DatePicker.Text = DateTime.Now.ToString();
        }

        private void MonthLeft_Click(object sender, RoutedEventArgs e)
        {
            Wraps.Children.Clear();
            DateTime selectedDate = DatePicker.SelectedDate ?? DateTime.Now;
            int Month = selectedDate.Month - 1;
            DateTime newDate = new DateTime(selectedDate.Year, Month, selectedDate.Day);

            DatePicker.SelectedDate = newDate;
            DatePicker.Text = newDate.ToString();
        }

        private void MonthVpered_Click(object sender, RoutedEventArgs e)
        {
            Wraps.Children.Clear();
            DateTime selectedDate = DatePicker.SelectedDate ?? DateTime.Now;
            int Month = selectedDate.Month + 1;
            DateTime newDate = new DateTime(selectedDate.Year, Month, selectedDate.Day);

            DatePicker.SelectedDate = newDate;
            DatePicker.Text = newDate.ToString();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Wraps.Children.Clear();
            DateTime selectedDate = new DateTime();
            selectedDate = Convert.ToDateTime(DatePicker.SelectedDate);
            int daysMonth = DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month);
            zapolnenie(daysMonth);
        }

        void zapolnenie(int number)
        {
            
            for (int i = 1; i <= number; i++)
            {
                Days days = new Days();
                days.NumberText.Content = $"{i}";
                
                WrapPanel wrapPanel = Wraps;
                days.Width = 100;
                days.Height = 100;
                days.Margin = new Thickness(5);
                wrapPanel.Children.Add(days.Daysss);
            }
        }

        public void smena(int chislo)
        {
            string kek = DatePicker.Text;
            DateTime selectedDate = new DateTime();
            selectedDate = Convert.ToDateTime(DatePicker.Text);

            DateTime newDate = new DateTime(selectedDate.Year, selectedDate.Month, chislo);


            DatePicker.Text = newDate.ToString();
            PageFrame.Navigate(new Page1(chislo, DatePicker.Text, kek));
        }
        public void obratno(string kek)
        {
            PageFrame.Content = null;
            DatePicker.Text = kek;
        }

        public void smenadate(int chislo, string date)
        {
            DateTime selectedDate = new DateTime();
            selectedDate = Convert.ToDateTime(date);

            DateTime newDate = new DateTime(selectedDate.Year, selectedDate.Month, chislo);


            DatePicker.Text = newDate.ToString();
            DatePicker.SelectedDate = Convert.ToDateTime(DatePicker.Text);
        }
    }
}
