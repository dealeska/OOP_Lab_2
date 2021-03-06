using System;

namespace OOP_Lab_1
{
    public sealed class FastFood : MenuItem
    {
        public bool Gloves { get; set; }
        public bool Napkin { get; set; }

        public FastFood(Int32 gloves, bool extraFood, bool napkin)
        {
            this.Gloves = !Convert.ToBoolean(gloves);
            if (Gloves)
                this.Cost = 300 + 50;
            else
                this.Cost = 300;

            this.Napkin = napkin;
            if (Napkin)
                this.Cost += 10;
            this.ExtraFood = extraFood;
        }      

        public override string WriteDescription()
        {
            return GetHierarchy() + $"You choose a fastfood " + ((Gloves) ? "eating with gloves" : "eating without gloves") +
                   " and " + ((Napkin) ? "with napkin" : "without napkin") + 
                   " " + ((ExtraFood) ? "take it away.\n" : "take it here.\n") +
                   $"That'll be {Cost} money, please.";
        }

        public override string GetHierarchy()
        {
            return base.GetHierarchy() + "Menu -> FastFood.\n";
        }
    }
}
