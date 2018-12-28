using System;

namespace Decorator_Example.Decorators
{
    class GelPenDecorator : Decorator
    {
        public bool CheckPerformance()
        {
            var result = base.CheckPerformance();
            Console.WriteLine("Result gel pen is" + result);

            return result;
        }
    }
}
