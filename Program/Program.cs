// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*#if DEBUG    // è utile nel LOGGING
Console.WriteLine("Siamo in debug e quindi ti do anche le info interne");
#endif
*/

/* Scrivi un programma in cui se sono in DEBUG faccio un ciclo for da 1 a 10 e stampo ogni volta il valore dell'indice del ciclo.
 * Se invece sono in RELEASE faccio il ciclo FOR da 1 a 20 e stampo il valore dell'indice del ciclo */

// Mia soluzione
//#if DEBUG
//    for(int i = 1; i < 11; i++)
//        Console.WriteLine(i);
//#endif

//#if RELEASE
//    for (int i = 1; i < 21; i++)
//        Console.WriteLine(i);
//#endif

// Soluzione Prof
#if DEBUG
    int i = 10;
#endif

#if RELEASE
    int i = 20;
#endif
for (int j = 1; j <= i; j++)
{
    Console.WriteLine(j.ToString());
}
