using System.Collections;

class CSStudy
{
    public void ArraySample()
    {
        var players = new string[10];
        string[] regions = { "서울", "경기", "부산" };

        var depts = new string[,] { { "김과장", "경리부" }, { "이과장", "총무부" } };

        string[,,] cubes;

        int[,] aa = new int[3, 2];
        int[][] A = new int[3][];
        A[0] = new int[2];
        A[1] = new int[3] { 1, 2, 3 };
        A[2] = new int[4] { 1, 2, 3, 4 };
        A[0][0] = 1;
        A[0][1] = 2;
        aa[0, 0] = 1;
        aa[0, 1] = 2;
        aa[2, 1] = 3;
        Console.WriteLine(A.GetLength(0));
        Console.WriteLine(A[1].Length);
        int sum = 0;
        int[] scores = { 80, 78, 60, 90, 100 };
        for (int i = 0; i < scores.Length; i++)
        {
            sum += scores[i];
        }
        //Console.WriteLine("sum = " + sum);
        //Console.WriteLine("sum = {0}", sum);
        Console.WriteLine($"sum = {sum}");
    }


    public void SortedDicSample()
    {
        var tmap = new SortedDictionary<int, string>();
        tmap.Add(1001, "Tom");
        tmap.Add(1003, "John");
        tmap.Add(1010, "Irina");
        tmap.Add(1005, "Lee");
        tmap.Add(1200, "Kim");

        string name1010 = tmap[1010];

        // Iterator
        foreach (KeyValuePair<int, string> kv in tmap)
        {
            Console.WriteLine("{2}{0}:{1} {4}", kv.Key, kv.Value, "*", 3, kv);
        }
    }

    public void HashTableSample()
    {
        Hashtable ht = new Hashtable();
        ht.Add("irina", "Irina SP");
        ht.Add("tom", "Tom Cr");
        ht.Add(3, 'a');

        if (ht.Contains("tom"))
        {
            Console.WriteLine(ht["tom"]);
        }

        //Dictionary<int, string> emp = new Dictionary<int, string>();
        var emp = new Dictionary<int, string>();
        emp.Add(1001, "Jane");
        //emp.Add(1002, "Tom");
        emp.Add(1003, "Cindy");
        if (emp.ContainsKey(1002) == false)
        {
            emp.Add(1002, "Kim");
        }

        string name = emp[1002];
        Console.WriteLine(name);
    }

    public void StackQueue()
    {
        //Stack<float> s = new Stack<float>();
        var s = new Stack<float>();
        s.Push(10.5f);
        s.Push(3.54f);
        s.Push(4.22f);

        float pp = s.Peek();
        Console.WriteLine("pp=" + pp);

        var p3 = s.Pop();
        Console.WriteLine("p3=" + p3);

        var p4 = s.Pop();
        Console.WriteLine("p4=" + p4);

        Queue<int> q = new Queue<int>();
        q.Enqueue(120);
        q.Enqueue(130);
        q.Enqueue(150);

        int next = q.Peek();
        Console.WriteLine("next=" + next);

        next = q.Dequeue();
        Console.WriteLine("next=" + next);
    }

    public void LinkedListSample()
    {
        //LinkedList<string> list = new LinkedList<string>();
        var list = new LinkedList<string>();

        int a = 1, b = 2;
        // var는 한줄에 하나만 정의 가능
        //var va = 1, v2 = 2;

        list.AddLast("Apple");
        list.AddLast("Banana");
        list.AddLast("Lemon");

        //LinkedListNode<string> node = list.Find("Banana");
        var node = list.Find("Banana");
        var newNode = new LinkedListNode<string>("Grape");

        list.AddAfter(node, newNode);
        list.AddAfter(node, "Kiwi");

        list.ToList<string>().ForEach(p => Console.WriteLine(p));

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    public void ListSample()
    {
        //List<int> myList = new List<int>();
        var myList = new List<int>();
        myList.Add(90);
        myList.Add(88);
        myList.Add(75);
        int val = myList[1];

        var chrList = new List<char>();
        chrList.Add('b');

        var boolList = new List<bool>();
        boolList.Add(false);

        var iarray = new int[100];
        iarray[2] = 10;
        myList.Add(10);
        Console.WriteLine(iarray.Length);
        Console.WriteLine(myList.Count);

        // 정렬
        myList.Sort();
    }

    public void ArrayListSample()
    {
        //ArrayList myList = new ArrayList();
        var myList = new ArrayList();
        myList.Add(90);
        myList.Add(88);
        myList.Add(75);
        int val = (int)myList[1];
        Console.WriteLine(val);
        Console.WriteLine(myList[0]);
    }

    public void ArrayExample()
    {
        int sum = 0;
        //int[] nums = new int[10] { 1,2,3,4,5,6,7,9,8,0 };
        int[] nums = new int[10];

        nums[0] = 1;
        nums[1] = 2;
        //
        nums[9] = 0;
        // 이거 안됨!!!
        //nums[10] = 9;

        Random rand = new Random();
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rand.Next() % 100;
        }

        for (int i = 0; i < nums.Length; i += 1)
        {
            Console.WriteLine(i + " : " + nums[i]);
            sum += nums[i];
        }

        Console.WriteLine("sum=" + sum);
    }

    /// <summary>
    /// int, float, string 은 기억하자
    /// </summary>
    public void DataType()
    {
        // bool 타입
        bool b = true;

        short sh = -32768;
        int i = 2147483647;
        long l = 1234L;
        float f = 123.85f;
        double d1 = 123.45;
        double d2 = 123.45D;
        decimal d = 123.45M;

        Console.WriteLine(f);
        i = (int)f;
        Console.WriteLine(i);

        char c = 'A';
        string s = "H";
        // null과 ""는 다르다
        string s2 = null;
        string s3 = "";
        string s4 = string.Empty;

        // 이건 에러난다
        //int ii = null;

        DateTime dt = new DateTime(2025, 7, 9, 11, 16, 00);

        if (i > int.MaxValue)
        {

        }
    }
}