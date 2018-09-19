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
using System.Windows.Shapes;

namespace DAHO.KlarupSportsBooking.GUI
{
    /// <summary>
    /// Interaction logic for CreateReservationxaml.xaml
    /// </summary>
    public partial class CreateReservationxaml : Window
    {
        ReservationHandler reservationHandler = new ReservationHandler();
        private ActivityHandler ActivityHandler = new ActivityHandler();
        private OpenTimeHandler OpenTimeHandler = new OpenTimeHandler();
        Reservation res = new Reservation();
        public CreateReservationxaml()
        {
            InitializeComponent();
            Title = "Klarup Halbooking";
            DTPickerStartDate.IsEnabled = false;
            DTPickerEndDate.IsEnabled = false;

            ComboBoxActivities.ItemsSource = ActivityHandler.GetAllActivities();

            List<(int,int)> times = OpenTimeHandler.DropdownSetterWeekday();
            ComboBoxStartTime.ItemsSource = times;
            ComboBoxEndTime.ItemsSource = times;            
        }

        private void ChkBoxIsNotSingleEvent_Checked(object sender, RoutedEventArgs e)
        {
            DTPickerStartDate.IsEnabled = true;
            DTPickerEndDate.IsEnabled = true;
        }

        private void ChkBoxIsNotSingleEvent_Unchecked(object sender, RoutedEventArgs e)
        {
            DTPickerStartDate.IsEnabled = false;
            DTPickerEndDate.IsEnabled = false;
        }

        private void DTPickerDateOfReservation_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ChkBoxIsNotSingleEvent.IsChecked == false)
            {
                DTPickerStartDate.SelectedDate = DTPickerDateOfReservation.SelectedDate;
                DTPickerEndDate.SelectedDate = DTPickerDateOfReservation.SelectedDate;
            }
        }

        private void BtnAddReservation_Click(object sender, RoutedEventArgs e)
        {
            (int, int) selectedStartTime = ((int,int))ComboBoxStartTime.SelectedItem;
            DateTime startTime = new DateTime(1900, 1, 1, selectedStartTime.Item1, selectedStartTime.Item2,0);

            (int, int) selectedEndTime = ((int, int))ComboBoxEndTime.SelectedItem;
            DateTime endTime = new DateTime(1900, 1, 1, selectedEndTime.Item1, selectedEndTime.Item2, 0);

            ReservationTime rt = new ReservationTime() { Date = (DateTime)DTPickerDateOfReservation.SelectedDate, StartTime = startTime, EndTime = endTime };

            res.ReservationTimes.Add(rt);
        }

        private void BtnDone_Click(object sender, RoutedEventArgs e)
        {
            res.StartDate = (DateTime)DTPickerStartDate.SelectedDate;
            res.EndDate = (DateTime)DTPickerEndDate.SelectedDate;
            Activity p = (Activity)ComboBoxActivities.SelectedItem;
            Activity a = new Activity() { Id = p.Id, ActivitiName = p.ActivitiName, RequiredSpace = p.RequiredSpace, Reservations = p.Reservations };
            res.Activity = a;
            res.Accepted = false;

            if (reservationHandler.Add(res))
            {
                MessageBox.Show("Reservation registreret");
                Close();
            }
            else
            {
                MessageBox.Show("Reservation fejlet");
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
