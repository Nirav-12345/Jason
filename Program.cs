using System;
namespace Invent3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = "C:/Users/Nirav Raj/Desktop/json/Invent3/Rice.json";

            Jason fetchJasonForRice = new Jason();
            Rice data = fetchJasonForRice.Read(path);

            for (int i = 0; i < data.typeofRice.Count; i++)
            {
                Console.WriteLine("1)Data for Rice");
                Console.WriteLine(data.typeofRice[i].name);
                Console.WriteLine(data.typeofRice[i].weight);
                Console.WriteLine(data.typeofRice[i].price);
                int TypeofRice = data.typeofRice[i].weight * data.typeofRice[i].price;
                Console.WriteLine("The inventory price of Bashmuti is" + TypeofRice);
                Console.WriteLine("----------------------");
                
            }
            for (int i = 0; i < data.typeofPules.Count; i++)
            {
                Console.WriteLine("2)Data for Pules");
                Console.WriteLine(data.typeofPules[i].name);
                Console.WriteLine(data.typeofPules[i].weight);
                Console.WriteLine(data.typeofPules[i].price);

                int TypeofPulse = data.typeofPules[i].weight * data.typeofPules[i].price;
                Console.WriteLine("The inventory price of Pulse is" + TypeofPulse);
                Console.WriteLine("-----------------------");
            }
            for (int i = 0; i < data.typeofWheats.Count; i++)
            {
                Console.WriteLine("3)Data for Wheat");
                Console.WriteLine(data.typeofWheats[i].name);
                Console.WriteLine(data.typeofWheats[i].weight);
                Console.WriteLine(data.typeofWheats[i].price);
                int TypeofWheats = data.typeofWheats[i].weight * data.typeofWheats[i].price;
                Console.WriteLine("The inventory price of Pulse is" + TypeofWheats);
                Console.WriteLine("-----------------------");
            }
            //Console.WriteLine(data.weight);
            //Console.WriteLine(data.price);
        }

    }
}