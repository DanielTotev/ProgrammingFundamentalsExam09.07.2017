using System;
using System.Linq;

namespace PokemonDon_tGo
{
    public class PokemonDontGo
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var allElementsSum = 0;
            while (numbers.Count > 0)
            {
                var elementToRemove = 0;
                var currentIndex = int.Parse(Console.ReadLine());
                if (currentIndex >= 0 && currentIndex < numbers.Count)
                {
                    elementToRemove  = numbers[currentIndex];
                    numbers.RemoveAt(currentIndex);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= elementToRemove)
                        {
                            numbers[i] += elementToRemove;
                        }
                        else
                        {
                            numbers[i] -= elementToRemove;
                        }
                    }
                }
                else if (currentIndex < 0)
                {
                    elementToRemove = numbers[0];
                    numbers[0] = numbers[numbers.Count - 1];
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= elementToRemove)
                        {
                            numbers[i] += elementToRemove;
                        }
                        else
                        {
                            numbers[i] -= elementToRemove;
                        }
                    }
                }
                else if (currentIndex >= numbers.Count)
                {
                    elementToRemove = numbers[numbers.Count - 1];
                    numbers[numbers.Count - 1] = numbers[0];
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= elementToRemove)
                        {
                            numbers[i] += elementToRemove;
                        }
                        else
                        {
                            numbers[i] -= elementToRemove;
                        }
                    }
                }
                allElementsSum += elementToRemove;
            }
            Console.WriteLine(allElementsSum);

        }
    }
}
