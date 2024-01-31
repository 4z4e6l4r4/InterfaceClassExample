namespace InterfaceClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region UserProcess
            UserController userController = new UserController();
            User user = new User();
            user.Name = "Azra";
            user.Email = "xxx@gmail.com";
            user.Password = "54321";

            Console.WriteLine(userController.Add(user));

            #endregion

            #region "Product Process"
            ProductController producstcontroller = new ProductController();
            Product product = new Product();
            product.Name = "Elma";
            product.Description = "Golden Elma";
            product.Price = 10;
            product.Stock = 1;

            producstcontroller.Add(product);

            #endregion
        
        
        
        
        }
    }
}