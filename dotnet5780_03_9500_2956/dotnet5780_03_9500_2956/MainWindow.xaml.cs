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
        public MainWindow()
        {
            //comment
            InitializeComponent();


            List<Host> hostsList = new List<Host>()
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
                            Uris = new List<string>(){ "https://www.isrotel.co.il/commerce/content/images/thumbs/0003715.jpeg?anchor=center&mode=crop&width=400&height=297",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiblteblsLmAhWx34UKHZJeAo8QjRx6BAgBEAQ&url=https%3A%2F%2Fwww.globes.co.il%2Fnews%2Farticle.aspx%3Fdid%3D1001267414&psig=AOvVaw3lS4Dw_POL_Hf2j8-JcF0T&ust=1576860694206050",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiItoK5lsLmAhVSQBoKHSEDAGQQjRx6BAgBEAQ&url=https%3A%2F%2Fwww.lametayel.co.il%2F%25D7%2590%25D7%2599%25D7%259A%2B%25D7%259E%25D7%2595%25D7%25A6%25D7%2590%25D7%2599%25D7%259D%2B%25D7%259E%25D7%259C%25D7%2595%25D7%25A0%25D7%2595%25D7%25AA%2B%25D7%2596%25D7%2595%25D7%259C%25D7%2599%25D7%259D%2B%25D7%2591%25D7%2597%25D7%2595%25D7%259C%2B%25D7%259B%25D7%259C%2B%25D7%2594%25D7%25A1%25D7%2595%25D7%2593%25D7%2595%25D7%25AA%2B%25D7%259C%25D7%259E%25D7%25A6%25D7%2599%25D7%2590%25D7%25AA%2B%25D7%259E%25D7%259C%25D7%2595%25D7%259F%2B%25D7%2598%25D7%2595%25D7%2591%2B%25D7%2595%25D7%259E%25D7%25A9%25D7%25AA%25D7%259C%25D7%259D&psig=AOvVaw3lS4Dw_POL_Hf2j8-JcF0T&ust=1576860694206050" }
                        },
                          new HostingUnit()
                        {
                            UnitName = "יופי של צימר",
                            Rooms=3,
                            IsSwimmingPool=true,
                            AllOrders=new List<DateTime>(),
                            Uris = new List<string>(){ "https://www.isrotel.co.il/commerce/content/images/thumbs/0003715.jpeg?anchor=center&mode=crop&width=400&height=297",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiblteblsLmAhWx34UKHZJeAo8QjRx6BAgBEAQ&url=https%3A%2F%2Fwww.globes.co.il%2Fnews%2Farticle.aspx%3Fdid%3D1001267414&psig=AOvVaw3lS4Dw_POL_Hf2j8-JcF0T&ust=1576860694206050",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiItoK5lsLmAhVSQBoKHSEDAGQQjRx6BAgBEAQ&url=https%3A%2F%2Fwww.lametayel.co.il%2F%25D7%2590%25D7%2599%25D7%259A%2B%25D7%259E%25D7%2595%25D7%25A6%25D7%2590%25D7%2599%25D7%259D%2B%25D7%259E%25D7%259C%25D7%2595%25D7%25A0%25D7%2595%25D7%25AA%2B%25D7%2596%25D7%2595%25D7%259C%25D7%2599%25D7%259D%2B%25D7%2591%25D7%2597%25D7%2595%25D7%259C%2B%25D7%259B%25D7%259C%2B%25D7%2594%25D7%25A1%25D7%2595%25D7%2593%25D7%2595%25D7%25AA%2B%25D7%259C%25D7%259E%25D7%25A6%25D7%2599%25D7%2590%25D7%25AA%2B%25D7%259E%25D7%259C%25D7%2595%25D7%259F%2B%25D7%2598%25D7%2595%25D7%2591%2B%25D7%2595%25D7%259E%25D7%25A9%25D7%25AA%25D7%259C%25D7%259D&psig=AOvVaw3lS4Dw_POL_Hf2j8-JcF0T&ust=1576860694206050" }
                        }
                    }
                },
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
                            Uris = new List<string>(){ "https://www.isrotel.co.il/commerce/content/images/thumbs/0003715.jpeg?anchor=center&mode=crop&width=400&height=297",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiblteblsLmAhWx34UKHZJeAo8QjRx6BAgBEAQ&url=https%3A%2F%2Fwww.globes.co.il%2Fnews%2Farticle.aspx%3Fdid%3D1001267414&psig=AOvVaw3lS4Dw_POL_Hf2j8-JcF0T&ust=1576860694206050",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiItoK5lsLmAhVSQBoKHSEDAGQQjRx6BAgBEAQ&url=https%3A%2F%2Fwww.lametayel.co.il%2F%25D7%2590%25D7%2599%25D7%259A%2B%25D7%259E%25D7%2595%25D7%25A6%25D7%2590%25D7%2599%25D7%259D%2B%25D7%259E%25D7%259C%25D7%2595%25D7%25A0%25D7%2595%25D7%25AA%2B%25D7%2596%25D7%2595%25D7%259C%25D7%2599%25D7%259D%2B%25D7%2591%25D7%2597%25D7%2595%25D7%259C%2B%25D7%259B%25D7%259C%2B%25D7%2594%25D7%25A1%25D7%2595%25D7%2593%25D7%2595%25D7%25AA%2B%25D7%259C%25D7%259E%25D7%25A6%25D7%2599%25D7%2590%25D7%25AA%2B%25D7%259E%25D7%259C%25D7%2595%25D7%259F%2B%25D7%2598%25D7%2595%25D7%2591%2B%25D7%2595%25D7%259E%25D7%25A9%25D7%25AA%25D7%259C%25D7%259D&psig=AOvVaw3lS4Dw_POL_Hf2j8-JcF0T&ust=1576860694206050" }
                        },
                          new HostingUnit()
                        {
                            UnitName = "יופי של צימר",
                            Rooms=3,
                            IsSwimmingPool=true,
                            AllOrders=new List<DateTime>(),
                            Uris = new List<string>(){ "https://www.isrotel.co.il/commerce/content/images/thumbs/0003715.jpeg?anchor=center&mode=crop&width=400&height=297",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiblteblsLmAhWx34UKHZJeAo8QjRx6BAgBEAQ&url=https%3A%2F%2Fwww.globes.co.il%2Fnews%2Farticle.aspx%3Fdid%3D1001267414&psig=AOvVaw3lS4Dw_POL_Hf2j8-JcF0T&ust=1576860694206050",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiItoK5lsLmAhVSQBoKHSEDAGQQjRx6BAgBEAQ&url=https%3A%2F%2Fwww.lametayel.co.il%2F%25D7%2590%25D7%2599%25D7%259A%2B%25D7%259E%25D7%2595%25D7%25A6%25D7%2590%25D7%2599%25D7%259D%2B%25D7%259E%25D7%259C%25D7%2595%25D7%25A0%25D7%2595%25D7%25AA%2B%25D7%2596%25D7%2595%25D7%259C%25D7%2599%25D7%259D%2B%25D7%2591%25D7%2597%25D7%2595%25D7%259C%2B%25D7%259B%25D7%259C%2B%25D7%2594%25D7%25A1%25D7%2595%25D7%2593%25D7%2595%25D7%25AA%2B%25D7%259C%25D7%259E%25D7%25A6%25D7%2599%25D7%2590%25D7%25AA%2B%25D7%259E%25D7%259C%25D7%2595%25D7%259F%2B%25D7%2598%25D7%2595%25D7%2591%2B%25D7%2595%25D7%259E%25D7%25A9%25D7%25AA%25D7%259C%25D7%259D&psig=AOvVaw3lS4Dw_POL_Hf2j8-JcF0T&ust=1576860694206050" }
                        }
                    }
                },
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
                            Uris = new List<string>(){ "https://www.isrotel.co.il/commerce/content/images/thumbs/0003715.jpeg?anchor=center&mode=crop&width=400&height=297",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiblteblsLmAhWx34UKHZJeAo8QjRx6BAgBEAQ&url=https%3A%2F%2Fwww.globes.co.il%2Fnews%2Farticle.aspx%3Fdid%3D1001267414&psig=AOvVaw3lS4Dw_POL_Hf2j8-JcF0T&ust=1576860694206050",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiItoK5lsLmAhVSQBoKHSEDAGQQjRx6BAgBEAQ&url=https%3A%2F%2Fwww.lametayel.co.il%2F%25D7%2590%25D7%2599%25D7%259A%2B%25D7%259E%25D7%2595%25D7%25A6%25D7%2590%25D7%2599%25D7%259D%2B%25D7%259E%25D7%259C%25D7%2595%25D7%25A0%25D7%2595%25D7%25AA%2B%25D7%2596%25D7%2595%25D7%259C%25D7%2599%25D7%259D%2B%25D7%2591%25D7%2597%25D7%2595%25D7%259C%2B%25D7%259B%25D7%259C%2B%25D7%2594%25D7%25A1%25D7%2595%25D7%2593%25D7%2595%25D7%25AA%2B%25D7%259C%25D7%259E%25D7%25A6%25D7%2599%25D7%2590%25D7%25AA%2B%25D7%259E%25D7%259C%25D7%2595%25D7%259F%2B%25D7%2598%25D7%2595%25D7%2591%2B%25D7%2595%25D7%259E%25D7%25A9%25D7%25AA%25D7%259C%25D7%259D&psig=AOvVaw3lS4Dw_POL_Hf2j8-JcF0T&ust=1576860694206050" }
                        },
                          new HostingUnit()
                        {
                            UnitName = "יופי של צימר",
                            Rooms=3,
                            IsSwimmingPool=true,
                            AllOrders=new List<DateTime>(),
                            Uris = new List<string>(){ "https://www.isrotel.co.il/commerce/content/images/thumbs/0003715.jpeg?anchor=center&mode=crop&width=400&height=297",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiblteblsLmAhWx34UKHZJeAo8QjRx6BAgBEAQ&url=https%3A%2F%2Fwww.globes.co.il%2Fnews%2Farticle.aspx%3Fdid%3D1001267414&psig=AOvVaw3lS4Dw_POL_Hf2j8-JcF0T&ust=1576860694206050",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiItoK5lsLmAhVSQBoKHSEDAGQQjRx6BAgBEAQ&url=https%3A%2F%2Fwww.lametayel.co.il%2F%25D7%2590%25D7%2599%25D7%259A%2B%25D7%259E%25D7%2595%25D7%25A6%25D7%2590%25D7%2599%25D7%259D%2B%25D7%259E%25D7%259C%25D7%2595%25D7%25A0%25D7%2595%25D7%25AA%2B%25D7%2596%25D7%2595%25D7%259C%25D7%2599%25D7%259D%2B%25D7%2591%25D7%2597%25D7%2595%25D7%259C%2B%25D7%259B%25D7%259C%2B%25D7%2594%25D7%25A1%25D7%2595%25D7%2593%25D7%2595%25D7%25AA%2B%25D7%259C%25D7%259E%25D7%25A6%25D7%2599%25D7%2590%25D7%25AA%2B%25D7%259E%25D7%259C%25D7%2595%25D7%259F%2B%25D7%2598%25D7%2595%25D7%2591%2B%25D7%2595%25D7%259E%25D7%25A9%25D7%25AA%25D7%259C%25D7%259D&psig=AOvVaw3lS4Dw_POL_Hf2j8-JcF0T&ust=1576860694206050" }
                        }
                    }
                }
            };
            cbHostList.ItemsSource = hostsList;
            cbHostList.DisplayMemberPath = "HostName";
            cbHostList.SelectedIndex = 0;
        }
    }
}
