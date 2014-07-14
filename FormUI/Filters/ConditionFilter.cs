using System;
using TomorrowSoft.BLL;
using TomorrowSoft.Model;
using FormUI.Properties;
namespace FormUI.Filters
{
    public class ConditionFilter
    {
         private static string _photovoltaic;
        private static string _battery;
         public static Condition FilterCondition(string phone,string context)
         {
             string[] result = context.Split(new[] { "光伏", "\r\n", "\n", "\r\t","电池",
             "市电","功放","喇叭1","喇叭2","喇叭3","喇叭4"}, 
             StringSplitOptions.RemoveEmptyEntries);
             var condition = new Condition()
                 {
                     PhoneNo = phone,
                     Photovoltaic = result[0],
                     Battery = result[1],
 
                     Horn1 = result[2],
                     Horn2 = result[3],
                     Horn3 = result[4],
                     Horn4 = result[5],
                     HandlerTime = DateTime.Now.ToLocalTime()
                     
                 };
             _photovoltaic = result[0].Replace( "V",string.Empty);
             _battery = result[1].Replace("V", string.Empty);

             return condition;

         }
        public static bool PhotovoltaicCompare()
        {
            var qs = new QsService().GetAll();
            if (qs.Rows.Count>0)
            {
                return (double.Parse(_photovoltaic) < Convert.ToDouble(qs.Rows[0]["QsDown"])&&
                    double.Parse( _battery )<Convert .ToDouble( Settings.Default.Battery));
            }
            return false;
        }
    }
}