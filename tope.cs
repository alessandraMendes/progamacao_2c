 class Program
    {
        static void Main(string[] args)
        {
            Produtos produto1 = new Produtos();

            produto1.Descricao = "Macarrão";
            produto1.Valor = 2;
            produto1.Estoque = 20;

            //produto1.SetDescricao("Macarrão");
            //produto1.SetValor(2);
            //produto1.SetEstoque(20);

            Produtos produto2 = new Produtos();
            //produto2.SetDescricao("Maça");
            //produto2.SetValor(4.30);
            //produto2.SetEstoque(55700);

            Produtos produto3 = new Produtos();
            //produto3.SetDescricao("Arroz");
            //produto3.SetValor(2.30);
            //produto3.SetEstoque(78);

            produto3.Descricao = "Arroz";
            produto3.Valor = 2.30 ;
            produto3.Estoque = 78 ;

            //Console.WriteLine(produto1.GetDescricao());
            //Console.WriteLine(produto1.GetValor());
            //Console.WriteLine(produto1.GetEstoque());
            //Console.WriteLine(produto3.GetDescricao());
            //Console.WriteLine(produto3.GetValor());
            //Console.WriteLine(produto3.GetEstoque());

            Console.WriteLine(produto1.Descricao);
            Console.WriteLine(produto1.Valor);
            Console.WriteLine(produto1.Estoque);
            Console.WriteLine(produto3.Descricao);
            Console.WriteLine(produto3.Valor);
            Console.WriteLine(produto3.Estoque);


        }
    }





  class Produtos
    {
        private string descricao;
        private double valor;
        private double estoque;

        //public string GetDescricao()
        //{
        //    return descricao;
        //}
        //public double GetValor()
        //{
        //    return valor;
        //}
        //public double GetEstoque()
        //{
        //    return estoque;
        //}
        //public void SetDescricao(string descricao)
        //{
        //    this.descricao = descricao;
        //}
        //public void SetValor(double valor)
        //{
        //    this.valor = valor;
        //}
        //public void SetEstoque(double estoque)
        //{
        //    this.estoque = estoque;
        //}

        public string Descricao { get; set; }
        public double Valor { get; set; }
        public double Estoque { get; set; }
    }

