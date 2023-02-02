using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_meyveler_hoca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "portakal", "elma", "mandalina", "muz" };
            double[] costsPerKg = { 12.5, 5, 15.5, 17 };
            double totalCost = TotalCost(fruits, costsPerKg, 4, "portakal","ananas","elma","mandalina");
            Console.WriteLine($"Toplam tutar  = {totalCost}");
        }

        static double TotalCost(string[] fruits, double[] costs, double weight, params string[] fruitsInBasket)
        {
            double totalCost = 0;
            double totalWeight = 0;
            foreach (var fruit in fruitsInBasket)
            {
                if (fruits.Contains(fruit))
                {
                    int index = Array.IndexOf(fruits, fruit);
                    totalCost += costs[index] * weight;
                    totalWeight += weight;
                    Console.WriteLine($"{fruit} meyvesinden {weight} kg alındı. Fiyat = {costs[index] * weight}");
                }
                else
                {
                    Console.WriteLine($"{fruit} meyvesinden stokta yok.");
                }
            }
            if (totalWeight>10)
            {
                totalCost = totalCost * 0.75;
                Console.WriteLine("Almış olduğunuz ürün 10 kg'ı aştığından %25 indirim hakkı kazandınız!");
            }
            return totalCost;
        }
    }
}
