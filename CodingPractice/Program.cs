using System;
using System.Diagnostics;
using System.Runtime.Remoting;

/*///1.object 타입의 기본 개념
object ob1 = 42;
object ob2 = 3.14;
object ob3 = "Hello";
object ob4 = true;
Console.WriteLine(ob1);
Console.WriteLine(ob2);
Console.WriteLine(ob3);
Console.WriteLine(ob4);
Console.WriteLine();
///2.object 타입의 활용
Stack stack = new Stack();
stack.push("sausage");
string s = (string)stack.Pop();
Console.WriteLine(s);
stack.push(3);
int three = (int)stack.Pop();
Console.WriteLine(three);
class Stack
{
    private int _position;
    private object[] _data = new object[10];

    public void push(object obj)
    {
        _data[_position++]=obj;
    }
    public object Pop()
    {
        return _data[--_position];
    }
}*/
///3-1 박싱
/*int i = 1234;
object o = i;
Console.WriteLine(o);
*/
///3-2 언박싱
/*object o = 1234;
int i = (int)o;
Console.WriteLine(i);*/
///4-1.값 타입을 object에 할당
/*int i = 42;
object boxed = i;
Console.WriteLine(boxed);*/
///4-2.값 타입을 인터페이스 타입에 할당
/*Point point = new Point { X = 10,Y=20};
IDisplayable d = point;
Console.WriteLine(d.GetType().Name);
interface IDisplayable
{
}
struct Point : IDisplayable
{
    public int X;
    public int Y;
}
*/
///5. 박싱의 특징
/*int i = 3;
object o = i;
i = 5;
Console.WriteLine($"원본: {i}");
Console.WriteLine($"박싱된 값: {o}");*/
///6. 언박싱 시 주의사항
/*object boxed = 42;
int i = (int)boxed;
Console.WriteLine($"언박싱 성공: {i}");
try
{
    long l = (long)boxed;
}
catch(InvalidCastException)
{
    Console.WriteLine("잘못된 타입으로 언박싱 시도");
}
int temp = (int)boxed;
long current = temp;
Console.WriteLine($"올바른 변환: {current}");*/
///7-1. 박싱/언박싱 오버헤드 비교
/*int sum = 0;
for (int i = 0; i<1000;i++)
{
    object boxed = i;
    sum += (int)boxed;
}
Console.WriteLine($"박싱 사용: {sum}");
int sum1 = 0;

for(int i = 0; i<1000; i++)
{
    sum1 += i;
}
Console.WriteLine($"직접 처리: {sum1}");*/
///7-2 제네릭으로 박싱 피하기
/*GenericStack<int> stack = new GenericStack<int>();
stack.Push(42);
int value = stack.Pop();
Console.WriteLine(value);
class GenericStack<T>
{
    private T[] _items = new T[100];
    private int _top = 0;
    public void Push(T item)
    {
        _items[_top++] = item;
    }
    public T Pop()
    {
        return _items[--_top];
    }
}*/
///8-1 GEtType() 메서드
/*int i = 1234;
string s = "안녕하세요";
char c = 'A';
double d = 3.14;
object o = new object();
Console.WriteLine(i.GetType());  
Console.WriteLine(s.GetType());  
Console.WriteLine(c.GetType());  
Console.WriteLine(d.GetType()); 
Console.WriteLine(o.GetType());  */
///8-2 typeof 연산자
/*Console.WriteLine(typeof(int));
Console.WriteLine(typeof(string));
Console.WriteLine(typeof(double));*/
///8-3 GetType()과 typeof()비교
/*Point p = new Point { X = 10, Y = 20 };
Console.WriteLine(p.GetType().Name);
Console.WriteLine(typeof(Point).Name);
Console.WriteLine(p.GetType()==typeof(Point));
Console.WriteLine(p.X.GetType().Name);
Console.WriteLine(p.Y.GetType().FullName);
class Point
{
    public int X;
    public int Y;
}*/
///9=1. 기본 동작
/*int i = 42;
double p = 3.14;
bool b = true;
Console.WriteLine(i.ToString());
Console.WriteLine(p.ToString());
Console.WriteLine(b.ToString());*/
///9-2 ToString() 재정의 하기
/*Panda p = new Panda { _Name = "Petey" };
Console.WriteLine(p);
Console.WriteLine(p.ToString());

class Panda
{
    public string _Name;
    public override string ToString()
    {
        return _Name;
    }
}*/
///9-3 더 상세한 TOString() 구현
/*Player p = new Player { Name = "Hero", Level = 10, Health = 100 };
Console.WriteLine(p);
class Player
{
    public string Name;
    public int Level;
    public int Health;

    public override string ToString()
    {
        return $"Player = {{Name={Name}, Level = {Level}, Heatlth = {Health}}}";
    }

}*/
///10. object 클래스의 멤버들
string s1 = "Hello";
string s2 = "Hello";
string s3 = s1;

Console.WriteLine($"s1.Equals(s2): {s1.Equals(s2)}");                
Console.WriteLine($"ReferenceEquals(s1, s2): {object.ReferenceEquals(s1, s2)}"); 
Console.WriteLine($"ReferenceEquals(s1, s3): {object.ReferenceEquals(s1, s3)}"); 

object obj1 = new object();
object obj2 = new object();
object obj3 = obj1;

Console.WriteLine($"obj1.Equals(obj2): {obj1.Equals(obj2)}");           
Console.WriteLine($"ReferenceEquals(obj1, obj2): {object.ReferenceEquals(obj1, obj2)}"); 
Console.WriteLine($"ReferenceEquals(obj1, obj3): {object.ReferenceEquals(obj1, obj3)}");  