using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Repositories;

namespace Services
{
    public class PosService
    {
        PosRepository posRepo;
        public PosService()
        {
            posRepo = new PosRepository();
        }

        public int Insert(Pos sale)
        {
            return posRepo.Insert(sale);
        }

    }
}
