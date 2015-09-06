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


namespace Calendar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        string[] Event = new string[10000];
        string[] Date = new string[10000];
        int index = 0;
              

        private void textBox_Date_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (textBox_Date.Text != "")
                textBox.IsEnabled = true;


         }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if ((Date[index] != textBox_Date.Text.ToString()))
            {
                index++;
                Event[index] = textBox.Text;
                Date[index] = Calendar.SelectedDate.ToString();
            }

        }

       private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            bool DateWithoutEvent = true;
            for (int i = 0; i <= index; i++)
            {
                if (Date[i] != null)
                {
                    if (Calendar.SelectedDate.ToString().Equals(Date[i]))
                    {
                        textBox.Text = Event[i].ToString();
                        DateWithoutEvent = false;
                    }
                }
            }
            if (DateWithoutEvent == true)
                textBox.Text = "Event for today: ";

        }
    }
}
        
