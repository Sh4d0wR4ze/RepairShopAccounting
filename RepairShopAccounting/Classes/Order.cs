using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RepairShopAccounting.Classes
{
    public class Order //хранит все данные о заказе
    {
        public int OrderNumber { get; set; }
        public string NameClient { get; set; }
        public DateTime DateOfReceiving { get; set; }
        public DateTime DateOfIssue { get; set; }
        public string EquipmentNumber { get; set; }
        public string services { get; set; }
        public int Price { get; set; }

        public Order(
            int number,
            string nameclient,
            DateTime dateofreceiving,
            DateTime dateofissue,
            string equipmentnumber,
            string service,
            int price
            )
        {
            OrderNumber = number;
            CheckName(nameclient);
            CheckDate(dateofissue, dateofreceiving);
            CheckEquipment(equipmentnumber);
            CheckServices(service);
            Price = price;
        }
        public void CheckName (string nameclient)
        {
            CheckErrors(nameclient, "Введите имя клиента");
            NameClient = nameclient;
        }
        public void CheckDate (DateTime dateofissue, DateTime dateofreceiving)
        {
            //CheckErrors<DateTime>(dateofissue, "Введите дату выдачи заказа");
            if (dateofissue < dateofreceiving)
            {
                MessageBox.Show("Дата выдачи заказа не может \nбыть раньше даты получения заказа", "Ошибка ввода");
                throw new ArgumentOutOfRangeException();
            }
            DateOfIssue = dateofissue;
            DateOfReceiving = dateofreceiving;
        }
        public void CheckEquipment (string equipmentnumber)
        {
            CheckErrors(equipmentnumber, "Введите номер или модель оборудования");
            EquipmentNumber = equipmentnumber;
        }

        public void CheckServices (string service)
        {
            CheckErrors(service, "Выберите услуги мастерской");
            services = service;
        }

        public void CheckPrice(int price)
        {

        }
        public void CheckErrors (string PossibleError, string ErrorMessage)
        {
            if (PossibleError.Length == 0)
            {
                MessageBox.Show(ErrorMessage, "Ошибка ввода");
                throw new ArgumentNullException();
            }
        }
    }
}
