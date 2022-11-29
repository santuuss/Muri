class PessoaJuridica : Contrato
    {
        // A T R I B U T O S
        public int cnpj { get; set; }
        public int inscricaoEstadual { get; set; }
        
        // C O N S T R U T O R E S
        public PessoaJuridica()
        {
        }

        public PessoaJuridica(int numero, string contratante, double valor, double prazo, int cnpj, int inscricaoEstadual) : base(numero, contratante, valor, prazo)
        {
            this.cnpj = cnpj;
            this.inscricaoEstadual = inscricaoEstadual;
        }

        // M É T O D O S
        public override double calcularPrestacao()
        {
            return valor / prazo + 3;
        }
        public override string exibirInfo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return $" Valor Contrato: R${valor.ToString("F2")} - Prestação: R${calcularPrestacao().ToString("F2")}";
        }
    }
