// Util을 사용하기 위해 필요한 namespace의 사용선언
using Zinine;

internal class Program
{
    /// <summary>
    /// Main 함수
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        var intArray = new int[] { -1, 0, 30, 1, 4 };
        var strArr1 = new string[] { "ab", "b", "c" };
        var strArr2 = new string[] { "m", "dot" };
        Solution sol = new Solution();
        Console.WriteLine(sol.Solution0812("string", 3));
        //Util.PrintIntArray(sol.Solution08082("abcde0"));
        //sol.Solution0806();

        CSStudy study = new CSStudy();
        //study.ClassSample();
    }
}