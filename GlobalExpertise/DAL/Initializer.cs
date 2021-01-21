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
            customers.ForEach(s => context.customers.Add(s));
            context.SaveChanges();

            var employees = new List<Employee>
            {
            new Employee{Name="Carson",FirstName="Alexander",Email="customer@gmail.com",Password= "passer", Departement= DEPARTEMENT.Commande},
            new Employee{Name="Carson",FirstName="Alexander",Email="customer@gmail.com",Password= "passer", Departement= DEPARTEMENT.Admin},
            new Employee{Name="Carson",FirstName="Alexander",Email="customer@gmail.com",Password= "passer", Departement= DEPARTEMENT.Livraison},
            new Employee{Name="Carson",FirstName="Alexander",Email="customer@gmail.com",Password= "passer", Departement=DEPARTEMENT.Comptable},
            };
            employees.ForEach(s => context.employees.Add(s));
            context.SaveChanges();


        }

    }
}
