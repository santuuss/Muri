class PessoaFisica : Contrato
    {
        // A T R I B U T O S
        public int cpf { get; set; }
        public int idadeContratante { get; set; }

        // C O N S T R U T O R E S
        public PessoaFisica()
        {
        }
        public PessoaFisica(int numero, string contratante, double valor, double prazo, int cpf, int idadeContratante) : base(numero, contratante, valor, prazo)
        {
            this.cpf = cpf;
            this.idadeContratante = idadeContratante;
        }

        // M É T O D O S
        public override double calcularPrestacao()
        {
            if (idadeContratante <= 30)
            {
                return valor / prazo + 1;
            }
            else if (idadeContratante <= 40)
            {
                return valor / prazo + 2;
            }
            else if (idadeContratante <= 50)
            {
                return valor / prazo + 3;
            }
            else
            {
                return valor / prazo + 4;
            }
        }
        public override string exibirInfo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return $" Idade do contatante: {idadeContratante} - Valor Contrato: R${valor.ToString("F2")} - Prestação: R${calcularPrestacao().ToString("F2")}";
        }
    }
