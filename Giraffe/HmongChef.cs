using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class HmongChef : Chef  //this is the subclass that is always going to be inheriting functionality from the superclass.
    {
        //let's say that this Hmong chef can do everything that the normal and Italian chef could do. 
        //So in inheriting all of the function and attributes from chef.cs 
        //now the Hmong chef can do everything the chef and Italian Checan do.
        //because i inherited all of the functionality from the chef class, i'm actually still able to make chicken with the Italian Chef.

        public override void MakeSpecialDish() //telling c# to override makespecialdish from the superclass.

        //virtual means this method can be overrideen in any subclasses. so when i say virtual, it basically
        //means that subclasses can change the functionality of this method. so i can just copy this method.
        {
            Console.WriteLine("The Chef makes pho");
        }


        public void MakePasta()
        {
            Console.Write("The Chef can make eggrolls!");
        }


    }
}
