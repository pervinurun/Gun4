using System;

namespace Gun4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> sehirler = new MyDictionary<int, string>();
            sehirler.Add(0905, "TURKEY");
            sehirler.Add(+1, "AMERİCA");
            sehirler.Add(+7, "İzmir");
        }
    }
}
