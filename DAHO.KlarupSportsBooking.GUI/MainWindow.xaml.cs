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
using DAHO.KlarupSportsBooking.Server;

namespace DAHO.KlarupSportsBooking.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Admin currentAdmin;
        private Union currentUnion;
        public MainWindow()
        {            
            InitializeComponent();
            ReservationHandler ReservationHandler = new ReservationHandler();
            DGReservations.ItemsSource = ReservationHandler.GetAllReservations();
            Program p = new Program();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            AdminHandler adminHandler = new AdminHandler();
            UnionHandler unionHandler = new UnionHandler();

            LoginWindow loginWindow = new LoginWindow();
            if (loginWindow.ShowDialog() == true)
            {
                try
                {
                    currentAdmin = adminHandler.Login(loginWindow.TBoxUsername.Text, loginWindow.TBoxPassword.Text);
                    currentUnion = unionHandler.Login(loginWindow.TBoxUsername.Text, loginWindow.TBoxPassword.Text);

                    if (currentAdmin != null || currentUnion != null)
                    {
                        if (currentAdmin != null)
                        {
                            TBlockCurrentUser.Text = currentAdmin.FirstName + " " + currentAdmin.LastName;
                            TabAdmin.IsEnabled = true;
                        }
                        else if (currentUnion != null)
                        {
                            TBlockCurrentUser.Text = currentUnion.Email;
                            TabAdmin.IsEnabled = false;
                        }
                        else
                        {
                            TabAdmin.IsEnabled = false;
                            TabUnion.IsSelected = true;
                        }
                    }
                    else
                    {
                        TBlockCurrentUser.Text = "Ingen bruger fundet.";
                    }
                }
                catch (ArgumentException error)
                {
                    MessageBox.Show(error.Message, error.GetType().ToString());
                }
            }
        }

        private void DGReservations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Reservation res = (Reservation)DGReservations.SelectedItem;
            if (res.Accepted == false)
            {
                BtnAcceptReservation.IsEnabled = true;
            }
            else
            BtnAcceptReservation.IsEnabled = false;
        }

        private void BtnNewReservation_Click(object sender, RoutedEventArgs e)
        {
            CreateReservationxaml cr = new CreateReservationxaml();
            cr.ShowDialog();
        }

        private void BtnAcceptReservation_Click(object sender, RoutedEventArgs e)
        {
            ReservationHandler ReservationHandler = new ReservationHandler();
            AcceptedReservationHandler AcceptedReservationHandler = new AcceptedReservationHandler();

            Reservation res = (Reservation)DGReservations.SelectedItem;
            AcceptedReservation ares = new AcceptedReservation() { AdminId = currentAdmin.Id, ReservationsId = res.Id };
            AcceptedReservationHandler.Add(ares);
            res.Accepted = true;
            ReservationHandler.Update(res);
            DGReservations.Items.Refresh();
        }
    }
}
