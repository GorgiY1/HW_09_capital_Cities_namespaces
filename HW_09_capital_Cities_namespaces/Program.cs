using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_09_capital_Cities_namespaces
{
    //namespace random2
    //{
    //    public static Random w()
    //    {
    //        return new Random();
    //    }
        
    //}
    
    namespace Country
    {
        abstract class Capital
        {
            public virtual int population { get; set; }

            public override string ToString() 
            {
                return base.ToString();
            }
        }
    }

    namespace Ukraine
    {
        class Kiev : Country.Capital 
        {
            public override string ToString()
            {
                return $"Population the capital Kiev: {population}";
            }
        }
    }

    namespace Britain
    {
        class London : Country.Capital 
        {
            public override string ToString()
            {
                return $"Population the capital London: {population}";
            }
        }
    }

    namespace USA
    {
        class Washington : Country.Capital 
        {
            public override string ToString()
            {
                return $"Population the capital Washington: {population}";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Разработать приложение, в котором бы сравнивалось 
             * население трёх столиц из разных стран.
             * Причём страна бы обозначалась пространством имён, 
             * а город – классом в данном пространстве.
             */

            Random random = new Random();

            //Country.Capital[] a = new Country.Capital[5];
            //a[0] = new Ukraine.Kiev();

            Ukraine.Kiev populationKiev = new Ukraine.Kiev();
            Britain.London populationLondon = new Britain.London(); 
            USA.Washington populationWashington = new USA.Washington();

            populationKiev.population = random.Next(1000000, 3000000); // 3 010 000
            populationLondon.population = random.Next(1000000, 3000000);
            populationWashington.population = random.Next(1000000, 3000000);

            
            Console.WriteLine(populationKiev);
            Console.WriteLine(populationLondon);
            Console.WriteLine(populationWashington);

            int maxValue = populationLondon.population;
            int minValue = populationLondon.population;
            if (populationKiev.population < minValue)
            {
                minValue = populationKiev.population;
            }
            if (populationWashington.population < minValue)
            {
                minValue = populationWashington.population;
            }

            Console.WriteLine($"Min population: {minValue}");

            maxValue = populationLondon.population;

            if (populationKiev.population > maxValue)
            {
                maxValue = populationKiev.population;
            }
            if (populationWashington.population > maxValue)
            {
                maxValue = populationWashington.population;       
            }

            //if(minValue > populationWashington.population & maxValue > populationWashington.population)
            //{
            //    Console.WriteLine($"Middle population: {populationWashington.population}");
            //}
            //if (minValue > populationKiev.population & maxValue > populationKiev.population)
            //{
            //    Console.WriteLine($"Middle population: {populationWashington.population}");
            //}
            //if (minValue > populationLondon.population & maxValue > populationLondon.population)
            //{
            //    Console.WriteLine($"Middle population: {populationWashington.population}");
            //}

            Console.WriteLine($"Max population: {maxValue}");

            Console.ReadKey();
        }
    }
}
