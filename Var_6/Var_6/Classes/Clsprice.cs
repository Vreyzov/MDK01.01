using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_6.Classes
{
    
        internal class Price
        {
            //Поля
            private string productName;
            private string storeName;
            private double productPrice;
            private int productQuantity;

            public string ProductName
            {
                get { return productName; }
                set { productName = value; }
            }

            public string StoreName
            {
                get { return storeName; }
                set { storeName = value; }
            }

            public double ProductPrice
            {
                get { return productPrice; }
                set { productPrice = value; }
            }

            public int ProductQuantity
            {
                get { return productQuantity; }
                set { productQuantity = value; }
            }

            //Конструктор по умолчанию
            public Price()
            {
            }

            //Конструктор с параметрами
            public Price(string productName, string storeName, double productPrice, int productQuantity)
            {
                this.productName = productName;
                this.storeName = storeName;
                this.productPrice = productPrice;
                this.productQuantity = productQuantity;
            }

            //Метод ввода данных объекта
            public void VvodDannih()
            {
                Console.WriteLine("Введите название товара:");
                productName = Console.ReadLine();

                Console.WriteLine("Введите название магазина:");
                storeName = Console.ReadLine();

                Console.WriteLine("Введите стоимость товара:");
                double.TryParse(Console.ReadLine(), out productPrice);

                Console.WriteLine("Введите количество товара:");
                int.TryParse(Console.ReadLine(), out productQuantity);
            }

            //Метод вывода данных объекта
            public override string ToString()
            {
                return $"*********************\n" + $"Товар: {productName}\n" + $"Магазин: {storeName}\n" + $"Стоимость: {productPrice} руб.\n" + $"Количество: {productQuantity}";
            }
        //Метод расчета общей стоимости товаров в магазине
        public static double CalculateTotalPriceInStore(Price[] prices, string storeName)
        {
            double total = 0;

            foreach (Price price in prices)
            {
                if (price.StoreName.Equals(storeName, StringComparison.OrdinalIgnoreCase))
                {
                    total += price.ProductPrice * price.ProductQuantity;
                }
            }

            return total;
        }
            //Метод поиска информации о товаре по названию
            public static Price FindProductByName(Price[] prices, string productName)
            {
                foreach (Price price in prices)
                {
                    if (price.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase))
                    {
                        return price;
                    }
                }

                return null;
            }
        }
    
}
