List<string> lista1 = new List<string>();
//lista1.Add(Console.ReadLine());
lista1.Add("Anna"); //Adicionar elemento na lista
lista1.Add("Alex");
lista1.Add("Maria");

Console.WriteLine(lista1[2]);
//int tamanho = lista1.Count;
Console.WriteLine(lista1.Count);

foreach (string str in lista1)
{
    Console.WriteLine(str);
}

int[] n = new int[3];

Console.Write("Digite a 1º nota: ");
n[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite a 2º nota: ");
n[1] = Convert.ToInt32(Console.ReadLine());

n[2] = (n[0] + n[1]) / 2;
Console.WriteLine($"\nMédia = {n[2]}");
