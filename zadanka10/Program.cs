// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Podaj liczbe n");
//
// int n = int.Parse(Console.ReadLine());
// int suma = 0;
//
// for (int i = 0; i <= n; i++)
// {
//     Console.WriteLine(suma);
//     suma += i;
// }
// Console.WriteLine(suma);


// for (int i = 0; i <= 10; i++)
// {
//     for (int j = 0; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
// }
//
// for (int i = 1; i <= 50; i++)
// {
//     if (i % 2 == 1)
//     {
//         Console.WriteLine($"Liczba {i} jest nieparzysta");
//     }
//     else
//     {
//         Console.WriteLine($"Liczba {i} jest parzysta");
//     }
//    
// }

//
// Console.WriteLine("Podaj liczbe od ktorej obliczymy jej silnie");
// int number = int.Parse(Console.ReadLine());
//
// int sum = 1;
// int counter = 1;
//
// do
// {
//
//     if (number == 0)
//     {
//         Console.WriteLine("Silnia to 1");
//     }
//     else
//     {
//         sum = sum * counter;
//         counter++;
//
//     }
//     
// } while (counter<=number); 
//
// Console.WriteLine($"Silnia to {sum}");
//
//

//
//
// Console.WriteLine("Podaj liczbe do odwrocienia");
// int liczba = int.Parse(Console.ReadLine());
// int odwrocona = 0;
//
// while (liczba > 0)
// {
//     int cyfra = liczba % 10;
//     odwrocona = odwrocona * 10 + cyfra;
//     liczba /= 10;
// }
// Console.WriteLine($"Odwr: {odwrocona}");


// Console.WriteLine("Podaj szerokosc");
// int szerokosc = int.Parse(Console.ReadLine());
//
// Console.WriteLine("Podaj wysokosc");
// int wysokosc = int.Parse(Console.ReadLine());
//
// for (int i = 0; i <= wysokosc; i++)
// {
//     for (int j = 0; j <= szerokosc; j++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();

// }


//
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine("Liczby pierwsze: ");
//
//
// bool czyPierwsza = false;
// for(int i = 2; i<=n; i++){
//     if(czyPierwsza == true) {
//         Console.WriteLine(i-1);
//     }
//     for(int j = 2; j<=n; j++) {
//         if(i%j!=0 || i==j) {
//             czyPierwsza = true;
//         }else {
//             czyPierwsza = false;
//             break;
//         }
//
//     }
// }
//



//
// Console.WriteLine("Podaj n");
// int n = int.Parse(Console.ReadLine());
// int fib = 0;
// int fib1 = 1;
// if (n == 1)
// {
//     Console.WriteLine('0');
// }
// else if (n == 2)
// {
//     Console.WriteLine(1);
//
// } 
// else 
// {
//     for (int i = 2; i < n; i++)
//     {
//         int next = fib + fib1;
//         Console.WriteLine(next);
//         fib = fib1;
//         fib1 = next;
//     }
//
// }
//
//
// Random rand = new Random();
// int wylosowana = rand.Next(1, 101);
// Console.WriteLine($"Hint:: {wylosowana}");
// int liczba = 0;
// do{
//     Console.WriteLine("Zgadnij liczbe w zakresie 0-100");
//     int.Parse(Console.ReadLine());
//     if(liczba == wylosowana) {
//         Console.WriteLine("OK");
//         return;
//     } else if(liczba > wylosowana){
//         Console.WriteLine("podales za duzo");
//     } else if (liczba < wylosowana)
//     {
//         Console.WriteLine("podales za malo");
//     }
// } while ( liczba == wylosowana );
//
//
Console.Write("Podaj wysokość piramidy: ");
int n = int.Parse(Console.ReadLine());

        
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n - i; j++)
    {
        Console.Write(" ");
    }

    for (int k = 1; k <= (2 * i - 1); k++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}

