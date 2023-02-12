//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int InputInt(string messag)
{
    Console.WriteLine(messag);
    return Convert.ToInt32(Console.ReadLine());

}
int[]GenerateArray(int len){

    int[] array =new int [len];
    Random rnd = new Random();
    for(int i =0; i< array.Length; i++){
        array[i] = rnd.Next(0, 10);
    }
    return array;
}

void PrintArray( int[] array){

    foreach( int item in array){
        Console.Write($"{item}\t");
    }
}

int sizeOfArray =InputInt("Введите размер массива: ");
int[] array = GenerateArray(sizeOfArray);
PrintArray(array);
