using System;

namespace Lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x, y, z;
            x = true;
            y = true;
            z = true;
            if(f(x,y,z)==true)
            {
                Console.WriteLine("x={0}, y={1}, z={2}, f(x,y,z)={3}", x, y, z, f(x, y, z));
                Console.Read();
                return;

            }
            x = false;
            y = true;
            z = true;
            if(f(x,y,z)==true)
            {
                Console.WriteLine("x={0}, y={1}, z={2}, f(x,y,z)={3}", x, y, z, f(x, y, z));
                Console.ReadLine();
                return;
            }
            x = true;
            y = false;
            z = true;
            if (f(x, y, z) == true) 
            {
                Console.WriteLine("x={0}, y={1}, z={2}, f(x,y,z)={3}", x, y, z, f(x, y, z));
                Console.ReadLine();
                return;
            }
            x = true;
            y = true;
            z = false;
            if (f(x, y, z) == true) 
            {
                Console.WriteLine("x={0}, y={1}, z={2}, f(x,y,z)={3}", x, y, z, f(x, y, z));
                Console.ReadLine();
                return;
            }
            x = true;
            y = false;
            z = false;
            if (f(x, y, z) == true) 
            {
                Console.WriteLine("x={0}, y={1}, z={2}, f(x,y,z)={3}", x, y, z, f(x, y, z));
                Console.ReadLine();
                return;
            }
            x = false;
            y = false;
            z = true;
            if (f(x, y, z) == true) 
            {
                Console.WriteLine("x={0}, y={1}, z={2}, f(x,y,z)={3}", x, y, z, f(x, y, z));
                Console.ReadLine();
                return;
            }
            x = false;
            y = true;
            z = true;
            if (f(x, y, z) == true) 
            {
                Console.WriteLine("x={0}, y={1}, z={2}, f(x,y,z)={3}", x, y, z, f(x, y, z));
                Console.ReadLine();
                return;
            }

            Console.WriteLine("f(x,y,z)=true, such values of x,y,z not found");
            Console.ReadLine();
        }

        static bool f(bool x, bool y, bool z)
        {
            return !y && x && z && !z;
        }
    }
}
//16) f(x, y, z) = !y&x&z&!z = true