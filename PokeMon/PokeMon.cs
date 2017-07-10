using System;

namespace PokeMon
{
    public class PokeMon
    {
        public static void Main()
        {
            var pokePower = int.Parse(Console.ReadLine());
            var pokePowerOriginalValue = pokePower;
            var distanceBetweenTargets = int.Parse(Console.ReadLine());
            var exhaustionFactor = int.Parse(Console.ReadLine());
            var targetsCount = 0;
            while (pokePower >= distanceBetweenTargets)
            {
                if (pokePower == (pokePowerOriginalValue * 0.5))
                {
                    if (exhaustionFactor != 0)
                    {
                        pokePower /= exhaustionFactor;
                        if (pokePower < distanceBetweenTargets)
                        {
                            break;
                        }
                    }
                }
                pokePower -= distanceBetweenTargets;
                targetsCount++;
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(targetsCount);
        }
    }
}
