using System;

namespace MeuApp {
    class Program {
        static void Main(string[] args) {
            var product = new Product(1, "Mouse gamer", 25.5f, EProductType.Product);
            Console.WriteLine("ID: " + product.Id);
            Console.WriteLine("Título: " + product.Title);
            Console.WriteLine("Preço: $" + product.Price);
            Console.WriteLine("Type:" + product.Type);
            Console.WriteLine("");
            Console.WriteLine(cotacaoDolar(product.Price, 5.0f));

            Product product2 = new Product(2, "Teclado", 10.0f, EProductType.Product);
            Console.WriteLine("ID: " + product2.Id);
            Console.WriteLine("Título: " + product2.Title);
            Console.WriteLine("Preço: $" + product2.Price);
            Console.WriteLine("Type:" + product2.Type);
            Console.WriteLine(cotacaoDolar(product2.Price, 5.0f));


        }

        public static float cotacaoDolar(float price, float dolar) {
            return price * dolar;
        }
        struct Product {

            public int Id;
            public string Title;
            public float Price;
            public EProductType Type;

            public Product (int id, string title, float price, EProductType type) {
                Id = id;
                Title = title;
                Price = price;
                Type = type;

            }

        }

        enum EProductType {
            Product = 1,
            Service = 2
        }

        }

    }



 