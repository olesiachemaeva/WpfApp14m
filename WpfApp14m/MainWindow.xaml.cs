using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp14m
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                Name = "Молочные продукты",
                Cost = 30,
                Image = "Tovar/milk.png",
                Category = ProductsP.Food

            });
            products.Add(new Product()
            {
                Name = "Овощи",
                Cost = 15,
                Image = "Tovar/vegetable.png",
                Category = ProductsP.Food

            });
            products.Add(new Product()
            {
                Name = "Куханная техника",
                Cost = 150,
                Image = "Tovar/appliances.png",
                Category = ProductsP.Tech

            });
            products.Add(new Product()
            {
                Name = "Бытовая техника",
                Cost = 100,
                Image = "Tovar/refrigerator.png",
                Category = ProductsP.Tech

            });
            products.Add(new Product()
            {
                Name = "Кондиционеры",
                Cost = 150,
                Image = "Tovar/conditioning.png",
                Category = ProductsP.Tech

            });
            lstBox.ItemsSource = products;
        }
    }
}
