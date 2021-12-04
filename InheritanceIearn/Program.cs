using System;

namespace InheritanceIearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef("amruta");
            chef.MakeSpecialDish();
            Chef.Sample();
            Chef.Type = "";
            //chef.
            ItalianChef italianchef = new ItalianChef("Ravi");
            italianchef.MakeSpecialDish();
            italianchef.MakeChicken();
            italianchef.add(2,3);
            italianchef.add(2, 3,2);
            Chef.KitchenName();
            Console.WriteLine(chef.Add<int>(2,4));

        }
    }
}
