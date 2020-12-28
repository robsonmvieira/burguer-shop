namespace BS.CrossCutting.ValueObject
{
    public class Phone
    {
        public const int PhoneNumberSize = 8;
        public int Number { get; private set; }


        protected Phone()
        {
            
        }

        public Phone(int number)
        {
            if (isValidPhone(number)) throw new DomainException("Numero de telefone incorreto");
            Number = number;
        }

        public bool isValidPhone(int number)
        {
            return true;
        }

        public int alterNumber(int number)
        {
            if (isValidPhone(number)) throw new DomainException("Numero de telefone incorreto");
            return Number = number;
        }
        
    }
}