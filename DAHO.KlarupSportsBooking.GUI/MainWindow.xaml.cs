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
        OpenTimeHandler OpenTimeHandler = new OpenTimeHandler();
        public MainWindow()
        {            
            InitializeComponent();
            //DateTime s = new DateTime(1900, 1, 1, 8, 0, 0);
            //DateTime e = new DateTime(1900, 1, 1, 22, 0, 0);
            //DateTime ws = new DateTime(1900, 1, 1, 9, 0, 0);
            //DateTime we = new DateTime(1900, 1, 1, 21, 0, 0);
            //OpenTime time = new OpenTime() { WeekdayStart = s, WeekdayEnd = e, WeekendStart = ws, WeekendEnd = we };
            //OpenTimeHandler.Add(time);
            CreateReservationxaml cr = new CreateReservationxaml();
            cr.ShowDialog();
        }
    }
}
