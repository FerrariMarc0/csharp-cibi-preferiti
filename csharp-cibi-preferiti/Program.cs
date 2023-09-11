namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myFavouritesDishes = { "Bistecca", "Astice", "Pasta", "Patate, in tutte le salse", "Orata al forno", "Ostriche" };
            int totalDishes = myFavouritesDishes.Length;
            string bestDish = myFavouritesDishes[0];
            string worstDish = myFavouritesDishes[totalDishes - 1];
            string middleDish1 = myFavouritesDishes[totalDishes / 2];
            string middleDish2 = myFavouritesDishes[totalDishes / 2 - 1];

            
            Console.WriteLine($"I miei piatti preferiti sono {totalDishes} in totale, al primo posto metterei la {bestDish}, mentre all' ultimo le {worstDish}.");
            Console.WriteLine("Classifica:");

            for (int i = 0; i < totalDishes; i++)
            {
                Console.Write($"{i + 1}: ");
                Console.WriteLine(myFavouritesDishes[i]);
            }

            if (totalDishes % 2 != 0)
            {
                
                Console.WriteLine($"Il piatto mediano è la {middleDish1}");
            }
            else
            {
                
                Console.WriteLine($"I cibi che mediamente preferisco sono la {middleDish1} e la {middleDish2}");
            }
        }
    }
}