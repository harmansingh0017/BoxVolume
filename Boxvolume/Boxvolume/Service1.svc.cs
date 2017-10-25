using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Boxvolume
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private const string connectionstring = "Server=tcp:mstempagain.database.windows.net,1433;Initial Catalog=mstempagagin;Persist Security Info=False;User ID= harmans ;Password= barcam10@ ;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
 

 

        public double GetSide(double Volume, double side1, double side2)
        {
            double x;
            return x = Volume / (side1 * side2);
        }

        public double GetVolume(double Length, double Width, double Height)
        {
            double volume = Length * Width * Height;
            const string insertvolume = "insert into Boxvolume (Volume, Length , Widht , Height) values (@Volume,  @Lenght , @Widht ,@Height)";
            using (SqlConnection databaseConnection = new SqlConnection(connectionstring))
            {
                databaseConnection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertvolume, databaseConnection))
                {
                    insertCommand.Parameters.AddWithValue("@Volume", volume);
                    insertCommand.Parameters.AddWithValue("@Lenght", Length);
                    insertCommand.Parameters.AddWithValue("@Widht", Width);
                    insertCommand.Parameters.AddWithValue("@Height", Height);


                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }

        
    }
}
