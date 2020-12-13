using CRUDApplication.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CRUDApplication.View.Employee
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Employees : ContentPage
    {
        EmployeeServices context = new EmployeeServices();
        public Employees()
        {
            InitializeComponent();
            lst.ItemsSource = context.GetAll();
        }

        private void lst_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            Models.Employees emp = e.SelectedItem as Models.Employees;
            Navigation.PushAsync(new View.Employee.Details(emp));
            lst.SelectedItem = null;
        }

        private void lst_Refreshing(object sender, EventArgs e)
        {
            lst.ItemsSource = context.GetAll();

            lst.EndRefresh();
        }

        private void btnCreateNew_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Employee.Create());
        }
    }
}