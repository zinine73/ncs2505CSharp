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
        var intArray = new int[] { 58,44,27,10,100 };
        var strArr1 = new string[] { "ab", "b", "c" };
        var strArr2 = new string[] { "m", "dot" };
        Solution sol = new Solution();
        Console.WriteLine(sol.Solution08202(intArray, 139));
        //Util.PrintArray(sol.Solution0819(intArray));
        //sol.Solution08122();

        CSStudy study = new CSStudy();
        //study.CompareRun();

        //Util.Sort(intArray, Util.DescendingCompare);
        //Util.PrintArray(intArray);
    }
}