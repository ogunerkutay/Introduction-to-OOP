using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegateSample
{
    internal class Program
    {
        delegate void MessageGosterHandler();
        delegate string MessageHandler();
        delegate int IslemYapHandler(int a, int b);
        delegate int IslemlerHandler(int x, int y);
        static void Main(string[] args)
        {
            //MessageGoster();
            //MessageGosterHandler messageGosterHandler = new MessageGosterHandler(MessageGoster);
            //messageGosterHandler();
            //messageGosterHandler.Invoke();

            //MessageHandler messageHandler = new MessageHandler(Message);
            //string _message = messageHandler.Invoke();
            //Console.WriteLine(_message);

            //IslemYapHandler islemYapHandler = new IslemYapHandler(Toplam);
            //Random random = new Random();
            //int x = random.Next(0, 100);
            //int y = random.Next(100, 200);
            //int toplam = islemYapHandler.Invoke(x,y);
            //Console.WriteLine(toplam);

            IslemlerHandler islemlerHandler = new IslemlerHandler(Toplama);
            islemlerHandler += Cikarma;
            islemlerHandler += Carpma;
            islemlerHandler += Bolme;
            islemlerHandler -= Bolme;
            islemlerHandler -= Carpma;
            int _result = islemlerHandler.Invoke(80, 20);
            Console.WriteLine(_result);

            Delegate[] _islemList = islemlerHandler.GetInvocationList();
            foreach (Delegate item in _islemList)
            {
                Console.WriteLine($"Metot Adı : {item.Method.Name}");
                Console.WriteLine($"Metot Dönüş Tipi : {item.Method.ReturnType}");
                Console.WriteLine($"Metot private mi? : {item.Method.IsPrivate}");
                Console.WriteLine($"Metot public mi : {item.Method.IsPublic}");
                Console.WriteLine($"Metot static mi : {item.Method.IsStatic}");
                Console.WriteLine($"Metot constructor mu : {item.Method.IsConstructor}");
                ParameterInfo[] _paramsInfo = item.Method.GetParameters();
                foreach (ParameterInfo parameterInfo in _paramsInfo)
                {
                    Console.WriteLine($"{parameterInfo.Name} - {parameterInfo.ParameterType} - {parameterInfo.IsOptional} - {parameterInfo.IsOut}");
                }

                int result = (int)item.DynamicInvoke(80, 20);
                Console.WriteLine($"{item.Method.Name} işlemi sonucu : {result}");
                Console.WriteLine(new String('*',100));
            }

        }


        static int Toplama(int x, int y)
        {
            return x + y;
        }

        static int Cikarma(int x, int y)
        {
            return x - y;
        }

        static int Carpma(int x, int y)
        {
            return x * y;
        }

        static int Bolme(int x, int y)
        {
            return x / y;
        }


        private static int Toplam(int x, int y)
        {
            int _result = x + y;
            return _result;
        }
        static string Message()
        { string _msg = "Hello World!";
            return _msg;
        }



    private static void MessageGoster()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
