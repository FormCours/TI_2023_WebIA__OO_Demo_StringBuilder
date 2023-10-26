
using System.Diagnostics;
using System.Text;
const int NB_OPERATION = 1_000_000;
const int NB_TEST = 10;

string ConcatString()
{
    string result = "Test";
    for (int i = 1; i < NB_OPERATION; i++)
    {
        result += " Test";
    }
    return result;
}

string ConcatStringBuilder()
{
    StringBuilder sb = new StringBuilder();
    sb.Append("Test");
    for (int i = 1; i < NB_OPERATION; i++)
    {
        sb.Append(" Test");
    }
    return sb.ToString();
}

Thread.Sleep(500);

Stopwatch s1 = new Stopwatch();
s1.Start();
for (int i = 0; i < NB_TEST; i++)
{
    ConcatString();
}
s1.Stop();

Stopwatch s2 = new Stopwatch();
s2.Start();
for (int i = 0; i < NB_TEST; i++)
{
    ConcatStringBuilder();
}
s2.Stop();

Console.WriteLine($"Nb concat : {NB_OPERATION}");
Console.WriteLine($"Concat string : {s1.ElapsedMilliseconds / NB_TEST}");
Console.WriteLine($"StringBuilder : {s2.ElapsedMilliseconds / NB_TEST}");