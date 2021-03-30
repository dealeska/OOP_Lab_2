using System;

namespace OOP_Lab_1
{
    public sealed class ColdDrink : Drink
    {
        public bool Ice { get; set; }

        public ColdDrink(Int32 capacity, bool extraFood, bool ice) : base(capacity, extraFood)
        {
            this.Ice = ice;
            if (Ice)
               this.Cost += 10;
        }

        public override string WriteDescription()
        {           
            return GetHierarchy() + base.WriteDescription() + "Your drink " + ((Ice) ? "with ice.\n" : "without ice.\n") +
                   $"That'll be {Cost} money, please.";
        }

        public override string GetHierarchy()
        {
            return base.GetHierarchy() + "-> ColdDrinks.\n";
        }
    }
}
