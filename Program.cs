internal class Program
{
    private static void Main(string[] args)
    {
        // 이거...테스트
        //Solution0704(3, 2);
        Console.WriteLine(Solution07072(27, 19));
    }

    public static int Solution07072(int num1, int num2)
    {
        int answer = num1 * num2;
        return answer;
    }

    public static int Solution0707(int num1, int num2)
    {
        int answer = 0;
        answer = num1 - num2;
        return answer;
    }

    public static int Solution0704(int num1, int num2)
    {
        int answer = 0;
        answer = num1 % num2;
        return answer;
    }
}