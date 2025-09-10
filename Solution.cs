using System.Text;
using System.Text.RegularExpressions;

class Solution
{
    /// <summary>
    /// 특별한 이차원 배열 2
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public int Solution09102(int[,] arr)
    {
        // int answer = 1;
        // for (int i = 0; i < arr.GetLength(0); i++)
        // {
        //     for (int j = 0; j < arr.GetLength(1); j++)
        //     {
        //         if (arr[i, j] != arr[j, i])
        //         {
        //             answer = 0;
        //             break;
        //         }
        //     }
        //     if (answer == 0) break;
        // }
        // return answer;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] != arr[j, i])
                {
                    return 0;
                }
            }
        }
        return 1;
    }

    /// <summary>
    /// 특별한 이차원 배열 1
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[,] Solution0910(int n)
    {
        int[,] answer = new int[n, n];
        // for (int i = 0; i < n; i++)
        // {
        //     for (int j = 0; j < n; j++)
        //     {
        //         if (i == j)
        //         {
        //             answer[i, j] = 1;
        //         }
        //     }
        // }
        for (int i = 0; i < n; i++)
        {
            answer[i, i] = 1;
        }
        return answer;
    }

    /// <summary>
    /// 0 떼기
    /// </summary>
    /// <param name="n_str"></param>
    /// <returns></returns>
    public string Solution09092(string n_str)
    {
        /*
        // 0이 지속되는지 여부 변수 : isZero
        bool isZero = true;
        // isZero 변수가 참일 때 반복 while
        while (isZero)
        {
            // 현재 맨 앞에 문자가 0인지 판별
            //if (n_str[0] == '0')
            //if (n_str[0].CompareTo('0') == 0)
            if (n_str[0].Equals('0'))
            {
                // 0이면 지우기
                n_str = n_str.Substring(1);
            }
            else
            {
                // isZero 변수를 false로
                isZero = false;
            }
        }
        return n_str;
        */
        return Convert.ToInt32(n_str).ToString();
    }

    /// <summary>
    /// 부분 문자열
    /// </summary>
    /// <param name="str1"></param>
    /// <param name="str2"></param>
    /// <returns></returns>
    public int Solution0909(string str1, string str2)
    {
        // int answer = 0;
        // if (str2.Contains(str1)) answer = 1;
        // return answer;
        //return (str2.IndexOf(str1) < 0) ? 0 : 1;
        return str2.Contains(str1) ? 1 : 0;
    }

    /// <summary>
    /// 꼬리 문자열
    /// </summary>
    /// <param name="str_list"></param>
    /// <param name="ex"></param>
    /// <returns></returns>
    public string Solution09082(string[] str_list, string ex)
    {
        //string answer = "";
        var sb = new StringBuilder();
        foreach (var item in str_list)
        {
            if (!item.Contains(ex))
            {
                //answer += item;
                sb.Append(item);
            }
        }
        //return answer;
        return sb.ToString();
    }

    /// <summary>
    /// 배열의 원소 삭제하기
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="delete_list"></param>
    /// <returns></returns>
    public int[] Solution0908(int[] arr, int[] delete_list)
    {
        var list = new List<int>();
        foreach (var item in arr)
        {
            if (!delete_list.Contains(item))
            {
                list.Add(item);
            }
        }
        return list.ToArray();
    }

    /// <summary>
    /// 정수 찾기
    /// </summary>
    /// <param name="num_list"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution09052(int[] num_list, int n)
    {
        // int answer = 0;
        // foreach (var item in num_list)
        // {
        //     if (item == n)
        //     {
        //         answer = 1;
        //     }
        // }
        // return answer;
        return num_list.Contains(n) ? 1 : 0;
    }

    /// <summary>
    /// 문자열 바꿔서 찾기
    /// </summary>
    /// <param name="myString"></param>
    /// <param name="pat"></param>
    /// <returns></returns>
    public int Solution0905(string myString, string pat)
    {
        // myString을 변환
        string str = string.Empty;
        // foreach 
        // foreach (var item in myString)
        // {
        //     str += item.Equals('A') ? 'B' : 'A';
        // }
        // string.Replace 를 이용
        str = myString.Replace('A', 'b').Replace('B', 'a').ToUpper();
        // pat가 포함되었는지 판별
        return str.Contains(pat) ? 1 : 0;
    }

    /// <summary>
    /// 숫자 찾기
    /// </summary>
    /// <param name="num"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int Solution09042(int num, int k)
    {
        // 간단한 방법
        //int answer = num.ToString().IndexOf(k.ToString());
        //return (answer == -1) ? answer : answer + 1;

        // IndexOf를 모르는 경우
        // 숫자를 문자열로 변환
        string str = num.ToString();
        // 비교할 숫자는 문자로 변환
        //char kchr = Convert.ToChar(k.ToString());
        char kchr = (char)('0' + k);
        // 문자열의 크기만큼 순회
        for (int i = 0; i < str.Length; i++)
        {
            // 문자열 중 인덱스에 해당하는 문자가 비교문자와 같으면
            if (str[i].Equals(kchr))
            {
                // 인덱스에 1 더한 값 반환
                return i + 1;
            }
        }
        // 없으면 -1 반환
        return -1;
    }

    /// <summary>
    /// 정수 부분
    /// </summary>
    /// <param name="flo"></param>
    /// <returns></returns>
    public int Solution0904(double flo)
    {
        int answer = 0;
        // 간단한 방법
        //answer = (int)(flo / 1);
        //answer = (int)flo;
        // 조금 복잡한 방법 : string 이용
        string str = flo.ToString();
        string[] strArr = str.Split(".");
        answer = Convert.ToInt32(strArr[0]);
        return answer;
    }

    /// <summary>
    /// 조건에 맞게 수열 변환하기 3
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int[] Solution09032(int[] arr, int k)
    {
        // 반환 배열의 크기를 알 수 있으므로 그 크기만큼 만든다
        int[] answer = new int[arr.Length];
        // 매번 계산해야 되는게 있다면 미리 해 놓자
        bool isEven = k % 2 == 0;
        // for문으로 반복
        for (int i = 0; i < answer.Length; i++)
        {
            // 삼항연산자 사용
            answer[i] = isEven ? arr[i] + k : arr[i] * k;
        }
        return answer;
    }

    /// <summary>
    /// l로 만들기
    /// </summary>
    /// <param name="myString"></param>
    /// <returns></returns>
    public string Solution0903(string myString)
    {
        // return myString.Replace("a", "l")
        //     .Replace("b", "l").Replace("c", "l")
        //     .Replace("d", "l").Replace("e", "l")
        //     .Replace("f", "l").Replace("g", "l")
        //     .Replace("h", "l").Replace("i", "l")
        //     .Replace("j", "l").Replace("k", "l");
        // 코드는 간단하나 실행시간은 더 걸린다
        return Regex.Replace(myString, "[a-k]", "l");
    }

    /// <summary>
    /// 이어 붙인 수
    /// </summary>
    /// <param name="num_list"></param>
    /// <returns></returns>
    public int Solution09022(int[] num_list)
    {
        int answer = 0;
        // 홀짝에 해당하는 문자열 변수를 만든다
        string even = "", odd = "";
        // foreach문으로 돌면서
        foreach (var item in num_list)
        {
            // 짝수면 짝수문자열에 
            if (item % 2 == 0)
            {
                //even += item.ToString();
                even += item;
            }
            else // 홀수면 홀수문자열에 넣기
            {
                odd += item;
            }
        }
        // 문자열을 정수값으로 변환 후 더한다
        answer = Int32.Parse(even) + Convert.ToInt32(odd);
        return answer;
    }

    /// <summary>
    /// 특정한 문자를 대문자로 바꾸기
    /// </summary>
    /// <param name="my_string"></param>
    /// <param name="alp"></param>
    /// <returns></returns>
    public string Solution0902(string my_string, string alp)
    {
        // 1. string에 있는 특정 메서드 사용 
        //return my_string.Replace(alp, alp.ToUpper());

        // 2. foreach 문으로 반복
        var sb = new StringBuilder();
        foreach (var item in my_string)
        {
            // alp와 같은지 비교
            if (item.ToString().Equals(alp))
            {
                // 같으면 대문자로 바꿔서 넣기
                //answer += alp.ToUpper();
                sb.Append((char)(item - 'a' + 'A'));
            }
            else
            {
                // 아니면 그냥 넣기
                sb.Append(item);
            }
        }
        return sb.ToString();
    }

    /// <summary>
    /// 덧셈식 출력하기
    /// </summary>
    public void Solution09012()
    {
        string[] s;
        Console.Clear();
        s = Console.ReadLine().Split(' ');
        int a = Int32.Parse(s[0]);
        int b = Convert.ToInt32(s[1]);
        //int result = a + b;
        //Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        Console.WriteLine($"{a} + {b} = {a + b}");
    }

    /// <summary>
    /// 문자열 돌리기
    /// </summary>
    public void Solution0901()
    {
        string s;
        Console.Clear();
        s = Console.ReadLine();
        foreach (var item in s)
        {
            Console.WriteLine(item);
        }
    }

    /// <summary>
    /// 주사위 게임 2
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public int Solution08292(int a, int b, int c)
    {
        int answer = 0;
        // if 비교문 중 가장 복잡한걸 마지막 else에 둔다
        //if ((a != b) && (a != c) && (b != c))
        //if ((a == b && a != c) || (a == c && a != b) || (b == c && a != b))
        //if ((a == b) && (a == c))
        if ((a != b) && (a != c) && (b != c))
        {
            answer = a + b + c;
        }
        else if ((a == b) && (a == c))
        {
            answer = (a + b + c) *
                (a * a + b * b + c * c) *
                (a * a * a + b * b * b + c * c * c);
        }
        else
        {
            answer = (a + b + c) * (a * a + b * b + c * c);
        }
        return answer;
    }

    /// <summary>
    /// 마지막 두 원소
    /// </summary>
    /// <param name="num_list"></param>
    /// <returns></returns>
    public int[] Solution0829(int[] num_list)
    {
        // answer의 크기를 알 수 있는가
        int len = num_list.Length + 1;
        // 그 크기만큼 answer를 정의
        int[] answer = new int[len];
        // num_list의 값을 answer에 넣기
        for (int i = 0; i < len - 1; i++)
        {
            answer[i] = num_list[i];
        }
        // 마지막 원소, 마지막 전 원소의 값 얻기
        int last1 = num_list[len - 2];
        int last2 = num_list[len - 3];
        // 마지막 원소와 전 원소의 비교
        if (last1 > last2) // 구해진 값을 answer의 마지막에 넣는다
        {
            // 마지막 원소가 크면 뺀 값
            answer[len - 1] = last1 - last2;
        }
        else
        {
            // 아니면 마지막 원소를 두배한 값
            answer[len - 1] = last1 * 2;
        }
        return answer;
    }

    /// <summary>
    /// 수 조작하기 2
    /// </summary>
    /// <param name="numlog"></param>
    /// <returns></returns>
    public string Solution08282(int[] numlog)
    {
        // 문자열 계산할때는 StringBuilder를 쓰자
        var sb = new StringBuilder();
        // 주어진 배열 길이 - 1 만큼 반복
        for (int i = 0; i < numlog.Length - 1; i++)
        {
            // 알아야할 값 = 다음 값 - 지금 값
            int val = numlog[i + 1] - numlog[i];
            // 해당 문자를 결과에 더한다
            if (val == 1) sb.Append('w');
            else if (val == -1) sb.Append('s');
            else if (val == 10) sb.Append('d');
            else sb.Append('a');
        }
        // 문자열로 변환 후 리턴
        return sb.ToString();
    }

    /// <summary>
    /// 수 조작하기 1
    /// </summary>
    /// <param name="n"></param>
    /// <param name="control"></param>
    /// <returns></returns>
    public int Solution0828(int n, string control)
    {
        // control의 길이만큼 반복
        foreach (var item in control)
        {
            // 해당문자에 따른 n 계산
            switch (item)
            {
                case 'w': n++; break;
                case 's': n--; break;
                case 'd': n += 10; break;
                case 'a': n -= 10; break;
                // switch-case문을 작성할때는, default를 추가하자
                default:
                    Console.WriteLine("Error!!");
                    break;
            }
        }
        // n 리턴
        return n;
    }

    /// <summary>
    /// 콜라츠 수열 만들기
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[] Solution08272(int n)
    {
        // list를 하나 만들자
        var list = new List<int>();
        // while 로 돌리자
        while (n != 1)
        {
            // n을 list에 넣는다
            list.Add(n);
            // n이 짝수인지 판별
            if (n % 2 == 0)
            {
                // 짝수일 때 변형
                n /= 2;
            }
            else
            {
                // 홀수일 때 변형
                n = 3 * n + 1;
            }
        }
        // 마지막으로 할 일
        list.Add(1);
        // list를 배열형식으로 변환 후 리턴
        return list.ToArray();
    }

    /// <summary>
    /// 글자 이어 붙여 문자열 만들기
    /// </summary>
    /// <param name="my_string"></param>
    /// <param name="index_list"></param>
    /// <returns></returns>
    public string Solution0827(string my_string, int[] index_list)
    {
        // 문자열 연산이므로 StringBuilder 사용
        var sb = new StringBuilder();
        // foreach로 index_list를 돌자
        foreach (var item in index_list)
        {
            // sb에 my_string의 현재 인덱스의 문자를 넣자
            sb.Append(my_string[item]);
        }
        // 문자열로 변환 후 리턴
        return sb.ToString();
    }

    /// <summary>
    /// 부분 문자열 이어 붙여 문자열 만들기
    /// </summary>
    /// <param name="my_strings"></param>
    /// <param name="parts"></param>
    /// <returns></returns>
    public string Solution08262(string[] my_strings, int[,] parts)
    {
        string answer = "";
        // parts의 1차원 갯수를 먼저 구하자
        int cnt = parts.GetLength(0);
        // for문으로 parts의 갯수만큼 반복
        for (int i = 0; i < cnt; i++)
        {
            // 잘라야 하는 길이를 먼저 구하자
            int len = parts[i, 1] - parts[i, 0] + 1;
            // 자른만큼의 문자열을 answer에 붙이자      
            answer += my_strings[i].Substring(parts[i, 0], len);
        }
        return answer;
    }

    /// <summary>
    /// 접미사 배열
    /// </summary>
    /// <param name="my_string"></param>
    /// <returns></returns>
    public string[] Solution0826(string my_string)
    {
        // string list를 준비
        var list = new List<string>();
        // for문으로 my_string 크기만큼 돌자
        for (int i = 0; i < my_string.Length; i++)
        {
            // list에 my_string을 자른 값을 넣자
            list.Add(my_string.Substring(i));
        }
        // list를 정렬
        list.Sort();
        // list를 배열로 변환시킨 후 리턴
        return list.ToArray();
    }

    /// <summary>
    /// 접두사인지 확인하기
    /// </summary>
    /// <param name="my_string"></param>
    /// <param name="is_prefix"></param>
    /// <returns></returns>
    public int Solution08252(string my_string, string is_prefix)
    {
        /*
        int answer = 1;
        // is_prefix 의 길이가 my_string보다 길면 0 리턴
        if (is_prefix.Length > my_string.Length)
        {
            return 0;
        }
        // for문 돌면서
        for (int i = 0; i < is_prefix.Length; i++)
        {
            // 현재 인덱스의 문자가 다르면 0 리턴
            if (my_string[i] != is_prefix[i])
            {
                return 0;
            }
        }
        // 리턴되지 않았으면 1 리턴
        return answer;
        */
        return my_string.IndexOf(is_prefix) == 0 ? 1 : 0;
    }

    /// <summary>
    /// 더 크게 합치기
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int Solution0825(int a, int b)
    {
        string ab = $"{a}{b}";
        string ba = $"{b}{a}";
        int iab = int.Parse(ab);
        int iba = Convert.ToInt32(ba);
        int answer = Math.Max(iab, iba);
        return answer;
    }

    /// <summary>
    /// 배열 만들기 1
    /// </summary>
    /// <param name="n"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int[] Solution08222(int n, int k)
    {
        // 리턴될 배열의 크기를 바로 알 수 없으니 list를 사용하자
        var list = new List<int>();
        // 1에서 n까지 반복
        for (int i = 1, j = i * k; i <= n; i++, j = i * k)
        {
            // 조건에 맞지 않으면 break
            if (j > n) break;
            // list에 k의 배수 넣기
            list.Add(j);
        }
        // list를 int배열로 변환해서 리턴
        return list.ToArray();
    }

    /// <summary>
    /// 카운트 다운
    /// </summary>
    /// <param name="start_num"></param>
    /// <param name="end_num"></param>
    /// <returns></returns>
    public int[] Solution0822(int start_num, int end_num)
    {
        /*
        int len = start_num - end_num + 1;
        int[] answer = new int[len];
        for (int i = 0; i < len; i++)
        {
            answer[i] = start_num - i;
        }
        return answer;
        */
        var list = new List<int>();
        for (int i = start_num; i >= end_num; i--)
        {
            list.Add(i);
        }
        return list.ToArray();
    }

    /// <summary>
    /// 순서 바꾸기
    /// </summary>
    /// <param name="num_list"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[] Solution08212(int[] num_list, int n)
    {
        // 리턴할 배열의 크기를 바로 알 수 있는가?
        // => 있다면 그 크기만큼 배열을 잡고 시작
        int[] answer = new int[num_list.Length];
        // 전체에서 순서를 알 수 있는 변수가 하나 필요
        // => answer에 값을 넣기 위한 인덱스
        int idx = 0;
        // n에서 시작하고 num_list 끝까지 반복
        for (int i = n; i < num_list.Length; i++)
        {
            // answer에 num_list 현재 값을 대입, 전체 인덱스 증가
            answer[idx++] = num_list[i];
        }
        // 처음부터 n까지 반복
        for (int i = 0; i < n; i++)
        {
            // answer에 num_list 현재 값을 대입
            answer[idx++] = num_list[i];
        }
        return answer;

        // queue를 사용
        /*
        Queue<int> q = new Queue<int>();
        for(int i = 0; i < num_list.Length; i++)
        {
            q.Enqueue(num_list[i]);
        }
        for(int i = 0; i < n; i++)
        {
            int x = q.Dequeue();
            q.Enqueue(x);
        }
        return q.ToArray();
        */
    }

    /// <summary>
    /// 첫 번째로 나오는 음수
    /// </summary>
    /// <param name="num_list"></param>
    /// <returns></returns>
    public int Solution0821(int[] num_list)
    {
        // num_list의 길이만큼 반복
        for (int i = 0; i < num_list.Length; i++)
        {
            // 현재 인덱스의 num_list값과 0 비교
            if (num_list[i] < 0)
            {
                // 작으면 현재 인덱스 리턴
                return i;
            }
        }
        // 아니면 -1 리턴
        return -1;
    }

    /// <summary>
    /// n보다 커질 때까지 더하기
    /// </summary>
    /// <param name="numbers"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Solution08202(int[] numbers, int n)
    {
        int answer = 0;
        foreach (var item in numbers)
        {
            answer += item;
            if (answer > n)
            {
                break;
            }
        }
        return answer;
    }

    /// <summary>
    /// 문자열의 뒤의 n글자
    /// </summary>
    /// <param name="my_string"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public string Solution0820(string my_string, int n)
    {
        //return my_string.Substring(my_string.Length - n, n);
        //return my_string.Remove(0, my_string.Length - n);
        string answer = "";
        for (int i = 0; i < my_string.Length; i++)
        {
            if (i < my_string.Length - n)
            {
                continue;
            }
            else
            {
                answer += my_string[i];
            }
        }
        return answer;
    }

    /// <summary>
    /// 문자열 정렬하기 (2)
    /// </summary>
    /// <param name="my_string"></param>
    /// <returns></returns>
    public string Solution08192(string my_string)
    {
        // list.Sort 사용
        /*
        string answer = "";
        var list = new List<string>();
        foreach (var item in my_string)
        {
            list.Add(item.ToString().ToLower());
        }
        list.Sort();
        foreach (var item in list)
        {
            answer += item;
        }
        return answer;
        */
        // Array.Sort 이용 (char array)
        char[] chrarr = my_string.ToLower().ToCharArray();
        Array.Sort(chrarr);
        return new string(chrarr);
    }

    /// <summary>
    /// 가장 큰 수 찾기
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public int[] Solution0819(int[] array)
    {
        int[] answer = new int[2];
        /*
        // array를 처음부터 끝까지 탐색한다
        for (int i = 0; i < array.Length; i++)
        {
            // 현재 인덱스의 array 값과 현재 최대값을 비교
            if (array[i] > answer[0])
            {
                //현재 인덱스 array 값이 크면 그걸 최대값으로 저장
                answer[0] = array[i];
                // 이 때 인덱스 값도 answer에 저장 
                answer[1] = i;
            }
        }
        */
        // Dictionary 이용
        //Dictionary<int, int> dic = new Dictionary<int, int>();
        var dic = new Dictionary<int, int>();
        // dic에 array값 넣기
        for (int i = 0; i < array.Length; i++)
        {
            dic.Add(array[i], i);
        }
        // 큰수 찾기 : List의 Sort를 이용
        var list = new List<int>(array);
        list.Sort();
        // 리턴 배열에 넣기
        answer[0] = list[list.Count - 1]; // list[array.Length - 1];
        answer[1] = dic[answer[0]];
        return answer;
    }

    /// <summary>
    /// 약수 구하기
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[] Solution08182(int n)
    {
        // list를 하나 준비
        var list = new List<int>();
        // 1부터 n까지 반복
        for (int i = 1; i <= n; i++)
        {
            // n이 인덱스 값으로 나누어 떨어지면
            if (n % i == 0)
            {
                // 그게 약수니까 list에 넣는다
                list.Add(i);
            }
        }
        // list를 배열형으로 바꿔서 리턴한다
        return list.ToArray();
    }

    /// <summary>
    /// 인덱스 바꾸기
    /// </summary>
    /// <param name="my_string"></param>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public string Solution0818(string my_string, int num1, int num2)
    {
        /*
        string answer = string.Empty;
        // num1, num2에 해당하는 char를 얻어온다
        char chr1 = my_string[num1];
        char chr2 = my_string[num2];
        // for문으로 돌면서
        for (int i = 0; i < my_string.Length; i++)
        {
            if (i == num1) // 인덱스가 num1과 같으면
            {
                answer += chr2; // num2를 넣고
            }
            else if (i == num2) // num2와 같으면
            {
                answer += chr1; // num1을 넣고
            }
            else // 아니면
            {
                answer += my_string[i]; // 원래 char를 넣는다
            }
        }
        return answer;
        */
        var sb = new StringBuilder(my_string);
        sb[num1] = my_string[num2];
        sb[num2] = my_string[num1];
        return sb.ToString();
    }

    /// <summary>
    /// 대문자와 소문자
    /// </summary>
    /// <param name="my_string"></param>
    /// <returns></returns>
    public string Solution08142(string my_string)
    {
        var sb = new StringBuilder();
        foreach (var item in my_string)
        {
            if ((item >= 'a') && (item <= 'z'))
            {
                sb.Append(item.ToString().ToUpper());
            }
            else
            {
                sb.Append(item.ToString().ToLower());
            }
        }
        return sb.ToString();
    }

    /// <summary>
    /// flag에 따라 다른 값 반환하기
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="flag"></param>
    /// <returns></returns>
    public int Solution0814(int a, int b, bool flag)
    {
        // int answer = 0;
        // //if (flag == true)
        // if (flag) // true와 비교일 경우 생략
        // {
        //     answer = a + b;
        // }
        // else
        // {
        //     answer = a - b;
        // }
        // return answer;
        return flag ? a + b : a - b;
    }

    /// <summary>
    /// 암호 해독
    /// </summary>
    /// <param name="cipher"></param>
    /// <param name="code"></param>
    /// <returns></returns>
    public string Solution08132(string cipher, int code)
    {
        // string answer = "";
        // for (int i = code - 1; i < cipher.Length; i += code)
        // {
        //     answer += cipher[i];
        // }
        // return answer;
        var sb = new StringBuilder();
        for (int i = code - 1; i < cipher.Length; i += code)
        {
            sb.Append(cipher[i]);
        }
        return sb.ToString();
    }

    /// <summary>
    /// n 번째 원소부터
    /// </summary>
    /// <param name="num_list"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[] Solution0813(int[] num_list, int n)
    {
        // 리턴할 배열의 크기를 알 수 있으면 구하자
        int len = num_list.Length - n + 1;
        // 구해진 크기만큼의 배열을 잡는다
        int[] answer = new int[len];
        // len크기만큼 반복
        // for (int i = 0; i < len; i++)
        // {
        //     // answer배열에 해당 값 넣기
        //     answer[i] = num_list[i + n - 1];
        // }
        // num_list의 크기만큼 반복
        for (int i = n - 1, j = 0; i < num_list.Length; i++, j++)
        {
            answer[j] = num_list[i];
        }
        return answer;
    }

    /// <summary>
    /// 홀짝 구분하기
    /// </summary>
    public void Solution08122()
    {
        string[] s;
        Console.Clear();
        s = Console.ReadLine().Split(' ');
        int a = Int32.Parse(s[0]);
        const string str = "{0} is {1}";
        const string strEven = "even";
        const string strOdd = "odd";
        string strVal = (a % 2 == 0) ? strEven : strOdd;
        Console.WriteLine(str, a, strVal);
        // if (a % 2 == 0)
        // {
        //     Console.WriteLine("{0} is even", a);
        // }
        // else
        // {
        //     Console.WriteLine($"{a} is odd");
        // }
    }

    /// <summary>
    /// 문자열 곱하기
    /// </summary>
    /// <param name="my_string"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public string Solution0812(string my_string, int k)
    {
        //string answer = "";
        var sb = new StringBuilder();
        for (int i = 0; i < k; i++)
        {
            //answer += my_string;
            sb.Append(my_string);
        }
        //return answer;
        return sb.ToString();
    }

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