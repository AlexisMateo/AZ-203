using Microsoft.Azure.Cosmos.Table;
using TableStorageExample.Models;
using System.Linq;
using System.Collections.Generic;
using AutoMapper;

namespace TableStorageExample.Repository
{
    public class EmployeeRepository: BaseRepository
    {
        private const string TABLE_NAME = "employees";
        private CloudTable employeeTable;

        public EmployeeRepository()
        {
            this.employeeTable = cloudTableClient.GetTableReference(TABLE_NAME);
        }
        public TableResult CreateEmployee(EmployeeEntity employeeEntity)
        {
            TableOperation insertOperation = TableOperation.Insert(employeeEntity);
            TableResult result =  this.employeeTable.Execute(insertOperation);

            return result;
        }
        public IEnumerable<Employee> GetEmployees()
        {
            TableQuery<EmployeeEntity> employeeQuery = new TableQuery<EmployeeEntity>().Where(
                    TableQuery.GenerateFilterConditionForInt("Age",QueryComparisons.GreaterThan,26));
        
            IEnumerable<EmployeeEntity> employeesEntity = employeeTable.ExecuteQuery(employeeQuery, null);

            var employees = Mapper.Map<IEnumerable<Employee>>(employeesEntity);

            return employees;
            
        }

    }
    
}