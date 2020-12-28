namespace BS.CrossCutting.ValueObject
{
    public class Email
    {
        public string Value { get; set; }

        protected Email()
        {
            
        }
        public Email(string email)
        {
            if (!isValidEmail(email)) throw new DomainException("Email inválido");
            Value = email;
        }

        private bool isValidEmail(string email)
        {
            return false;
        }
    }
}