using EasyTabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platfer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new PlatferMain());
            AppContainer container = new AppContainer();
            container.Tabs.Add(new EasyTabs.TitleBarTab(container) {
                Content=new PlatferMain
                {
                    Text="New Tab"
                }
            });
            container.SelectedTabIndex = 0;
            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(container);
            Application.Run(applicationContext);
        }
    }
}
