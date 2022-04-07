using System;

namespace CustomCollection
{
    class MyList<T> where T : PrLanguages
    {
        public T[] Languages;

        public MyList()
        {
            Languages = new T[0];
        }

        public void AddLang(T language)
        {
            Array.Resize(ref Languages, Languages.Length + 1);
            Languages[Languages.Length - 1] = language;
        }

        public void DateSort()
        {
            PrLanguages temp = new PrLanguages(null, new DateTime());
            for (int i = 0; i < Languages.Length; i++)
            {
                for (int j = i + 1; j < Languages.Length; j++)
                {
                    if (Languages[j].ReleaseDate < Languages[i].ReleaseDate)
                    {
                        temp = Languages[i];
                        Languages[i] = Languages[j];
                        Languages[j] = (T)temp;
                    }
                }
            }
        }

        public void NameSort()
        {
            for (int i = 0; i < Languages.Length; i++)
            {
                for (int j = i + 1; j < Languages.Length; j++)
                {
                    Array.Sort(Languages, (x, y) => String.Compare(x.Name, y.Name));
                }
            }
        }
    }

}
