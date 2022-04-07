using System;
using System.Collections.Generic;

namespace CustomCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime JTime = new DateTime (1996, 01, 23);
            PrLanguages Java = new PrLanguages("Java", JTime);

            DateTime PTime = new DateTime(1991, 02, 20);
            PrLanguages Python = new PrLanguages("Python",PTime);

            DateTime CTime = new DateTime(2002, 12, 12);
            PrLanguages CSharp = new PrLanguages("C#", CTime);

            DateTime RTime = new DateTime(1996, 12, 25);
            PrLanguages Ruby = new PrLanguages("Ruby", RTime);

            DateTime JsTime = new DateTime(1996, 12, 25);
            PrLanguages JS = new PrLanguages("Java Script", JsTime);


            MyList<PrLanguages> LangList= new MyList<PrLanguages>();
            LangList.AddLang(Python);
            LangList.AddLang(CSharp);
            LangList.AddLang(Java);
            LangList.AddLang(Ruby);
            LangList.AddLang(JS);


            //LangList.NameSort();
            LangList.DateSort();


            foreach (PrLanguages lang in LangList.Languages)
            {
                Console.WriteLine($"{lang.Name}\n{lang.ReleaseDate}\n");
            }
        }

    }

}
