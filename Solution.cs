using System.Text;

class Solution
{
    /// <summary>
    /// 최댓값 만들기 (2)
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public int Solution08112(int[] numbers)
    {
        // 가장 작은 값으로 answer 설정
        //int answer = -10000 * 10000;
        int answer = int.MinValue;
        // for문을 중첩으로 돌린다
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                // 각각의 인덱스 값을 곱해서 나온 값과, 현재 최대값 비교
                //int max = numbers[i] * numbers[j];
                // if (answer < max)
                // {
                //     // 큰값을 최대값으로
                //     answer = max;
                // }
                answer = Math.Max(answer, numbers[i] * numbers[j]);
            }
        }
        return answer;
    }

    /// <summary>
    /// 숨어있는 숫자의 덧셈(1)
    /// </summary>
    /// <param name="my_string"></param>
    /// <returns></returns>
    public int Solution0811(string my_string)
    {
        int answer = 0;
        // my_string을 하나씩 돌자
        foreach (var item in my_string)
        {
            /*
            // 얻어온 item이 '1'과 '9'사이에 있다면
            if ((item >= '1') && (item <= '9'))
            {
                // answer에 그 값을 더한다
                answer += (item - '0');
            }
            */
            if (int.TryParse(item.ToString(), out var value))
            {
                answer += value;
            }
        }
        return answer;
    }

    /// <summary>
    /// 문자열 정렬하기 (1)
    /// </summary>
    /// <param name="my_string"></param>
    /// <returns></returns>
    public int[] Solution08082(string my_string)
    {
        // int list를 만든다
        var list = new List<int>();
        // my_string을 순회한다
        foreach (var item in my_string)
        {
            /*
            // 숫자인지 판별
            if ((item >= '0') && (item <= '9'))
            {
                // 숫자면 list에 char의 값을 넣는다
                list.Add(item - '0');
            }
            */
            if (int.TryParse(item.ToString(), out var value))
            {
                list.Add(value);
            }
        }
        // list를 정렬
        list.Sort();
        // list를 배열 형식으로 변환해서 리턴
        return list.ToArray();
    }

    /// <summary>
    /// 주사위의 개수
    /// </summary>
    /// <param name="box"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution0808(int[] box, int n)
    {
        return (box[0] / n) * (box[1] / n) * (box[2] / n);
    }

    /// <summary>
    /// 가위 바위 보
    /// </summary>
    /// <param name="rsp"></param>
    /// <returns></returns>
    public string Solution08072(string rsp)
    {
        const char rsp_rock = '0';
        const char rsp_scissors = '2';
        const char rsp_paper = '5';

        string answer = string.Empty;
        // for (int i = 0; i < rsp.Length; i++)
        // {
        //     if (rsp[i] == '0')      answer += "5";
        //     else if (rsp[i] == '2') answer += "0";
        //     else                    answer += "2";
        // }

        // foreach (var item in rsp)
        // {
        //     if (item == '0')        answer += "5";
        //     else if (item == '2')   answer += "0";
        //     else                    answer += "2";
        // }
        var sb = new StringBuilder();
        foreach (var item in rsp)
        {
            if (item == rsp_rock) sb.Append(rsp_paper);
            else if (item == rsp_scissors) sb.Append(rsp_rock);
            else sb.Append(rsp_scissors);
        }
        return sb.ToString();
        // return answer
    }

    /// <summary>
    /// 공배수
    /// </summary>
    /// <param name="number"></param>
    /// <param name="n"></param>
    /// <param name="m"></param>
    /// <returns></returns>
    public int Solution0807(int number, int n, int m)
    {
        // int answer = 0;
        // if ((number % n == 0) && (number % m == 0))
        // {
        //     answer = 1;
        // }
        // return answer;
        return ((number % n == 0) && (number % m == 0)) ? 1 : 0;
    }

    /// <summary>
    /// 개미 군단
    /// </summary>
    /// <param name="hp"></param>
    /// <returns></returns>
    public int Solution08062(int hp)
    {
        int generalAP = 5;  // 장군개미 공격력
        int soldierAP = 3;  // 병정개미 공격력
        //int workerAP = 1;   // 일개미 공격력

        int generalAcount = hp / generalAP;
        hp = hp % generalAP;
        int soldierAcount = hp / soldierAP;
        hp = hp % soldierAP;
        //int workerAcount = hp / workerAP;
        //hp = hp % workerAP;
        int answer = generalAcount + soldierAcount + hp;
        return answer;
    }

    /// <summary>
    /// 직각삼각형 출력하기
    /// </summary>
    public void Solution0806()
    {
        string[] s;
        Console.Clear();
        s = Console.ReadLine().Split(' ');
        int n = Int32.Parse(s[0]);
        //int n2 = Convert.ToInt32(s[0]);
        //int n3 = int.Parse(s[0]);

        // for문으로 n만큼 반복
        for (int i = 1; i <= n; i++)
        {
            // for문으로 n만큼 반복
            for (int j = 1; j <= i; j++)
            {
                // 줄바꿈 없이 "*" 출력
                Console.Write("*");
            }
            // 줄바꿈
            Console.WriteLine();
        }
    }

    /// <summary>
    /// 문자열의 앞의 n글자
    /// </summary>
    /// <param name="my_string"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public string Solution08052(string my_string, int n)
    {
        //return my_string.Substring(0, n);
        string answer = "";
        var sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            //answer += my_string[i];
            sb.Append(my_string[i]);
        }
        //return answer;
        return sb.ToString();
    }

    /// <summary>
    /// n의 배수
    /// </summary>
    /// <param name="num"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution0805(int num, int n)
    {
        /*
        int answer = 0;
        if (num % n == 0)
        {
            answer = 1;
        }
        else
        {
            answer = 0;
        }
        */
        return (num % n == 0) ? 1 : 0;
    }

    /// <summary>
    /// 옷가게 할인 받기
    /// </summary>
    /// <param name="price"></param>
    /// <returns></returns>
    public int Solution08042(int price)
    {
        /*
        double answer = price;
        if (price >= 500000)
        {
            answer = price * 0.80;
        }
        else if (price >= 300000)
        {
            answer = price * 0.90;
        }
        else if (price >= 100000)
        {
            answer = price * 0.95;
        }
        return (int)answer;
        */
        if (price >= 500000)
        {
            price = (int)(price * 0.8);
        }
        else if (price >= 300000)
        {
            price = (int)(price * 0.9);
        }
        else if (price >= 100000)
        {
            price = (int)(price * 0.95);
        }
        return price;
    }

    /// <summary>
    /// 짝수는 싫어요
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[] Solution0804(int n)
    {
        // List 정의
        //List<int> list = new List<int>();
        var list = new List<int>();
        // 1부터 n(포함)까지 반복
        for (int i = 1; i <= n; i++)
        {
            // 홀수냐?
            if (i % 2 != 0)
            {
                // 홀수면 list에 넣기
                list.Add(i);
            }
        }
        // list를 int[] 형식으로 바꿔서 리턴
        return list.ToArray();
    }

    /// <summary>
    /// 중앙값 구하기
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public int Solution08012(int[] array)
    {
        // array값을 가진 list를 만든다
        var list = new List<int>(array);
        // list를 정렬한다
        list.Sort();
        // 가운데에 해당하는 인덱스를 구한다
        //int index = list.Count / 2;
        int index = array.Length / 2;
        // list에서 그 인덱스의 값을 리턴한다
        return list[index];
    }

    /// <summary>
    /// 배열 두 배 만들기
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public int[] Solution0801(int[] numbers)
    {
        // numbers의 크기만큼 반복
        for (int i = 0; i < numbers.Length; i++)
        {
            // index에 해당하는 값을 두배해서 넣기
            //numbers[i] = numbers[i] * 2;
            numbers[i] *= 2;
            //numbers[i] <<= 1;
        }
        // 결과 리턴
        return numbers;
    }

    /// <summary>
    /// 중복된 숫자 개수
    /// </summary>
    /// <param name="array"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution07312(int[] array, int n)
    {
        int answer = 0;
        // foreach
        foreach (var item in array)
        {
            // if
            if (item == n)
            {
                // 같으면 answer 증가
                answer++;
            }
        }
        return answer;
    }

    /// <summary>
    /// 문자열 붙여서 출력하기
    /// </summary>
    public void Solution0731()
    {
        String[] input;
        Console.Clear();
        input = Console.ReadLine().Split(' ');
        String s1 = input[0];
        String s2 = input[1];

        Console.WriteLine(s1 + s2);
    }

    /// <summary>
    /// 제곱수 판별하기
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution07302(int n)
    {
        /*
        int answer = 0, min = 1, max = 1000;
        for (int i = min; i <= max; i++)
        {
            if (i * i == n)
            {
                answer = 1;
                break;
            }
            answer = 2;
        }
        return answer;
        */
        double answer = Math.Sqrt(n);
        return (answer % 1 == 0) ? 1 : 2;
    }

    /// <summary>
    /// 문자리스트를 문자열로 변환하기
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public string Solution0730(string[] arr)
    {
        string answer = "";
        /*
        foreach (var item in arr)
        {
            answer += item;
        }
        */
        var sb = new StringBuilder();
        foreach (var item in arr)
        {
            sb.Append(item);
        }
        answer = sb.ToString();
        return answer;
    }

    /// <summary>
    /// 문자 반복 출력하기
    /// </summary>
    /// <param name="my_string"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public string Solution07292(string my_string, int n)
    {
        string answer = string.Empty;
        // foreach로 my_string을 순회
        foreach (var item in my_string)
        {
            // for로 n만큼 반복
            for (int i = 0; i < n; i++)
            {
                // answer에 더한다
                answer += item;
            }
        }
        return answer;
    }

    /// <summary>
    /// 문자열 안에 문자열
    /// </summary>
    /// <param name="str1"></param>
    /// <param name="str2"></param>
    /// <returns></returns>
    public int Solution0729(string str1, string str2)
    {
        /*
        int answer = 0;
        if (str1.Contains(str2))
        {
            answer = 1;
        }
        else
        {
            answer = 2;
        }
        */
        int answer = str1.Contains(str2) ? 1 : 2;
        return answer;
    }

    /// <summary>
    /// 배열 원소의 길이
    /// </summary>
    /// <param name="strlist"></param>
    /// <returns></returns>
    public int[] Solution07282(string[] strlist)
    {
        // 리턴할 배열의 크기를 얻어온다
        int len = strlist.Length;
        // 크기만큼의 배열을 정의한다
        int[] answer = new int[len];
        // for
        for (int i = 0; i < len; i++)
        {
            // 리턴 배열의 각 요소에 strlist의 각 요소 길이를 넣는다
            answer[i] = strlist[i].Length;
        }
        // 배열을 리턴
        return answer;
    }

    /// <summary>
    /// 아이스 아메리카노
    /// </summary>
    /// <param name="money"></param>
    /// <returns></returns>
    public int[] Solution0728(int money)
    {
        /*
        int[] answer = new int[2];
        answer[0] = money / 5500;
        //answer[1] = money - answer[0] * 5500;
        answer[1] = money % 5500;
        return answer;
        */
        return new int[] { money / 5500, money % 5500 };
    }

    /// <summary>
    /// n의 배수 고르기
    /// </summary>
    /// <param name="n"></param>
    /// <param name="numlist"></param>
    /// <returns></returns>
    public int[] Solution07252(int n, int[] numlist)
    {
        // 배수를 담을 리스트 정의
        var list = new List<int>();
        // numlist를 순회하면서
        foreach (var item in numlist)
        {
            // n의 배수이면 
            if (item % n == 0)
            {
                // 리스트에 넣기
                list.Add(item);
            }
        }
        // 리턴할 배열 정의
        int[] answer = new int[list.Count];
        // 리스트를 순회하면서
        for (int i = 0; i < answer.Length; i++)
        {
            // 배열에 리스트 값 넣기
            answer[i] = list[i];
        }
        // 배열 리턴
        return answer;
    }

    /// <summary>
    /// 순서쌍의 개수
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution0725(int n)
    {
        int answer = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                answer++;
            }
        }
        return answer;
    }
    /// <summary>
    /// 배열의 유사도
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    /// <returns></returns>
    public int Solution07242(string[] s1, string[] s2)
    {
        int answer = 0;
        // s1의 크기만큼 반복
        foreach (var item1 in s1)
        {
            // s2의 크기만큼 반복
            foreach (var item2 in s2)
            {
                // 같으면 answer 증가
                if (item1.Equals(item2))
                //if (item1 == item2)
                {
                    answer++;
                }
            }
        }
        return answer;
    }
    /// <summary>
    /// 점의 위치 구하기
    /// </summary>
    /// <param name="dot"></param>
    /// <returns></returns>
    public int Solution0724(int[] dot)
    {
        return dot[0] > 0 ? dot[1] > 0 ? 1 : 4 : dot[1] > 0 ? 2 : 3;
        /*
        if (dot[0] > 0)
        {
            if (dot[1] > 0)
            {
                return 1;
            }
            else
            {
                return 4;
            }
        }
        else
        {
            if (dot[1] > 0)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
        */
    }

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