using Zinine;

internal class Program
{
    /// <summary>
    /// Main 함수
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        var intArray = new int[] { 2, 100, 120, 600, 12, 12 };
        var strArr1 = new string[] { "ab","b","c" };
        var strArr2 = new string[] { "m", "dot" };
        Solution sol = new Solution();
        Console.WriteLine(sol.Solution07302(976));
        //Util.PrintIntArray(sol.Solution07282(strArr1));

        CSStudy stduy = new CSStudy();
        //stduy.ArrayExample();
    }
}