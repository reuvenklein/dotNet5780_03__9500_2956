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

namespace dotnet5780_03_9500_2956
{
    /// <summary>
    /// Interaction logic for HostingUnitUserControl.xaml
    /// </summary>
    public partial class HostingUnitUserControl : UserControl
    {
        private Calendar CreateCalendar()
        {
            Calendar MonthlyCalendar = new Calendar();
            MonthlyCalendar.Name = "MonthlyCalendar";
            MonthlyCalendar.DisplayMode = CalendarMode.Month;
            MonthlyCalendar.SelectionMode = CalendarSelectionMode.SingleRange;
            MonthlyCalendar.IsTodayHighlighted = true;
            return MonthlyCalendar;
        }
        private void SetBlackOutDates()
        {
            foreach (DateTime date in CurrentHostingUnit.AllOrders)
            {
                MyCalendar.BlackoutDates.Add(new CalendarDateRange(date));
            }
        }
        private Calendar MyCalendar;
        public HostingUnit CurrentHostingUnit { get; set; }
        public HostingUnitUserControl(HostingUnit hostUnit)
        {
            InitializeComponent();
            this.CurrentHostingUnit = hostUnit;
            UserControlGrid.DataContext = hostUnit;
            Calendar MyCalendar;
            MyCalendar = CreateCalendar();
             vbCalendar.Child=null;
            vbCalendar.Child = MyCalendar;
            SetBlackOutDates();
        }
    }
}
