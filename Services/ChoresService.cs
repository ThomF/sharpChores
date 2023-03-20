using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sharpChores.Services;

    public class ChoresService
    {
        private readonly ChoresRepository _repo;

        public ChoresService(ChoresRepository repo)
        {
            _repo = repo;
        }

        public List<Chore> GetAllChores()
        {
            return _repo.GetAllChores();
        }

    internal Chore CreateChore(Chore choreData)
    {
        Chore chore = _repo.CreateChore(choreData);
        return chore;
    }

    internal Chore FinishChore(int id)
    {
        Chore chore = this.GetOneChore(id);
        chore.Finished();
        return chore;
    }

    internal Chore GetOneChore(int id)
        {
            Chore chore = _repo.GetOneChore(id);
            if (chore == null) throw new Exception($"No Chore with that Id:{id}");
            return chore;
        }

    internal string RemoveChore(int choreId)
    {
        Chore chore = this.GetOneChore(choreId);
        bool result = _repo.RemoveChore(choreId);
        if(!result) throw new Exception("How did you get here?");
        return $"{chore.Name} Has been destroyed by the force of gravity";
    }
}
