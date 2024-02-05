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
    min = i;

    //  INTERCAMBIAR VALORES MEDIANTE POSICIONES
    for (int j = i+1; j < secuencial.Length; j++)
    {
        //  VALIDAR DATOS MENORES

        if (secuencial[j] < secuencial[min])
        {
            min = j;
        }
    }
    //  INTERCAMBIANDO VALORES
    aux = secuencial[i];
    secuencial[i] = secuencial[min];
    secuencial[min] = aux;

}


//  IMPRESION DE DATOS ORDENADOS
Console.WriteLine("\nDATOS ORDENADOS");
for (int i = 0; i < secuencial.Length; i++)
{
    Console.Write(secuencial[i]+" ");
}

timeMeasure.Stop();
Console.WriteLine($"\nTiempo de ejecucion: {timeMeasure.Elapsed.TotalMilliseconds} ms");