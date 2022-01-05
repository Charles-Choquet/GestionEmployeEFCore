using GestionEmploye.Common.Interfaces;
using GestionEmploye.Common.Model;
using GestionEmploye.ViewModels.Command;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GestionEmploye.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private EmployeViewModel employeSelectionne;
        private IEmployeDataProvider _employeDataProvider;

        public MainWindowViewModel(IEmployeDataProvider employeDP) 
        {
            _employeDataProvider = employeDP;
            Employes = new();
            ChargerCmd = new DelegateCommand(Charger);
        }

        public ObservableCollection<EmployeViewModel> Employes { get; }
        public DelegateCommand ChargerCmd { get; }
        public ObservableCollection<Role> Roles { get; } = new();

        public EmployeViewModel EmployeSelectionne
        {
            get => employeSelectionne;
            set
            {
                if(employeSelectionne != value)
                {
                    employeSelectionne= value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(PeutAfficherDetails));
                }
                
            }
        }

        public bool PeutAfficherDetails => EmployeSelectionne != null;
        public bool PeutAjouter => EmployeSelectionne == null;

        public void Charger()
        {
            var employes = _employeDataProvider.ChargerEmployes();
            var roles = _employeDataProvider.ChargerRoles();
            
            Employes.Clear();
            foreach (var employe in employes)
            {
                Employes.Add(new EmployeViewModel(employe, _employeDataProvider));
            }

            Roles.Clear();
            foreach (var jobRole in roles)
            {
                Roles.Add(jobRole);
            }
        }        
    }
}
