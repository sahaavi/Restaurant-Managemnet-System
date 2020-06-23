using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Interfaces;
using System.Data.SqlClient;

namespace Repositories
{
    public class PosRepository : IPos<Pos>, IDisposable
    {
        DataAccess dataAccess;
        public PosRepository()
        {
            dataAccess = new DataAccess();
        }

        public int Insert(Pos entity)
        {
            try
            {
                string sql = "INSERT INTO Sales(Item_Id,Name,Price,Quantity,Discount,Total_Amount,Payment_Type,Sale_Date,Customer_Id,Cashier_Name) VALUES('" + entity.ItemId + "','" + entity.Name + "','" + entity.Price + "','" + entity.Quantity + "','" + entity.Discount + "','" + entity.TotalAmount + "','" + entity.PaymentType + "','" + entity.SaleDate + "','" + entity.CustomerId + "','" + entity.CashierName + "')";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
