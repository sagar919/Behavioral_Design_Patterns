
using System;

namespace ObserverDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Subject RedMI = new Subject("OPPO", 10000, "Out Of Stock");

            
             Observer user1 = new Observer("Sagar", RedMI);

           
            Observer user2 = new Observer("Karan", RedMI);

            
            Observer user3 = new Observer("Bhavish", RedMI);

            Console.WriteLine("Red MI Mobile current state : " + RedMI.getAvailability());
            Console.WriteLine();

           
            RedMI.setAvailability("Available");
            Console.Read();
        }
    }
}
