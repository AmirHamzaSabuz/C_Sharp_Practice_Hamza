internal class Program
{
    private static void Main(string[] args)
    {
        int[,] arr = new int[5, 5];
        int k = 11;
        int a = arr.GetLength(0);
        int b = arr.GetLength(1);

        Console.WriteLine("a = " + a + ", b =" + b);
        Console.WriteLine();

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = k;
                k++;
            }
        }

        // for printing horizontally
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {

                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // for printing vertically. // There is a problem. Row and column number changed.
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            for (int j = 0; j < arr.GetLength(0); j++)
            {

                Console.Write(arr[j, i] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        // for printing vertically
        // if rows and columns are not equal, this code will occur runtime exception. so I have to implement another trick.

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {

                Console.Write(arr[j, i] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();


        //Example Question and answer

        //Question. write 11 to 25 Horizontally in 5 rows and 3 columns
        /*
        Print
        11  12  13
        14  15  16
        17  18  19
        20  21  22
        23  24  25
        */

        int[,] horizontallyPrint = new int[5, 3];
        int hpValue = 11;

        for (int i = 0; i < horizontallyPrint.GetLength(0); i++)
        {
            for (int j = 0; j < horizontallyPrint.GetLength(1); j++)
            {
                horizontallyPrint[i, j] = hpValue;
                hpValue++;
            }
        }
        for (int i = 0; i < horizontallyPrint.GetLength(0); i++)
        {
            for (int j = 0; j < horizontallyPrint.GetLength(1); j++)
            {
                Console.Write(horizontallyPrint[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();




        //Question. write 11 to 25 vertically in 5 rows and 3 columns
        /*
        Print
        11  16  21
        12  17  22
        13  18  23
        14  19  24
        15  20  25
        */

        // My answer
        // This is the trick to print vertically without changing rows and column numbers (in output).

        int[,] verticallyPrint = new int[3, 5];
        int vpValue = 11;

        for (int i = 0; i < verticallyPrint.GetLength(0); i++)
        {
            for (int j = 0; j < verticallyPrint.GetLength(1); j++)
            {
                verticallyPrint[i, j] = vpValue;
                vpValue++;
            }
        }
        // transpose
        for (int i = 0; i < verticallyPrint.GetLength(1); i++)
        {
            for (int j = 0; j < verticallyPrint.GetLength(0); j++)
            {
                Console.Write(verticallyPrint[j, i] + " ");
            }
            Console.WriteLine();
        }
    }
}