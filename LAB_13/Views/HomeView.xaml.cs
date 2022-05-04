using LAB_13;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace SwitchingViewsMVVM.Views
{
    /// <summary>
    /// Логика взаимодействия для HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        ProductContext db;
        public HomeView()
        {
            InitializeComponent();
            db = new ProductContext();
            db.Products.Load();
            ProductGrid.ItemsSource = db.Products.Local.ToBindingList();


            db.ByProducts.Load();
            ByProductGrid.ItemsSource = db.ByProducts.Local.ToBindingList();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChangesAsync();
  
        }
      //  List<Product> products = new List<Product>();


    private void By_Click(object sender, RoutedEventArgs e)
        {
            if (ProductGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < ProductGrid.SelectedItems.Count; i++)
                {
                    Product product = ProductGrid.SelectedItems[i] as Product;

                    ByProduct byProduct = new ByProduct();
                    byProduct.Name = product.Name;
                    byProduct.Price = product.Price;
                    byProduct.Count = product.Count;
                    byProduct.Id = product.Id;
                    db.ByProducts.Add(byProduct);
                    if (product != null)
                    {
                        //перемещение
                        //  products = new List<Product>();
                        // products.Add(product);



                        db.Products.Remove(product);

                    }

                }
            }
            db.SaveChangesAsync();
        }



        private void Delete_Click(object sender, RoutedEventArgs e)
        {

                for (int i = 0; i < ProductGrid.SelectedItems.Count; i++)
                {
                    Product product = ProductGrid.SelectedItems[i] as Product;

                    if (product != null)
                    {
                        //перемещение
                        //  products = new List<Product>();
                        // products.Add(product);



                        db.Products.Remove(product);

                    }
                }
            
            db.SaveChangesAsync();
        }

        private void BySave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {

            if (ByProductGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < ByProductGrid.SelectedItems.Count; i++)
                {
                    ByProduct byProduct = ByProductGrid.SelectedItems[i] as ByProduct;

                    Product product = new Product();
                    product.Name = byProduct.Name;
                    product.Price = byProduct.Price;
                    product.Count = byProduct.Count;
                    product.Id = byProduct.Id;
                    db.Products.Add(product);

                    if (byProduct != null)
                    {
                        db.ByProducts.Remove(byProduct);

                    }

                }
            }
            db.SaveChangesAsync();
        }
    }
}
