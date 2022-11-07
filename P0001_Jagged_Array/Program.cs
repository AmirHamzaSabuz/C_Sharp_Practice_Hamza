internal class Program
{
    private static void Main(string[] args)
    {
        // Example 1
        int[][] arr1 = new int[5][];

        for (int i = 0; i < arr1.Length; i++)
        { 
            arr1[i] = new int[3];
        }

        // this code will print 0
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr1[i].Length; j++)
            {
                Console.Write(arr1[i][j] + " ");
            }
            Console.WriteLine();
        }

        // change values with -1
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr1[i].Length; j++)
            {              
                arr1[i][j] = -1;          
            }           
        }

        
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr1[i].Length; j++)
            {
               Console.Write(arr1[i][j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // Example 2. print 1 2 3 4 ... n

        // initialize with 1 2 3 4 ... n
        int k = 11;
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr1[i].Length; j++)
            {

                arr1[i][j] = k;
                k++;
            }
            
        }

        // print 1 2 3 4 ... n
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr1[i].Length; j++)
            {
                Console.Write(arr1[i][j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();



        //Example 3. print with index

        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr1[i].Length; j++)
            {
                Console.Write("[{0}][{1}] = {2}  ", i, j, arr1[i][j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // Example 4. another array. 

        int[][] arr2 = new int[3][];
        arr2[0] = new int[] { 10, 20, 30};
        arr2[1] = new int[] { 40, 50 };
        arr2[2] = new int[] { 40, 50, 60 };

        for (int i = 0; i < arr2.Length; i++)
        {
            for (int j = 0; j < arr2[i].Length; j++)
            {
                Console.Write(arr2[i][j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //Example 5. another array

        int[][] arr3 = new int[3][] {
            new int[] { 10, 20},
            new int[] {30, 40, 50 },
            new int [] {100 }
        };

        for (int i = 0; i < arr3.Length; i++)
        {
            for (int j = 0; j < arr3[i].Length; j++)
            {
                Console.Write(arr3[i][j] + " ");
                //Console.WriteLine("arr3[{0}][{1}] = {2} ", i, j, arr3[i][j]);
            }
            Console.WriteLine();
        }

        // Transpose

        int[][] Transpose(int[][] matrix)
        {
            var trans = GenerateArray(matrix[0].Length, matrix.Length, 0);

            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix[0].Length; j++)
                {
                    trans[j][i] = matrix[i][j];
                }
            }
            return trans;
        }
        static T[][] GenerateArray<T>(int row, int Col, T value)
        {
            var arr = new T[row][];

            for (int i = 0; i < row; i++)
            {
                arr[i] = new T[Col];
                for (int j = 0; j < Col; j++)
                {
                    arr[i][j] = value;
                }
            }
            return arr;
        }


        // use of the above transpose method 
        int[][] trans_of_arr1 = Transpose(arr1);

        for (int i = 0; i < trans_of_arr1.Length; i++)
        {
            for (int j = 0; j < trans_of_arr1[i].Length; j++)
            {
                Console.Write(trans_of_arr1[i][j] + " ");
            }
            Console.WriteLine();
        } 
    }


}