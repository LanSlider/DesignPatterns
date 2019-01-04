namespace Proxy
{
    class Proxy : ISubject
    {
        private readonly Subject _subject;

        public Proxy(Subject subject)
        {
            _subject = subject;
        }

        public void SomeOperation()
        {
            _subject.SomeOperation();
        }
    }
}
