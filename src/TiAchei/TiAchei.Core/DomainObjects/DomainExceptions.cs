namespace TiAchei.Core.DomainObjects
{
    public class DomainExceptions : Exception
    {
        public DomainExceptions() { }
        public DomainExceptions(string message) : base(message){}

        public DomainExceptions(string message, Exception exception) : base(message, exception) { }
    }
}
