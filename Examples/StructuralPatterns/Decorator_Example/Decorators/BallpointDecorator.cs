﻿using System;

namespace Decorator_Example.Decorators
{
    class BallpointDecorator : Decorator
    {


        public bool CheckPerformance()
        {
            var result = base.CheckPerformance();
            Console.WriteLine("Result ballpoint pen is" + result);

            return result;
        }
    }
}
