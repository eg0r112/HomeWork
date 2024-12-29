namespace Home4;

class Program
{
    static void Main(string[] args)
    {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            int[] mergedArray = MergeArrays.Merge(array1, array2);
            Console.WriteLine("Merged Array: " + string.Join(", ", mergedArray));

            // Ротация массива
            int[] arrayToRotate = { 1, 2, 3, 4, 5 };
            int positions = 2;
            RotateArray.Rotate(arrayToRotate, positions);
            Console.WriteLine("Rotated Array: " + string.Join(", ", arrayToRotate));
    }
}
