using System;
using Microsoft.Azure.Cosmos.Table;

namespace TableStorageExample.Models
{
    public class EmployeeEntity : TableEntity
    {
        public EmployeeEntity()
        {
        }
        public EmployeeEntity(byte age, string lastName, string firstName)
        {
            this.PartitionKey = "staff";
            this.RowKey =  Guid.NewGuid().ToString();
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Age = age;
        }

        public string LastName { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
    }
}