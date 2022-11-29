class Contrato
    {
        // A T R I B U T O S
        public int numero { get; set; }
        public string contratante { get; set; }
        public double valor { get; set; }
        public double prazo { get; set; }
        // C O N S T R U T O R E S
        public Contrato()
        {
        }
        public Contrato(int numero, string contratante, double valor, double prazo)
        {
            this.numero = numero;
            this.contratante = contratante;
            this.valor = valor;
            this.prazo = prazo;
        }

        // M É T O D O S
        public virtual double calcularPrestacao()
        {
            return valor / prazo;
        }
        public virtual string exibirInfo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return $" Valor Contrato: R${valor.ToString("F2")} - Prestação: R${calcularPrestacao().ToString("F2")}";
        }
    }
    
