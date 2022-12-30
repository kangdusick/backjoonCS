namespace _1260
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader rd = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter wr = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int N, M, V;
            var inputs = rd.ReadLine().Split(' ');
            N = int.Parse(inputs[0]);
            M = int.Parse(inputs[1]);
            V = int.Parse(inputs[2]);
        }
    }
}