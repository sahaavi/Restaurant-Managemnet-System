using Entities;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CategoryRepository:IRepository<Category>,IDisposable
    {
        DataAccess dataAccess;
        public CategoryRepository()
        {
            dataAccess = new DataAccess();
        }
        public List<Category> GetAll()
        {
            try
            {
                string sql = "SELECT * FROM Purchase_Category";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<Category> categories = new List<Category>();
                while (reader.Read())
                {
                    Category category = new Category();
                    category.Id = (int)reader["Id"];
                    category.Category_Name = reader["Category_Name"].ToString();
                    categories.Add(category);
                }
                return categories;
            }
            catch (Exception)
            { return null; }
        }

        public Category Get(int id)
        {
            try
            {
                string sql = "SELECT * FROM Purchase_Category WHERE Id=" + id;
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                Category category = new Category();
                category.Id = (int)reader["Id"];
                category.Category_Name = reader["Category_Name"].ToString();
                dataAccess.Dispose();
                return category;
            }
            catch (Exception)
            { return null;  }
        }

        public Category Get(string name)
        {
            try
            {
                string sql = "SELECT * FROM Purchase_Category WHERE Category_Name='" + name + "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                Category category = new Category();
                category.Id = (int)reader["Id"];
                category.Category_Name = reader["Category_Name"].ToString();
                return category;
            }
            catch (Exception)
            { return null; }
        }

        public int Insert(Category entity)
        {
            try
            {
                string sql = "INSERT INTO Purchase_Category(Category_Name) VALUES('" + entity.Category_Name + "')";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            { return 0; }
        }

        public int Update(Category entity)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE Purchase_Category SET Category_Name='" + entity.Category_Name + "' WHERE Id=" + entity.Id;
            return dataAccess.ExecuteQuery(sql);
        }

        //public int Delete(int id)
        //{

        //    string sql = "DELETE FROM Categories WHERE Id="+id;
        //    return dataAccess.ExecuteQuery(sql);
        //}

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
