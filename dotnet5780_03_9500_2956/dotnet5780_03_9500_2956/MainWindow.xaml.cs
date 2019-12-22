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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Host> hostsList;
        public MainWindow()
        {
            hostsList = new List<Host>()
            {
                new Host()
                {
                    HostName = "Tsimerman",
                    Units = new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName = "יופי של צימר",
                            Rooms=3,
                            IsSwimmingPool=true,
                            AllOrders=new List<DateTime>(),
                            Uris = new List<string>(){ "https://www.hotels.co.il/hotelsmain/hotels/hotelimages/500/8D907C1A-E496-6F94-303A8B088457A7B3.jpg",
                                                       "https://www.hotels.co.il/hotelsmain/hotels/hotels_pics/283ACAF7-07B6-B928-51F300E9AD7F787C.jpg",
                                                       "https://www.hotels.co.il/hotelsmain/hotels/hotels_pics/AFAAD607-C3C2-345A-B8C5BDABCC895243.jpg" }
                        },
                          new HostingUnit()
                        {
                            UnitName = "יופי של צימר 2",
                            Rooms=3,
                            IsSwimmingPool=true,
                            AllOrders=new List<DateTime>(),
                            Uris = new List<string>(){ "https://www.isrotel.co.il/commerce/content/images/thumbs/0003715.jpeg?anchor=center&mode=crop&width=400&height=297",
                                                       "https://www.hotels.co.il/hotelsmain/hotels/room_pics/4073FC9F-DFE6-9E2F-EA66980FD9748352.jpg",
                                                       "https://www.hotels.co.il/hotelsmain/hotels/room_pics/4080E86F-C61E-9C0A-C3EF1CBDB6BD847C.jpg" }
                        }
                    }
                },
                 new Host()
                {
                    HostName = "Tsimerguy",
                    Units = new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName = "יופי של צימר 3",
                            Rooms=3,
                            IsSwimmingPool=true,
                            AllOrders=new List<DateTime>(),
                            Uris = new List<string>(){ "https://www.hotels.co.il/hotelsmain/hotels/room_pics/4080DE25-DAD5-7E2F-98F92A72125F04B2.jpg",
                                                       "https://www.hotels.co.il/hotelsmain/hotels/room_pics/14476846-BE16-7C6F-F8BF3E6BDCF31219.jpg",
                                                       "https://www.hotels.co.il/hotelsmain/hotels/hotels_pics/9F61650A-A3D5-6A96-A1D9C43D73DA15FD_tn.jpg" }
                        },
                          new HostingUnit()
                        {
                            UnitName = " 4יופי של צימר",
                            Rooms=3,
                            IsSwimmingPool=false,
                            AllOrders=new List<DateTime>(),
                            Uris = new List<string>(){ "https://www.hotels.co.il/hotelsmain/hotels/hotelimages/500/163032EE-90B5-3EDB-8EBB4494902A80CC.jpg",
                                                       "https://www.hotels.co.il/hotelsmain/hotels/hotelimages/500/FCB68288-EDA0-8829-5746C2385E2AAA30.jpg",
                                                       "https://www.hotels.co.il/hotelsmain/hotels/hotels_pics/CEDE4250-9616-3694-C0FB59C29A44B9F3.jpg" }
                        }
                    }
                },
                  new Host()
                {
                    HostName = "Tsimerowner",
                    Units = new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName = "יופי של צימר 5",
                            Rooms=3,
                            IsSwimmingPool=true,
                            AllOrders=new List<DateTime>(),
                            Uris = new List<string>(){ "https://www.hotels.co.il/hotelsmain/hotels/hotels_pics/CEDD299C-C3C2-16B8-1AB1E32445042BF4_tn.jpg",
                                                       "https://www.hotels.co.il/hotelsmain/hotels/hotels_pics/CEDD98B5-06E5-9C96-59D5604F795C9921.jpg",
                                                       "https://www.hotels.co.il/hotelsmain/hotels/hotelimages/500/69579938-155D-F312-5F48B119AE4D65B4.jpg" }
                        },
                          new HostingUnit()
                        {
                            UnitName = "יופי של צימר 6",
                            Rooms=3,
                            IsSwimmingPool=false,
                            AllOrders=new List<DateTime>(),
                            Uris = new List<string>(){ "https://www.hotels.co.il/hotelsmain/hotels/hotels_pics/DE9AE455-155D-F312-5F75312C75D2B644_tn.jpg",
                                                       "https://www.hotels.co.il/hotelsmain/hotels/hotels_pics/DE9A24F6-155D-F312-5FE9A8240E2AD3A5_tn.jpg",
                                                       "https://www.hotels.co.il/hotelsmain/hotels/hotelimages/500/813B08EC-C3BB-02B0-D9E8FB07572C1E57.jpg" }
                        }
                    }
                }
            };
            InitializeComponent();
            
            cbHostList.ItemsSource = hostsList;
            cbHostList.DisplayMemberPath = "HostName";
            cbHostList.SelectedIndex = 0;
        }

        private Host currentHost;

        private void cbHostList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InitializeHost(cbHostList.SelectedIndex);
        }
        private void InitializeHost(int index)
        {
            MainGrid.Children.RemoveRange(1,3);
            currentHost = hostsList[index];
            UpGrid.DataContext = currentHost;
            for (int i = 0; i < currentHost.Units.Count; i++)
            {
                HostingUnitUserControl a = new HostingUnitUserControl(currentHost.Units[i]);
                MainGrid.Children.Add(a);
                Grid.SetRow(a,i+1);
            }
        }
    }
}
