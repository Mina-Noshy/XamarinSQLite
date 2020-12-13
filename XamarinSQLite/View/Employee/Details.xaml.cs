using CRUDApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CRUDApplication.View.Employee
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Details : ContentPage
    {
        EmployeeServices context = new EmployeeServices();
        public Details()
        {
            InitializeComponent();
        }
        public Details(Models.Employees emp)
        {
            InitializeComponent();
            this.BindingContext = emp;
        }

        private void btnBack_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btnEdit_Clicked(object sender, EventArgs e)
        {
            Models.Employees emp = new Models.Employees
            {
                Id = int.Parse(lblId.Text),
                Name = lblName.Text,
                Phone = lblPhone.Text,
                Email = lblEmail.Text,
                Address = lblAddress.Text
            };
            Navigation.PushAsync(new View.Employee.Edit(emp));
        }

        private void btnDelete_Clicked(object sender, EventArgs e)
        {
            Models.Employees emp = new Models.Employees
            {
                Id = int.Parse(lblId.Text),
                Name = lblName.Text,
                Phone = lblPhone.Text,
                Email = lblEmail.Text,
                Address = lblAddress.Text
            };

            context.Delete(emp);
            DisplayAlert("deleted", "employee deleted successful", "ok");
            Navigation.PopAsync();
        }
    }
}