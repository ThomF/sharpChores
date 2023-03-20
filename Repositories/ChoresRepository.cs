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
        internal Chore GetOneChore(int id)
        {
            Chore chore = dbChores.Find(chore => chore.Id == id);
            return chore;
        }

        internal Chore CreateChore(Chore choreData)
        {
            choreData.Id = dbChores[dbChores.Count - 1].Id + 1;
            dbChores.Add(new Chore(choreData.Name, choreData.Time , choreData.Location, choreData.Id));
            return choreData;
        }

        internal bool RemoveChore(int choreId)
        {
            int count = dbChores.RemoveAll(chore => chore.Id == choreId);
            return count > 0;
        }
    }
