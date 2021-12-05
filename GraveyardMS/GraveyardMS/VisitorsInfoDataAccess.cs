using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraveyardMS
{
    class VisitorsInfoDataAccess:AdminPerson
    {
        public List<User> GetVisitorsInfo()
        {
            string sql = "SELECT * FROM VisitorsInfo";
            SqlDataReader reader = this.GetData(sql);
            List<User> visitorsinfo = new List<User>();
            while (reader.Read())
            {
                User user = new User();
                user.Name = reader["VisitorId"].ToString();
                // visitor.Divison = reader["Divison"].ToString();
                // visitor.Place = reader["Place"].ToString();
                //  visitor.Payment = reader["Payment"].ToString();
                //  visitor.District = reader["District"].ToString();
                visitorsinfo.Add(user);
            }
            return visitorsinfo;
        }
    }
}
