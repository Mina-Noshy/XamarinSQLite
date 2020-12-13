using CRUDApplication.Database;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CRUDApplication
{
    public partial class App : Application
    {

        private static AppDbContext _context;
        public static AppDbContext context
        {
            get
            {
                if (_context == null)
                    _context = new AppDbContext();
                return _context;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
