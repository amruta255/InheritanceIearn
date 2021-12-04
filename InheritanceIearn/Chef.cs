using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceIearn
{
   
    public partial class Chef
    {
        public string name;

       
        public Chef (string _name)
        {
            name = _name;
            this.UpdateFirst();
        }
        public static string KitchenName()
        {
            return "Amruta";
        }
        public void MakeChicken()
        {
            Console.WriteLine("The Chef "+name+" Makes Chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef Makes Salad");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef Makes bbq");
        }

    }
}
