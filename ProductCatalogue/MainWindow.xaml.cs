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
                new Product (
                   "Laptop",
                    999.99m,
                    "Powerful and portable laptop for work and play."
                    ),
                new Product(
                
                    "Smartphone",
                    499.99m,
                   "High-performance smartphone with a stunning display."
               ),
                new Product
                (
                  "Headphones",
                    199.99m,
                    "Noise-cancelling over-ear headphones with deep bass."
                )
            };

            // Set initial product context
            this.DataContext = _products[_currentIndex];
        }

        private void BtnPrev_Click(object sender, RoutedEventArgs e)
        {
            // Move index one step back, if possible
            if (_currentIndex > 0)
            {
                _currentIndex--;
                this.DataContext = _products[_currentIndex];
            } else
            {
                _currentIndex = _products.Count - 1;
                this.DataContext = _products[_currentIndex];
            }
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            // Move index one step forward, if possible
            if (_currentIndex < _products.Count - 1)
            {
                _currentIndex++;
                this.DataContext = _products[_currentIndex];
            } else
            {
                _currentIndex = 0;
                this.DataContext = _products[_currentIndex];
            }
        }
    }
}
