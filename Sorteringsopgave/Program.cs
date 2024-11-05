
using Sorteringsopgave;
using System.Diagnostics;

// Start tidsmåling med Stopwatch
Stopwatch stopwatch = new Stopwatch(); 
stopwatch.Start();

// Kald din sorteringsalgoritme her ..... 
int[] tytyry = FileReader.ReadNumbersFromFile("C:\\Users\\sarai\\Downloads\\100.txt");
foreach (int t in tytyry)
{
    Console.WriteLine(t);
}

Console.WriteLine("____________________________");

int[] sortedtytyry = Bubblesorty.BubbleSort(tytyry);
foreach (int t in sortedtytyry)
{
    Console.WriteLine(t);
}

// Stop tidsmåling
stopwatch.Stop(); 

// Udskriv tiden, det tog at sortere arrayet
Console.WriteLine($"Tid til at sortere: {stopwatch.Elapsed.TotalMilliseconds} ms");
