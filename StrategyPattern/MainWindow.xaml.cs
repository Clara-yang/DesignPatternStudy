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

namespace StrategyPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class CashType
        {
            public string Name { get; set; }
            public int Id { get; set; }
        }

        double totalPrice = 0;
        CashType type = new CashType();
        public MainWindow()
        {
            InitializeComponent();

            List<CashType> types = new List<CashType>();
            types.Add(new CashType { Name = "正常收费", Id = 1 });
            types.Add(new CashType { Name = "打8折", Id = 2 });
            types.Add(new CashType { Name = "满300返50", Id = 3 });
            cashtype.ItemsSource = types;
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            CashContext context = new CashContext(type?.Name);
            totalPrice += context.GetResult(Convert.ToDouble(price.Text) * Convert.ToDouble(number.Text));
            summary.Items.Add("price:" + price.Text + ",number:" + number.Text +
                "，discount:" + type?.Name + ",totalPrice:" + totalPrice);
            result.Text = totalPrice.ToString();
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            price.Text = "0";
            number.Text = "0";
            cashtype.SelectedIndex = 0;
            summary.Items.Clear();
            result.Text = "0";
        } 

        private void cashtype_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            type = cashtype.SelectedItem as CashType;
        }
    }
}
