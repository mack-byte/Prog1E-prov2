using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1Eprov2
{
    class Program
    {
        static void Main(string[] args)
        {


            Random gen = new Random();
            Console.WriteLine("How many cars would you like to check");
            string input = Console.ReadLine();
            List<int> totalCars = new List<int>(); // Skapar en lista som de totala antalet bilar sparas

            int amount;
            bool lyckad = int.TryParse(input, out amount); //Konverterar string-inputen till en int
            
            int contra = gen.Next(0, amount);//Slumpar ett tal mellan 0 och antalet användaren angivit vilket då blir antalet contraband cars
            int clean = amount - contra; //Subtraherar contraband car från ursprungsantalet vilket då blir clean cars
            

            for (int i = 0; i < clean; i++) //En loop som adderar clean cars i listan
            {
                CleanCar cln = new CleanCar();
                totalCars.Add(cln.contrabandAmount);
                
            }
            for (int i = 0; i < contra; i++)
            {
                CleanCar cont = new CleanCar();
                totalCars.Add(cont.contrabandAmount);
                
            }
            
            bool gameloop = false;
            while (gameloop == false) //
            {
                Console.WriteLine("Which car would you like to check");
                string input2 = Console.ReadLine();
                int inp = int.Parse(input2);

                if (inp <= amount) //Gör så att man inte kan skriva in ett tal högre än antalet bilar
                {
                    Console.WriteLine("In car " + input2 + " You found " + totalCars[inp] + " Contraband items"); //Skriver ut antalet contrabands i den bilen man kikar i
                }
                else if (inp > amount)
                {
                    Console.WriteLine("please try again");
                }
                                
                
                
            }


            

        }
       
       
    }
}
