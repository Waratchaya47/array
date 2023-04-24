using System;
namespace quiz2{
    class program{
          static void Main(string[] args) {

             Console.Write("Input number item in pack: ");
             int numItems = int.Parse(Console.ReadLine());

              string[] itemNames = new string[numItems];
              string[] itemTypes = new string[numItems];

             for (int i = 0; i < numItems; i++)  {
                  Console.Write($"Item {i+1} name: ");
                  itemNames[i] = Console.ReadLine();

               Console.Write($"Item {i+1} type: ");
               itemTypes[i] = Console.ReadLine();
        }

        while (true)
        {
            Console.Write("Search for an item (enter 'ShowAll' to show all items): ");
            string input = Console.ReadLine();

            if (input == "ShowAll")
            {
                Console.WriteLine("All items in your backpack:");
                for (int i = 0; i < numItems; i++)
                {
                    Console.WriteLine($"{itemNames[i]}\n({itemTypes[i]})\n");
                }
            }
            else if (Array.IndexOf(itemTypes, input) != -1)
            {
                for (int i = 0; i < numItems; i++)
                {
                    if (itemTypes[i] == input)
                    {
                        Console.WriteLine(itemNames[i]);
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("End");
                break;
            }
        }
    }
    }
}

