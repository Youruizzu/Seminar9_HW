// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int FindAckermann(int n, int m){
    if (n == 0){
        return m + 1;
    }
    if (n >= 1 && m == 0){
        return FindAckermann(n-1, 1);
    }
    else {
        return FindAckermann(n-1, FindAckermann(n, m-1));
    }
}

Console.WriteLine(FindAckermann(3, 2));