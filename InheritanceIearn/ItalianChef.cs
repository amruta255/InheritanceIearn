using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceIearn
{
    public partial class Chef
    {
        public static string Type = "";
        public T Add<T>(T a, T b)
        {
            dynamic A = a;
            dynamic B = b;
            return A + B;
        }
        public static void Sample(string type)
        {
            Type = type;
            Console.WriteLine(Type);
        }
        

    }
    public class ItalianChef : Chef
    {
        public ItalianChef(string _name) : base(_name)
        {
           //( name == "" || name ==null)
            if (!string.IsNullOrEmpty(_name))
               _name =_name.ToUpper();
        }
        public int add(int a,int b)
        {
            return a + b;
        }
        public int add(int a, int b,int c)
        {
            return a + b+c;
        }
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes maggi");
        }

        public void MakePasta()
        {
            Console.WriteLine("The Chef Makes Pasta");
        }
    }
}
