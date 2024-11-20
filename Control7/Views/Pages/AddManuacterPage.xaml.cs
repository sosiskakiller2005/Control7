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
    /// Логика взаимодействия для AddManuacterPage.xaml
    /// </summary>
    public partial class AddManuacterPage : Page
    {
        private static Entities _context = new Entities();
        public AddManuacterPage()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ManufacterTb.Text != string.Empty)
            {
                Manufatcer newManufacter = new Manufatcer()
                {
                    Name = ManufacterTb.Text
                };
                _context.Manufatcer.Add(newManufacter);
                _context.SaveChanges();
                MessageBox.Show("Производитель добавлен.");
            }
        }
    }
}
