// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Clear();

int GetNumSummBetweenTwoPoints(int pointOne, int pointTwo){
    if (pointOne == pointTwo) {
        return pointOne;
    }
    else{
        return pointOne + GetNumSummBetweenTwoPoints(pointOne+1, pointTwo);
    }
}


Console.WriteLine(GetNumSummBetweenTwoPoints(4, 8));
