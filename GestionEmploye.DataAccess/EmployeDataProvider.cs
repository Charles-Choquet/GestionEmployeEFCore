using GestionEmploye.Common.Interfaces;
using GestionEmploye.Common.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmploye.DataAccess
{
    public class EmployeDataProvider : IEmployeDataProvider
    {
        private static readonly EmployeContexte _context = new();


        public IEnumerable<Employe> ChargerEmployes()
        {
            IEnumerable<Employe> employes = _context.Employe.ToList();
            return employes;
        }

        public IEnumerable<Role> ChargerRoles()
        {
            IEnumerable<Role> roles = _context.Role.ToList();
            return roles;
        }

        public void AjouterEmploye(Employe newEmploye)
        {
            var employe = new Employe { Nom = newEmploye.Nom, Prenom = newEmploye.Prenom, DateEmbauche= newEmploye.DateEmbauche, EstPiloteDeLigne= newEmploye.EstPiloteDeLigne, RoleId=newEmploye.RoleId };
            _context.Employe.Add(employe);
            _context.SaveChanges();
        }

        public void SauvegarderEmploye(Employe employe)
        {
            if (_context.Employe.Find(employe.Id) == null) {
                _context.Employe.Add(employe);
            };
            _context.SaveChanges();
        }
    }
}
