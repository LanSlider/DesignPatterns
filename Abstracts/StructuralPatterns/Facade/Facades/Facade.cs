namespace Facade.Facades
{
    class Facade
    {
        private readonly SubsystemA _subsystemA;
        private readonly SubsystemB _subsystemB;
        private readonly SubsystemC _subsystemC;

        public Facade(SubsystemA subsystemA, SubsystemB subsystemB, SubsystemC subsystemC)
        {
            _subsystemA = subsystemA;
            _subsystemB = subsystemB;
            _subsystemC = subsystemC;
        }

        public void FacadeOperation1()
        {
            _subsystemA.Operation1();
            _subsystemC.Operation3();
        }

        public void FacadeOperation2()
        {
            _subsystemB.Operation2();
            _subsystemC.Operation3();
        }
    }
}
