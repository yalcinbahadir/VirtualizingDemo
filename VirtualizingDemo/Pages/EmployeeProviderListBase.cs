using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualizingDemo.Data;
using VirtualizingDemo.Models;

namespace VirtualizingDemo.Pages
{
    public class EmployeeProviderListBase : ComponentBase
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();
        protected float itemHeight = 50;
        protected int TotalNumberOfEmployees = 1000;

        protected override void OnInitialized()
        {
            Employees = EmployeeService.Employees;
           
        }
        protected async ValueTask<ItemsProviderResult<Employee>> LoadEmployees(ItemsProviderRequest request)
        {
            //assume that we have asked the API the total number in a seperate call.
            var numberOfEmployees = Math.Min(request.Count, TotalNumberOfEmployees - request.StartIndex);
            var EmployeeListItems = await EmployeeService.GetTakeLongEmployeeList(request.StartIndex, numberOfEmployees);          
            return new ItemsProviderResult<Employee>(EmployeeListItems, TotalNumberOfEmployees);
        }
    }
}
