using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

        int length = a.GetLength(0);

        var str = new StringBuilder();

        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                str.Append(a[i,j]);
            }
        }

        int[] ints = new int[length * length];

        for (int i = 0; i < str.Length; i++)
        {
            if(int.TryParse(str[i].ToString(), out int value))
            {
                ints[i] = value;
            }
        }

        Array.Sort(ints);

        int counter = 0;

        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                a[i, j] = ints[counter];
                counter++;
                Console.Write($"{a[i,j]} ");
            }
            Console.WriteLine();
        }
    }

}