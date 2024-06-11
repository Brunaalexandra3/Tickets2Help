using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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

namespace Tickets2Help
{
    /// <summary>
    /// Interação lógica para Tickets2Help.xam
    /// </summary>
    public partial class Tickets2Help : Window
    {
        private TicketService ticketService;

        public Tickets2Help()
        {
            InitializeComponent();
            ticketService = new TicketService();
            LoadTickets();
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            Login Login = new Login();
            Login.ShowDialog();
        }

        private void btn_register_Click(object sender, RoutedEventArgs e)
        {
            Register Register = new Register();
            Register.ShowDialog();
        }
    }
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Login login = new Login();
            login.Show();
        }
    }
    public void LoadTickets(object TicketsDataGrid)
    {
        List<Ticket> tickets = TicketService.GetTickets("user1"); // Replace with actual user code
        TicketsDataGrid.ItemsSource = tickets;
    }
}
