namespace BS.CrossCutting.ValueObject
{
    public class Password
    {
        public string Value { get; set; }


        protected Password()
        {
            
        }
        public Password(string value)
        {
            if (isValidPassword(value)) throw new DomainException("O Password está incorreto");
            Value = value;
        }
        public bool isValidPassword(string value)
        {
            if (value == null)
            {
                return false;
            }
            return true;
        }
    }
}