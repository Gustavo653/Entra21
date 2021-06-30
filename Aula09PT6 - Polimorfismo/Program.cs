using System;
using System.Collections.Generic;

namespace Aula09PT6___Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
            {
               new Rectangle(),
               new Triangle(),
               new Circle()
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
