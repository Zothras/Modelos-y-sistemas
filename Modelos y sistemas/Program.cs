int Dia1 = 1;
int Dia365 = 365;
int numero = 0;
int vueltas = 0;
double coincidencias = 0;


Random random = new Random();
void Prueba()
{
    List<int> numeros = new List<int>();
    for (int x = 0; x < 10000; x++)
    {
        numero = random.Next(Dia1, Dia365);
        numeros.Add(numero);
    }
    int antisumaputa = 0;
    for (int y = 0; y < numeros.Count; y++)
    {
        for (int z = y + 1; z < numeros.Count; z++)
        {
            if (numeros[z] == numeros[y] && antisumaputa != 1)
            {
                coincidencias++;
                antisumaputa = 1;
            }
        }
    }

}
do
{
    Prueba();
    vueltas++;
} while (vueltas<=300000);


Console.WriteLine(coincidencias);
Console.ReadKey();