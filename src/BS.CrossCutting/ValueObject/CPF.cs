using System;

namespace BS.CrossCutting.ValueObject
{
    public class CPF
    {
        public string Value { get; private set; }

        public CPF()
        {
            
        }
        public CPF(string value)
        {
            if (!isValidCPF(value)) throw new DomainException("Cpf inválido");
            Value = formatedValue(value);
        }

        public bool isValidCPF(string cpf)
        {
            
            return true;
        }

        private string formatedValue(string cpf) => Convert.ToInt64(cpf).ToString(@"000\.000\.000\-00");
    }
}