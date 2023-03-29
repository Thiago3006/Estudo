using System;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two separate numbers where the first determines the row and the second the column: ");
            string[] s = Console.ReadLine().Split(' ');
            int m = int.Parse(s[0]);
            int n = int.Parse(s[1]);
            int[,] mat = new int[m,n];
            Console.WriteLine($"\nNow below, inform the set of {n} numbers separating by space and press enter, this process will be repeated {m} times:");

            for(int i =0; i < m; i++){
                string[] value = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++){
                    mat[i,j] = int.Parse(value[j]);
                }
            }

            Console.Write("\nEnter with value to verificate your values in around his: ");
            int u = int.Parse(Console.ReadLine());

            for(int i = 0; i < m; i++){
                for(int j = 0; j < n; j++){
                    if(mat[i,j] == u){
                        Console.WriteLine($"\nPosition: {i},{j}");
                        if(i > 0){
                            Console.WriteLine($"Up: {mat[i-1, j]}");
                        }
                        if(j < n -1){
                            Console.WriteLine($"Right: {mat[i, j+1]}");
                        }
                        if(i < m -1){
                            Console.WriteLine($"Down: {mat[i+1, j]}");
                        }
                        if(j > 0){
                            Console.WriteLine($"Left: {mat[i, j -1]}");
                        }

                    }
                }
            }




        }
    }
}
