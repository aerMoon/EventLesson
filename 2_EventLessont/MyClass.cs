using System;
using System.Collections.Generic;
using System.Text;



namespace _2_EventLessont
{
    internal class MyClass
    {
        //поле - экз делегата для
        // реализации списка обработчиков события
        private MyDelegate myevent;
        
        //объявление события (с описанием аксессоров)
        public event MyDelegate MyEvent
        {
            // аксессор для добавления метода в списов обработчиков события
            add
            {
                myevent+=value;
            }
            // удаление метода через аксессор
            remove
            {
                myevent-=value;
            }
        }
        //метод для генерирования события
        public void RaiseMyEvent(string txt)
        {
            // если для события предусмотрены обработчики:
            if (myevent!=null)
            {
                // генерирование события (вызов экз делегата)
                myevent(txt);
            }
        }
    }
}
