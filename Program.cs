// Util을 사용하기 위해 필요한 namespace의 사용선언
using Zinine;
using MyExtension; // 확장메서드용

internal class Program
{
    /// <summary>
    /// Main 함수
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        var intArr = new int[] { 5, 2, 1, 7, 5 };
        var int2Arr = new int[,] { { 0, 4 }, { 1, 2 }, { 3, 5 }, { 7, 7 } };
        var strArr1 = new string[] { "progressive", "hamburger", "hammer", "ahocorasick" };
        var strArr2 = new string[] { "m", "dot" };
        Solution sol = new Solution();
        ///// 배열이 아닌 값을 리턴하는 경우 /////
        //Console.WriteLine(sol.Solution08292(2, 6, 1));
        ///// 배열값을 리턴하는 경우 /////
        //Util.PrintArray(sol.Solution0829(intArr));
        ///// 실행이 터미널창에서 이뤄지는 경우 /////
        sol.Solution09012();

        CSStudy study = new CSStudy();
        //study.ExtensionTest();

        ///// 내림차순 정렬을 이용할 때 /////
        //Util.Sort(intArray, Util.DescendingCompare);
        //Util.PrintArray(intArray);
    }
}