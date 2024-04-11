using segundaRevisao;

Circulo circulo1 = new Circulo();

Console.WriteLine(" Digite o raio do seu circulo: ");
circulo1.raio = double.Parse(Console.ReadLine());

double area = circulo1.Area();

Console.WriteLine(" A área do circulo é: " + circulo1.Area());
