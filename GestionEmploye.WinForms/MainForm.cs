using GestionEmploye.DataAccess;
using GestionEmploye.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmploye.WinForms
{
    public partial class MainForm : Form
    {
        private MainWindowViewModel _viewModel;

        public MainForm()
        {
            InitializeComponent();
            _viewModel = new MainWindowViewModel(new EmployeDataProvider());
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            Charger();

            txtBx_Nom.DataBindings.Add("Text", bs_Employes, "Nom",false, DataSourceUpdateMode.OnPropertyChanged);
            txtBx_Prenom.DataBindings.Add("Text", bs_Employes, "Prenom",false, DataSourceUpdateMode.OnPropertyChanged);
            dtpick_DateEmbauche.DataBindings.Add("Value", bs_Employes, "DateEmbaucheWpf");
            cmbBox_ListeRoles.DataSource = _viewModel.Roles;
            cmbBox_ListeRoles.DisplayMember = "Nom";
            cmbBox_ListeRoles.ValueMember = "Id";
            cmbBox_ListeRoles.DataBindings.Add("SelectedValue", bs_Employes, "RoleId");
            chkBox_EstPiloteDeLigne.DataBindings.Add("Checked", bs_Employes, "EstPiloteDeLigne");
        }

        private void btn_rafraichir_Click(object sender, EventArgs e)
        {
            Charger();
            bs_Employes.ResetBindings(false);
        }

        private void Charger()
        {
            _viewModel.Charger();
            bs_Employes.DataSource = _viewModel.Employes;
            listBox_ListeEmployes.DataSource = bs_Employes;
            listBox_ListeEmployes.DisplayMember = "Nom";
        }

        private void btn_Sauvegarder_Click(object sender, EventArgs e)
        {
            var vmCourant = bs_Employes.Current as EmployeViewModel;
            vmCourant.Sauvegarder();
        }
    }
}
