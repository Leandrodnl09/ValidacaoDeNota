// Exercício site URI "Validação de Nota"
// O usuário tera que digitar notas do aluno ate que seja no intervalo de 0,10, caso contrario mostrar mensagem "nota invalida"
// Contendo duas notas validas mostrar a média na tela.

double nota1 = double.Parse(Console.ReadLine());
while (nota1 < 0.0 || nota1 > 10.0)
{
    Console.WriteLine("nota invalida");
    nota1 = double.Parse(Console.ReadLine());
}

double nota2 = double.Parse(Console.ReadLine());
while (nota2 < 0.0 || nota2 > 10.0)
{
    Console.WriteLine("nota invalida");
    nota2 = double.Parse(Console.ReadLine());
}

double media = (nota1 + nota2) / 2.0;
Console.WriteLine("media = " + media.ToString("F2"));