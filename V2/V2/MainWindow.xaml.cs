using System.Windows;

namespace UpperCaseConverter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var model = new Model();
            var viewModel = new ViewModel(model);
            this.DataContext = viewModel;
        }
    }
}