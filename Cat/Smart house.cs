using System;

using System.Collections.Generic;

namespace Cat

{

    public class CatSmartHouse

    {

        List<Cat> cats = new List<Cat>();

        public CatSmartHouse(int foodResource)

        {

            FoodResource = foodResource;

        }

        public int FoodResource

        { get; set; }

        public void AddCat(Cat cat)

        {

            cats.Add(cat);

            cat.HungerStatusChenged += Cat_HungerStatusChenged;

        }

        private void Cat_HungerStatusChenged(object sender, EventArgs e)

        {

            var cat = (Cat)sender;

            if (cat.HungryStatus <= 20 && FoodResource > 0)

            {

                byte needFood = (byte)(100 - cat.HungryStatus);

                if (FoodResource > needFood)

                    FoodResource -= needFood;

                else

                {

                    needFood = (byte)FoodResource;

                    FoodResource = 0;

                }

                cat.Feed(needFood);

                Console.WriteLine($"Покормлена кошка: {cat.Name}\nОстаток еды в вольере: {FoodResource}");

            }

        }

    }

}
