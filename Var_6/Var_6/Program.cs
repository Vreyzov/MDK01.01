using System;
using System.IO;
using Var_6.Classes;

    

        Console.WriteLine("Введите количество товаров:");
        int itemCount;
        while (!int.TryParse(Console.ReadLine(), out itemCount) || itemCount <= 0)
        {
            Console.WriteLine("Введите корректное количество товаров (целое положительное число):");
        }

    Price[] prices = new Price[itemCount];

        //Ввод данных о товарах
        for (int i = 0; i < itemCount; i++)
        {
            prices[i] = new Price();
            prices[i].VvodDannih();
        }

        //Вывод данных о товарах
        Console.WriteLine("\nИнформация о товарах:");
        foreach (Price price in prices)
        {
            Console.WriteLine(price.ToString());
        }
         //Метод расчета общей стоимости товаров в магазине
        Console.WriteLine("\nРасчет общей стоимости товаров в магазине:");
        Console.Write("Введите название магазина для расчета: ");
        string storeToCalculate = Console.ReadLine();

        double totalInStore = Price.CalculateTotalPriceInStore(prices, storeToCalculate);
        if (totalInStore > 0)
        {
            Console.WriteLine($"Общая стоимость товаров в магазине {storeToCalculate}: {totalInStore} руб.");
        }
        else
        {
            Console.WriteLine($"Магазин {storeToCalculate} не найден или в нем нет товаров.");
        }


        //Поиск информации о товаре по названию
        Console.WriteLine("\nПоиск информации о товаре по названию:");
        Console.Write("Введите название товара для поиска: ");
        string productToFind = Console.ReadLine();

    Price foundProduct = Price.FindProductByName(prices, productToFind);
        if (foundProduct != null)
        {
            Console.WriteLine($"Информация о товаре:\n{foundProduct.ToString()}");
        }
        else
        {
            Console.WriteLine($"Товар с названием {productToFind} не найден.");
        }

