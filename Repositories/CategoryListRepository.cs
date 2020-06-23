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
    public class CategoryListRepository : ICategoryList<CategoryList>, IDisposable
    {
        DataAccess dataAccess;
        public CategoryListRepository()
        {
            dataAccess = new DataAccess();
        }

        public List<CategoryList> GetAll()
        {
            try
            {
                string sql = "SELECT * FROM ItemCategory";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<CategoryList> cat = new List<CategoryList>();
                while (reader.Read())
                {
                    CategoryList catList = new CategoryList();
                    catList.Id = (int)reader["Id"];
                    catList.CategoryName = reader["Category_Name"].ToString();
                    cat.Add(catList);
                }
                return cat;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public CategoryList Get(int id)
        {
            try
            {
                string sql = "SELECT * FROM ItemCategory WHERE Id=" + id;
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                CategoryList catList = new CategoryList();
                catList.Id = (int)reader["Id"];
                catList.CategoryName = reader["Category_Name"].ToString();
                dataAccess.Dispose();
                return catList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public CategoryList Get(string name)
        {
            try
            {
                string sql = "SELECT * FROM ItemCategory WHERE Category_Name='" + name + "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                CategoryList catList = new CategoryList();
                catList.Id = (int)reader["Id"];
                catList.CategoryName = reader["Category_Name"].ToString();
                dataAccess.Dispose();
                return catList;
            }
            catch (Exception)
            {
                return null;
            }
        }

      

        public int Insert(CategoryList entity)
        {
            try
            {
                string sql = "INSERT INTO ItemCategory(Category_Name) VALUES('" + entity.CategoryName + "')";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Update(CategoryList entity)
        {
            try
            {
                dataAccess = new DataAccess();
                string sql = "UPDATE ItemCategory SET Category_Name='" + entity.CategoryName + "'  WHERE Id=" + entity.Id;
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
