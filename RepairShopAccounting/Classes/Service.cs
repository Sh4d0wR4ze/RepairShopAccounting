using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RepairShopAccounting.Classes
{
    public class Service
    {
        public int Maintenance { get; set; }
        public int Diagnostics { get; set; }
        public int TechnicalConclusion { get; set; }
        public int Repairs { get; set; }
        public int PriceOtherService { get; set; }
        public string ListCost { get; set; }
        public int Cost { get; set; }

        public Service()
        {
            Maintenance = 1000;
            Diagnostics = 2000;
            TechnicalConclusion = 850;
            Repairs = 2000;
            PriceOtherService = 0;
            ListCost = "";
        }
        public void CalcCost (
            string maintence,
            string diagnostic,
            string tecniclconclusion,
            string repairs,
            string other
            )
        {
            if (maintence == "True")
            {
                Cost += Maintenance;
                ListCost += "Техническое обслуживание, ";
            }
            if (diagnostic == "True")
            {
                Cost += Diagnostics;
                ListCost += "Диагностика, ";
            }
            if (tecniclconclusion == "True")
            {
                Cost += TechnicalConclusion;
                ListCost += "Техническое заключение, ";
            }
            if (repairs == "True")
            {
                Cost += Repairs;
                ListCost += "Ремонт, ";
            }
            if (!int.TryParse(other, out int result) || other.Length == 0)
            {
                MessageBox.Show("Цена должна быть числом", "Ошибка ввода");
                throw new FormatException();
            }
            if (result > 0)
            {
                Cost += result;
            }
        }

    }
}
