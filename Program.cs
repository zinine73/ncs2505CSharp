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
        var intArr = new int[] {1,2,3,100,99,98};
        var intArr2 = new int[] {3,3,3,3,3};
        var int2Arr = new int[,] { {1,3}, {0,4} };
        var strArr1 = new string[] { "problemsolving","practiceguitar", "swim", "studygraph" };
        var strArr2 = new string[] { "", "dot" };
        var boolArr = new bool[] { true, false, true, false };
        Solution sol = new Solution();
        ///// 배열이 아닌 값을 리턴하는 경우 /////
        //Console.WriteLine(sol.Solution1001(intArr));
        ///// 배열값을 리턴하는 경우 /////
        Util.PrintArray(sol.Solution10022(strArr1, boolArr));
        ///// 실행이 터미널창에서 이뤄지는 경우 /////
        //sol.Solution09012();

        CSStudy study = new CSStudy();
        //study.FormatTest();

        ///// 내림차순 정렬을 이용할 때 /////
        //Util.Sort(intArray, Util.DescendingCompare);
        //Util.PrintArray(intArray);
    }
}