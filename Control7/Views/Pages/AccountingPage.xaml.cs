using Control7.Model;
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

namespace Control7.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для AccountingPage.xaml
    /// </summary>
    public partial class AccountingPage : Page
    {
        private static Entities _context = new Entities();
        public AccountingPage()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DateDp.SelectedDate != null && EmployeesCmb.SelectedItem != null && ManufacterCmb.SelectedItem != null && MaterialCmb.SelectedItem != null && PriceTb.Text != string.Empty && QuantityTb.Text != string.Empty)
            {
                Accounting newAccunting = new Accounting()
                {
                    DateDelivery = (DateTime)DateDp.SelectedDate,
                    Employee = EmployeesCmb.SelectedItem as Employee,
                    Material = MaterialCmb.SelectedItem as Material,
                    Price = Convert.ToDecimal(PriceTb.Text),
                    Quantity = Convert.ToInt32(QuantityTb.Text)
                };
                _context.Accounting.Add(newAccunting);
                _context.SaveChanges();
                MessageBox.Show("Запись добавлена.");
            }
            else
            {
                MessageBox.Show("Заполните все поля для ввода."); 
            }
        }
    }
}
