using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Musteri = new MyDictionary<int, string>();
            Musteri.Add(1, "Çağrı");
            Musteri.Add(2, "Burak");
            Musteri.Add(3, "Elif");
            Musteri.Add(4, "Nihan");
            Musteri.List();
        }

        class MyDictionary<Tkey,Tvalue>
        {
            Tkey[] _key;
            Tvalue[] _value;
            Tkey[] _tempKey;
            Tvalue[] _tempValue;

            public MyDictionary()
            {
                _key = new Tkey[0];
                _value = new Tvalue[0];
            }
            public void Add(Tkey item, Tvalue item2)
            {
                _tempKey = _key;
                _key = new Tkey[_key.Length+1];
                for (int i = 0; i < _tempKey.Length; i++)
                {
                    _key[i] = _tempKey[i];
                }
                _key[_key.Length - 1] = item;

                _tempValue = _value;
                _value = new Tvalue[_value.Length + 1];
                for (int i = 0; i < _tempValue.Length; i++)
                {
                    _value[i] = _tempValue[i];
                }
                _value[_value.Length - 1] = item2;
                
            }
            public void List()
            {
                for (int i = 0; i < _key.Length; i++)
                {
                    Console.WriteLine(_key[i]+": "+_value[i]);
                }
            }


        }
    }
}
