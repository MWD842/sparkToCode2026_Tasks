using ECommerceDatabase.Models;
using System;
using System.Linq;
namespace ECommerceDatabase
{
    public class Program
    {

        static ProjectContext context = new ProjectContext();

        static int loggedInUserId = 0;
        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== E-Commerce Console App =====");
                Console.WriteLine(" 1. Register New User");
                Console.WriteLine(" 2. Login");
                Console.WriteLine(" 3. Add New Category");
                Console.WriteLine(" 4. Add New Product");
                Console.WriteLine(" 5. View All Products");
                Console.WriteLine(" 6. Place an Order");
                Console.WriteLine(" 7. View My Orders");
                Console.WriteLine(" 8. View Order Details");
                Console.WriteLine(" 9. Add a Review for an Order");
                Console.WriteLine("10. View All Reviews for a Product");
                Console.WriteLine("11. Logout");
                Console.WriteLine(" 0. Exit");
                Console.Write("Enter your choice: ");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
                switch (choice)
                {
                    case 1: RegisterUser(); break;
                    case 2: Login(); break;
                    case 3: AddCategory(); break;
                    case 4: AddProduct(); break;
                    case 5: ViewAllProducts(); break;
                    case 6: PlaceOrder(); break;
                    case 7: ViewMyOrders(); break;
                    case 8: ViewOrderDetails(); break;
                    case 9: AddReview(); break;
                    case 10: ViewReviewsForProduct(); break;
                    case 11: Logout(); break;
                    case 0:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
        static void RegisterUser()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            var user = new User { UserName = name, UserEmail = email, UserPassword = password };
            context.Users.Add(user);
            context.SaveChanges();

            Console.WriteLine($"User registered with Id {user.UserId}");
        }
        static void Login()
        {
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            var user = context.Users.FirstOrDefault(u => u.UserEmail == email && u.UserPassword == password);
            if (user == null)
            {
                Console.WriteLine("Invalid email or password.");
                return;
            }

            loggedInUserId = user.UserId;
            Console.WriteLine($"Logged in as {user.UserName}");
        }
        static void AddCategory()
        {
            Console.Write("Enter the category name: ");
            string name = Console.ReadLine();

            context.Categories.Add(new Category { CategoryName = name });
            context.SaveChanges();

            Console.WriteLine("Category added.");
        }
        static void AddProduct()
        {
            var categoryList = context.Categories.ToList();
            if (categoryList.Count == 0)
            {
                Console.WriteLine("You need at least one category before adding a product.");
                return;
            }

            Console.WriteLine("Available categories:");
            for (int i = 0; i < categoryList.Count; i++)
                Console.WriteLine($"[{categoryList[i].CategoryId}] {categoryList[i].CategoryName}");

            Console.Write("Product name: ");
            string productName = Console.ReadLine();

            Console.Write("Price in OMR: ");
            decimal productPrice;
            if (!decimal.TryParse(Console.ReadLine(), out productPrice) || productPrice <= 0)
            {
                Console.WriteLine("The price must be a number greater than 0.");
                return;
            }

            Console.Write("Category Id: ");
            int chosenCategory;
            if (!int.TryParse(Console.ReadLine(), out chosenCategory))
            {
                Console.WriteLine("Numbers only please.");
                return;
            }

            var category = categoryList.FirstOrDefault(c => c.CategoryId == chosenCategory);
            if (category == null)
            {
                Console.WriteLine("That category Id does not exist.");
                return;
            }

            var product = new Product();
            product.ProductName = productName;
            product.ProductPrice = productPrice;
            product.CategoryId = category.CategoryId;

            context.Products.Add(product);
            context.SaveChanges();

            Console.WriteLine($"{product.ProductName} was added under {category.CategoryName}.");
        }
        static void ViewAllProducts()
        {
            var productList = context.Products.ToList();
            if (productList.Count == 0)
            {
                Console.WriteLine("There are no products to show.");
                return;
            }

            var categoryList = context.Categories.ToList();

            Console.WriteLine("\n===== Product List =====");
            for (int i = 0; i < productList.Count; i++)
            {
                var item = productList[i];
                var match = categoryList.FirstOrDefault(c => c.CategoryId == item.CategoryId);
                string label = "Uncategorized";
                if (match != null)
                    label = match.CategoryName;

                Console.WriteLine($"[{item.ProductId}] {item.ProductName} | {item.ProductPrice} OMR | {label}");
            }
        }
        static void PlaceOrder()
        {
            if (loggedInUserId == 0)
            {
                Console.WriteLine("You must be logged in to place an order.");
                return;
            }

            var products = context.Products.ToList();
            if (products.Count == 0)
            {
                Console.WriteLine("No products available.");
                return;
            }

            var order = new Order { UserId = loggedInUserId, OrderDate = DateTime.Now };
            context.Orders.Add(order);
            context.SaveChanges();

            decimal total = 0;
            bool addingProducts = true;

            while (addingProducts)
            {
                Console.WriteLine("Products:");
                foreach (var p in products)
                    Console.WriteLine($"{p.ProductId}. {p.ProductName} - {p.ProductPrice:C}");

                Console.Write("Product Id: ");
            }
        }
        static void ViewMyOrders()
        {
            if (loggedInUserId == 0)
            {
                Console.WriteLine("You must be logged in to view your orders.");
                return;
            }

            var orders = context.Orders.Where(o => o.UserId == loggedInUserId).ToList();
            if (orders.Count == 0)
            {
                Console.WriteLine("You have no orders.");
                return;
            }

            var products = context.Products.ToList();

            Console.WriteLine($"You have {orders.Count} order(s):");
            foreach (var o in orders)
            {
                var items = context.OrderProducts.Where(op => op.OrderId == o.OrderId).ToList();

                decimal total = 0;
                foreach (var i in items)
                {
                    var product = products.FirstOrDefault(p => p.ProductId == i.ProductId);
                    if (product != null)
                        total += product.ProductPrice * i.Quantity;
                }

                Console.WriteLine($"Order {o.OrderId} - {o.OrderDate} - {items.Count} item(s) - {total:C}");
            }
        }
        static void ViewOrderDetails()
        {
            // TODO: implement
        }
        static void AddReview()
        {
            // TODO: implement - check loggedInUserId != 0 first
        }
        static void ViewReviewsForProduct()
        {
            // TODO: implement
        }
        static void Logout()
        {
            // TODO: implement - reset loggedInUserId back to 0
        }

    }
}


