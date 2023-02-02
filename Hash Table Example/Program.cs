using System;
using System.Collections;
using System.Collections.Generic;

namespace Hash_Table_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Hashtable
            ////Çok büyük datalarda hashtable kullanma 100 milyar baloncuk seviyesinde

            //Hashtable _htCities = new Hashtable();
            //_htCities.Add(1,"Adana");
            //_htCities.Add(6, "Ankara");
            //_htCities.Add(7, "Antalya");
            //_htCities.Add(34, "İstanbul");
            //_htCities.Add(35, "İzmir");
            //_htCities.Add(28, "Giresun");
            //_htCities.Add(61, "Trabzon");

            ////Count Methodu
            //Console.WriteLine($"_htCities Eleman Sayısı : {_htCities.Count}");

            ////Remove Methodu
            //_htCities.Remove(6);
            //Console.WriteLine($"_htCities Eleman Sayısı : {_htCities.Count}");

            ////Contains,ContainsKEy,ContainsValue Methodları
            //bool _result_1 = _htCities.ContainsKey(34);
            //bool _result_2 = _htCities.ContainsKey(6);
            //bool _result_3 = _htCities.ContainsValue("Ankara");
            //bool _result_4 = _htCities.ContainsKey(100);

            ////Keys ve Valus Methodları
            //Console.WriteLine("HashTable Keys");
            //ICollection _keys = _htCities.Keys;
            //foreach (var key in _keys)
            //{
            //    Console.WriteLine(key);
            //}

            //Console.WriteLine("HashTable Values");
            //ICollection _values = _htCities.Values;
            //foreach (var value in _values)
            //{
            //    Console.WriteLine(value);
            //}

            //Console.WriteLine("Key ve Value");
            //foreach (var key in _keys)
            //{
            //    Console.WriteLine($"{key} : {_htCities[key].ToString()}");
            //}

            ////En hızlı yöntem
            //Console.WriteLine("DictionaryEntry Kullanarak HashTable Key ve Value Değerlerine Erişim");
            ////DictionaryEntry de = new DictionaryEntry();
            //foreach (DictionaryEntry _de in _htCities)
            //{
            //    Console.WriteLine($"{_de.Key} : {_de.Value}");
            //}

            ////dictionary için keyvalue pair
            ////hashtable için dictionaryentry


            ////Clone Methodu
            //object _htNewCitiesObject = _htCities.Clone();
            //Hashtable _htNewCities = (Hashtable)_htNewCitiesObject;
            //foreach (DictionaryEntry _de in _htNewCities)
            //{
            //    Console.WriteLine($"{_de.Key} : {_de.Value}");
            //}

            ////CopyTo Methodu
            //Array _htCitiesMembers = new DictionaryEntry[_htCities.Count];
            //_htCities.CopyTo(_htCitiesMembers,3);




            //Clear Methodu
            //_htCities.Clear();
            //Console.WriteLine($"_htCities Eleman Sayısı : {_htCities.Count}");
            #endregion

            #region SortedList

            //SortedList _htCities = new SortedList();

            //_htCities.Add(1, "Adana");
            //_htCities.Add(6, "Ankara");
            //_htCities.Add(7, "Antalya");
            //_htCities.Add(34, "İstanbul");
            //_htCities.Add(35, "İzmir");
            //_htCities.Add(28, "Giresun");
            //_htCities.Add(61, "Trabzon");
            //_htCities[16] = "Bursa";
            //_htCities[16] = "Malatya";


            //Console.WriteLine("-----------------Elemanların Eklenmesi------------");
            //Console.WriteLine($"Eleman Sayısı : {_htCities.Count}");
            //Console.WriteLine($"Kapasite Sayısı : {_htCities.Capacity}");
            //_htCities.TrimToSize();

            ////_htCities.Clear();

            //Console.WriteLine("Keys Değerleri");
            //ICollection _keys = _htCities.Keys;
            //foreach (var key in _keys)
            //{
            //    Console.WriteLine(key);
            //}

            //Console.WriteLine("Value Değerleri");
            //ICollection _values = _htCities.Values;
            //foreach (var value in _values)
            //{
            //    Console.WriteLine(value);
            //}

            //Console.WriteLine("Tüm Değerleri key value çifti olarak erişmek");
            //foreach (var key in _keys)
            //{
            //    Console.WriteLine($"{key} : {_htCities[key].ToString()}");
            //}

            //Console.WriteLine("DictionaryEntry Kullanımı");
            //foreach (DictionaryEntry _de in _htCities)
            //{
            //    Console.WriteLine($"{_de.Key} - {_de.Value}");
            //}

            ////Contains, ContainsKey, ContainsValue
            //bool _result_1 = _htCities.Contains(34);
            //bool _result_2 = _htCities.ContainsKey(6);
            //bool _result_3 = _htCities.ContainsValue("İzmir");

            ////Remove ve RemoveAt Metotları
            //_htCities.Remove(6);
            //_htCities.RemoveAt(0);

            ////IndexOfKey ve IndexOfValue Metotları
            //int _indexKey_1 = _htCities.IndexOfKey(34);
            //int _indexKey_2 = _htCities.IndexOfKey(100);
            //int _indexValue_1 = _htCities.IndexOfValue("Ankara");
            //int _indexValue_2 = _htCities.IndexOfValue("Malatya");

            ////GetByIndex Metodu
            //int _index = _htCities.IndexOfValue("İzmir");
            //string _value = _htCities.GetByIndex(_index).ToString();
            //Console.WriteLine($"{_index} e ait Value : {_value}");

            ////SetByIndex Metodu
            //_htCities.SetByIndex(5,"Malatya");

            ////Clone Metodu
            //object _htCitiesObject = _htCities.Clone();
            //SortedList _htNewCities = (SortedList)_htCitiesObject;
            //foreach (DictionaryEntry _de in _htNewCities)
            //{
            //    Console.WriteLine($"{_de.Key} : {_de.Value}");
            //}

            //CopyTo Metodu
            //Array _htNewCities = new DictionaryEntry[_htCities.Capacity];
            //_htCities.CopyTo(_htNewCities, 4);
            //foreach (DictionaryEntry _de in _htNewCities)
            //{
            //    Console.WriteLine($"{_de.Key} : {_de.Value}");
            //}
            #endregion

            #region List

            //List<string> _cities = new List<string>();
            //Console.WriteLine("Eleman Eklenmeden Önceki Count ve Capacity Değerleri");
            //Console.WriteLine($"Eleman Sayısı : {_cities.Count}");
            //Console.WriteLine($"Kapasite Sayısı : {_cities.Capacity}");

            //_cities.Add("İzmir");
            //Console.WriteLine("Bir Eleman Eklendikten Sonraki Count ve Capacity Değerleri");
            //Console.WriteLine($"Eleman Sayısı : {_cities.Count}");
            //Console.WriteLine($"Kapasite Sayısı : {_cities.Capacity}");

            //_cities = new List<string>{ "İzmir", "Çanakkale", "Samsun", "Ordu" };
            //_cities.Add("İzmir");
            //_cities.Add("Çanakkale");
            //_cities.Add("Samsun");
            //_cities.Add("Ordu");
            //_cities.Add("Adana");

            //string[] _citiesArray = new string[] {"Manisa","Muğla","Antalya","İstanbul"};
            //_cities.AddRange(_citiesArray);

            //Console.WriteLine($"Eleman Sayısı : {_cities.Count}");
            //Console.WriteLine($"Kapasite Sayısı : {_cities.Capacity}");
            //_cities.TrimExcess();
            //Console.WriteLine($"Eleman Sayısı : {_cities.Count}");
            //Console.WriteLine($"Kapasite Sayısı : {_cities.Capacity}");
            //_cities.Clear();
            //Console.WriteLine($"Eleman Sayısı : {_cities.Count}");
            //Console.WriteLine($"Kapasite Sayısı : {_cities.Capacity}");

            //Contains Metodu
            //bool _result_1 = _cities.Contains("Antalya");
            //bool _result_2 = _cities.Contains("Bursa");

            ////Sort ve Reverse Metotları
            //_cities.Sort();

            //Console.WriteLine("Sıralanmış Şekli");
            //foreach (string item in _cities)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(new String('-', 100));

            //_cities.Reverse();
            //foreach (string item in _cities)
            //{
            //    Console.WriteLine(item);
            //}

            //IndexOf ve LastIndexOf
            //int _result_1 = _cities.IndexOf("Antalya");
            //_cities.Add("Antalya");
            //int _result_2 = _cities.LastIndexOf("Antalya");


            //Insert ve InsertRange
            //_cities.Insert(3,"Malatya");
            //_cities.InsertRange(5, new string[] { "Mersin", "Eskişehir", "Tokat" });

            ////Remove, RemoveAt, RemoveRange
            //bool _result_1 = _cities.Remove("Tokat");
            //bool _result_2 = _cities.Remove("Ağrı");

            //_cities.RemoveAt(0);

            //_cities.RemoveRange(2,2);

            //GetRange
            //List<string> _newCities = _cities.GetRange(2,4);

            //CopyTo Metodu
            //string[] _newCities = new string[25];
            //_cities.CopyTo(_newCities);
            //_cities.CopyTo(_newCities, 5);
            //_cities.CopyTo(4,_newCities,6,4);

            //ToArray Metodu
            //string[] _newCities = _cities.ToArray();



            #endregion


            #region HashSet

            //HashSet<int> _numbers = new HashSet<int>();

            //_numbers.Add(100);
            //_numbers.Add(200);
            //_numbers.Add(300);
            //_numbers.Add(400);
            //_numbers.Add(500);

            //Count Metodu
            //Console.WriteLine($"Eleman Sayısı : {_numbers.Count}");

            //Clear Metodu
            //_numbers.Clear();
            //Console.WriteLine($"Eleman Sayısı : {_numbers.Count}");

            //Remove Metodu
            //bool _result_1 = _numbers.Remove(100);
            //bool _result_2 = _numbers.Remove(10000);

            //Contains Metodu
            //bool _result_1 = _numbers.Remove(100);
            //bool _result_2 = _numbers.Contains(600);

            //CopyTo
            //int[] _newNumbers = new int[10];
            //_numbers.CopyTo(_newNumbers);
            //_numbers.CopyTo(_newNumbers,3);
            //_numbers.CopyTo(_newNumbers,2,3);

            #endregion


            #region Stack

            //LAST IN FIRST OUT LIFO SYSTEM

            //Stack<int> stack = new Stack<int>();  /İNT 

            //Stack _visitedSitees = new Stack(); //OBJECT 

            //Stack<string> _visitedSites = new Stack<string>();

            ////Push metodu Listeye eleman eklemek için kullanılır
            //_visitedSites.Push("www.google.com");
            //_visitedSites.Push("www.onedio.com");
            //_visitedSites.Push("www.stackoverflow.com");
            //_visitedSites.Push("www.csharpnedir.com");

            ////Count methodu
            //Console.WriteLine($"Eleman sayısı : {_visitedSites.Count}");

            ////Elemanların yazdırılması
            //foreach (var item in _visitedSites)
            //{
            //    Console.WriteLine(item);
            //}

            ////Listedeki son elemana ulaşır ve listeden siler
            //string item2 = (string)_visitedSites.Pop();    
            
            //Console.WriteLine(item2);


            ////Listedeki son eklenen elemana ulaşır ve listeden silmez
            //_visitedSites.Peek().ToString();

            ////Clear Metodu
            //_visitedSites.Clear();

            ////Contains
            //bool _result_1 = _visitedSites.Contains("www.google.com");
            //bool _result_2 = _visitedSites.Contains("Sample Text");

            //string item3;
            //bool _resul_3 = _visitedSites.TryPop(out item3); //.NET Core fonksiyonu

            //bool _resul_4 = _visitedSites.TryPeek(out item3); //.NET Core fonksiyonu

            ////ToArray
            //string[] _array = _visitedSites.ToArray();


            ////CopyTo
            //string[] _array2 = new string[10];
            //_visitedSites.CopyTo(_array2, 4);


            #endregion

            //FIRST IN FIRST OUT FIFO SYSTEM
            //RabbitMQ, SQS AMAZON AWS, Azure service bus
            //Apache Kafka, Kafka Cominty 2milyon per sec
            #region Queue

            //Queue numbers = new Queue();
            //Queue<int> _numbers = new Queue<int>();
            
            ////Enqueue
            //_numbers.Enqueue(100);
            //_numbers.Enqueue(200);
            //_numbers.Enqueue(300);
            //_numbers.Enqueue(400);
            //_numbers.Enqueue(500);

            ////Dequeue
            //int _item = _numbers.Dequeue();
            //while (_item != 0)
            //{
            //    Console.WriteLine(_item);
            //    try
            //    {
            //        _item = _numbers.Dequeue();
            //    }
            //    catch (InvalidOperationException _invalid)
            //    {
            //        _item = 0;
            //    }
            //}

            ////Peek
            //int _item2 = _numbers.Peek();

            ////Clear
            //_numbers.Clear();

            ////Contains
            //bool _resul_1 = _numbers.Contains(200);
            //bool _resul_2 = _numbers.Contains(400);
            //bool _resul_3 = _numbers.Contains(1000);

            ////trydeque
            //int _item3;
            //bool _result_4 = _numbers.TryDequeue(out _item3); //.NET Core

            ////trypeek
            //int _item4;
            //bool _result_5 = _numbers.TryPeek(out _item4); //.NET Core

            ////ToArray
            //int[] _numberArray = _numbers.ToArray();

            ////CopyTo
            //int[] _numberArray = new int[10];
            //_numbers.CopyTo(_numberArray, 4);







            #endregion

        }
    }
}
