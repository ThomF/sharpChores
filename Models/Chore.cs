using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sharpChores.Models
{
    public class Chore
    {
        public Chore(string name, int time, string location, int id)
        {
            Name = name;
            Time = time;
            Location = location;
            Id = id;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Time { get; set; }
        public string Location { get; set; }
        public bool Done { get; private set; } = false;

        // public void Done()
        // {
        // this.Done = true;
        // }
    }
}