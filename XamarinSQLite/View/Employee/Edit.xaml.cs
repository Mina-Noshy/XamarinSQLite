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
    public partial class Edit : ContentPage
    {
        Services.EmployeeServices context = new Services.EmployeeServices();
        public Edit()
        {
            InitializeComponent();
        }

        public Edit(Models.Employees emp)
        {
            InitializeComponent();
            this.BindingContext = emp;
        }

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            Models.Employees emp = new Models.Employees
            {
                Id = int.Parse(lblId.Text),
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                Address = txtAddress.Text
            };
            context.Update(emp);
            DisplayAlert("updated", "employee updated successful", "ok");
            Navigation.PopAsync();
        }

        private void btnCancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}