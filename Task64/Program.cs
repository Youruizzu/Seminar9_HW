// Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа 
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8

Console.Clear();

List<int> GetEvenNumsBetweenTwoPoints(int pointOne, int pointTwo, List<int> list){
    if (pointOne == pointTwo) {
        if (pointOne % 2 == 0) list.Add(pointOne);
        return list;
    }
    if (pointOne % 2 == 0) {
        list.Add(pointOne);
        return GetEvenNumsBetweenTwoPoints(pointOne+1, pointTwo, list);
    }
    return GetEvenNumsBetweenTwoPoints(pointOne+1, pointTwo, list);
}

void PrintList(List<int> list){
    Console.Write("<");
    for (int i = 0; i < list.Count - 1; i++){
        Console.Write($"{list[i]}, ");
    }
    Console.Write($"{list[list.Count - 1]}");
    Console.Write(">");
    Console.WriteLine();
}

List<int> list = new List<int>();
PrintList(GetEvenNumsBetweenTwoPoints(1, 20, list));