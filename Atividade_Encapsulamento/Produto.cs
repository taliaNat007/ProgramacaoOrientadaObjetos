    public class Produto
    {
        // questão 1: criação da classe
        public string cod_prod;
        public string nome;
        private string unidade;
        private double preco;
        public float quantidade;

        public void SetPreco(double preco)
        {
            if (preco > 0)
            {
                this.preco = preco;
            }
            else 
            {
                Console.WriteLine(" O preço do produto deve ser maior R$ 0,00");
            }
        }// FIM DO SET VERIFICAR PRECO

        public double GetPreco()
        { 
            return preco;
        }// FIM DO GET VERIFICAR PREÇO

        public void SetTipoUnidade(string unidade)
        {
            if (unidade == "LT")
            {
                this.unidade = unidade;
            }
            else 
            {
                if (unidade == "CX")
                {
                    this.unidade = unidade;
                }
                else
                {
                    if (unidade == "KG")
                    {
                        this.unidade = unidade;
                    }
                        else
                    {
                        if (unidade == "UN")
                        {
                            this.unidade = unidade;
                        }
                        else
                        {
                            if (unidade == "MT")
                            {
                                this.unidade = unidade;
                            }
                            else
                            {
                                Console.WriteLine(" Opção Inexistente!");
                            }
                        }
                    }
                }
            }
        }// FIM DO SET VERIFICAR TIPO DE UNIDADE

        public string GetTipoUnidade()
        {
            return unidade;
        }// FIM DO GET VERIFICAR TIPO DE UNIDADE
}

