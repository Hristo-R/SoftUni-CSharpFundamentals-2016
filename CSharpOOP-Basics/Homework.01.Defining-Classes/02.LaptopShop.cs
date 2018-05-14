namespace Problem_02.LaptopShop
{
    using System;

    public class LaptopShop
    {
        public static void Main()
        {
            Laptop laptopLevovo = new Laptop(
                "Lenovo Yoga 2 Pro",
                "Lenovo",
                "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                "8 GB",
                "Intel HD Graphics 4400",
                "128GB SSD",
                "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",
                "Li-Ion, 4-cells, 2550 mAh",
                "4,5",
                2259.00M);

            Battery batteryLenovo = new Battery("Li-Ion, 4-cells, 2550 mAh", "4,5");

            Laptop laptopHP = new Laptop("HP 250 G2", 699.00M);
            Battery batteryHP = new Battery();

            Console.WriteLine(laptopLevovo);
            Console.WriteLine();
            Console.WriteLine(laptopHP);
        }
    }
}