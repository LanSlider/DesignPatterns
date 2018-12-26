using Decorator_Example.Components;

namespace Decorator_Example.Decorators
{
    abstract class Decorator : Pen
    {
        private Pen _pen;

        public void SetPen(Pen pen)
        {
            this._pen = pen;
        }

        public override bool CheckPerformance()
        {
            if (_pen != null)
            {
                return _pen.CheckPerformance();
            }

            return false;
        }
    }
}
