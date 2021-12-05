using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraveyardMS
{
    class VisitorDataAccess:AdminPerson
    {
        public List<Visitor> GetVisitors()
        {
            string sql = "SELECT * FROM Visitors";
            SqlDataReader reader = this.GetData(sql);
            List<Visitor> visitors = new List<Visitor>();
            while (reader.Read())
            {
                Visitor visitor = new Visitor();
                visitor.VisitorId = (int)reader["VisitorId"];
                visitor.Divison = reader["Divison"].ToString();
                visitor.Place = reader["Place"].ToString();
                visitor.Payment = reader["Payment"].ToString();
                visitor.District = reader["District"].ToString();
                visitors.Add(visitor);
            }
            return visitors;
        }

        public Visitor GetVisitorById(int visitorId)
        {
            string sql = "SELECT * FROM Visitors WHERE VisitorId=" + visitorId;
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                reader.Read();
                Visitor visitor = new Visitor();
                visitor.VisitorId = (int)reader["VisitorId"];
                visitor.Divison = reader["Divison"].ToString();
                visitor.Place = reader["Place"].ToString();
                visitor.Payment = reader["Payment"].ToString();
                visitor.District = reader["District"].ToString();
                return visitor;
            }
            else
                return null;
        }

        public bool CreateVisitor(string visitorDivison, string visitorPlace, string visitorPayment, string visitorDistrict)
        {
            string sql = "INSERT INTO Visitors(Divison,Place,Payment,District) VALUES('" + visitorDivison + "', '"+ visitorPlace + "','" + visitorPayment + "','" + visitorDistrict + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }
     
        public bool UpdateVisitor(int VisitorId, string Divison, string Place, string Payment, string District)
        {
            string sql = "UPDATE Visitors SET Divison='" + Divison + "',Place='"+Place+"',Payment='"+Payment+"',District='"+District+"' WHERE VisitorId=" + VisitorId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }
        public bool DeleteVisitor(int visitorId)
        {
            string sql = "DELETE FROM Visitors WHERE VisitorId=" + visitorId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }
       /* public List<string> GetCategoryNames()
        {
            string sql = "SELECT CategoryName FROM Categories";
            SqlDataReader reader = this.GetData(sql);
            List<string> categories = new List<string>();
            while (reader.Read())
            {
                categories.Add(reader["CategoryName"].ToString());
            }
            return categories;
        }
        public Category GetCategoryByName(string categoryName)
        {
            string sql = "SELECT * FROM Categories WHERE CategoryName='" + categoryName + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                reader.Read();
                Category category = new Category();
                category.CategoryId = (int)reader["CategoryId"];
                category.CategoryName = reader["CategoryName"].ToString();
                return category;
            }
            else
                return null;
        }*/

    }
}
