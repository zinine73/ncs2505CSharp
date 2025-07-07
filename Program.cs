internal class Program
{
    private static void Main(string[] args)
    {
        // 이거...테스트
        //Solution0704(3, 2);
        Console.WriteLine(Solution0707(3, 2));
    }

    public static int Solution0707(int num1, int num2)
    {
        return 0;
    }

    public static int Solution0704(int num1, int num2)
    {
        int answer = 0;
        answer = num1 % num2;
        return answer;
    }
}