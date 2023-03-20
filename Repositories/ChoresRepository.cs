using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sharpChores.Repositories;

    public class ChoresRepository
    {
        private List<Chore> dbChores = new List<Chore>();

        public ChoresRepository()
        {
            dbChores.Add(new Chore("Sweep Floor", 10, "Kitchen", 1));
            dbChores.Add(new Chore("Dust", 3, "Living Room", 2));
        }

        internal List<Chore> GetAllChores()
        {
            return dbChores;
        }
    }
