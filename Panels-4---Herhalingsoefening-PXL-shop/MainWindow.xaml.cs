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
using System.Windows.Threading;

namespace Panels_4___Herhalingsoefening_PXL_shop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _output;
        private double _totalPrice;
        private DispatcherTimer _timer;

        public MainWindow()
        {
            InitializeComponent();
            RandomBackground();
            StartTimer();

            _output = "";
            _totalPrice = 0;
        }

        private void StartTimer()
        {
            _timer = new DispatcherTimer();
            _timer.Tick += TimerTick;
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            //TijdTextBlock.Text = DateTime.Now.ToLongTimeString();
            timeTextBlock.Text = DateTime.Now.ToString("hh:mm:ss tt") + " " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void RandomBackground()
        {
            Random random = new Random();
            if (random.Next(0, 2) == 0)
            {
                mainGrid.Background = Brushes.LimeGreen;
            }
            else
            {
                mainGrid.Background = Brushes.LightGreen;
            }
        }

        public string FrameResult(string amount)
        {
            string result = "";
            for (int i = 0; i < amount.Length + 5; i++)
            {
                result = result + "*";
            }
            result = result + $"\n* €{amount} *\n";
            for (int i = 0; i < amount.Length + 5; i++)
            {
                result = result + "*";
            }
            return result;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            _output = _output + $"{amountTextBox.Text} x {nameTextBox.Text}\n";
            _totalPrice = _totalPrice +
                (Convert.ToInt32(amountTextBox.Text) *
                Convert.ToDouble(priceTextBox.Text));
            ticketTextBox.Text = _output;
        }

        private void checkOutButton_Click(object sender, RoutedEventArgs e)
        {
            ticketTextBox.Text = _output + $"\n\n{FrameResult(_totalPrice.ToString())}\n\n\nPXL - Shop";
        }

        private void newOrderButton_Click(object sender, RoutedEventArgs e)
        {
            ticketTextBox.Text = "";
            nameTextBox.Text = "";
            amountTextBox.Text = "";
            priceTextBox.Text = "";
            _output = "";
            _totalPrice = 0;
        }
    }
}
