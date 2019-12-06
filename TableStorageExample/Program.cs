using System;
using System.Collections.Generic;
using dotenv.net;
using Microsoft.Azure.Cosmos.Table;
using TableStorageExample.Config;
using TableStorageExample.Models;
using TableStorageExample.Repository;

namespace TableStorageExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DotEnv.Config();
            AutomapperConfig.Initialize();
            GetEmployees();
        }

        public static void CreateEmployee()
        {
            EmployeeEntity employeeEntity = new EmployeeEntity(age:22,lastName:"Mateo",firstName:"Daniel");
            EmployeeRepository employeeRepository = new EmployeeRepository();
            employeeRepository.CreateEmployee(employeeEntity);
        }

        public static void GetEmployees()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            IEnumerable<Employee> employees = employeeRepository.GetEmployees();
            

        }

    }
}
