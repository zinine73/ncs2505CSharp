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
        var intArr = new int[] {2,4,8};
        var intArr2 = new int[] {4,1,2};
        var int2Arr = new int[,] { {80,70},{70,80},{30,50},{90,100},{100,90},{100,100},{10,30} };
        var strArr1 = new string[] { "19 - 6 = 13", "5 + 66 = 71","5 - 15 = 63","3 - 1 = 2" };
        var strArr2 = new string[] { "moos", "dzx", "smm", "sunmmo", "som"};
        var str2Arr = new string[,] {{"jaja11","98761"},{"krong0313","29440"},{"rabbit00","111333"}};
        var boolArr = new bool[] { true, false, true, false, false, true };
        Solution sol = new Solution();
        ///// 배열이 아닌 값을 리턴하는 경우 /////
        //Console.WriteLine(sol.Solution1212(intArr));
        ///// 배열값을 리턴하는 경우(2차원 이상 안됨) /////
        Util.PrintArray(sol.Solution12122(5, 5));
        ///// 실행이 터미널창에서 이뤄지는 경우(Run without Debugging) /////
        //sol.Solution1210();

        CSStudy study = new CSStudy();
        //study.FormatTest();

        ///// 내림차순 정렬을 이용할 때 /////
        //Util.Sort(intArray, Util.DescendingCompare);
        //Util.PrintArray(intArray);
    }
}