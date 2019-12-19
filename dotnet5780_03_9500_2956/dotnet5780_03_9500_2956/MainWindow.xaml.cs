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
                                                       "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwif9qq5v8LmAhXyzoUKHW6iCkwQjRx6BAgBEAQ&url=https%3A%2F%2Fwww.hotels.co.il%2Fhotelsmain%2Fhotels%2Fhotel-group-sale-list.cfm&psig=AOvVaw3rRkuEgtBg9bHgJp4rUN2g&ust=1576871821575532",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwjI6pvMv8LmAhVSUxoKHTwaCs4QjRx6BAgBEAQ&url=%2Furl%3Fsa%3Di%26source%3Dimages%26cd%3D%26ved%3D2ahUKEwif9qq5v8LmAhXyzoUKHW6iCkwQjRx6BAgBEAQ%26url%3Dhttps%253A%252F%252Fwww.mako.co.il%252Ftravel-israel%252Fleisure%252FArticle-af6db78ee134b51006.htm%26psig%3DAOvVaw3rRkuEgtBg9bHgJp4rUN2g%26ust%3D1576871821575532&psig=AOvVaw3rRkuEgtBg9bHgJp4rUN2g&ust=1576871821575532" }
                        },
                          new HostingUnit()
                        {
                            UnitName = "יופי של צימר 2",
                            Rooms=3,
                            IsSwimmingPool=true,
                            AllOrders=new List<DateTime>(),
                            Uris = new List<string>(){ "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiR0Mnhv8LmAhUhz4UKHVOqAEUQjRx6BAgBEAQ&url=https%3A%2F%2Fwww.emalon.co.il%2Fwestern-galilee-hotels%2Faquaduct-hotel&psig=AOvVaw3rRkuEgtBg9bHgJp4rUN2g&ust=1576871821575532",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwjSirzqv8LmAhXCzIUKHe6JCcoQjRx6BAgBEAQ&url=%2Furl%3Fsa%3Di%26source%3Dimages%26cd%3D%26ved%3D2ahUKEwiR0Mnhv8LmAhUhz4UKHVOqAEUQjRx6BAgBEAQ%26url%3Dhttps%253A%252F%252Fwww.olivebb.co.il%252Fhotel%252F%2525D7%252590%2525D7%2525A7%2525D7%252595%2525D7%252595%2525D7%252593%2525D7%252595%2525D7%2525A7%2525D7%252598%26psig%3DAOvVaw3rRkuEgtBg9bHgJp4rUN2g%26ust%3D1576871821575532&psig=AOvVaw3rRkuEgtBg9bHgJp4rUN2g&ust=1576871821575532",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwimzsH8v8LmAhWqzIUKHVyZDyQQjRx6BAgBEAQ&url=https%3A%2F%2Fwww.olivebb.co.il%2Fdocument%2F60%2C102%2C17.aspx&psig=AOvVaw3rRkuEgtBg9bHgJp4rUN2g&ust=1576871821575532" }
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
                            UnitName = "יופי של צימר 3",
                            Rooms=3,
                            IsSwimmingPool=true,
                            AllOrders=new List<DateTime>(),
                            Uris = new List<string>(){ "https://www.isrotel.co.il/commerce/content/images/thumbs/0003715.jpeg?anchor=center&mode=crop&width=400&height=297",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiblteblsLmAhWx34UKHZJeAo8QjRx6BAgBEAQ&url=https%3A%2F%2Fwww.globes.co.il%2Fnews%2Farticle.aspx%3Fdid%3D1001267414&psig=AOvVaw3lS4Dw_POL_Hf2j8-JcF0T&ust=1576860694206050",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiItoK5lsLmAhVSQBoKHSEDAGQQjRx6BAgBEAQ&url=https%3A%2F%2Fwww.lametayel.co.il%2F%25D7%2590%25D7%2599%25D7%259A%2B%25D7%259E%25D7%2595%25D7%25A6%25D7%2590%25D7%2599%25D7%259D%2B%25D7%259E%25D7%259C%25D7%2595%25D7%25A0%25D7%2595%25D7%25AA%2B%25D7%2596%25D7%2595%25D7%259C%25D7%2599%25D7%259D%2B%25D7%2591%25D7%2597%25D7%2595%25D7%259C%2B%25D7%259B%25D7%259C%2B%25D7%2594%25D7%25A1%25D7%2595%25D7%2593%25D7%2595%25D7%25AA%2B%25D7%259C%25D7%259E%25D7%25A6%25D7%2599%25D7%2590%25D7%25AA%2B%25D7%259E%25D7%259C%25D7%2595%25D7%259F%2B%25D7%2598%25D7%2595%25D7%2591%2B%25D7%2595%25D7%259E%25D7%25A9%25D7%25AA%25D7%259C%25D7%259D&psig=AOvVaw3lS4Dw_POL_Hf2j8-JcF0T&ust=1576860694206050" }
                        },
                          new HostingUnit()
                        {
                            UnitName = " 4יופי של צימר",
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
                            UnitName = "יופי של צימר 5",
                            Rooms=3,
                            IsSwimmingPool=true,
                            AllOrders=new List<DateTime>(),
                            Uris = new List<string>(){ "https://www.isrotel.co.il/commerce/content/images/thumbs/0003715.jpeg?anchor=center&mode=crop&width=400&height=297",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiblteblsLmAhWx34UKHZJeAo8QjRx6BAgBEAQ&url=https%3A%2F%2Fwww.globes.co.il%2Fnews%2Farticle.aspx%3Fdid%3D1001267414&psig=AOvVaw3lS4Dw_POL_Hf2j8-JcF0T&ust=1576860694206050",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiItoK5lsLmAhVSQBoKHSEDAGQQjRx6BAgBEAQ&url=https%3A%2F%2Fwww.lametayel.co.il%2F%25D7%2590%25D7%2599%25D7%259A%2B%25D7%259E%25D7%2595%25D7%25A6%25D7%2590%25D7%2599%25D7%259D%2B%25D7%259E%25D7%259C%25D7%2595%25D7%25A0%25D7%2595%25D7%25AA%2B%25D7%2596%25D7%2595%25D7%259C%25D7%2599%25D7%259D%2B%25D7%2591%25D7%2597%25D7%2595%25D7%259C%2B%25D7%259B%25D7%259C%2B%25D7%2594%25D7%25A1%25D7%2595%25D7%2593%25D7%2595%25D7%25AA%2B%25D7%259C%25D7%259E%25D7%25A6%25D7%2599%25D7%2590%25D7%25AA%2B%25D7%259E%25D7%259C%25D7%2595%25D7%259F%2B%25D7%2598%25D7%2595%25D7%2591%2B%25D7%2595%25D7%259E%25D7%25A9%25D7%25AA%25D7%259C%25D7%259D&psig=AOvVaw3lS4Dw_POL_Hf2j8-JcF0T&ust=1576860694206050" }
                        },
                          new HostingUnit()
                        {
                            UnitName = "יופי של צימר 6",
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
                            Uris = new List<string>(){ "https://www.isrotel.co.il/commerce/content/images/thumbs/0003715.jpeg?anchor=center&mode=crop&width=400&height=297",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiblteblsLmAhWx34UKHZJeAo8QjRx6BAgBEAQ&url=https%3A%2F%2Fwww.globes.co.il%2Fnews%2Farticle.aspx%3Fdid%3D1001267414&psig=AOvVaw3lS4Dw_POL_Hf2j8-JcF0T&ust=1576860694206050",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiItoK5lsLmAhVSQBoKHSEDAGQQjRx6BAgBEAQ&url=https%3A%2F%2Fwww.lametayel.co.il%2F%25D7%2590%25D7%2599%25D7%259A%2B%25D7%259E%25D7%2595%25D7%25A6%25D7%2590%25D7%2599%25D7%259D%2B%25D7%259E%25D7%259C%25D7%2595%25D7%25A0%25D7%2595%25D7%25AA%2B%25D7%2596%25D7%2595%25D7%259C%25D7%2599%25D7%259D%2B%25D7%2591%25D7%2597%25D7%2595%25D7%259C%2B%25D7%259B%25D7%259C%2B%25D7%2594%25D7%25A1%25D7%2595%25D7%2593%25D7%2595%25D7%25AA%2B%25D7%259C%25D7%259E%25D7%25A6%25D7%2599%25D7%2590%25D7%25AA%2B%25D7%259E%25D7%259C%25D7%2595%25D7%259F%2B%25D7%2598%25D7%2595%25D7%2591%2B%25D7%2595%25D7%259E%25D7%25A9%25D7%25AA%25D7%259C%25D7%259D&psig=AOvVaw3lS4Dw_POL_Hf2j8-JcF0T&ust=1576860694206050" }
                        },
                          new HostingUnit()
                        {
                            UnitName = "יופי של צימר 2",
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
                            UnitName = "יופי של צימר 3",
                            Rooms=3,
                            IsSwimmingPool=true,
                            AllOrders=new List<DateTime>(),
                            Uris = new List<string>(){ "https://www.isrotel.co.il/commerce/content/images/thumbs/0003715.jpeg?anchor=center&mode=crop&width=400&height=297",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiblteblsLmAhWx34UKHZJeAo8QjRx6BAgBEAQ&url=https%3A%2F%2Fwww.globes.co.il%2Fnews%2Farticle.aspx%3Fdid%3D1001267414&psig=AOvVaw3lS4Dw_POL_Hf2j8-JcF0T&ust=1576860694206050",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiItoK5lsLmAhVSQBoKHSEDAGQQjRx6BAgBEAQ&url=https%3A%2F%2Fwww.lametayel.co.il%2F%25D7%2590%25D7%2599%25D7%259A%2B%25D7%259E%25D7%2595%25D7%25A6%25D7%2590%25D7%2599%25D7%259D%2B%25D7%259E%25D7%259C%25D7%2595%25D7%25A0%25D7%2595%25D7%25AA%2B%25D7%2596%25D7%2595%25D7%259C%25D7%2599%25D7%259D%2B%25D7%2591%25D7%2597%25D7%2595%25D7%259C%2B%25D7%259B%25D7%259C%2B%25D7%2594%25D7%25A1%25D7%2595%25D7%2593%25D7%2595%25D7%25AA%2B%25D7%259C%25D7%259E%25D7%25A6%25D7%2599%25D7%2590%25D7%25AA%2B%25D7%259E%25D7%259C%25D7%2595%25D7%259F%2B%25D7%2598%25D7%2595%25D7%2591%2B%25D7%2595%25D7%259E%25D7%25A9%25D7%25AA%25D7%259C%25D7%259D&psig=AOvVaw3lS4Dw_POL_Hf2j8-JcF0T&ust=1576860694206050" }
                        },
                          new HostingUnit()
                        {
                            UnitName = " 4יופי של צימר",
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
                            UnitName = "יופי של צימר 5",
                            Rooms=3,
                            IsSwimmingPool=true,
                            AllOrders=new List<DateTime>(),
                            Uris = new List<string>(){ "https://www.isrotel.co.il/commerce/content/images/thumbs/0003715.jpeg?anchor=center&mode=crop&width=400&height=297",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiblteblsLmAhWx34UKHZJeAo8QjRx6BAgBEAQ&url=https%3A%2F%2Fwww.globes.co.il%2Fnews%2Farticle.aspx%3Fdid%3D1001267414&psig=AOvVaw3lS4Dw_POL_Hf2j8-JcF0T&ust=1576860694206050",
                                                       "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiItoK5lsLmAhVSQBoKHSEDAGQQjRx6BAgBEAQ&url=https%3A%2F%2Fwww.lametayel.co.il%2F%25D7%2590%25D7%2599%25D7%259A%2B%25D7%259E%25D7%2595%25D7%25A6%25D7%2590%25D7%2599%25D7%259D%2B%25D7%259E%25D7%259C%25D7%2595%25D7%25A0%25D7%2595%25D7%25AA%2B%25D7%2596%25D7%2595%25D7%259C%25D7%2599%25D7%259D%2B%25D7%2591%25D7%2597%25D7%2595%25D7%259C%2B%25D7%259B%25D7%259C%2B%25D7%2594%25D7%25A1%25D7%2595%25D7%2593%25D7%2595%25D7%25AA%2B%25D7%259C%25D7%259E%25D7%25A6%25D7%2599%25D7%2590%25D7%25AA%2B%25D7%259E%25D7%259C%25D7%2595%25D7%259F%2B%25D7%2598%25D7%2595%25D7%2591%2B%25D7%2595%25D7%259E%25D7%25A9%25D7%25AA%25D7%259C%25D7%259D&psig=AOvVaw3lS4Dw_POL_Hf2j8-JcF0T&ust=1576860694206050" }
                        },
                          new HostingUnit()
                        {
                            UnitName = "יופי של צימר 6",
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
