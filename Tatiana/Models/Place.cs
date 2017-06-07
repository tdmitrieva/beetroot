using Starcounter;

namespace Tatiana.Models
{
    [Database]
    public class Place
    {
        public string Street;
        public int Number;
        public int ZipCode;
        public string City;
        public string Country;
    }
}
