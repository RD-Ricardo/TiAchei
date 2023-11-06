namespace TiAchei.Core.DomainObjects.ValueObjects
{
    public class Email
    {
        public string Value { get; set; }
        public Email(string value)
        {
            Value = value;
        }
    }
}
