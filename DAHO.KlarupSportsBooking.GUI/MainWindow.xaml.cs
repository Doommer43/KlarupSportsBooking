using DAHO.KlarupSportsBooking.BusinessLayer;
using DAHO.KlarupSportsBooking.DateAccessLayer.EF;
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

namespace DAHO.KlarupSportsBooking.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AdminHandler adminHandler = new AdminHandler();
        ReservationHandler ReservationHandler = new ReservationHandler();
        private Admin currentAdmin;
        public MainWindow()
        {            
            InitializeComponent();
            DGReservations.ItemsSource = ReservationHandler.GetAllReservations();
            DGReservations.AutoGenerateColumns = false;
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            if (loginWindow.ShowDialog() == true)
            {
                currentAdmin = adminHandler.Login(loginWindow.TBoxUsername.Text, loginWindow.TBoxPassword.Text);
                if (currentAdmin != null)
                {
                    TBlockCurrentUser.Text = currentAdmin.FirstName + " " + currentAdmin.LastName;
                    TabAdmin.IsEnabled = true;
                }
                else
                {
                    TabAdmin.IsEnabled = false;
                    TabUnion.IsSelected = true;
                }
            }
        }

        private void DGReservations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnNewReservation_Click(object sender, RoutedEventArgs e)
        {
            CreateReservationxaml cr = new CreateReservationxaml();
            cr.ShowDialog();
        }
    }
}
