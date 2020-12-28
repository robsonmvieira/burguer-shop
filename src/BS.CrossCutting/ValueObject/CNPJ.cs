namespace BS.CrossCutting.ValueObject
{
    public class CNPJ
    {
        public const int CNPJMaxNumber = 14;

        public int Value { get; private set; }

        protected CNPJ()
        {
            
        }
        public CNPJ(int value)
        {
            if (!isValidCNPJ(value)) throw new DomainException("CNPJ inválido");
            {
                
            }
            Value = value;
        }

        public bool isValidCNPJ(int value)
        {
            return true;
        }
    }
}