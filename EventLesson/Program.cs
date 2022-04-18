using System;//2.16
delegate void MyDelegate(string txt);
namespace EventLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // создание объекта с событием:
            MyClass obj = new MyClass();

            // создание объеъктов:
            Alpha A = new Alpha("A");
            Alpha B = new Alpha("B");

            // попытка сгенерировать событие:
            obj.RaiseMyEvent("1 event");
            // добавление обработчика для события:
            obj.MyEvent+=A.show;
            // генерирование события:
            obj.RaiseMyEvent("2 event");
            Console.WriteLine("-----------------");

            // добавление обработчика для события:
            obj.MyEvent+=B.show;
            // генерирование события:
            obj.RaiseMyEvent("3 event");
            Console.WriteLine("-----------------");

            // удаление метода из списка обработчиков события:
            obj.MyEvent-=A.show;
            // генерирование события:
            obj.RaiseMyEvent("4 event");
            Console.WriteLine("-----------------");

            // удаление методов из списка обработчиков события:
            obj.MyEvent-=A.show;
            obj.MyEvent-=B.show;
            // попытка сгенерировать событие:
            obj.RaiseMyEvent("5 event");

            // создание экземпляра делегата:
            MyDelegate md = A.show;
            // добавление метода в список вызово экз делегата:
            md+=B.show;
            // добавление экз делегата в список
            // обработчиков события:
            obj.MyEvent+=md;
            // генерирование события:
            obj.RaiseMyEvent("6 event");
        }
    }
}
