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
    public partial class Create : ContentPage
    {
        EmployeeServices context = new EmployeeServices();

        public Create()
        {
            InitializeComponent();
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            Models.Employees emp = new Models.Employees
            {
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                Address = txtAddress.Text
            };
            context.Add(emp);
            DisplayAlert("added", "added employee successful", "ok");
            Navigation.PopAsync();
        }

        private void btnCancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}