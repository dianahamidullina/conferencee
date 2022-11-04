using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace conferencee
{
    public class Boris { }
    class Rashid : Boris { } //finance director
    class Lukas : Rashid { }
    class Buh : Lukas { }
    class OIlham : Boris { } // automatisation director
    class Orcadiy : OIlham { }
    class Volodya : Orcadiy { }
    class Ilshat : Volodya { } // system
    class Ivanich : Ilshat { }
    class Ilya : Ivanich { }
    class Vitya : Ivanich { }
    class Jeka : Ivanich { }
    class Sergey : Volodya { }// development
    class Lyasan : Sergey { }
    class Marat : Lyasan { }
    class Dina : Lyasan { }
    class Ildar : Lyasan { }
    class Anton : Lyasan { }
    internal class Program

    {
        static void spisok()
        {
            string path = (@"C:\Users\Diana\source\repos\conferencee\conferencee\TextFile1.txt");

            string text = File.ReadAllText(path);
            Console.WriteLine($"{text}");
        }
        static void Otvet(Type a, Type b)
        {
            if (a.IsSubclassOf(b)) { Console.WriteLine("Yes"); } // проверяем является ли классы наследниками друг друга
            else { Console.WriteLine("No"); }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Озакомьтесь с сотрудниками офиса:");
            spisok();
            Console.WriteLine("Введите от кого хотите дать задачу (на английском)");
            string cto= Console.ReadLine();
            Console.WriteLine("Введите кому хотите дать задачу (на английском)");
            string comy = Console.ReadLine();
            Console.WriteLine("Введите название задачи");
            string what = Console.ReadLine();
            Type C = Type.GetType("conferencee" + "." + cto, false, true); // получаем типы классов по имени(строке)
            Type C2 = Type.GetType("conferencee" + "." + comy, false, true);
            Console.WriteLine($"Итак, от {cto} дана задача {what}  для {comy}.");
            Console.WriteLine("Ответ сотрудника:");
            Otvet(C2, C);
        }
    }
}