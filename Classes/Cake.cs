using System;

namespace OOP_Lab_1
{
    public sealed class Cake : Dessert
    {
        public bool Raisins { get; set; }
        public Cake(Int32 delivery, bool extraFood, bool raisins) : base(delivery, extraFood)
        {
            this.Raisins = raisins;
            if (Raisins)
                this.Cost += 20;
        }       

        public override string WriteDescription()
        {
            return GetHierarchy() + base.WriteDescription() + "Your dessert " + 
                   ((Raisins) ? "with raisins.\n" : "without raisins.\n") +
                   $"That'll be {Cost} money, please.";
        }

        public override string GetHierarchy()
        {
            return base.GetHierarchy() + "-> Cakes.\n";
        }
    }
}
