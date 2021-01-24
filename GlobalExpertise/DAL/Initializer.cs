using System;
using System.Collections.Generic;
using   GlobalExpertise.models;

namespace GlobalExpertise.DAL 
{
    class Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EnterpriseContext>
    {
        protected override void Seed(EnterpriseContext context)
        {
            var customers = new List<Customer>
            {
            new Customer{Name="Carson",FirstName="Alexander",Email="customer@gmail.com",Address= "Km unite 5 villa 586", IdCardNumber="44852765668658"},
            new Customer{Name="Carson",FirstName="Alexander",Email="customer@gmail.com",Address= "Km unite 5 villa 586", IdCardNumber="44852765668658"},
            new Customer{Name="Carson",FirstName="Alexander",Email="customer@gmail.com",Address= "Km unite 5 villa 586", IdCardNumber="44852765668658"},
            new Customer{Name="Carson",FirstName="Alexander",Email="customer@gmail.com",Address= "Km unite 5 villa 586", IdCardNumber="44852765668658"},
            };
            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            var employees = new List<Employee>
            {
           
            };
            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();


        }

    }
}
