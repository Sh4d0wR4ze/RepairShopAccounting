using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using RepairShopAccounting.Classes;

namespace RepairShopAccounting
{
    /// <summary>
    /// Логика взаимодействия для ViewOrders.xaml
    /// </summary>
    public partial class ViewOrders : Window
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        private void ViewAllOrdersButton_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Order> collection = new ObservableCollection<Order>();
            Table.ItemsSource = collection;
            foreach (var order in Orders.orders)
            {
                collection.Add(order);
            }
        }

        private void ViewCurrentOrdersButton_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Order> collection = new ObservableCollection<Order>();
            Table.ItemsSource = collection;
            foreach (var order in Orders.orders)
            {
                if (order.DateOfIssue > DateTime.Now)
                {
                    collection.Add(order);
                }
            }
        }

        private void ViewCompletedOrdersButton_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Order> collection = new ObservableCollection<Order>();
            Table.ItemsSource = collection;
            foreach (var order in Orders.orders)
            {
                if (order.DateOfIssue <= DateTime.Now)
                {
                    collection.Add(order);
                }
            }
        }
    }
}
