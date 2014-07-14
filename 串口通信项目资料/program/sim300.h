#include <STC12C5A60S2.h>

/*sim300初始化*/
void sim300Init()
{ Startsim300=0;		 
  delay(700);	                //约7s,启动sim300
  Startsim300=1;  
  delay(2000);	                //约20s
  SIO1SendStrs("ATE1");         //有回显
  SIO1SendChar(0x0d);	        //<CR>
  SIO1SendChar(0x0a);           //<LF>
  delay(3);
  SIO1SendStrs("ATE1");         //有回显
  SIO1SendChar(0x0d);	        //<CR>*/
  SIO1SendChar(0x0a);           //<LF>
  delay(3);	       
  SIO1SendStrs("ATV1");         //以OK方式回显
  SIO1SendChar(0x0d);	        //<CR>
  SIO1SendChar(0x0a);	        //<LF>
  delay(3); 
  SIO1SendStrs("AT+CLIP=1");    //来电显示
  SIO1SendChar(0x0d);	        //<CR>
  SIO1SendChar(0x0a);	        //<LF>
  delay(4);
  SIO1SendStrs("AT+CNMI=2,1");  //短信先缓存，待数据线空闲再行通知；存到默认的内存位置，且向TE发出通知
  SIO1SendChar(0x0d);	        //<CR>
  SIO1SendChar(0x0a);	        //<LF>
  delay(4);
  SIO1SendStrs("AT+CMGF=0");    //中文短信格式
  SIO1SendChar(0x0D);	        //<CR>
  SIO1SendChar(0x0a);	        //<LF>
  delay(3); 
  // ClrSIM(50);	  //删除SIM卡内所有50条短信
}

/*发送短信头*/
//入口:mhs——报文长度(10进制)百位
//     mts——报文长度(10进制)十位
//     mus——报文长度(10进制)个位,
//     cts——短信内容字节数(16进制)十位
//     cus——短信内容字节数(16进制)个位 
void SmsReplyHead(uchar mhs,uchar mts,uchar mus,uchar cts,uchar cus)
{ uchar i;
  TelPDU();     //短信号码转换为PDU格式
  SIO1SendStrs("AT+CMGS=");                           //短信发送命令
  if (mhs!='0')
    SIO1SendChar(mhs);								  //报文长度(10进制)百位
  SIO1SendChar(mts);	                              //报文长度(10进制)十位	
  SIO1SendChar(mus);	                              //报文长度(10进制)个位,共25B
  SIO1SendChar(13);	                                  //<CR>
  SIO1SendChar(10);	                                  //<LF>
  delay(3);
  SIO1SendStrs("0011000D9168");                       //报文起始码
  for (i=0;i<12;i++)
    SIO1SendChar(SMSCallInTel[i]);                    //短信回复对象   
  SIO1SendStrs("0008A0");                             //PDU08编码表、服务器保存时间
  SIO1SendChar(cts);                                  //短信内容字节数(16进制)十位
  SIO1SendChar(cus);                                  //短信内容字节数(16进制)个位  
}
					 
/*短信回复——用于0、1~2.1、1~2.2、3.1、3.2、4、9*/
//入口:mhs——报文长度(10进制)百位
//     mts——报文长度(10进制)十位
//     mus——报文长度(10进制)个位,
//     cts——短信内容字节数(16进制)十位
//     cus——短信内容字节数(16进制)个位
// Content——短信内容字符串
void SmsReply(uchar  Mhs,uchar Mts,uchar  Mus,uchar Cts,uchar Cus,uchar *Content)                              
{ SmsReplyHead(Mhs,Mts,Mus,Cts,Cus);     			  //短信头
  SIO1SendStrs(Content);                              //短信内容
  SIO1SendChar(26);	                                  //ctrl+z(报文结束)	
}

/*DTE当前状态、设置参数回复*/
//光伏电压：××.×V
//电池电压：××.×V
//工作电压：×.××V
//RDS：已开（关）
//功放电源：已开（关）
//充电电压：××~××V
//放电电压：××~××V
//音量：×级 7EA7   
void SmsReplyStatusParameters(void)
{ SmsReplyHead('1','5','5','8','C');   //短信头报文长140B,短信内容长140B
 //光伏××.×V   (带换行共18B)    
  SIO1SendStrs("51494F0F003");         //"光伏"unicode码
  SIO1SendChar(SampleResult[2]+'0'); 	               //光伏电压十位
  SIO1SendStrs("003");				               
  SIO1SendChar(SampleResult[1]+'0');	               //光伏电压个位
  SIO1SendStrs("002E003");		                   //.unicode码
  SIO1SendChar(SampleResult[0]+'0');	               //光伏电压小数点后1位
  SIO1SendStrs("0056000D000A");		               //V、<CR>、<LF>unicode码       
 //电池××.×V  (带换行共18B) 
  SIO1SendStrs("75356C60003");         //"电池"unicode码
  SIO1SendChar(SampleResult[14]+'0');  	               //电池电压十位
  SIO1SendStrs("003");				  
  SIO1SendChar(SampleResult[13]+'0'); 	               //电池电压个位
  SIO1SendStrs("002E003");		  
  SIO1SendChar(SampleResult[12]+'0');  	               //电池电压小数点后1位
  SIO1SendStrs("0056000D000A");		 			   //V、<CR>、<LF>unicode码
  //电源×.××V   (带换行共18B) 
  SIO1SendStrs("75356E90003");         //"电源"unicode码、数字unicode码高高3位
  SIO1SendChar(SampleResult[17]+'0');  	               //工作电压整数位
  SIO1SendStrs("002E003");				  		   //小数点
  SIO1SendChar(SampleResult[16]+'0'); 	               //工作电压小数点后1位
  SIO1SendStrs("003");		  
  SIO1SendChar(SampleResult[15]+'0');  	               //工作电压小数点后2位
  SIO1SendStrs("0056000D000A");		 
 //RDS已开(关)  (带换行共14B)  
  if (1)
    SIO1SendStrs("0052004400535DF25F00000D000A");  //"RDS:已开"、<CR>、<LF>unicode码
  else
    SIO1SendStrs("0052004400535DF25173000D000A");  //"RDS:已关"、<CR>、<LF>unicode码             
 //功放已开(关) (带换行共12B)	
  if (1)
    SIO1SendStrs("529F653E5DF25F00000D000A");  //"功放已开"、<CR>、<LF>unicode码
  else
    SIO1SendStrs("529F653E5DF25173000D000A");  //"功放已关"、<CR>、<LF>unicode码        
 //喇叭正常(异常) (带换行共12B) 
  if (1)
    SIO1SendStrs("558753ED6B635E38000D000A");	//喇叭正常
  else
    SIO1SendStrs("558753ED5F025E38000D000A");	//喇叭异常
//充电××~××V	 (带换行共20B)
  SIO1SendStrs("51457535003");		   //"充电"unicode码 
  SIO1SendChar(ChargeVmin/10%10+'0');
  SIO1SendStrs("003");
  SIO1SendChar(ChargeVmin%10+'0');
  SIO1SendStrs("FF5E003");
  SIO1SendChar(ChargeVmax/10%10+'0');
  SIO1SendStrs("003");
  SIO1SendChar(ChargeVmax%10+'0');
  SIO1SendStrs("0056000D000A");
//放电××~××V   (带换行共20B)
  SIO1SendStrs("653E7535003");		   //"放电"unicode码 
  SIO1SendChar(DischargeVmin/10%10+'0');
  SIO1SendStrs("003");
  SIO1SendChar(DischargeVmin%10+'0');
  SIO1SendStrs("FF5E003");
  SIO1SendChar(DischargeVmax/10%10+'0');
  SIO1SendStrs("003");
  SIO1SendChar(DischargeVmax%10+'0');
  SIO1SendStrs("0056000D000A");
//音量×级     (共8B)
  SIO1SendStrs("97F391CF003");
  SIO1SendChar(VOL+'0');
  SIO1SendStrs("7EA7");    	  
  SIO1SendChar(26);	         //ctrl+z(报文结束)	
}

/*监听——拨号后放录音段10s*/
void Listen(void)
{ uchar i;
  SIO1SendStrs("AT+COLP=1");             //拨号成功后直接提示
  SIO1SendChar(0x0d);	         //<CR>
  SIO1SendChar(0x0a);	         //<LF>
  SIO1SendStrs("ATD");                   
  for (i=0;i<11;i++)                     //拨号
    SIO1SendChar(SMSCallInTel[i]);       //号码位 
  SIO1SendChar(0x0d);	         //<CR>	  
  SIO1SendChar(0x0a);	         //<LF>
  MP3Play(0,MusicNum);                   //单曲播放第1首
  delay(1000);	  	         //播放10s
  SIO1SendStrs("ATH");                   //挂机
  SIO1SendChar(0x0d);	         //<CR>
  SIO1SendChar(0x0a);	         //<LF>
  StopMP3();		         //停播
}

/*删除SIM卡内前n条短信*/
//入口：SMSNum 欲删除的最后1条短信
void ClrSIM(uchar n)
{ uchar k,i,j; 
  for (k=1;k<n+1;k++)
  { if (k<10)
    { SIO1SendStrs("AT+CMGD=");  /*删除指令*/
      SIO1SendChar(k+'0');	  /*第k条*/
      SIO1SendChar(13);	  /*<CR>*/
      SIO1SendChar(10);	  /*<LF>*/
      delay(4);
    }
    else
    { i=k/10;
      j=k%10;
      SIO1SendStrs("AT+CMGD=");  /*删除指令*/
      SIO1SendChar(i+'0');	  /*第k条*/
      SIO1SendChar(j+'0');	 
      SIO1SendChar(13);	  /*<CR>*/
      SIO1SendChar(10);	  /*<LF>*/
      delay(4);
    } 
  }
}



