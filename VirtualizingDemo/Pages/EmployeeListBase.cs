using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualizingDemo.Data;
using VirtualizingDemo.Models;

namespace VirtualizingDemo.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();
        protected float itemHeight = 50;
        protected override void OnInitialized()
        {
            Employees = EmployeeService.Employees;
           
        }
    }
}
