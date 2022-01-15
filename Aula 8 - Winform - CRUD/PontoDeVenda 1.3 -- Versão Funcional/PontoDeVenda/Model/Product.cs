namespace PontoDeVenda.Model
{
    class Product
    {
        public string _description;
        public int _quant;
        public float _value;
        /*
        public Product(string description, int quant, float value)
        {
            Description = description;
            Quant = quant;
            Value = value;
        }

        public string Description
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Descricao nao pode ser nulo ou vazio!!");
                _description = value;
            }
            get
            {
                return _description;
            }
        }
        public string Quant
        {
            set
            {
                if (int.MinValue(0))
                    throw new Exception("Quantidade nao pode ser vazio!!");
                _quant = value;
            }
            get
            {
                return _quant;
            }
        }

        public string Quant
        {
            set
            {
                if ((float.IsNegative(value)))
                    throw new Exception("Valor Invalido!!");
                _value = value;
            }
            get
            {
                return _value;
            }
        }

        */
    }
}
