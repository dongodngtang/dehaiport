using System.Data;
using System.Data.SQLite;
using System.Text;
using TomorrowSoft.DBUtility;

namespace TomorrowSoft.DAL
{
    public class QsRepository
    {
        public bool Add(string sendtime, string qs)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into QsWarning(");
            strSql.Append("SendTime,QsDown)");
            strSql.Append(" values (");
            strSql.Append("@SendTime,@QsDown)");
            SQLiteParameter[] parameters = {
				
					new SQLiteParameter("@SendTime", DbType.String),
					new SQLiteParameter("@QsDown", DbType.String)
				};

            parameters[0].Value = sendtime;
            parameters[1].Value = qs;

            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);
            return rows > 0;
        }

        public DataTable GetAll()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select SendTime,QsDown");
            strSql.Append(" FROM QsWarning");
            return DbHelperSQLite.Query(strSql.ToString()).Tables[0];
        }

        public void DeleteQs()
        {
            string strSql = "DELETE FROM QsWarning";
            DbHelperSQLite.ExecuteSql(strSql);
        }
    }
}