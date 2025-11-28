// Util을 사용하기 위해 필요한 namespace의 사용선언
using Zinine;
using MyExtension;
using System.Drawing;
using System.Windows.Forms.VisualStyles; // 확장메서드용

internal class Program
{
    /// <summary>
    /// Main 함수
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        var intArr = new int[] {7,9};
        var intArr2 = new int[] {1,2,3,4,5,6,7,8,9};
        var int2Arr = new int[,] { {57,192,534,2},{9,345,192,999} };
        var strArr1 = new string[] { "s", "o", "m", "d" };
        var strArr2 = new string[] { "moos", "dzx", "smm", "sunmmo", "som"};
        var boolArr = new bool[] { true, false, true, false, false };
        Solution sol = new Solution();
        ///// 배열이 아닌 값을 리턴하는 경우 /////
        Console.WriteLine(sol.Solution11282(int2Arr));
        ///// 배열값을 리턴하는 경우(2차원 이상 안됨) /////
        //Util.PrintArray(sol.Solution11282(int2Arr));
        ///// 실행이 터미널창에서 이뤄지는 경우(Run without Debugging) /////
        //sol.Solution1126();

        CSStudy study = new CSStudy();
        //study.FormatTest();

        ///// 내림차순 정렬을 이용할 때 /////
        //Util.Sort(intArray, Util.DescendingCompare);
        //Util.PrintArray(intArray);
    }
}