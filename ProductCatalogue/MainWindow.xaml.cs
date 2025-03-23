using System.Collections.ObjectModel;
using System.Windows;

namespace ProductCatalogue
{
    public partial class MainWindow : Window
    {
        // The collection that holds all products
        private ObservableCollection<Product> _products;

        // Tracks the current product index
        private int _currentIndex = 0;

        public MainWindow()
        {
            InitializeComponent();

            // Create some sample products
            _products = new ObservableCollection<Product>
            {
            };

            // Set initial product context
            this.DataContext = _products[_currentIndex];
        }

        private void BtnPrev_Click(object sender, RoutedEventArgs e)
        {
                this.DataContext = _products[_currentIndex];
            
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
                this.DataContext = _products[_currentIndex];
            
        }
    }
}
