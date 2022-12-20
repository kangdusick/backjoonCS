using System.Collections;
using System.Collections.Concurrent;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StreamReader rd = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter wr = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        Stack<int> stack = new Stack<int>();
        int n;
        int iter = 0;
        n = int.Parse(rd.ReadLine());
        int[] A = new int[n];
        var sol = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            A[i] = int.Parse(rd.ReadLine());
        }
        int num = 1;
        while (num <= n)
        {
            stack.Push(num);
            num++;
            sol.Append("+\n");
            while (stack.Count != 0 && stack.Peek() == A[iter])
            {
                stack.Pop();
                iter++;
                sol.Append("-\n");
            }
        }
        if (stack.Count > 0)
        {
            wr.WriteLine("NO");
        }
        else
        {
            wr.WriteLine(sol.ToString());
        }
        rd.Close();
        wr.Close();
    }
}

