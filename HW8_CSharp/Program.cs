using System;

namespace HW8_CSharp
{
    class Program
    {
        


        static void Main(string[] args)
        {
            // +1.   Разработать класс в соответствии с полученным вариантом.                                

            // +2.   Реализовать не менее пяти закрытых полей (различных типов), представляющих
            //      основные характеристики рассматриваемого класса.

            // +3.   Создать не менее трех методов управения классом и методы доступа к его закрытым полям.

            // 4.   Создать метод, в который передаются аргументы по ссылке.

            // +5.   Создать не менее двух статических полей (различных типов), представляющих
            //      общие характеристики объектов данного класса.

            // 6.   Обязательным требованием является реализация нескольких перегруженных конструкторов,
            //      аргументы которых определяются студентом, исходя из специфики реализуемого класса, 
            //      а так же реализация конструктора по умолчанию.

            // +7.   Создать статический конструктор.

            // 8.   Создать массив (не менее 5 элементов) объектов созданного класса.

            // +9.   Создать дополнительный метод для данного класса в другом файле, используя ключевое 
            //      слово partial.

            CarrierRocket launcher1 = new CarrierRocket();
           
            CarrierRocket launcher2 = new CarrierRocket("Falcon", 2344,60000,true,true,false,CarrierType.ORBITAL,CountryOfOrigin.USA);
            CarrierRocket launcher3 = new CarrierRocket("Souz", 2344,34000,false,false,false,CarrierType.SUBORBITAL,CountryOfOrigin.RUSSIA);
            CarrierRocket launcher4 = new CarrierRocket("Proton", 2344,50000,false,false,false,CarrierType.ORBITAL,CountryOfOrigin.RUSSIA);
            CarrierRocket launcher5 = new CarrierRocket("StarShip", 2244,6000,true,true,true,CarrierType.INTERSTELLAR,CountryOfOrigin.USA);
            

            launcher2.Launched(launcher2);

            CarrierRocketPool group = new CarrierRocketPool();
            group.AddRocket(launcher1);
            group.AddRocket(launcher2);
            group.AddRocket(launcher3);
            group.AddRocket(launcher4);
            group.AddRocket(launcher5);


            Console.WriteLine(group.ToString());



        }
    }
}
