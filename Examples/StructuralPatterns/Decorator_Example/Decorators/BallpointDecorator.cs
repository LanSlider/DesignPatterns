using System;

namespace Decorator_Example.Decorators
{
    class BallpointDecorator : Decorator
    {


        public override bool CheckPerformance()
        {
            var result = base.CheckPerformance();
            Console.WriteLine("Result ballpoint pen is" + result);

            return result;
        }
    }
}
