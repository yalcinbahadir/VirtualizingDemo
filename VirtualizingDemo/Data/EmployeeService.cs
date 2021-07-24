﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualizingDemo.Models;

namespace VirtualizingDemo.Data
{
    public class EmployeeService
    {
        private static List<Employee> _employees = new List<Employee>()
        {
            new Employee{ Id=1, FirstName="Ali-1", LastName="Yalcin" },
            new Employee{ Id=11, FirstName="Ali-11", LastName="Yalcin" },
            new Employee{ Id=12, FirstName="Ali-12", LastName="Yalcin" },
            new Employee{ Id=13, FirstName="Ali-13", LastName="Yalcin" },
            new Employee{ Id=14, FirstName="Ali-14", LastName="Yalcin" },
            new Employee{ Id=15, FirstName="Ali-15", LastName="Yalcin" },
            new Employee{ Id=16, FirstName="Ali-16", LastName="Yalcin" },
            new Employee{ Id=17, FirstName="Ali-17", LastName="Yalcin" },
            new Employee{ Id=18, FirstName="Ali-18", LastName="Yalcin" },
            new Employee{ Id=19, FirstName="Ali-19", LastName="Yalcin" },
            new Employee{ Id=20, FirstName="Ali-20", LastName="Yalcin" },
            new Employee{ Id=21, FirstName="Ali-21", LastName="Yalcin" },
            new Employee{ Id=22, FirstName="Ali-22", LastName="Yalcin" },
            new Employee{ Id=23, FirstName="Ali-23", LastName="Yalcin" },
            new Employee{ Id=24, FirstName="Ali-24", LastName="Yalcin" },
            new Employee{ Id=25, FirstName="Ali-25", LastName="Yalcin" },
            new Employee{ Id=26, FirstName="Ali-26", LastName="Yalcin" },
            new Employee{ Id=27, FirstName="Ali-1", LastName="Yalcin" },
            new Employee{ Id=28, FirstName="Ali-11", LastName="Yalcin" },
            new Employee{ Id=29, FirstName="Ali-12", LastName="Yalcin" },
            new Employee{ Id=30, FirstName="Ali-13", LastName="Yalcin" },
            new Employee{ Id=31, FirstName="Ali-14", LastName="Yalcin" },
            new Employee{ Id=32, FirstName="Ali-15", LastName="Yalcin" },
            new Employee{ Id=33, FirstName="Ali-16", LastName="Yalcin" },
            new Employee{ Id=34, FirstName="Ali-17", LastName="Yalcin" },
            new Employee{ Id=35, FirstName="Ali-18", LastName="Yalcin" },
            new Employee{ Id=36, FirstName="Ali-19", LastName="Yalcin" },
            new Employee{ Id=37, FirstName="Ali-20", LastName="Yalcin" },
            new Employee{ Id=38, FirstName="Ali-21", LastName="Yalcin" },
            new Employee{ Id=39, FirstName="Ali-22", LastName="Yalcin" },
            new Employee{ Id=40, FirstName="Ali-23", LastName="Yalcin" },
            new Employee{ Id=41, FirstName="Ali-24", LastName="Yalcin" },
            new Employee{ Id=42, FirstName="Ali-25", LastName="Yalcin" },
            new Employee{ Id=43, FirstName="Ali-26", LastName="Yalcin" },
            new Employee{ Id=44, FirstName="Ali-1", LastName="Yalcin" },
            new Employee{ Id=45, FirstName="Ali-11", LastName="Yalcin" },
            new Employee{ Id=46, FirstName="Ali-12", LastName="Yalcin" },
            new Employee{ Id=47, FirstName="Ali-13", LastName="Yalcin" },
            new Employee{ Id=48, FirstName="Ali-14", LastName="Yalcin" },
            new Employee{ Id=49, FirstName="Ali-15", LastName="Yalcin" },
            new Employee{ Id=50, FirstName="Ali-16", LastName="Yalcin" },
            new Employee{ Id=51, FirstName="Ali-17", LastName="Yalcin" },
            new Employee{ Id=52, FirstName="Ali-18", LastName="Yalcin" },
            new Employee{ Id=53, FirstName="Ali-19", LastName="Yalcin" },
            new Employee{ Id=54, FirstName="Ali-20", LastName="Yalcin" },
            new Employee{ Id=55, FirstName="Ali-21", LastName="Yalcin" },
            new Employee{ Id=56, FirstName="Ali-22", LastName="Yalcin" },
            new Employee{ Id=57, FirstName="Ali-23", LastName="Yalcin" },
            new Employee{ Id=58, FirstName="Ali-24", LastName="Yalcin" },
            new Employee{ Id=59, FirstName="Ali-25", LastName="Yalcin" },
            new Employee{ Id=60, FirstName="Ali-26", LastName="Yalcin" },
            new Employee{ Id=61, FirstName="Ali-1", LastName="Yalcin" },
            new Employee{ Id=62, FirstName="Ali-11", LastName="Yalcin" },
            new Employee{ Id=662, FirstName="Ali-12", LastName="Yalcin" },
            new Employee{ Id=63, FirstName="Ali-13", LastName="Yalcin" },
            new Employee{ Id=64, FirstName="Ali-14", LastName="Yalcin" },
            new Employee{ Id=65, FirstName="Ali-15", LastName="Yalcin" },
            new Employee{ Id=66, FirstName="Ali-16", LastName="Yalcin" },
            new Employee{ Id=67, FirstName="Ali-17", LastName="Yalcin" },
            new Employee{ Id=68, FirstName="Ali-18", LastName="Yalcin" },
            new Employee{ Id=69, FirstName="Ali-19", LastName="Yalcin" },
            new Employee{ Id=70, FirstName="Ali-20", LastName="Yalcin" },
            new Employee{ Id=71, FirstName="Ali-21", LastName="Yalcin" },
            new Employee{ Id=72, FirstName="Ali-22", LastName="Yalcin" },
            new Employee{ Id=73, FirstName="Ali-23", LastName="Yalcin" },
            new Employee{ Id=74, FirstName="Ali-24", LastName="Yalcin" },
            new Employee{ Id=75, FirstName="Ali-25", LastName="Yalcin" },
            new Employee{ Id=76, FirstName="Ali-26", LastName="Yalcin" },
                        new Employee{ Id=1, FirstName="Ali-1", LastName="Yalcin" },
            new Employee{ Id=11, FirstName="Ali-11", LastName="Yalcin" },
            new Employee{ Id=12, FirstName="Ali-12", LastName="Yalcin" },
            new Employee{ Id=13, FirstName="Ali-13", LastName="Yalcin" },
            new Employee{ Id=14, FirstName="Ali-14", LastName="Yalcin" },
            new Employee{ Id=15, FirstName="Ali-15", LastName="Yalcin" },
            new Employee{ Id=16, FirstName="Ali-16", LastName="Yalcin" },
            new Employee{ Id=17, FirstName="Ali-17", LastName="Yalcin" },
            new Employee{ Id=18, FirstName="Ali-18", LastName="Yalcin" },
            new Employee{ Id=19, FirstName="Ali-19", LastName="Yalcin" },
            new Employee{ Id=20, FirstName="Ali-20", LastName="Yalcin" },
            new Employee{ Id=21, FirstName="Ali-21", LastName="Yalcin" },
            new Employee{ Id=22, FirstName="Ali-22", LastName="Yalcin" },
            new Employee{ Id=23, FirstName="Ali-23", LastName="Yalcin" },
            new Employee{ Id=24, FirstName="Ali-24", LastName="Yalcin" },
            new Employee{ Id=25, FirstName="Ali-25", LastName="Yalcin" },
            new Employee{ Id=26, FirstName="Ali-26", LastName="Yalcin" },
            new Employee{ Id=27, FirstName="Ali-1", LastName="Yalcin" },
            new Employee{ Id=28, FirstName="Ali-11", LastName="Yalcin" },
            new Employee{ Id=29, FirstName="Ali-12", LastName="Yalcin" },
            new Employee{ Id=30, FirstName="Ali-13", LastName="Yalcin" },
            new Employee{ Id=31, FirstName="Ali-14", LastName="Yalcin" },
            new Employee{ Id=32, FirstName="Ali-15", LastName="Yalcin" },
            new Employee{ Id=33, FirstName="Ali-16", LastName="Yalcin" },
            new Employee{ Id=34, FirstName="Ali-17", LastName="Yalcin" },
            new Employee{ Id=35, FirstName="Ali-18", LastName="Yalcin" },
            new Employee{ Id=36, FirstName="Ali-19", LastName="Yalcin" },
            new Employee{ Id=37, FirstName="Ali-20", LastName="Yalcin" },
            new Employee{ Id=38, FirstName="Ali-21", LastName="Yalcin" },
            new Employee{ Id=39, FirstName="Ali-22", LastName="Yalcin" },
            new Employee{ Id=40, FirstName="Ali-23", LastName="Yalcin" },
            new Employee{ Id=41, FirstName="Ali-24", LastName="Yalcin" },
            new Employee{ Id=42, FirstName="Ali-25", LastName="Yalcin" },
            new Employee{ Id=43, FirstName="Ali-26", LastName="Yalcin" },
            new Employee{ Id=44, FirstName="Ali-1", LastName="Yalcin" },
            new Employee{ Id=45, FirstName="Ali-11", LastName="Yalcin" },
            new Employee{ Id=46, FirstName="Ali-12", LastName="Yalcin" },
            new Employee{ Id=47, FirstName="Ali-13", LastName="Yalcin" },
            new Employee{ Id=48, FirstName="Ali-14", LastName="Yalcin" },
            new Employee{ Id=49, FirstName="Ali-15", LastName="Yalcin" },
            new Employee{ Id=50, FirstName="Ali-16", LastName="Yalcin" },
            new Employee{ Id=51, FirstName="Ali-17", LastName="Yalcin" },
            new Employee{ Id=52, FirstName="Ali-18", LastName="Yalcin" },
            new Employee{ Id=53, FirstName="Ali-19", LastName="Yalcin" },
            new Employee{ Id=54, FirstName="Ali-20", LastName="Yalcin" },
            new Employee{ Id=55, FirstName="Ali-21", LastName="Yalcin" },
            new Employee{ Id=56, FirstName="Ali-22", LastName="Yalcin" },
            new Employee{ Id=57, FirstName="Ali-23", LastName="Yalcin" },
            new Employee{ Id=58, FirstName="Ali-24", LastName="Yalcin" },
            new Employee{ Id=59, FirstName="Ali-25", LastName="Yalcin" },
            new Employee{ Id=60, FirstName="Ali-26", LastName="Yalcin" },
            new Employee{ Id=61, FirstName="Ali-1", LastName="Yalcin" },
            new Employee{ Id=62, FirstName="Ali-11", LastName="Yalcin" },
            new Employee{ Id=662, FirstName="Ali-12", LastName="Yalcin" },
            new Employee{ Id=63, FirstName="Ali-13", LastName="Yalcin" },
            new Employee{ Id=64, FirstName="Ali-14", LastName="Yalcin" },
            new Employee{ Id=65, FirstName="Ali-15", LastName="Yalcin" },
            new Employee{ Id=66, FirstName="Ali-16", LastName="Yalcin" },
            new Employee{ Id=67, FirstName="Ali-17", LastName="Yalcin" },
            new Employee{ Id=68, FirstName="Ali-18", LastName="Yalcin" },
            new Employee{ Id=69, FirstName="Ali-19", LastName="Yalcin" },
            new Employee{ Id=70, FirstName="Ali-20", LastName="Yalcin" },
            new Employee{ Id=71, FirstName="Ali-21", LastName="Yalcin" },
            new Employee{ Id=72, FirstName="Ali-22", LastName="Yalcin" },
            new Employee{ Id=73, FirstName="Ali-23", LastName="Yalcin" },
            new Employee{ Id=74, FirstName="Ali-24", LastName="Yalcin" },
            new Employee{ Id=75, FirstName="Ali-25", LastName="Yalcin" },
            new Employee{ Id=76, FirstName="Ali-26", LastName="Yalcin" }
        };

        public static async Task<List<Employee>> GetTakeLongEmployeeList(int startIndex, int numberOfEmployees)
        {
            if (startIndex>= _employees.Count-numberOfEmployees)
            {
                startIndex = 0;
            }
            var result = _employees.Skip(startIndex).Take(numberOfEmployees).ToList();
            return result;
        }

        public static List<Employee> Employees => _employees;
    }
}
