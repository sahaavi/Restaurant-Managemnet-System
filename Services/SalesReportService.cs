using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Repositories;

namespace Services
{
    public class SalesReportService
    {
        SalesReportRepository salesRepo;
        public SalesReportService()
        {
            salesRepo = new SalesReportRepository();
        }

        public List<Pos> GetAllSales()
        {
            return salesRepo.GetAll();
        }
        public List<Pos> GetAllDate(DateTime date1, DateTime date2)
        {
            return salesRepo.GetAllDate(date1, date2);
        }
        public List<Pos> GetAllItem(string name)
        {
            return salesRepo.GetAllItem(name);
        }
        public Pos GetById(int id)
        {
            return salesRepo.Get(id);
        }
        public Pos GetByName(string name)
        {
            return salesRepo.Get(name);
        }
    }
}
