// Задайте значения M и N. Напишите программу, 
// которая найдёт наибольший общий делитель (НОД) 
// этих чисел с помощью рекурсии.
// M = 28; N = 7 -> 7

int FindGreatestCommonDiviser(int m, int n){
    if (n == 0){
        return m;
    }
    else return FindGreatestCommonDiviser(n, m % n);
}

Console.WriteLine(FindGreatestCommonDiviser(153, 318));