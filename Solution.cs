class Solution
{
    /// <summary>
    /// 짝수의 합
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution07112(int n)
    {
        int answer = 0;
        // for문으로 n까지 돌자
        for (int i = 1; i <= n; i++)
        {
            // 짝수냐?
            if (i % 2 == 0)
            {
                // 짝수면 answer에 더하기
                answer += i;
            }
        }
        return answer;
    }

    /// <summary>
    /// 양꼬치
    /// </summary>
    /// <param name="n">몇인분</param>
    /// <param name="k">음료수</param>
    /// <returns>지불해야할 금액</returns>
    public int Solution0711(int n, int k)
    {
        int answer = 0;
        // 서비스로 받은 음료는 몇병인가
        int service = n / 10;
        // 전체 지불 금액 중 서비스 받은 음료수 빼기
        answer = n * 12000 + (k - service) * 2000;
        return answer;
    }

    /// <summary>
    /// 각도기
    /// </summary>
    /// <param name="angle"></param>
    /// <returns></returns>
    public int Solution07102(int angle)
    {
        int answer = 3;
        string str = "둔";
        Console.Write(angle + "도는 ");
        if (angle == 90)
        {
            str = "직";
            answer = 2;
        }
        else if (angle == 180)
        {
            str = "평";
            answer = 4;
        }
        else if ((0 < angle) && (angle < 90))
        {
            str = "예";
            answer = 1;
        }
        // else
        // {
        //     str = "둔";
        //     answer = 3;
        // }
        Console.WriteLine(str + "각입니다.");
        /*
        if ((0 < angle) && (angle < 90))
        {
            answer = 1;
        }
        else if (angle == 90)
        {
            answer = 2;
        }
        else if ((90 < angle) && (angle < 180))
        {
            answer = 3;
        }
        else //if (angle == 180)
        {
            answer = 4;
        }
        */
        return answer;
    }

    /// <summary>
    /// 두 수의 합 구하기
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution0710(int num1, int num2)
    {
        return num1 + num2;
    }

    /// <summary>
    /// 두 수의 나눗셈
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution07092(int num1, int num2)
    {
        int answer = 0;
        answer = 1000 * num1 / num2;
        /*
        float fanswer = (float)num1 / num2;
        fanswer *= 1000f;
        answer = (int)fanswer;
        */

        /*
        float fnum1 = (float)num1;
        float fnum2 = (float)num2;
        float fanswer = 0f;
        fanswer = fnum1 / fnum2;
        fanswer = fanswer * 1000f;
        answer = (int)fanswer;
        */
        return answer;
    }

    /// <summary>
    /// 나이 출력
    /// </summary>
    /// <param name="age"></param>
    /// <returns></returns>
    public int Solution0709(int age)
    {
        int answer = 0;
        answer = 2022 - age + 1;
        return answer;
    }

    /// <summary>
    /// 이게 보이게 됩니다
    /// </summary>
    /// <param name="num1">파라메터로 인티져</param>
    /// <param name="num2">integer</param>
    /// <returns> 리턴 값....어떻게 된다</returns>
    public int Solution07082(int num1, int num2)
    {
        int answer = -1;
        if (num1 == num2)
        {
            return 1;
        }
        return answer;
    }

    /// <summary>
    /// 몫 구하기
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution0708(int num1, int num2)
    {
        // int answer = 0;
        // answer = num1 / num2;
        // return answer;
        return num1 / num2;
    }

    /// <summary>
    /// 두 수의 곱 구하기
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution07072(int num1, int num2)
    {
        int answer = num1 * num2;
        return answer;
    }

    /// <summary>
    /// 빼기 연산
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution0707(int num1, int num2)
    {
        int answer = 0;
        answer = num1 - num2;
        return answer;
    }

    /// <summary>
    /// 나머지 구하기
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution0704(int num1, int num2)
    {
        int answer = 0;
        answer = num1 % num2;
        return answer;
    }
}