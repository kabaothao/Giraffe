using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Chef //this is the super class.
    {   
        //this chef have 3 methods. the chef can make chicken, salad, and bbq ribs. so this is a pretty cool amd simple class. 
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }

        public virtual void MakeSpecialDish()
            //virtual means this method can be overrideen in any subclasses. so when i say virtual, it basically
            //means that subclasses can change the functionality of this method. so i can just copy this method.
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }



    }
}
