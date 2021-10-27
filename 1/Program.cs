using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Comp> compsList = new List<Comp>()
            {
                new Comp(){Code = 1, BrandName = "HP", ProcessorType = "Core i5", Chastota = 3.4, OZY = 4, HDD = 500, VideoCardMemory = 8, Price = 450, InStock = 14 },
                new Comp(){Code = 2, BrandName = "Acer", ProcessorType = "Core i5", Chastota = 3.2, OZY = 8, HDD = 1000, VideoCardMemory = 4, Price = 550, InStock = 31 },
                new Comp(){Code = 3, BrandName = "Dell", ProcessorType = "Core i3", Chastota = 3, OZY = 4, HDD = 500, VideoCardMemory = 2, Price = 300, InStock = 7 },
                new Comp(){Code = 4, BrandName = "HP", ProcessorType = "Core i7", Chastota = 3.7, OZY = 8, HDD = 2000, VideoCardMemory = 16, Price = 850, InStock = 26 },
                new Comp(){Code = 5, BrandName = "Asus", ProcessorType = "Core i5", Chastota = 3.2, OZY = 4, HDD = 1000, VideoCardMemory = 4, Price = 480, InStock = 17 },
                new Comp(){Code = 6, BrandName = "HP", ProcessorType = "Core i3", Chastota = 3, OZY = 8, HDD = 500, VideoCardMemory = 2, Price = 400, InStock = 36 },
                new Comp(){Code = 7, BrandName = "Lenovo", ProcessorType = "Core i5", Chastota = 3.5, OZY = 16, HDD = 500, VideoCardMemory = 6, Price = 550, InStock = 16 },
                new Comp(){Code = 8, BrandName = "Asus", ProcessorType = "Core i7", Chastota = 3.9, OZY = 16, HDD = 1000, VideoCardMemory = 8, Price = 900, InStock = 9 }
            };

            Console.WriteLine("1. Введите название процессора: ");
            string proc = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("По запросу найдено:");
            List<Comp> compsProc = compsList
                .Where(d => d.ProcessorType == proc)
                .ToList();
            foreach (Comp d in compsProc)
                Console.WriteLine($"{d.Code} {d.BrandName}, {d.ProcessorType}");
            Console.WriteLine();

            Console.WriteLine("2. Введите требуемое ОЗУ: ");
            int ozy = Convert.ToInt32(Console.ReadLine());
            List<Comp> compsOZY = compsList
                .Where(d => d.OZY >= ozy)
                .ToList();
            Console.WriteLine();
            Console.WriteLine("По запросу найдено:");
            foreach (Comp d in compsOZY)
                Console.WriteLine($"{d.Code} {d.BrandName}, {d.OZY}");
            Console.WriteLine();

            Console.WriteLine("3. Cортировка по цене: ");
            List<Comp> compsPrice = compsList
                .OrderBy(d => d.Price)
                .ToList();
            foreach (Comp d in compsPrice)
                Console.WriteLine($"{d.Code} {d.BrandName}, {d.Price}");
            Console.WriteLine();

            Console.WriteLine("4. Сортировка по типу процессора: ");
            List<Comp> procType = compsList
                .OrderBy(d => d.ProcessorType)
                .ToList();
            foreach (Comp d in procType)
                Console.WriteLine($"{d.Code} {d.BrandName}, {d.ProcessorType}");
            Console.WriteLine();

            Console.WriteLine("5. Стоимость самого дорогого компьютера:");
            int maxPrice = compsList
                .Max(d => d.Price);
            Console.WriteLine(maxPrice);
            Console.WriteLine();

            Console.WriteLine("6. Стоимость самого бюджетного компьютера:");
            int minPrice = compsList
                .Min(d => d.Price);
            Console.WriteLine(minPrice);
            Console.WriteLine();

            Console.WriteLine("7. Есть ли хотя бы один компьютер в количестве не менее 30 штук: ");
            var comps30 = compsList
                .Any((d => d.InStock >= 30));
            if (comps30 == true)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
            Console.ReadKey();
        }
    }
    class Comp
    {
        public int Code { get; set; }
        public string BrandName { get; set; }
        public string ProcessorType { get; set; }
        public double Chastota { get; set; }
        public int OZY { get; set; }
        public int HDD { get; set; }
        public int VideoCardMemory { get; set; }
        public int Price { get; set; }
        public int InStock { get; set; }
    }
}
