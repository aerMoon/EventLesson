using System;//2,17

delegate void MyDelegate(string txt);

namespace _2_EventLessont
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            Alpha A = new Alpha("A");
            Alpha B = new Alpha("B");

            obj.RaiseMyEvent("1 event");
            Console.WriteLine("---------------");

            obj.MyEvent+=A.show;
            obj.RaiseMyEvent("2 event");
            Console.WriteLine("---------------");

            obj.MyEvent+=B.show;
            obj.RaiseMyEvent("3 event");
            Console.WriteLine("---------------");

            obj.MyEvent-=A.show;
            obj.RaiseMyEvent("4 event");
            Console.WriteLine("---------------");

            obj.MyEvent-=A.show;
            obj.MyEvent-=B.show;
            obj.RaiseMyEvent("5 event");
            Console.WriteLine("---------------");

            MyDelegate md = A.show;
            md+=B.show;
            obj.MyEvent+=md;
            obj.RaiseMyEvent("6 event");

        }
    }
}
