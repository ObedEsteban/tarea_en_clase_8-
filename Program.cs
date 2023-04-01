void matriz()
{
    string[] nombre = new string[]
    {
   "Anderson","Brandon","Yeimi","Fatima","Vivian"
    };

    foreach(string n in nombre)
    {
        Console.WriteLine("nombre=" + n);
    }

    int[] notas = new int[]
    {
        50,90,85,73,61
    };
    int promedio = 0;
    int maxNota = notas[0];
    string nombreMaxNota = nombre[0];
    foreach (int n in notas)
    {
        if (n > maxNota)
        {
            maxNota = n;
            nombreMaxNota = nombre[Array.IndexOf(notas, n)];
        }
        promedio += n;
    }

    promedio=promedio / notas.Length;
    Console.WriteLine("el promedio=" + promedio);
    Console.WriteLine("la nota maxima es = " + maxNota + " y la persona es " + nombreMaxNota) ;
    
}

matriz();
