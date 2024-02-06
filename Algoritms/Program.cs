using System.Diagnostics;

Stopwatch timeMeasure = new Stopwatch();

int[] secuencial = new int[] { 2, 4, 23, 8, 5, 9, 4, 6, 1 };

int aux, min;

Console.WriteLine("LISTA ORIGINAL");
for (int i = 0; i < secuencial.Length; i++)
{
    Console.Write(secuencial[i]+" ");
}

timeMeasure.Start();
for (int i = 0; i < secuencial.Length; i++)
{
	for (int j = 0; j < secuencial.Length-1; j++)
	{
		min = j + 1;
		if (secuencial[j] > secuencial[j+1])
		{
			aux = secuencial[j];
			secuencial[j] = secuencial[j+1];
			secuencial[j+1] = aux;
		}
	}
}

Console.WriteLine("\nLISTA ORDENDA");
for (int i = 0; i < secuencial.Length; i++)
{
	Console.Write(secuencial[i]+" ");
}

timeMeasure.Stop();
Console.WriteLine($"\nTiempo de depuracion: {timeMeasure.Elapsed.TotalMilliseconds} ms");