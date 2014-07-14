/*********************************************************
 * 	GSM数字广播系统TDE程序                   *
 *                                                       *
 * 功能：SIM300实现电话呼叫和短信收发                    *
 *       本地操作喊话器和MP3二路音源信号的广播           *
 *       远程操作呼入和MP3二路音源信号的广播             *
 *********************************************************/
#include <sim300.h>

void main(void)
{ uint i;
  uchar j,k,Temp1,Temp2;
  MCUInit();         //MCU初始化
  initLCDM();	     //LCD初始化
  ExportIAP();       //导出数据
  if ((MTelNum>10)||(STelNum>20))
  {//白名单空处理 
    MTelNum=0;	             //管理操作者个数
    STelNum=0;	             //授权操作者个数
    VOL=6;	             //音量默认6级
    ChargeVmin=51;           //充电电压下限默认51V
    ChargeVmax=56;           //充电电压上限默认56V
    DischargeVmin=46;        //放电电压下限默认46V
    DischargeVmax=50;        //放电电压上限默认50V
    Center=1;                //中心机默认无
    WhiteBookVoidDisplay();
    BellUp(1000);            //蜂鸣器鸣叫提示
  }
  EA=1;	             //开中断
/*进入电压标度整定/固定号码设置状态*/
  MonitorSettings();
  ExportIAP();               //再次导出数据
  PlayerVolume(VOL);         //播放器音量
/*进入运行状态*/
  CR=1;
  DTEStartDisplay();         //DTE启动时，显示"德海通信GSM数字广播系统启动中..."
  sim300Init();	             //sim300初始化
  EA=0;	             //关中断
  ClrSIM(30);	             //删除SIM卡内所有短信
  EA=1;	             //开中断
  ADC_CONTR = ADC_POWER|ADC_SPEEDLL|ADC_START|channel[ch];   //启动ADC
  delay(1);          
  CR=0;                      //关闭PCA定时器
  ET0=1;                     //允许T0中断
  ES=1;	             //允许串口1中断*/
  TR0=1;                     //启动T0
  Rx=0;
  for (i=0;i<RxIn;i++) RS3[i]='\0'; //清空字符接收缓冲区
  LCDBLARelay=0;                    //关LCD背灯
  ClearScreen();                    //清屏
  BELL=0;                           //蜂鸣器静音  
  while(1)
  { WDT_CONTR=Pre_scale_Word;       //清0,启动看门狗,预分频数=64,约2.2755s后复位
    delay(20);  
/*监测呼入*/
    Temp1=FindStr(RS3,"RING");
    Temp2=FindStr(RS3,"+CLIP: \"");
    if (Temp1||Temp2)  
    { //有呼入处理     
      for (i=0;i<12;i++) 
        SMSCallInTel[i]=RS3[i+Temp2+7];/*获取12位呼入号码*/
      if (!(SMSCallInTel[11]!='\"'))	
        SMSCallInTel[11]='F';        //11位号码不够12位,后补"F"
      SMSCallInTel[12]='\0';         //呼入号码字符串结束符	  
      if (FindStr(EnTelBook,SMSCallInTel))   
      { //拨打者号码属于白名单的处理
        delay(1300);
        SIO1SendStrs("ATA");      //接通
        SIO1SendChar(0x0d);	  //<CR>
        SIO1SendChar(0x0a);	  //<LF>
        delay(2);                 //稍等
        if (EnPA)
        { RDSRelay=0;	  //断开RDS音源继电器       
          CallInRelay=1;          //接通呼入音源继电器
          MICSRelayL=0;           //断开喊话器继电器       
          MP3SRelay=0;	  //断开MP3音源继电器
          VGRelay=1;              //接通呼入与MP3组前置放大器
          PASRelay=1;	  //打开功放
        }	 
      }
      else
      { //拨打者号码不属于白名单的处理
        SIO1SendStrs("ATH");      //挂机
        SIO1SendChar(0x0d);	  //<CR>
        SIO1SendChar(0x0a);	  //<LF>
      }
      Rx=0;
      for (i=0;i<RxIn;i++) RS3[i]='\0';//清空字符接收缓冲区
    }	
/*监测短信*/
    Temp1=FindStr(RS3,"+CMTI: \"SM\",");
    delay(2);//等待直到收到短信位置符
    if (Temp1)
    {//有短信处理
      Rx=0;
      Temp2=RS3[Temp1+11];  //获取SIM卡中短信位置
      for (i=0;i<RxIn;i++) 
        RS3[i]='\0';        //清空字符接收缓冲区
      SIO1SendStrs("AT+CMGR="); //读短信	
      SIO1SendChar(Temp2);
      SIO1SendChar(0x0d);	  //<CR>
      SIO1SendChar(0x0a);	  //<LF>
      while (1)
      { Temp1=FindStr(RS3,"0D9168");    //获取发短信者号码位置
        if (Temp1) break;
      }
      SMSCallInTel[12]='\0';	//短信号码字符串结束符
      BellUp(50);      //等待接收命令
      for (i=0;i<12;i++) 
        SMSCallInTel[i]=RS3[i+Temp1+5]; //获取PDU格式的短信号码
      TelPDU();      //短信号码转换为自然格式
      if (FindStr(EnTelBook,SMSCallInTel))     //发送者号码是否属白名单
      {/*短信发送者号码属于白名单的处理*/ 
      //1、"管理"——添加管理号码
        if (FindStr(RS3,"7BA17406"))           //7BA17406为"管理"unicode码    
        { //添加管理号码处理
          if (MTelNum==10)
          { //管理号码已满,回复短信："管理号码已满(最多10个),刚才的添加无效！"
            SmsReply('0','5','9','2','C',"7BA1740653F778015DF26EE1FF086700591A003100304E2AFF0C521A624D7686DFB52A0465E06548FF01"); 		 
            goto clrSMS;
          }
          if (FindStr(EnTelBook,SMSCallInTel)>=12*MTelNum)
          {//回复短信："您无权添加号码！"
            SmsReply('0','2','9','0','E',"60A865E067436DFB52A053F77801FF01");
            goto clrSMS;
          }
          delay(6);	   //等待参数接收完毕
          if ((RS3[Temp1+48]=='1')&&(RS3[Temp1+52]!='0'))
          { //是手机号码处理
            if (Validity(Temp1+45,11))
            {//添加处理
              GainComandTel(Temp1+48,11);  //获得添加号码
              SMSComandTel[12]='\0';       //获得的号码作为一个字符串			  
              if (FindStr(EnTelBook,SMSComandTel))  
              {//添加号码属白名单,回复短信："该号码已存在！"
	SmsReply('0','2','9','0','E',"8BE553F778015DF25B585728FF01");
	goto clrSMS; 
              } 			 			  	
              else
              {//添加号码不属白名单,作添加处理
	for (i=12*(MTelNum+STelNum);i>12*MTelNum-1;i--)
	  EnTelBook[i+12]=EnTelBook[i];     //白名单中所有授权号码依次后移12个位置
	for (i=12*MTelNum;i<12*MTelNum+12;i++)
	  EnTelBook[i]=SMSComandTel[i];     //加号码于白名单中管理号码之尾
	MTelNum++;     //管理号码个数+1
	ImportIAP();		    //保存于EEPROM
             //回复短信："该号码已添加！"
	SmsReply('0','2','9','0','E',"8BE553F778015DF26DFB52A0FF01");
	goto clrSMS; 
              }			
            }
          }
          goto error;   //非手机号码，回复短信："命令错误！"		  
        }
      //2、"授权"——添加授权号码	
        if (FindStr(RS3,"63886743"))         //63886743为"授权"unicode码     
        { //添加授权号码处理
          if (MTelNum+STelNum>30)
          {//授权号码已满，回复短信："白名单已满(最多30个),刚才的添加无效！"
            SmsReply('0','5','7','2','A',"767D540D53555DF26EE1FF086700591A003300304E2AFF0C521A624D7686DFB52A0465E06548FF01"); 		 
            goto clrSMS;
          }
          if (FindStr(EnTelBook,SMSCallInTel)>=12*MTelNum)
          {//回复短信："您无权添加号码！"
            SmsReply('0','2','9','0','E',"60A865E067436DFB52A053F77801FF01");
            goto clrSMS;
          }
          delay(6);   //等待参数接收完毕
          if (Validity(Temp1+45,12))
            GainComandTel(Temp1+48,12);  //获得添加号码         
          else
            if (Validity(Temp1+45,11))
            { GainComandTel(Temp1+48,11);  //获得添加号码
              SMSComandTel[11]='F';
            }
            else
              goto  error;  //转回复短信："命令错误！"
          if (SMSComandTel[0]=='0'||((SMSComandTel[0]=='1')&&(SMSComandTel[1]!='0')))
            if (FindStr(EnTelBook,SMSComandTel))  
            {//添加号码属白名单,回复短信："该号码已存在！"
              SmsReply('0','2','9','0','E',"8BE553F778015DF25B585728FF01");
              goto clrSMS; 
            } 			 			  	
            else
            {//添加号码不属白名单，作添加处理
              for (i=0;i<13;i++)
	EnTelBook[12*(MTelNum+STelNum)+i]=SMSComandTel[i];  //加号码于白名单尾
              STelNum++;     //授权号码个数+1
              ImportIAP();   //保存于EEPROM
             //回复短信："该号码已添加！"
              SmsReply('0','2','9','0','E',"8BE553F778015DF26DFB52A0FF01");
              goto clrSMS; 
            }
          else
            goto  error;  //转回复短信："命令错误！"			          		  
        }
      //3、"查看"——查看全部所设定的号码	 
        if (FindStr(RS3,"67E5770B"))   //67E5770B为"查看"unicode码 
        { /*转为英文短信格式*/
          SMSCallInTel[11]='\0';
          SIO1SendStrs("AT+CMGF=1");   //英文短信格式
          SIO1SendChar(13);	       //<CR>
          SIO1SendChar(10);	       //<LF>
          delay(3);
          SIO1SendStrs("AT+CMGS=");    //短信发送命令
          SIO1SendChar(0x22);	       //"""ASCII码
          SIO1SendStrs(SMSCallInTel);  //回复短信对象
          SIO1SendChar(0x22);	       //"""ASCII码
          SIO1SendChar(13);	       //<CR>
          SIO1SendChar(10);	       //<LF>
          delay(3);	       //等待发送完毕
        //发送管理号码(11位手机号码）
          i=0;
          while (EnTelBook[i]!='\0')
          { if (EnTelBook[i]!='F')
              SIO1SendChar(EnTelBook[i]); //当前号码位*/
            i++;                    	            
            if (i%12==0)
              if ((i==12*MTelNum)||(i==12*(MTelNum+STelNum)))
              { SIO1SendChar(46);       //"."ASCII码
                 if (i==12*MTelNum)
                 { SIO1SendChar(13);    //<CR>
                   SIO1SendChar(10);    //<LF>
                 }
              }
              else
                 SIO1SendChar(44);	               //","ASCII码
          }                	         
          SIO1SendChar(26);	  //ctrl+z
        /*转为中文短信格式*/
          delay(50);	 //等待发送完毕
          SIO1SendStrs("AT+CMGF=0");    
          SIO1SendChar(13);	        //<CR>
          SIO1SendChar(10);	        //<LF>
          delay(3);              //等待发送完毕
          goto clrSMS;
        }   	 	
      //4、"清除"——清除全部号码，但保留1个原始号码   
        if (FindStr(RS3,"6E059664"))   	  //6E059664为"清除"unicode码
        { //清除号码处理
          if (FindStr(EnTelBook,SMSCallInTel)>=12*MTelNum)
          {//回复短信："您无权清除号码！"
            SmsReply('0','2','9','0','E',"60A865E067436E05966453F77801FF01");
            goto clrSMS;
          }
          EnTelBook[12]='\0';    //1个号码字符串结束符        
          MTelNum=1;     //保留1个管理号码
          STelNum=0;     //无授权号码
          ImportIAP();   //导入数据，掉电有效的保存
       //回复短信："保留了1个管理号码,其余已全部清除!"
          SmsReply('0','5','1','2','4',"4FDD75594E8600314E2A7BA1740653F77801FF0C51764F595DF2516890E86E059664FF01");
          goto clrSMS;
       }	 
     //5、"删除"——删除指定的号码
       if (FindStr(RS3,"52209664"))    		  //52209664为"删除"unicode码
       { if (FindStr(EnTelBook,SMSCallInTel)>=12*MTelNum)
         {//回复短信："您无权删除号码！"
           SmsReply('0','2','9','0','E',"60A865E067435220966453F77801FF01");
           goto clrSMS;
         }
         delay(6);	   //等待参数接收完毕
         if (Validity(Temp1+45,12))
         { GainComandTel(Temp1+48,12);   //获得12位号码
           goto Delete;
         }
         if (Validity(Temp1+45,11))
         { GainComandTel(Temp1+48,11);   //获得11位号码
           SMSComandTel[11]='F';
           goto Delete;
         }
         //回复短信："该号码不存在！"
         SmsReply('0','2','9','0','E',"8BE553F778014E0D5B585728FF01");
         delay(3);
         goto clrSMS;
         Delete:
         i=FindStr(EnTelBook,SMSComandTel);
         if (!i)
         {//回复短信："该号码不存在！"
           SmsReply('0','2','9','0','E',"8BE553F778014E0D5B585728FF01");
           delay(3);
           goto clrSMS;
         }
         if (i==1) 
         {//删除号码为保留号码，回复短信："该号保留不能删！"
           SmsReply('0','3','1','1','0',"8BE553F74FDD75594E0D80FD5220FF01");
           delay(3);
           goto clrSMS;
         }
         if (i<12*MTelNum)
           MTelNum--;    //删除号码为管理号码
         else
           STelNum--;    //删除号码为授权号码
         i+=11;
         while (EnTelBook[i]!='\0')
         { EnTelBook[i-12]=EnTelBook[i];
           i++;
         }
         EnTelBook[i-12]='\0';
         ImportIAP();   //保存到EEPROM
        //回复短信："该号码已删除！"
         SmsReply('0','2','9','0','E',"8BE553F778015DF252209664FF01"); 
         goto clrSMS;            		  		  
       }
     //6、"查询"——上传光伏、电池、工作电压，RDS、功放状态，充、放电、音量设置
       if (FindStr(RS3,"67E58BE2"))    	//67E58BE2为"查询"unicode码
       { SmsReplyStatusParameters();	//回复短信：当前状态与参数设置情况
         delay(20);   //等待发送完毕
         goto clrSMS;
       }	
     //7、"监听"							
       if (FindStr(RS3,"76D1542C"))    	//76D1542C为"监听"unicode码
       { Listen();	                //回拨后放10s录音段
         goto clrSMS;
       }	 
     //8、"开机"			    	  	
       if (FindStr(RS3,"64AD653E"))             //64AD653E为"播放"unicode码
       { delay(2);	                //等待参数接收完毕
         if (Validity(Temp1+45,4))
         {//循环放音
           if (((RS3[Temp1+48]=='1')||(RS3[Temp1+48]=='2'))&&(RS3[Temp1+52]!='0'))
           { SMStimeElapsed=1200*(10*(RS3[Temp1+56]-'0')+RS3[Temp1+60]-'0');  //获得限时值
             SMSplayLimit=1;	                                               //短信点播限时有效
             MP3Play(RS3[Temp1+48]-'0',RS3[Temp1+52]-'0');                    //播放所点录音段
             if (EnPA) 
             { RDSRelay=0;	  //断开RDS音源继电器       
               CallInRelay=0;     //断开呼入音源继电器
               MICSRelayL=0;      //断开喊话器继电器       
               MP3SRelay=1;	  //接通MP3音源继电器
               VGRelay=1;         //接通呼入与MP3组前置放大器
               PASRelay=1;	  //打开功放
               if (RS3[Temp1+48]=='1')
               {//回复短信："已开机！第×曲单循环播放××分钟。"
	 SmsReplyHead('0','5','3','2','6');     			    //短信头报文长53B,短信内容长38B
                 SIO1SendStrs("5DF25F00673AFF01000D000A7B2C003");   //"已开机!第"unicode码
	 SIO1SendChar(RS3[Temp1+52]);					        //曲号			  
	 SIO1SendStrs("66F253555FAA73AF64AD653E003");	    //"曲单循环播放"unicode码		                
	 SIO1SendChar(RS3[Temp1+56]);		    //播放时间十位
	 SIO1SendStrs("003");	       
	 SIO1SendChar(RS3[Temp1+60]);		    //播放时间个位
	 SIO1SendStrs("5206949F3002");	                    //"分钟。"unicode码
                 SIO1SendChar(26);	                    //ctrl+z(报文结束)
               }
               else
               {//回复短信："已开机！从第×曲大循环播放××分钟。"及录音播放情况
	 SmsReplyHead('0','5','5','2','8');     	  //短信头报文长55B,短信内容长40B
                 SIO1SendStrs("5DF25F00673AFF01000D000A4ECE7B2C003");    //"已开机！从第"unicode码
	 SIO1SendChar(RS3[Temp1+52]);		       //曲号			  
	 SIO1SendStrs("66F259275FAA73AF64AD653E003");	      //"曲大循环播放"unicode码
	 SIO1SendChar(RS3[Temp1+56]);		      //播放时间十位
	 SIO1SendStrs("003");		   
	 SIO1SendChar(RS3[Temp1+60]);		   //播放时间个位
	 SIO1SendStrs("5206949F3002");		                //"分钟。"unicode码
                 SIO1SendChar(26);	                                //ctrl+z(报文结束)
               }
               goto clrSMS;
             }
           }
           else
             goto error;      //转回复短信："命令错误！"
          }
          else
            if (Validity(Temp1+45,2)&&(RS3[Temp1+48]=='0')&&(RS3[Temp1+52]!='0'))
            { //单曲放音
              MP3Single=1;	     //MP3模块单曲放音有效
              MP3Play(RS3[Temp1+48]-'0',RS3[Temp1+52]-'0');                    //播放所点录音段
              if (EnPA) 
              { RDSRelay=0;	  //断开RDS音源继电器       
                CallInRelay=0;    //断开呼入音源继电器
                MICSRelayL=0;     //断开喊话器继电器       
                MP3SRelay=1;	  //接通MP3音源继电器
                VGRelay=1;        //接通呼入与MP3组前置放大器
                PASRelay=1;	  //打开功放
               //回复短信："已开机!第×曲单曲播放。"
                SmsReplyHead('0','4','3','1','C');         //短信头报文长43B,短信内容长28B
                SIO1SendStrs("5DF25F00673AFF01000D000A7B2C003");    //"已开机!第"unicode码
                SIO1SendChar(RS3[Temp1+52]);		    //曲号			  
                SIO1SendStrs("66F2535566F264AD653E3002");		    //"曲单曲播放。"unicode码
                SIO1SendChar(26);	                                //ctrl+z(报文结束)
              }
              goto clrSMS;
            }
            else																 
              goto error;	//转回复短信："命令错误！" 
        }	    		    
      //9、"关机"——关闭功放和MP3
        if (FindStr(RS3,"5173673A"))   			 //5173673A为"关机"unicode码
        { RDSRelay=0;	  //断开RDS音源继电器       
          CallInRelay=0;          //断开呼入音源继电器
          MICSRelayL=0;           //断开喊话器继电器       
          MP3SRelay=0;	  //断开MP3音源继电器
          VGRelay=0;              //接通RDS与喊话器组前置放大器
          PASRelay=0;	  //关闭功放
          StopMP3();              //MP3停播
          SmsReply('0','2','3','0','8',"5DF25173673AFF01"); //回复短信："已关机！"
          goto clrSMS;
        }  
      //10、"音量"——设置MP3音量					 
        if (FindStr(RS3,"97F391CF"))        //97F391CF为"音量"unicode码
        { delay(1);	//等待参数接收完毕
          if (Validity(Temp1+45,1)) 
          { VOL=RS3[Temp1+48]-'0';   //获得音量级别
            PlayerVolume(VOL); //播放器音量
            ImportIAP();	 //保存到EEprom
           //回复短信："播放器音量已设置为×级！"
            SmsReplyHead('0','3','9','1','8');       //短信头报文长39B,短信内容24B
            SIO1SendStrs("64AD653E566897F391CF5DF28BBE7F6E4E3A003");    //"播放器音量已设置为"unicode码
            SIO1SendChar(RS3[Temp1+48]);	   //音量级别			  
            SIO1SendStrs("7EA7FF01");	   //"级！"unicode码						//"级！"unicode码
            SIO1SendChar(26);	       //ctrl+z(报文结束)
            goto clrSMS;
          }
          else
            goto error;	//转发短信提示："短信错误！"
        }
      //11、"充电"——设置充电电压
        if (FindStr(RS3,"51457535"))	//51457535为"充电"unicode码
        { if (FindStr(EnTelBook,SMSCallInTel)>=12*MTelNum)
          {//回复短信："您无权设置充电参数！"
            SmsReply('0','3','5','1','4',"60A865E067438BBE7F6E5145753553C26570FF01");
            goto clrSMS;
          }
          delay(2);	//等待参数接收完毕
          if (Validity(Temp1+45,4))
          { i=10*(RS3[Temp1+48]-'0')+RS3[Temp1+52]-'0';  //获得充电电压下限
            if (i<CVEnmin)
            { //回复短信："蓄电池充电限于CVEnmin~CVEnmaxV！刚才的设置无效！"
              ChargeOutOf: 
              SmsReplyHead('0','6','3','3','0');       //短信头报文长63B,短信内容长48B
              SIO1SendStrs("84C475356C605145753596504E8E003");    //"蓄电池充电限于"unicode码
              SIO1SendChar(CVEnmin/10%10+'0');	  //CVEnmin十位
              SIO1SendStrs("003");             
              SIO1SendChar(CVEnmin%10+'0');   	  //CVEnmin个位
              SIO1SendStrs("FF5E003");
              SIO1SendChar(CVEnmax/10%10+'0');	  //CVEnmax十位
              SIO1SendStrs("003");
              SIO1SendChar(CVEnmax%10+'0');   	  //CVEnmax个位
              SIO1SendStrs("0056FF01000D000A521A624D76848BBE7F6E65E06548FF01");//"V！刚才的设置无效！"unicode码
              SIO1SendChar(26);	                  //ctrl+z(报文结束)
            }							   
            else
            { ChargeVmin=i;
              i=10*(RS3[Temp1+56]-'0')+RS3[Temp1+60]-'0';  //获得充电电压上限	
              if (i>CVEnmax)	
                goto ChargeOutOf;	  //转回复短信："蓄电池充电限于CVEnmin~CVEnmaxV！刚才的设置无效！"				   
              else
                ChargeVmax=i;
              ImportIAP();		  //保存于EEPROM
           //回复短信："蓄电池充电电压已设置为××~××V！"
              SmsReplyHead('0','5','1','2','4');   //短信头报文长51B,短信内容长36B 
              SIO1SendStrs("84C475356C60514575357535538B5DF28BBE7F6E4E3A003");    //"蓄电池充电电压已设置为"unicode码
              SIO1SendChar(RS3[Temp1+48]);    	  //设置的充电电压下限十位
              SIO1SendStrs("003");
              SIO1SendChar(RS3[Temp1+52]);    	  //设置的充电电压下限个位
              SIO1SendStrs("FF5E003");
              SIO1SendChar(RS3[Temp1+56]);         //设置的充电电压上限十位
              SIO1SendStrs("003");
              SIO1SendChar(RS3[Temp1+60]);    	  //设置的充电电压上限个位
              SIO1SendStrs("0056FF01");							  //"V！"unicode码
              SIO1SendChar(26);	                  //ctrl+z(报文结束)	        
            }
            goto clrSMS;	   		  	    
          }
          else
             goto error;		  	    
       }  
     //12、"放电"——设置放电电压
       if (FindStr(RS3,"653E7535"))	//653E7535为"放电"unicode码
       { if (FindStr(EnTelBook,SMSCallInTel)>=12*MTelNum)
         {//回复短信："您无权设置放电参数！"
           SmsReply('0','3','5','1','4',"60A865E067438BBE7F6E653E753553C26570FF01");
           goto clrSMS;
         }
         delay(2);	//等待参数接收完毕
         if (Validity(Temp1+45,4))
         { i=10*(RS3[Temp1+48]-'0')+RS3[Temp1+52]-'0';  //获得放电电压下限
           if (i<DisCVEnmin)
           {//低于下限极限值，回复短信："蓄电池放电限于VDEnmin~VDEnminV！刚才的设置无效！"
             DisChOutOf: 
             SmsReplyHead('0','6','3','3','0');       //短信头报文长63B,短信内容长48B
             SIO1SendStrs("84C475356C60653E753596504E8E003");    //"蓄电池放电限于"unicode码
             DisChRange: 
             SIO1SendChar(DisCVEnmin/10%10+'0');	    //DisCVEnmin十位
             SIO1SendStrs("003");
             SIO1SendChar(DisCVEnmin%10+'0');	    //DisCVEnmin个位
             SIO1SendStrs("FF5E003");
             SIO1SendChar(DisCVEnmax/10%10+'0');	    //DisCVEnmax十位
             SIO1SendStrs("003");
             SIO1SendChar(DisCVEnmax%10+'0');	    //DisCVEnmax个位
             SIO1SendStrs("0056FF01000D000A521A624D76848BBE7F6E65E06548FF01");  //"V！刚才的设置无效！"unicode码
             SIO1SendChar(26);	          //ctrl+z(报文结束)
             goto clrSMS;
           }							   
            else
            { DischargeVmin=i;
              i=10*(RS3[Temp1+56]-'0')+RS3[Temp1+60]-'0';  //获得放电电压上限	
              if (i>DisCVEnmax)
                goto DisChOutOf;	//转回复短信："蓄电池放电限于VDEnmin~VDEnminV！刚才的设置无效！"							   
              else
                DischargeVmax=i;
              ImportIAP();		                //保存于EEPROM，掉电有效
           //回复短信："蓄电池放电电压已设置为××~××V！"
              SmsReplyHead('0','5','1','2','4');      //短信头报文长51B,短信内容长36B
              SIO1SendStrs("84C475356C60653E75357535538B5DF28BBE7F6E4E3A003");    //"蓄电池放电电压已设置为"
              goto DisChRange;  	      //转范围发送
            }   		  	    
          }
          else
            goto error;
        }
      //13、"日期"——设置MP3模块日期(年月日)
        if (FindStr(RS3,"65E5671F"))	//65E5671F为"日期"unicode码
        { delay(2);	//等待参数接收完毕
          if (Validity(Temp1+45,6))
          { i=2000+10*(RS3[Temp1+48]-'0')+RS3[Temp1+52]-'0';  //获得年(年份前二位固定为20)
            j=10*(RS3[Temp1+56]-'0')+RS3[Temp1+60]-'0';       //获得月
            k=10*(RS3[Temp1+64]-'0')+RS3[Temp1+68]-'0';       //获得日
            if ((j==0)||(j>12)||(k==0)||(k>31))
              goto error;         //月为0或超过12或日为0或超过31,发出错信息
            if ((j==2)&&(k>29))
              goto error;         //2月超过29,发出错信息
            if ((j==2)&&(k%4!=0)&&(k>28))
              goto error;         //不能被4整除的年份为非闰年,其2月超过28,发出错信息
            if ((j==2)&&(k%100==0)&&(k%400!=0)&&(k==29))
              goto error;         //能被100整除但不能被400整除的年份为非闰年,其2月超过28,发出错信息 
            if (((j==4)||(j==6)||(j==9)||(j==11))&&(k==31))
              goto error;         //4、6、9、11月为31,发出错信息 
            //将年月日传送到MP3 
            S2BUF=0x7e;		   /*发送日期设置命令起始字节*/
            while(!(S2CON&2));   //等待发送完毕
            S2CON&=0xfd;	       //清除发送完毕标志
            S2BUF=6;		   /*发送日期设置命令字节数*/
            while(!(S2CON&2));   //等待发送完毕
            S2CON&=0xfd;	       //清除发送完毕标志
            S2BUF=0xb1;	                   /*发送日期设置命令码字节*/
            while(!(S2CON&2));   //等待发送完毕
            S2CON&=0xfd;	       //清除发送完毕标志
            S2BUF=i/256;	                  /*发送年前二位字节*/
            while(!(S2CON&2));   //等待发送完毕 
            S2CON&=0xfd;	       //清除发送完毕标志
            S2BUF=i%256;	                  /*发送年后二位字节*/
            while(!(S2CON&2));   //等待发送完毕 
            S2CON&=0xfd;	       //清除发送完毕标志
            S2BUF=j;	                  /*发送月字节*/
            while(!(S2CON&2));   //等待发送完毕 
            S2CON&=0xfd;	       //清除发送完毕标志
            S2BUF=k;	                  /*发送日字节*/
            while(!(S2CON&2));   //等待发送完毕 
            S2CON&=0xfd;	       //清除发送完毕标志
            S2BUF=0x7e;	                  /*发送日期设置命令结束字节*/
            while(!(S2CON&2));   //等待发送完毕 
            S2CON&=0xfd;	       //清除发送完毕标志 
          //回复短信："日期已设置为20××年××月××日！"
            SmsReplyHead('0','5','1','2','4');      //短信头报文长51B,短信内容36B
            SIO1SendStrs("65E5671F5DF28BBE7F6E4E3A00320030003");    //"日期已设置为20"unicode码   
            SIO1SendChar(RS3[Temp1+48]);  
            SIO1SendStrs("003");   
            SIO1SendChar(RS3[Temp1+52]); 
            SIO1SendStrs("5E74003");      //已发送"20xx年"
            SIO1SendChar(RS3[Temp1+56]); 
            SIO1SendStrs("003"); 
            SIO1SendChar(RS3[Temp1+60]); 
            SIO1SendStrs("6708003");      //已发送"xx月"
            SIO1SendChar(RS3[Temp1+64]);
            SIO1SendStrs("003");  
            SIO1SendChar(RS3[Temp1+68]); 
            SIO1SendStrs("65E5FF01");     //已发送"xx日!"           			     						//"级！"unicode码
            SIO1SendChar(26);	          //ctrl+z(报文结束)
            goto clrSMS;               
          }
          else
            goto error;
        }
      //14、"时间"——设置MP3模块时间(时分秒)
        if (FindStr(RS3,"65F695F4"))	//65F6595F4为"时间"unicode码
        { delay(2);              	//等待参数接收完毕           
          if (Validity(Temp1+45,6))
          { i=10*(RS3[Temp1+48]-'0')+RS3[Temp1+52]-'0';       //获得时
            j=10*(RS3[Temp1+56]-'0')+RS3[Temp1+60]-'0';       //获得分
            k=10*(RS3[Temp1+64]-'0')+RS3[Temp1+68]-'0';       //获得秒
            if ((i>23)||(j>59)||(k>59))
              goto error;         //时分秒超范围,发出错信息
           //将时分秒传送到MP3 
            S2BUF=0x7e;		   /*发送时间设置命令起始字节*/
            while(!(S2CON&2));   //等待发送完毕
            S2CON&=0xfd;	       //清除发送完毕标志
            S2BUF=5;		   /*发送时间设置命令字节数*/
            while(!(S2CON&2));   //等待发送完毕
            S2CON&=0xfd;	       //清除发送完毕标志
            S2BUF=0xb2;	                   /*发送时间设置命令码字节*/
            while(!(S2CON&2));   //等待发送完毕
            S2CON&=0xfd;	       //清除发送完毕标志
            S2BUF=i;	                  /*发送时字节*/
            while(!(S2CON&2));   //等待发送完毕 
            S2CON&=0xfd;	       //清除发送完毕标志
            S2BUF=j;	                  /*发送分字节*/
            while(!(S2CON&2));   //等待发送完毕 
            S2CON&=0xfd;	       //清除发送完毕标志
            S2BUF=k;	                  /*发送秒字节*/
            while(!(S2CON&2));   //等待发送完毕 
            S2CON&=0xfd;	       //清除发送完毕标志
            S2BUF=0x7e;	                  /*发送时间设置命令结束字节*/
            while(!(S2CON&2));   //等待发送完毕 
            S2CON&=0xfd;	       //清除发送完毕标志 
          //回复短信："时间已设置为××:××:××!"
            SmsReplyHead('0','4','5','1','E');      //短信头报文长39B,短信内容30B
            SIO1SendStrs("65F695F45DF28BBE7F6E4E3A003");    //"时间已设置为"unicode码
            SIO1SendChar(RS3[Temp1+48]);	    //时高位
            SIO1SendStrs("003");    
            SIO1SendChar(RS3[Temp1+52]);            //时低位
            SIO1SendStrs("003A003");                //":"unicode码
            SIO1SendChar(RS3[Temp1+56]);            //分高位
            SIO1SendStrs("003");  
            SIO1SendChar(RS3[Temp1+60]);            //分低位
            SIO1SendStrs("003A003");                //":"unicode码
            SIO1SendChar(RS3[Temp1+64]);            //秒高位
            SIO1SendStrs("003");  
            SIO1SendChar(RS3[Temp1+68]);     	    //秒低位		  
            SIO1SendStrs("FF01");	    //"!"unicode码						//"级！"unicode码
            SIO1SendChar(26);	       //ctrl+z(报文结束)
            goto clrSMS;      
          }
        }
        error: 
        SmsReply('0','2','5','0','A',"547D4EE495198BEFFF01"); //回复短信："命令错误！"
        clrSMS: 
        delay(5);
        Rx=0;
        for (i=0;i<RxIn;i++)
          RS3[i]='\0';                //清空字符接收缓冲区
        ClrSIM(Temp2-'0');           //删除此条及之前所有短信
      }
    }
/*监测挂机*/
    if (FindStr(RS3,"NO CARRIER"))
    { RDSRelay=0;	     //断开RDS音源继电器       
      CallInRelay=0;                 //断开呼入音源继电器
      MICSRelayL=0;                  //断开喊话器继电器       
      MP3SRelay=0;                   //断开MP3音源继电器
      VGRelay=0;                     //接通RDS与MIC组前置放大器
      PASRelay=0;	     //关闭功放
      Rx=0;
      for (i=0;i<RxIn;i++) 
        RS3[i]='\0';                 //清空字符接收缓冲区
    }
/*本地播放*/
    if (PlayDown)                    //"播放"键
    { PlayDown=0;
      LCDBLARelay=1;                 //打开LCD背灯
      LocalPlayDisplay(MusicNum);    //显示"正在播放...第1首"
      MP3Play(0,MusicNum);           //单曲播放第1首
      SMSplayLimit=0;                //播放不限时
    }
    if (PreyDown)                    //"上一首"键
    { PreyDown=0;
      LCDBLARelay=1;                 //打开LCD背灯
      if (LocalPlay)
      { LocalPlayDisplay(MusicNum);  //显示"正在播放...第x曲"
        MP3Play(0,MusicNum);         //单曲播放上一首
        SMSplayLimit=0;              //播放不限时
      }
      else	  
      { Page=~Page;                  //查询状态翻页切换
        if (Page)
          DTEStatus1();	     //显示功放1供电电压、功放2供电电压、外接市电电压
        else
          DTEStatus2();              //显示RDS接收状态、开关机状态、2个喇叭状态
        LCDOff=1;                    //LCD背灯亮8s有效
      }			  
    }
    if (NextDown)                    //"下一首"键
    { NextDown=0;
      LCDBLARelay=1;                 //打开LCD背灯
      if (LocalPlay)
      { LocalPlayDisplay(MusicNum);  //显示"正在播放...第x曲"
        MP3Play(0,MusicNum);         //单曲播放下一首
        SMSplayLimit=0;              //不限时
      }
      else	 
      { DateTimeDisplay();           //显示日期时间
        LCDOff=1;                    //LCD背灯亮15s有效
      }	
    }
/*监测RDS
    if (RDSState&&EnPA)                
    { RDSRelay=1;	     //接通RDS音源继电器       
      CallInRelay=0;                 //断开呼入音源继电器
      MICSRelayL=0;                  //断开喊话器继电器       
      MP3SRelay=0;                   //断开MP3音源继电器
      VGRelay=0;                     //接通RDS与喊话器组前置放大器
      PASRelay=1;	     //打开功放
    }
    else 
    { RDSRelay=0;	     //断开RDS音源继电器       
      CallInRelay=0;                 //断开呼入音源继电器
      MICSRelayL=0;                  //断开喊话器继电器       
      MP3SRelay=0;                   //断开MP3音源继电器
      VGRelay=0;                     //接通RDS与MIC组前置放大器
      PASRelay=0;	     //关闭功放
    } */
  }
}

/*T0中断函数——4个本地操作键检测与处理、MP3busy检测与处理、本地喊话处理、6路采样*/
void WatchDog() interrupt 1 using 2
{ uint V;
  TH0=(65536-5*110592/12)/256;	/*T0定时50ms*/ //65536-11.0592*50000/12*/
  TL0=(65536-5*110592/12)%256;
  if (++Deltt>MaxDeltt) 
    Deltt=MaxDeltt; 
  //本地""播放/状态""键处理
  key=KeyLocalPlay;  //检测本地""播放/状态""键
  if ((key^SKPlay)&&key) 
  {//"播放/状态"键有效
    State=!State;	    //"播放/状态"切换
    if (State) 
    { MusicNum=1;	    //播放第1曲
      PlayDown=1;	    //本地播放键有效
      LocalPlay=1;                  //本地播放
      if (EnPA) 
      { RDSRelay=0;	    //断开RDS音源继电器       
        CallInRelay=0;              //断开呼入音源继电器
        MICSRelayL=0;               //断开喊话器继电器       
        MP3SRelay=1;	    //接通MP3音源继电器
        VGRelay=1;                  //接通呼入与MP3组前置放大器
        PASRelay=1;	    //打开功放
      }
      else
      { LCDBLARelay=1;              //开LCD背灯
        CellLowDisplay();           //显示电池电压过低不能播放
        BellUp(1000);
        LCDBLARelay=0;              //关LCD背灯
        ClearScreen();
      }
    }
    else 
    { RDSRelay=0;	    //断开RDS音源继电器       
      CallInRelay=0;                //断开呼入音源继电器
      MICSRelayL=0;                 //断开喊话器继电器       
      MP3SRelay=0;                  //断开MP3音源继电器
      VGRelay=0;                    //接通RDS与MIC组前置放大器
      PASRelay=0;	    //关闭功放
      LCDBLARelay=0;                //关LCD背灯
      StopMP3();   	    //MP3停播
      LocalPlay=0;	    //本地音乐停止
      ClearScreen();                //LCD清屏
    }
  }
  SKPlay=key;	                    //保存""播放/状态""键状态
 //本地"上一首"键处理
  key=KeyLocalPrevious;             //检测本地点播"上一首"键
  if ((key^SKPre)&&key) 	  
  {//"上一首"键有效且播放
    if (LocalPlay) 
    { if (--MusicNum==0) MusicNum=9;
        EnDeltt=1;                  //允许检测"上一首"或"下一首"键按下与MP3放音完毕之间的时间差
        Deltt=0;
    }
    PreyDown=1;	                    //本地点播"上一首"键有效
  }
  SKPre=key;	                    //保存"上一首"键状态
 //本地"下一首"键处理
  key=KeyLocalNext;	    //检测本地本地点播"下一首"键
  if ((key^SKNext)&&key)
  {//"下一首"键有效且播放
    if (LocalPlay)
    { if (++MusicNum==10) MusicNum=1;
        EnDeltt=1;                  //允许检测"上一首"或"下一首"键按下与MP3放音完毕之间的时间差
        Deltt=0;
    }
    NextDown=1;	                    //本地点播"下一首"键有效
  }  
  SKNext=key;	                    //保存"下一首"键状态
 //MP3busy状态检测与处理
  key=MP3Busy;	                    //检测MP3模块放音状态
  if ((key^SMP3Busy)&&(key==0))
  {if (Deltt==MaxDeltt)  ClearScreen();//MP3模块放音结束,LCD清屏
   if (MP3Single)
   { MP3Single=0;                   //短信单曲无效
     RDSRelay=0;	    //断开RDS音源继电器       
     CallInRelay=0;                 //断开呼入音源继电器
     MICSRelayL=0;                  //断开喊话器继电器       
     MP3SRelay=0;                   //断开MP3音源继电器
     VGRelay=0;                     //接通RDS与喊话器组前置放大器
     PASRelay=0;                    //关闭功放
   }
  }      	   
  SMP3Busy=key;	       //保存MP3busy状态 
 //监测本地喊话
  key=MICState;        //检测本地喊话器开关状态
  if (key^MIC) 
    if (key)           //喊话器开关有动作
    { RDSRelay=0;	  //断开RDS音源继电器       
      CallInRelay=0;              //断开呼入音源继电器
      MICSRelayL=0;               //断开喊话器继电器       
      MP3SRelay=0;                //断开MP3音源继电器
      VGRelay=0;                  //接通RDS与喊话器组前置放大器
      PASRelay=0;	  //关闭功放
    }
    else 
      if (EnPA) 
      { RDSRelay=0;	  //断开RDS音源继电器       
        CallInRelay=0;            //断开呼入音源继电器
        MICSRelayL=1;             //接通喊话器继电器       
        MP3SRelay=0;	  //断开MP3音源继电器
        VGRelay=0;                //接通RDS与喊话器组前置放大器
        PASRelay=1;	  //打开功放
      }
  MIC=key; //保存喊话器开关状态
 //监测本地状态显示是否到15秒
  if (LCDOff) 
    if (StaDispCtrl++>250) //本地状态显示延时计数器计数12.5秒
    { //计数12.5秒到
      StaDispCtrl=0;
      LCDOff=0;
      LCDBLARelay=0;  //关LCD背灯
      ClearScreen();  //LCD清屏
    }	
//短信播放限时   
  if (SMSplayLimit)   
    if (SMStimeElapsed--==0)
    { SMSplayLimit=0;                  //时间到,限时失效
      RDSRelay=0;	       //断开RDS音源继电器       
      CallInRelay=0;                   //断开呼入音源继电器
      MICSRelayL=0;                    //断开喊话器继电器       
      MP3SRelay=0;                     //断开MP3音源继电器
      VGRelay=0;                       //接通RDS与MIC组前置放大器
      PASRelay=0;                      //关闭功放
      StopMP3();	       //MP3停播
    } 
//获得6路采样结果
  while (!(ADC_CONTR&ADC_FLAG));       //ADC转换未结束,等待
  ADC_CONTR &=!ADC_FLAG;               //清除ADC转换结束标志
  ADC_LOW2&=3;                         // 屏蔽高6位
  V=4*ADC_RES+ADC_LOW2;
  switch (ch)
  { case 0:V=10.0*V0max*V/1024;break;  //功放1供电电压(V),放大10倍 		 
    case 1:V=10.0*V1max*V/1024;break;  //功放2供电电压(V),放大10倍
    case 2:V=10.0*V4max*V/1024;break;  //外接电源电压(V),放大10倍 		
    case 3:V=10.0*V5max*V/1024;break;  //光伏输出电压(V),放大10倍  
    case 4:{ V=10.0*V6max*V/1024;      //蓄电池输出电压(V),放大10倍
             if (V<10.0*DisCVEnmin)         
               EnPA=0;	       //电池电压低于设置放电下限极值,禁止功放打开
             if (V>10.0*DisCVEnmax)
               EnPA=1;	       //电池电压高于设置放电上限极值,允许功放打开
             if (V>10.0*CVEnmin)         
               LVRelay=0;	       //电池电压高于设置充电上限极值,禁止光伏充电
             if (V<10.0*CVEnmax) 
               LVRelay=1;	       //电池电压低于设置充电下限极值,允许光伏充电
           } break;  
    case 5:V=10.0*V7max*V/1024;        //负载电压(V),放大10倍
  }                            
  SampleResult[3*ch]=V%10;             //获得结果低位并保存
  V/=10;
  SampleResult[3*ch+1]=V%10;           //获得结果中位并保存
  V/=10;
  SampleResult[3*ch+2]=V%10;           //获得结果高位并保存
  if (++ch>5) 
    ch=0;
  ADC_CONTR = ADC_POWER|ADC_SPEEDLL|ADC_START|channel[ch];      	
}

/*串口1中断——通过串口1接收SIM300发送的数据*/
void ReciveData(void) interrupt 4 using 1
{ if(RI)
  { RS3[Rx]=SBUF;  //读串口1接收SIM300发送的数据至缓冲数组 
    RI=0;
    if(Rx++>RxIn-2)Rx=0;    //最多读RxIn-1个		
  }
}

/*PCA中断——DTE启动时控制蜂鸣器间歇性鸣叫*/
void PCA(void) interrupt 7 using 1
{ CCF0=0;                //清除中断标志
  CCAP0L=value;
  CCAP0H=value>> 8;      //更新比较值
  value+=fosc/12/20;
  if (SmapleStartCnt--==0)
  { SmapleStartCnt=5;   //反复计数0.5s
    BELL=~BELL;//启动中蜂鸣器间歇鸣叫
    ch++;
  }
}