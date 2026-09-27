using System;
using System.Threading;

int numero = 0;

while (numero <= 10)
{
    Console.Write(numero + " ");
    Thread.Sleep(1000);
    numero++;
}