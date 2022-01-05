using GestionEmploye.ViewModels;
using GestionEmploye.DataAccess;
using System.Windows;

namespace GestionEmploye.WPF
{
    
    public partial class MainWindow : Window
    {
        private MainWindowViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MainWindowViewModel(new EmployeDataProvider());
            DataContext = _viewModel;

            Activated += MainWindow_Activated; ;
        }

        private void MainWindow_Activated(object sender, System.EventArgs e)
        {
            _viewModel.Charger();
        }
    }
}
