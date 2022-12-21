using System.Text;

namespace _2559;
class Program
{
    static void Main(string[] args)
    {
        StreamReader rd = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter wr = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int K,sum=0,max;
        var read = rd.ReadLine().Split(' ');
        int[] turms = new int[int.Parse(read[0])];
        K = int.Parse(read[1]);
        read = rd.ReadLine().Split(' ');
        for(int i = 0; i<read.Length;i++)
        {
            turms[i] = int.Parse(read[i]);
            if(i<K)
            {
                sum += turms[i];
            }
        }
        max = sum;
        for(int i=K;i<turms.Length;i++)
        {
            sum -= turms[i - K];
            sum += turms[i];
            if(sum>max)
            {
                max = sum;
            }
        }
        wr.WriteLine(max.ToString());
        rd.Close();
        wr.Close();
    }
}

