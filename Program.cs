using Zoo;
namespace Csharp_Lessons7_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Tiger tig = new Tiger("Tom",15);
             tig.Print();

             Crocodile croc = new Crocodile("Crocs", "Meat");
             croc.Print();

             Kangaroo kang = new Kangaroo("Bibi", 2);

             kang .Print();

             Animal t2 = new Tiger("Papuas", 22);
             t2.Print();*/

            Passport my_passp = new Passport(1234, "Sergey", "Russian", 25);
            my_passp.Print("Passport");
            ForeignPassport my_for_passp = new ForeignPassport(4444, my_passp.Name, my_passp.Country, my_passp.Age,"Germany");

            my_for_passp.Print("Foreign passport");
        }
    }



    /*// наследование


    // абстрактный класс
    public abstract class CDA {

        // абстрактный метод
        public abstract void B(int x);

        // виртуальный метод
        public virtual void C() { }
    }


    public class ABC //public sealed class ABC - sealed запрещает наследоваться от этого класса
    {
        public ABC() { }
        // виртуальный метод
        public virtual void A() { }

        // абстрактный метод, обязательно должен быть в абстрактном классе
        //public abstract void B(int x);

    }

    public class BCA : ABC
    {
        // конструктор наследуется от базового конструктора
        public BCA():base() { } 

    }*/
}
