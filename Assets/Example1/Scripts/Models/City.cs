using System;
namespace Example1.Models
{
    public class City : ISelectable
    {
        private string name;
        private int id;
        public City(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public string GetDisplayName()
        {
            return name;
        }

        public int GetId()
        {
            return id;
        }
    }
}



