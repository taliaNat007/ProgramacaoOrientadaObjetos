List<Produto> listaproduto = new List<Produto>();

while (true)
{
    Console.WriteLine(@"    Qual opção deseja realizar
                         Digite 1 | Cadastrar
                         Digite 2 | Listar
                         Digite 3 | Excluir ");
    int opc = Convert.ToInt32(Console.ReadLine());
    
    Produto produto1 = new Produto();

    if (opc == 1 )
    {
        // Cadastrando Produto
        Console.WriteLine("Insira o código do produto: ");
        produto1.cod_prod = Console.ReadLine();

        Console.WriteLine("Insira o nome do produto: ");
        produto1.nome = Console.ReadLine();
        
        Console.WriteLine(@" Digite o tipo da unidade do produto
                                    LT | Litro
                                    CX | Caixa
                                    KG | Kilo grama
                                    UN | Unidade
                                    MT | Metros: ");
        string unidade = Console.ReadLine();
        produto1.SetTipoUnidade(unidade);
        
        Console.WriteLine("Insira o preço do produto: ");
        double preco = Convert.ToDouble(Console.ReadLine());
        produto1.SetPreco(preco);

        Console.WriteLine(" Insira a quantidade do produto: ");
        produto1.quantidade = Convert.ToInt32(Console.ReadLine());

        listaproduto.Add(produto1);
    }
    else if (opc == 2)
    {
        //Listando Produto
            foreach (Produto produto in listaproduto)
            {
                Console.WriteLine(" Código do produto: " + produto.cod_prod);
                Console.WriteLine(" Nome do produto: " + produto.nome);
                Console.WriteLine(" Unidade do produto: " + produto.GetTipoUnidade());
                Console.WriteLine(" Preco do produto R$ " + produto.GetPreco() + ",00");
                Console.WriteLine(" Quantidade do produto: " + produto.quantidade);
            }
    }
    else if (opc == 3)
    {
        Console.WriteLine(" Digite o Código do produto que deseja EXCLUIR");
        string codigo = Console.ReadLine();

        Produto prodExcluir = listaproduto.FirstOrDefault(p => p.cod_prod == codigo);
        listaproduto.Remove(prodExcluir);
    }
}


/*
Console.WriteLine("Insira o preço do produto");
double preco = Convert.ToDouble(Console.ReadLine());
produto1.SetPreco(preco);

Console.WriteLine(@" Digite o tipo da unidade do produto
                                    LT | Litro
                                    CX | Caixa
                                    KG | Kilo grama
                                    UN | Unidade
                                    MT | Metros");
string unidade = Console.ReadLine(); 
produto1.SetTipoUnidade(unidade);

Console.WriteLine($"O preço do produto é R$ {produto1.GetPreco()},00: ");
Console.WriteLine("A unidade do produto é: " + produto1.GetTipoUnidade());
*/