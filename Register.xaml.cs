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

namespace Tickets2Help
{
    /// <summary>
    /// Lógica interna para Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, RoutedEventArgs e)
        {
            string Name = txt_name.Text;
            string Password = txt_password.Text;
            string Role = ((ComboBoxItem)RoleComboBox.SelectedItem).Content.ToString();

            if (userService.RegisterUser(Name, Password, Role))
            {
                MessageBox.Show("User registered successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error registering user.");
            }
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
