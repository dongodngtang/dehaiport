using System.Data;
using System.Data.SQLite;
using System.Text;
using TomorrowSoft.DBUtility;

namespace TomorrowSoft.DAL
{
    public class MessageIndexRepository
    {
        public bool Add(string mesIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MessageIndex(");
            strSql.Append("MessageIndex )");
            strSql.Append(" values (");
            strSql.Append("@MessageIndex )");
            SQLiteParameter[] parameters = {
				
					new SQLiteParameter("@MessageIndex", DbType.String),
					
				};
            parameters[0].Value = mesIndex;
            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);
            return rows > 0;
        }

        public DataTable GetAll()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MessageIndex");
            strSql.Append(" FROM MessageIndex");
            return DbHelperSQLite.Query(strSql.ToString()).Tables[0];
        }
        public void Delete()
        {
            string strSql = "DELETE FROM MessageIndex";
            DbHelperSQLite.ExecuteSql(strSql);
        }
    }
}