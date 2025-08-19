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
        var intArray = new int[] { 9,10,11,8 };
        var strArr1 = new string[] { "ab", "b", "c" };
        var strArr2 = new string[] { "m", "dot" };
        Solution sol = new Solution();
        //Console.WriteLine(sol.Solution08182(24));
        Util.PrintArray(sol.Solution0819(intArray));
        //sol.Solution08122();

        CSStudy study = new CSStudy();
        //study.DeleTest();
    }
}