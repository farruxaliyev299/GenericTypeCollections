using System;

namespace CustomCollection
{
    public class PrLanguages
    {
        public DateTime ReleaseDate { get; set; }

        public string Name { get; set; }

        public PrLanguages(string name,DateTime release)
        {
            Name = name;
            ReleaseDate = release;
        }
    }

}
