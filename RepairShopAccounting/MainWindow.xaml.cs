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

namespace RepairShopAccounting
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MainWindow : Window        
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateOrderButton_Click(object sender, RoutedEventArgs e)
        {
            CreateOrder co = new CreateOrder();
            co.Show();
        }

        private void ViewOrdersButton_Click(object sender, RoutedEventArgs e)
        {
            ViewOrders vo = new ViewOrders();
            vo.Show();
        }
    }
}
