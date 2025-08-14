namespace Zinine
{
    class Util
    {
        /// <summary>
        /// 사칙연산 계산기
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="calcType"></param>
        /// <returns></returns>
        /// <exception cref="ArithmeticException"></exception>
        public static int Calc(int a, int b, string calcType = "+")
        {
            switch (calcType)
            {
                case "+": return a + b;
                case "-": return a - b;
                case "*": return a * b;
                case "/": return a / b;
                default:
                    throw new ArithmeticException();
            }
        }

        /// <summary>
        /// 정수배열의 합을 구하기
        /// </summary>
        /// <param name="scoresArray"></param>
        /// <returns></returns>
        public static int CalculateSum(int[] scoresArray)
        {
            int sum = 0;
            for (int i = 0; i < scoresArray.Length; i++)
            {
                sum += scoresArray[i];
            }
            return sum;
        }

        /// <summary>
        /// 정수 배열을 출력시키는 함수
        /// </summary>
        /// <param name="answerArray"></param>
        public static void PrintIntArray(int[] answerArray)
        {
            Console.Write("[");
            for (int i = 0; i < answerArray.Length; i++)
            {
                Console.Write(answerArray[i]);
                if (i != answerArray.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }

        /// <summary>
        /// 배열을 출력시키는 함수
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="answerArray"></param>
        public static void PrintArray<T>(T[] answerArray)
        {
            Console.Write("[");
            for (int i = 0; i < answerArray.Length; i++)
            {
                Console.Write(answerArray[i]);
                if (i != answerArray.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }

        /// <summary>
        /// 내 꿈을 실현시켜줄 함수
        /// </summary>
        public static void MakeLotto()
        {
            const int TOTAL_BALLS = 45;   // 전체 공 개수
            const int PICK_BALLS = 6;     // 뽑는 공 수

            // 랜덤 함수 사용 선언
            var random = new System.Random();
            // 볼이 담긴 리스트 선언
            var ballList = new List<int>();
            // 리스트에 볼 45개 넣기
            for (int i = 1; i <= TOTAL_BALLS; i++)
            {
                ballList.Add(i);
            }
            // 리스트에서 볼 하나씩 6번 꺼내기
            for (int i = 0; i < PICK_BALLS; i++)
            {
                // 남아 있는 볼 갯수 중 랜덤하게 인덱스 고르기
                int index = random.Next() % ballList.Count;
                // [인덱스]와 볼 번호 출력
                Console.Write("[" + index + "]");
                Console.WriteLine(ballList[index]);
                // 인덱스에 있는 볼을 리스트에서 지우기
                ballList.RemoveAt(index);
            }
        }
    }
}