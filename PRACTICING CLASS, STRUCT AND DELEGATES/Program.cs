using System;
using System.Runtime;

namespace Practicing
{
    class Practicing
    {
        static void Main(string[] args)
        {
            #region USING A CLASS
            
            var person = new PracticingClass("JIR0 LAURENZ", "AGAD")
            {
                NickName = "RORO",
                BirthDate = new DateTime(2003, 12, 28)
            };

            person.NickNameHandler += NickNameChanging;
            person.Update("RURU");

            Console.WriteLine($"{person.FullName} = {person.NickName} = {person.GetAge()} YEARS OF AGE");
            
            #endregion

            #region USING A STRUCT
            /*
            var mango = new Fruit() { Name = "MANGO", Color = "YELLOW" };
            var banana = new Fruit() { Name = "BANANA", Color = "YELLOW" };

            Console.WriteLine(mango.Name);
            */
            #endregion

            #region USING A DELEGATE
            /*
            var person = new PracticingClass("TIFFANY", "KATE")
            {
                NickName = "ANNIE"
            };
            var kate = person;
            //7
            kate.FavoriteFruits.Add(new Fruit("BANANA", "YELLOW"));

            kate.AddFavoriteFruit(new Fruit("MANGO", "YELLOW"), AddedNewFruit);
            kate.DeleteFavoriteFruit(kate.FavoriteFruits[0], (prutas) =>
            {
                Console.WriteLine($"DELETED FRUIT: {prutas.Name}");
                return 1;
            });

            Console.WriteLine($"{kate.FullName}");
            foreach (var pagkain in kate.FavoriteFruits)
                Console.WriteLine($"{pagkain.Name}");
            */
            #endregion
        }

        #region ADDING NEW FRUITS
        //6
        private static int AddedNewFruit(Fruit prutas)
        {
            Console.WriteLine($"ADDED FRUIT: {prutas.Name}");
            return 1;
        }

        #endregion

        #region EVENT CLASS (NICKNAME CHANGING)
        //4
        private static void NickNameChanging(object sender, NickNameArgs args)
        {
            Console.WriteLine($"NICKNAME IS CHANGING TO: {args.NickName}");
        }

        #endregion
    }
}