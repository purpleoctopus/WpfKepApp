using System.Collections.Generic;
using System.Linq;
using System.Windows;
using WpfKepApp.Models;

namespace WpfKepApp
{
    public partial class MainWindow : Window
    {
        private List<Product> products;

        public MainWindow()
        {
            InitializeComponent();
            LoadProducts();
            productDataGrid.ItemsSource = products;
        }

        private void LoadProducts()
        {
            products = new List<Product>
            {
                new Product("Телефон", 12000, 0),
                new Product("Ноутбук", 25000, 15),
                new Product("Навушники", 1000, 10),
                new Product("Монітор", 6000, 0)
            };
        }

        public void FindMinPriceProduct_Click(object sender, RoutedEventArgs e)
        {
            if (products.Any())
            {
                // Знаходимо товар з мінімальною ціною
                var minPriceProduct = products.OrderBy(p => p.GetPriceAfterDiscount).First();
                minPriceProductText.Text = $"Товар з мінімальною ціною: {minPriceProduct}";
            }
            else
            {
                minPriceProductText.Text = "Список товарів порожній.";
            }
        }
    }
}