class Solution
{
    /// <summary>
    /// 피자 나눠 먹기(3)
    /// </summary>
    /// <param name="slice"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution07232(int slice, int n)
    {
        int answer = (n % slice > 0) ? n / slice + 1 : n / slice;
        /*
        int answer = 0;
        // for 
        for (int i = 1; i <= n; i += slice)
        {
            // 피자 한판 더하기
            answer++;
        }
        */
        return answer;
    }

    /// <summary>
    /// 배열 자르기
    /// </summary>
    /// <param name="numbers"></param>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int[] Solution0723(int[] numbers, int num1, int num2)
    {
        // 리턴할 배열의 크기를 먼저 구한다
        int len = num2 - num1 + 1;
        // 구한 크기만큼 배열을 선언
        int[] answer = new int[len];
        // 크기만큼 반복
        for (int i = 0; i < len; i++)
        {
            // 인덱스에 해당하는 값을 배열에 넣는다
            answer[i] = numbers[num1 + i];
        }
        // 배열을 리턴
        return answer;
    }

    /// <summary>
    /// 삼각형의 완성조건(1)
    /// </summary>
    /// <param name="sides"></param>
    /// <returns></returns>
    public int Solution07222(int[] sides)
    {
        int answer = 0;
        // list를 이용한 정렬
        var list = new List<int>(sides);
        list.Sort();
        // 정렬
        //Array.Sort(sides);
        /*
        // 가장 큰 값과 나머지 값들의 합과 비교
        if (sides[2] < sides[0] + sides[1])
        {
            return 1;
        }
        else
        {
            return 2;
        }
        */
        answer = (list[2] < list[0] + list[1]) ? 1 : 2;
        //answer = (sides[2] < sides[0] + sides[1]) ? 1 : 2;
        return answer;
    }

    /// <summary>
    /// 머쓱이보다 키 큰 사람
    /// </summary>
    /// <param name="array"></param>
    /// <param name="height"></param>
    /// <returns></returns>
    public int Solution0722(int[] array, int height)
    {
        int answer = 0;
        foreach (var item in array)
        {
            if (item > height)
            {
                answer++;
            }
        }
        /*
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > height)
            {
                answer++;
            }
        }
        */
        return answer;
    }

    /// <summary>
    /// 자릿수 더하기
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution07212(int n)
    {
        int answer = 0;
        // n을 string으로 변환
        string str = n.ToString();
        // string을 처음부터 반복
        foreach (var item in str)
        {
            // answer에 각 char의 계산된 값을 더한다
            answer += (item - '0');
        }
        return answer;
    }

    /// <summary>
    /// 모음 제거
    /// </summary>
    /// <param name="my_string"></param>
    /// <returns></returns>
    public string Solution0721(string my_string)
    {
        // 도트연산자 이어서 사용하기 예
        //my_string.Replace("a", "").Remove(4).Substring(0, 2);
        // char의 공백문자는 '\0'
        //my_string.Replace('a','\0');
        return my_string.Replace("a", "")
            .Replace("e", "")
            .Replace("i", "")
            .Replace("o", "")
            .Replace("u", "");
        /*
        // for, if를 사용한 방법
        string answer = string.Empty;
        for (int i = 0; i < my_string.Length; i++)
        {
            if ((my_string[i] != 'a') &&
                (my_string[i] != 'e') &&
                (my_string[i] != 'i') &&
                (my_string[i] != 'o') &&
                (my_string[i] != 'u'))
            {
                // string연산이니까, stringBuilder를 쓰자
                answer += my_string[i];
            }
        }
        return answer;
        */
    }

    /// <summary>
    /// 최댓값 만들기(1)
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public int Solution0718(int[] numbers)
    {
        int answer = 0;
        // 중첩 for문을 이용한 방법
        /*
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                // if (i == j)
                // {
                //     continue;
                // }
                // 각각의 인덱스 값을 곱해서 나온 값과 현재 최대값을 비교
                // if (answer < numbers[i] * numbers[j])
                // {
                //     // 큰값을 최대값으로
                //     answer = numbers[i] * numbers[j];
                // }
                answer = Math.Max(answer, numbers[i] * numbers[j]);
            }
        }
        */
        // 정렬를 이용한 방법
        //Array.Sort(numbers);
        // 마지막 수와 마지막 전 수 를 곱한다
        //answer = numbers[numbers.Length - 1] * numbers[numbers.Length - 2];
        var list = new List<int>(numbers);
        list.Sort();
        answer = list[list.Count - 1] * list[list.Count - 2];
        return answer;
    }

    /// <summary>
    /// 세균 증식
    /// </summary>
    /// <param name="n"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public int Solution07172(int n, int t)
    {
        return n << t;
        /*
        int answer = 0;
        // Math
        answer = (int)(n * Math.Pow(2, t));
        // for
        for (int i = 0; i < t; i++)
        {
            n *= 2;
        }
        answer = n;
        return answer;
        */
    }

    /// <summary>
    /// 피자 나눠 먹기(1)
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution0717(int n)
    {
        int answer = 0;
        // 온전한 피자 한판으로 먹을 수 있는 사람 수
        int piz = n / 7;
        // 나머지 피자 조각 먹는 사람 수
        int res = ((n % 7) == 0) ? 0 : 1;
        /*
        if ((n % 7) == 0)
        {
            res = 0;
        }
        else
        {
            res = 1;
        }
        */
        answer = piz + res;
        return answer;
    }

    /// <summary>
    /// 뒤집힌 문자열
    /// </summary>
    /// <param name="my_string"></param>
    /// <returns></returns>
    public string Solution07162(string my_string)
    {
        //string answer = "ABC";
        var list = new List<char>(my_string);
        list.Reverse();
        string answer = new string(list.ToArray());
        /*
        var sb = new StringBuilder();
        foreach (var item in my_string)
        {
            sb.Insert(0, item);
        }
        string answer = sb.ToString();
        */
        /*
        int len = my_string.Length;
        //string answer = string.Empty;
        char[] answerArray = new char[len];

        // for / foreach 돌자
        for (int i = 0; i < len; i++)
        {
            // 위치를 주의해서 배열로 바꾼 answer에 넣자
            answerArray[len - 1 - i] = my_string[i];
        }
        // 캐릭터 배열을 스트링으로 바꿔서 리턴
        string answer = new string(answerArray);
        */
        return answer;
    }

    /// <summary>
    /// 편지
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public int Solution0716(string message)
    {
        int answer = 0;
        answer = message.Length * 2;
        return answer;
    }
    
    /// <summary>
    /// 특정 문자 제거하기
    /// </summary>
    /// <param name="my_string"></param>
    /// <param name="letter"></param>
    /// <returns></returns>
    public string Solution07152(string my_string, string letter)
    {
        string answer = string.Empty;
        answer = my_string.Replace(letter, string.Empty);
        // StringBuilder
        /*
        var sb = new StringBuilder();
        foreach (var item in my_string)
        {
            if (item.ToString().CompareTo(letter) != 0)
            {
                sb.Append(item);
            }
        }
        answer = sb.ToString();
        */
        // for / foreach
        /*
        foreach (var item in my_string)
        {
            if (item.ToString() != letter)
            {
                answer += item;
            }
        }
        */
        /*
        for (int i = 0; i < my_string.Length; i++)
        {
            // 현재 아이템 과 letter를 비교
            if (my_string[i].ToString() != letter)
            {
                // 다르면 answer에 추가
                answer += my_string[i];
            }
        }
        */
        return answer;
    }

    /// <summary>
    /// 짝수 홀수 개수
    /// </summary>
    /// <param name="num_list"></param>
    /// <returns></returns>
    public int[] Solution0715(int[] num_list)
    {
        //int[] answer = new int[2];
        var answer = new int[2] { 0, 0 };
        // for / foreach
        foreach (var item in num_list)
        {
            answer[item % 2]++;
            // if (item % 2 == 0)
            // {
            //     answer[0]++;
            // }
            // else
            // {
            //     answer[1]++;
            // }
        }
        /*
        for (int i = 0; i < num_list.Length; i++)
        {
            // 값이 짝수냐
            if (num_list[i] % 2 == 0)
            {
                // answer[0]를 1 증가
                answer[0]++;
            }
            else    // 아니냐(홀수냐)
            {
                // answer[1]를 1 증가
                answer[1]++;
            }
        }
        */
        return answer;
    }

    /// <summary>
    /// 배열 뒤집기
    /// </summary>
    /// <param name="num_list"></param>
    /// <returns></returns>
    public int[] Solution07142(int[] num_list)
    {
        int len = num_list.Length;
        int[] answer = new int[len];
        // for
        for (int i = 0; i < len; i++)
        {
            //answer[len - 1 - i] = num_list[i];
            answer[i] = num_list[len - 1 - i];
        }
        return answer;
    }

    /// <summary>
    /// 배열의 평균값
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public double Solution0714(int[] numbers)
    {
        double answer = 0;
        // foreach
        foreach (var item in numbers)
        {
            answer += item;
        }
        /*
        // for문을 사용해서 int[] 을 돌린다
        for (int i = 0; i < numbers.Length; i++)
        {
            // answer에 현재 배열값을 더한다
            answer += numbers[i];
        }
        */
        // 더해진 결과값을 int[]의 크기로 나눈다
        answer /= numbers.Length;
        return answer;
    }

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