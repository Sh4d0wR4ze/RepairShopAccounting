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
using System.Windows.Shapes;
using RepairShopAccounting.Classes;

namespace RepairShopAccounting
{
    /// <summary>
    /// Логика взаимодействия для CreateOrder.xaml
    /// </summary>
    public partial class CreateOrder : Window
    {
        public CreateOrder()
        {
            InitializeComponent();
            DateOfReceiving.SelectedDate = DateTime.Now;
            OrderNumber.Text = Orders.OrderNumber.ToString();
        }

        private void PriceOtherSevices_KeyPress(object sender, AccessKeyPressedEventArgs e)
        {
            
        }

        private void SeeTheCostButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Service service = new Service();
                ObtainInfoService(ref service);
                CostOfAllServices.Text = service.Cost.ToString();
            }
            catch (FormatException) { }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Service service = new Service();
                ObtainInfoService(ref service);
                Order order = new Order(
                Orders.OrderNumber,
                NameClient.Text,
                DateOfReceiving.SelectedDate.Value.Date,
                DateOfIssue.SelectedDate.Value.Date,
                EquipmentNumber.Text,
                MergeServices(service.ListCost, OtherSevices.Text),
                service.Cost
                );
                Orders.orders.Add(order);
                Orders.OrderNumber++;
                OrderNumber.Text = Orders.OrderNumber.ToString();
                ClearWindow();
            }
            catch (ArgumentNullException) { }
            catch (ArgumentOutOfRangeException) { }
            catch (FormatException) { }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Введите дату выдачи заказа", "Ошибка ввода");
            }
        }

        public string MergeServices (string services, string otherservices)
        {
            return services + otherservices;
        }
        public void ObtainInfoService (ref Service service)
        {
            service.CalcCost(
                Maintenance.IsChecked.ToString(),
                Diagnostics.IsChecked.ToString(),
                TechnicalConclusion.IsChecked.ToString(),
                Repairs.IsChecked.ToString(),
                PriceOtherSevices.Text
                );
        }
        public void ClearWindow ()
        {
            NameClient.Text = "";
            DateOfIssue.Text = "";
            EquipmentNumber.Text = "";
            Maintenance.IsChecked = false;
            Diagnostics.IsChecked = false;
            TechnicalConclusion.IsChecked = false;
            Repairs.IsChecked = false;
            OtherSevices.Text = "";
            PriceOtherSevices.Text = "0";
            CostOfAllServices.Text = "";
        }
    }
}
