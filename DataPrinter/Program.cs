using System;
Console.WriteLine("=== 데이터 출력기 ===");
Console.WriteLine();
objectData od = new objectData();
od.PrintAll(new object[] { 42, 3.14, "Hello", true, 100, "World", false, 2.718 });
Console.WriteLine();
od.PrintInfo();
class objectData
{
    public int intcount;
    public int stringcount;
    public int booleancount;
    public int doublecount;
    public void PrintData(object data)
    {
        if (data.GetType() == typeof(int))
        {
            intcount++;
            Console.WriteLine($"정수: {data}");
        }
        else if (data.GetType() == typeof(double))
        {
            doublecount++;
            Console.WriteLine($"실수: {data:F2}");
        }
        else if (data.GetType() == typeof(string))
        {
            stringcount++;
            string str = (string)data;
            Console.WriteLine($"문자열: \"{data}\"(길이: {str.Length})");
        }
        else if(data.GetType() == typeof(Boolean))
        {
            booleancount++;
            Boolean b = (Boolean)data;
            if (b == true)
            {
                Console.WriteLine($"논리값: {data} -> 참");
            }
            else
            {
                Console.WriteLine($"논리값: {data} -> 거짓");
            }
        }
        else
        {
            Console.WriteLine($"알수 없는 타입: {data.GetType()}-{data}");
        }
    }

    public void PrintAll(object[] data)
    {
        Console.WriteLine("[전체 데이터 출력]");
        foreach (object obj in data)
        {
            PrintData(obj);
        }
    }
    public void PrintInfo()
    {
        Console.WriteLine("[타입별 통계]");
        Console.WriteLine($"정수:{intcount}");
        Console.WriteLine($"실수:{doublecount}");
        Console.WriteLine($"문자열:{stringcount}");
        Console.WriteLine($"논리값:{booleancount}");
    }
}