DateOnly data = DateOnly.FromDateTime(DateTime.Now);
Voo voo = new Voo(100, data, 1);

/*for (int i = 0; i < voo.qtdVagas; i++)
{
    Console.WriteLine(voo.vagas[i]);
}*/


Console.WriteLine(voo.Verificar(8));
voo.Ocupa(8);
Console.WriteLine(voo.Verificar(8));
voo.PoltronasLivre(100);
