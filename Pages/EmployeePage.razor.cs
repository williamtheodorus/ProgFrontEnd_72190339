using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LatihanBlazor.Models;

namespace LatihanBlazor.Pages
{
    public partial class EmployeePage
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees(){
            Employee e1 = new Employee{
                EmployeeId=1,
                FirstName="Erick",
                LastName="Kurniawan",
                Email="erick@actual-training.com",
                DateOfBirth = new DateTime(1999,10,5),
                Gen = Gender.Male,
                Depart = new Department{DepartmentId=1,DepartmentName="IT"},
                PhotoPath = "images/erick.jpg"
            };
            Employee e2 = new Employee{
                EmployeeId=2,
                FirstName="Keren",
                LastName="Kezia",
                Email="kezia@gmail.com",
                DateOfBirth = new DateTime(1999,10,10),
                Gen = Gender.Female,
                Depart = new Department{DepartmentId=2,DepartmentName="Desain"},
                PhotoPath = "images/kezia.jpg"
            };
            Employee e3 = new Employee{
                EmployeeId=3,
                FirstName="William",
                LastName="Theodorus",
                Email="william@gmail.com",
                DateOfBirth = new DateTime(1999,10,8),
                Gen = Gender.Male,
                Depart = new Department{DepartmentId=3,DepartmentName="Manager"},
                PhotoPath = "images/theo.jpg"
            };
            Employee e4 = new Employee{
                EmployeeId=4,
                FirstName="Dorus",
                LastName="Zo",
                Email="zo@gmail.com",
                DateOfBirth = new DateTime(1999,10,9),
                Gen = Gender.Male,
                Depart = new Department{DepartmentId=3,DepartmentName="Manager"},
                PhotoPath = "images/zo.jpg"
            };

            Employees = new List<Employee>{e1,e2,e3};
        }
    }
}