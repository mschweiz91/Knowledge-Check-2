namespace KnowledgeCheck2
{
    using System;
    using System.Collections.Generic;
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Laptop>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var laptop = new Laptop();

                Console.WriteLine("Adding a new laptop");

                Console.WriteLine("Enter the brand name of the laptop: ");
                laptop.Brand = Console.ReadLine();

                Console.WriteLine("Enter the value for the laptop's screen size in inches: ");
                laptop.ScreenSizeInches = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the price of the laptop: ");
                laptop.Price = decimal.Parse(Console.ReadLine());

                recordList.Add(laptop);

               
            }

            // Print out the list of records using Console.WriteLine()

                        
            recordList.ForEach(recordList => Console.WriteLine(recordList));

        }
    }
}