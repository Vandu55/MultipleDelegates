using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDelegates
{

    public delegate void Cal(int A, int B);
    public delegate void Show_dele();
    public delegate void Display(int A);
    class Program
    {
        public static void Show() { 
          Console.WriteLine("This is shoew method");
        }
        public static void Dis( int num)
        {
            int square = num * num;
            Console.WriteLine("Square 0f {0} is {1}",num,square);
        }
        public static void Cube(int num)
        {
            int cube = num * num  *num;
            Console.WriteLine("Cube 0f {0} is {1}", num, cube);
        }


        static void Main(string[] args)
        {
            Show_dele obj = new Show_dele(Show);
            obj();

            Display obj3 = new Display(Dis);
            obj3(5);
            Display  obj4 = new Display(Cube);
            obj4(5);

            Console.ReadLine();
        }
    }
}
