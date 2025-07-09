class CSStudy
{
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