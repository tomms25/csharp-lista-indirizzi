﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//In questo esercizio dovrete leggere un file CSV, che cambia poco da quanto appena visto nel live-coding in classe, e salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati a partire dalla classe Indirizzo.
//Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” che possono accadere a questo genere di file: vi chiedo di pensarci e di gestire come meglio crediate queste casistiche.


var indirizzi = Analisi.Read();
foreach (var indirizzo in indirizzi)
{
    if (indirizzo == null)
    {
        Console.WriteLine("Dati non sufficienti");
        Console.WriteLine();
    }
    else
    {
        indirizzo.StampIndirizzo();
        Console.WriteLine();
    }
}

Analisi.Write(indirizzi);