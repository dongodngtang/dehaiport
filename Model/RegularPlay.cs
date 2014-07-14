using System;
namespace TomorrowSoft.Model
{
	/// <summary>
	/// RegularPlay:实体类
	/// </summary>
	public  class RegularPlay
	{
        public int Id { get; set; }
        public string Time { get; set; }
        public string RegularType { get; set; }
        public string Music { get; set; }
        public string PlayType { get; set; }
        public int Status { get; set; }
        public string Phone { get; set; }
        public string PlayTimes { get; set; }
        public string TerminalName { get; set; }
	    

	    public RegularPlay(string alarmTime, string regularType, string music, 
            string playType, int status,string phone,string playtimes,string terminalName)
	    {
	        Time = alarmTime;
	        RegularType = regularType;
	        Music = music;
	        PlayType = playType;
	        Status = status;
	        Phone = phone;
	        PlayTimes = playtimes;
	        TerminalName = terminalName;
	    }
        public RegularPlay()
        {
            
        }
	}
}

