using System.Collections.Generic;

namespace Places.Models
{
    public class Item
    {
        public string CityName { get; set; }
        public string Date { get; set; }
        public string Days { get; set; }
        public string Partner { get; set; }
        public string Journal { get; set; }
        public int Id { get; }
        private static List<Item> _instances = new List<Item> { };

        public Item(string cityName, string date, string days, string partner, string journal)
        {
            CityName = cityName;
            Date = date;
            Days = days;
            Partner = partner;
            Journal = journal;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Item> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Item Find(int searchId)
        {
            return _instances[searchId - 1];
        }
    }
}