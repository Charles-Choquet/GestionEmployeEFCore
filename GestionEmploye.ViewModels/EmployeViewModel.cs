using GestionEmploye.Common.Interfaces;
using GestionEmploye.Common.Model;
using GestionEmploye.ViewModels.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmploye.ViewModels
{
    public class EmployeViewModel : ViewModelBase
    {
        private Employe _employe;
        private IEmployeDataProvider _employeDataProvider;

        public DelegateCommand SauvegarderCmd { get; }
        public DelegateCommand AjouterCmd { get; }

        public EmployeViewModel(Employe employe, IEmployeDataProvider employeDP)
        {
            _employe = employe;
            _employeDataProvider = employeDP;
            SauvegarderCmd = new DelegateCommand(Sauvegarder, () => PeutSauvegarder);
            AjouterCmd = new DelegateCommand(Ajouter);
        }       

        public string Nom 
        { 
          get => _employe.Nom; 
          set
          {
                if (_employe.Nom != value)
                {
                    _employe.Nom = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(PeutSauvegarder));
                    SauvegarderCmd.RaiseCanExecuteChanged();
                }
          }
        }
        public string Prenom
        {
            get => _employe.Prenom;
            set
            {
                if (_employe.Prenom != value)
                {
                    _employe.Prenom = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(PeutSauvegarder));
                    SauvegarderCmd.RaiseCanExecuteChanged();
                }
            }
        }
        
        public DateTimeOffset DateEmbauche
        {
            get => _employe.DateEmbauche;
            set
            {
                if (_employe.DateEmbauche != value)
                {
                    _employe.DateEmbauche = value;
                    RaisePropertyChanged();
                }
            }
        }
        public DateTime DateEmbaucheWpf
        {
            get => _employe.DateEmbauche.DateTime;
            set
            {
                if (_employe.DateEmbauche != value)
                {
                    _employe.DateEmbauche = value;
                    RaisePropertyChanged();
                }
            }
        }

        public int RoleId
        {
            get => _employe.RoleId;
            set
            {
                if (_employe.RoleId != value)
                { 

                    _employe.RoleId = value;
                    RaisePropertyChanged();
                }
            }
        }
        public bool EstPiloteDeLigne
        {
            get => _employe.EstPiloteDeLigne;
            set
            {
                if(_employe.EstPiloteDeLigne != value)
                {
                    _employe.EstPiloteDeLigne = value;
                    RaisePropertyChanged();
                }
                
            }
        }

        public bool PeutSauvegarder => !string.IsNullOrWhiteSpace(Prenom) && !string.IsNullOrWhiteSpace(Nom);        

        public void Sauvegarder()
        {
            _employeDataProvider.SauvegarderEmploye(_employe);
        }

        public void Ajouter()
        {
            _employeDataProvider.AjouterEmploye(_employe);
        }

    }
}
