using System;

namespace Constructor

{
    class Product
    {
        public int ProductId;
        public string ProductName;
        public double Price;
        public Product(int productId, string productName, double price)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
        }
        public void Display()
        {
            Console.WriteLine($"ID: {ProductId}, Name: {ProductName}, Price: {Price}");
        }
    }
    class Program

    {
        static void Main(string[] args)
        {
            // TODO: Tạo đối tượng Product dùng Constructor
            // TODO: In thông tin sản phẩm

            Product p = new Product(100, "Laptop Dell cua KaVu", 50000000);
            // In thông tin sản phẩm
            p.Display();
        }
    }
}

