// Напишите программу, которая выводит монотонную последовательность 
// из N элементов в виде равностороннего треугольника с помощью рекурсии
// N = 5 -> https://ibb.co/9nZgLtY

Console.Clear();

// spaceConst = layers+1 или spaceConst > layers
void DrawTriangle(int layers, int spaceConst){
    if (spaceConst < layers){
        Console.WriteLine("spaceConst должен быть больше, чем layers или равен ему!");
        throw new ArgumentException();
    }
    if(layers == 0){
        Console.WriteLine();
    }
    else{
        DrawTriangle(layers-1, spaceConst);
        if (layers%2 == 0){
            for (int spaces = 0; spaces < spaceConst-layers; spaces++){
                Console.Write(" ");
            }
        }
        if (layers%2 != 0){
            for (int spaces = 0; spaces < spaceConst-layers; spaces++){
                Console.Write(" ");
            }
        }
        for (int i=layers; i > 0; i--){
            Console.Write(layers+" ");
        }
        Console.WriteLine();
    }
}

DrawTriangle(9, 9);