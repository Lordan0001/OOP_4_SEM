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
using System.Data.Entity;

namespace Test2
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }

    class UserContext : DbContext
    {
        public UserContext() : base("MyConnection1")
        { }

        public DbSet<Book> Books { get; set; }
    }

    public partial class MainWindow : Window
    {
        UserContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new UserContext();
            db.Books.Load();
            MyGrid.ItemsSource = db.Books.Local.ToBindingList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChangesAsync();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(MyGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < MyGrid.SelectedItems.Count; i++)
                {
                    Book book = MyGrid.SelectedItems[i] as Book;
                    if (book != null)
                    {
                        db.Books.Remove(book);
                    }
                }
            }
            db.SaveChangesAsync();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            UserContext userContext = new UserContext();

            IQueryable<Book> books = userContext.Books
                .Where(c => c.Name == Search.Text)
                .Select(c => c);

            MyGrid.ItemsSource = books.ToList();


        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            UserContext userContext = new UserContext();

            IQueryable<Book> books = userContext.Books
                .Where(c => c.Price.ToString() == Search.Text)
                .Select(c => c);

            MyGrid.ItemsSource = books.ToList();
        }
    }
}
