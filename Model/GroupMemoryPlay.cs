using System;

namespace TomorrowSoft.Model
{
	/// <summary>
	/// GroupMemoryPlay:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class GroupMemoryPlay
	{
		public GroupMemoryPlay()
		{}
		#region Model
		private int _id;
		private string _groupname;
		private string _termianlname;
		private string _terminalno;
		private double? _playdelay;
		private int? _playtimes;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GroupName
		{
			set{ _groupname=value;}
			get{return _groupname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TerminalName
		{
			set{ _termianlname=value;}
			get{return _termianlname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TerminalNo
		{
			set{ _terminalno=value;}
			get{return _terminalno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? PlayDelay
		{
			set{ _playdelay=value;}
			get{return _playdelay;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PlayTimes
		{
			set{ _playtimes=value;}
			get{return _playtimes;}
		}
        public string Music { get; set; }
        public string PlayStyle { get; set; }
        public string PlayMinute { get; set; }
		#endregion Model

	}
}

