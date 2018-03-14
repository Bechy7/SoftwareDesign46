using System.Windows.Input;

namespace SimpleMVVMExample
{
    public class ProductViewModel : ObservableObject
    {
        #region Fields

        private int _productId;
        private ProductModel _currentProduct;
        private ICommand _getProductCommand;
        private ICommand _saveProductCommand;

        #endregion

        #region Public Properties/Commands

        public int ProductId
        {
            get { return _productId; }
            set
            {
                if (value != _productId)
                {
                    _productId = value;
                    OnPropertyChanged("ProductId");
                }
            }
        }

        public ProductModel CurrentProduct
        {
            get { return _currentProduct; }
            set
            {
                if (value != _currentProduct)
                {
                    _currentProduct = value;
                    OnPropertyChanged("CurrentProduct");
                }
            }
        }

        public ICommand GetProductCommand
        {
            get
            {
                if (_getProductCommand == null)
                {
                    _getProductCommand = new RelayCommand(
                        param => GetProduct(),
                        param => ProductId > 0
                    );
                }
                return _getProductCommand;
            }
        }

        public ICommand SaveProductCommand
        {
            get
            {
                if (_saveProductCommand == null)
                {
                    _saveProductCommand = new RelayCommand(
                        param => SaveProduct(),
                        param => (CurrentProduct != null)
                    );
                }
                return _saveProductCommand;
            }
        }

        #endregion

        #region Private Helpers

        private void GetProduct()
        {
            // Usually you'd get your Product from your datastore,
            // but for now we'll just return a new object
            ProductModel p = new ProductModel();
            p.ProductId = ProductId;
            p.ProductName = "Test Product";
            p.UnitPrice = 10;
            CurrentProduct = p;
        }

        private void SaveProduct()
        {
            // You would implement your Product save here
        }

        #endregion
    }
}
