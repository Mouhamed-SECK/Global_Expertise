using GlobalExpertise.views;
using System;

using System.Windows.Forms;

namespace GlobalExpertise
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           /* GlobalExpertise.DAL.EnterpriseContext db = new DAL.EnterpriseContext();
            db.Departements.Add(new models.Departement() { Name = "Commande"} );
            db.Departements.Add(new models.Departement() { Name = "Compatbilité" });
            db.Departements.Add(new models.Departement() { Name = "Admin" });


            db.Employees.Add(new models.Employee{ Name="Seck", FirstName="Mouhamed Mosutapha", Email="medsoseck@gmail.com", Password="Passer", DepartementId= 3}); */


            Application.Run(new Login());
        }
    }
}
