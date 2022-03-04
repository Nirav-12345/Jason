using System;
namespace InventoryProgram2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = "C:/Users/Nirav Raj/Desktop/json/InventoryProgram2/Rice.json";

            FetchJasonRice fetchJasonForRice = new FetchJasonRice();
            Rice data = fetchJasonForRice.Read(path);

            for (int i = 0; i < data.typeofRice.Count; i++)
            {
                Console.WriteLine("1)Data for Rice");
                Console.WriteLine(data.typeofRice[i].name);
                Console.WriteLine(data.typeofRice[i].weight);
                Console.WriteLine(data.typeofRice[i].price);
                Console.WriteLine("----------------------");
            }
            for (int i = 0; i < data.typeofPules.Count; i++)
            {
                Console.WriteLine("2)Data for Pules");
                Console.WriteLine(data.typeofPules[i].name);
                Console.WriteLine(data.typeofPules[i].weight);
                Console.WriteLine(data.typeofPules[i].price);
                Console.WriteLine("-----------------------");
            }
            for (int i = 0; i < data.typeofWheats.Count; i++)
            {
                Console.WriteLine("3)Data for Wheat");
                Console.WriteLine(data.typeofWheats[i].name);
                Console.WriteLine(data.typeofWheats[i].weight);
                Console.WriteLine(data.typeofWheats[i].price);
                Console.WriteLine("-----------------------");
            }
            //Console.WriteLine(data.weight);
            //Console.WriteLine(data.price);
        }

    }
}