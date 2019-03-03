using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using iDent.Models;

namespace iDent.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TeamPage : ContentPage
	{
        private ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        
		public TeamPage ()
		{
			InitializeComponent ();

            employees.Add(new Employee("Matthew Glen", "Pension Administator", "This is the descriptionThis is the descriptionThis is the descriptionThis is the description This is the descriptionThis is the descriptionThis is the description", "headshotPL.jpg"));
            employees.Add(new Employee("Matthew Glen", "Pension Administator", "This is the description", "headshotPL.jpg"));
            employees.Add(new Employee("Matthew Glen", "Pension Administator", "This is the description", "headshotPL.jpg"));
            employees.Add(new Employee("Matthew Glen", "Pension Administator", "This is the description", "headshotPL.jpg"));
            employees.Add(new Employee("Matthew Glen", "Pension Administator", "This is the description", "headshotPL.jpg"));
            employees.Add(new Employee("Matthew Glen", "Pension Administator", "This is the description", "headshotPL.jpg"));


            EmployeeListView.ItemsSource = employees;

            //var tapGestureRecognizer = new TapGestureRecognizer();
            ////			tapGestureRecognizer.NumberOfTapsRequired = 2; // double-tap
            //tapGestureRecognizer.Tapped += OnTapGestureRecognizerTapped;
            //image1.GestureRecognizers.Add(tapGestureRecognizer);
        }


        private void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            //if (descriptionLabelLayout.IsVisible == true)
            //{
            //    descriptionLabelLayout.IsVisible = false;
            //    nameLabelLayout.IsVisible = true;
            //}
            //else
            //{
            //    descriptionLabelLayout.IsVisible = true;
            //    nameLabelLayout.IsVisible = false;
            //}
            
        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }

           

        }

        void OnTap(object sender, ItemTappedEventArgs e)
        {

            Employee selectedEmployee = (Employee)e.Item;

            foreach (Employee employee in EmployeeListView.ItemsSource)
            {
                //employee.NameVisible = selectedEmployee.Equals(employee) ? false : true;
                //employee.DescVisible = selectedEmployee.Equals(employee) ? true : false;

                if (selectedEmployee.Equals(employee))
                {
                    switch (employee.NameVisible)
                    {
                        case true:
                            employee.NameVisible = false;
                            employee.DescVisible = true;
                            break;
                        case false:
                            employee.NameVisible = true;
                            employee.DescVisible = false;
                            break;
                    }

                    employee.OnPropertyChanged();

                }

            }

        }
    }
        
}