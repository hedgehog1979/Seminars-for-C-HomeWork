


// int[] array = new int[12];
// // Random rand = new Random();
// // for(int i = 0; i < array.Length; i++)
// // {
//     // array[i] = rand.Next(-9,10);
// // }

// for(int i = 0; i < array.Length; i++) 
// {
//     array[i] = new Random().Next(-9,10);
// }
// Console.Write('[' + string.Join(" ", array) + ']');
// int sumPos = 0;
// int sumNeg = 0;
// for(int i = 0; i < array.Length; i++)
// {
//     if (array[i]>0)
//     {
//         sumPos+=array[i];
//     }
//     else{
//         sumNeg+=array[i];
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"Pos sum = {sumPos}, а отрицательных - {sumNeg}");

int[] FillArray(int size, int LeftRange, int RightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i]= rand.Next(LeftRange, RightRange + 1);
    }
    return arr;
}
void sumPosAndNeg(int[] arr, out int SumPos, out int SumNeg)
{
    SumPos = 0;
    SumNeg = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0)
        {
            SumPos+=arr[i];
        }
        else
        {
            SumNeg+=arr[i];
        }
    }
}
int[] array = FillArray(5, -9, 9);
sumPosAndNeg(array, out int sumP, out int sumN);
Console.Write('[' + string.Join(" ", array) + ']');
Console.WriteLine($"Pos sum = {sumP}, а отрицательных - {sumN}");


