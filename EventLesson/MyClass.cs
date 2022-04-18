using System;
using System.Collections.Generic;
using System.Text;

namespace EventLesson 
{
    internal class MyClass
    {
        //объявление события
        public event MyDelegate MyEvent;
        
        //метод для генерирования события
        public void RaiseMyEvent(string txt)
        {
            //если для события предусмотрены обработчики:
            if (MyEvent!=null)
            {
                //генерирование события:
                MyEvent(txt);
            }
        }
    }
}
