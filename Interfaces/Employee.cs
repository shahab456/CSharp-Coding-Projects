using System;

namespace Interfaces
{
    class Employee : Person, IQuittable
    {

       public void Quit() {
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
