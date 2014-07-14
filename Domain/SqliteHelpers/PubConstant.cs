using System.Configuration;

namespace Domain.SqliteHelpers
{
    public class PubConstant
    {
        public static string ConnectionString
        {
            get { string connetionString = ConfigurationManager.AppSettings["ConnetionString"];
                return connetionString;
            }
        } 
    }
}