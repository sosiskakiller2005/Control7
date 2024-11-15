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
            ManufacterCmb.ItemsSource = _context.Manufatcer.ToList();
            ManufacterCmb.DisplayMemberPath = "Name";
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ManufacterCmb.SelectedItem != null && MaterialNameTb.Text != string.Empty)
            {
                Material newMaterial = new Material()
                {
                    Name = MaterialNameTb.Text,
                    Manufatcer = ManufacterCmb.SelectedItem as Manufatcer
                };
                _context.Material.Add(newMaterial);
                _context.SaveChanges();
                MessageBox.Show("Материал добавлен.");
            }
        }
    }
}
