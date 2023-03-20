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

    }
