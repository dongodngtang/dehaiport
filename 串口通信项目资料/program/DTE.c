/*********************************************************
 * 	GSM���ֹ㲥ϵͳTDE����                   *
 *                                                       *
 * ���ܣ�SIM300ʵ�ֵ绰���кͶ����շ�                    *
 *       ���ز�����������MP3��·��Դ�źŵĹ㲥           *
 *       Զ�̲��������MP3��·��Դ�źŵĹ㲥             *
 *********************************************************/
#include <sim300.h>

void main(void)
{ uint i;
  uchar j,k,Temp1,Temp2;
  MCUInit();         //MCU��ʼ��
  initLCDM();	     //LCD��ʼ��
  ExportIAP();       //��������
  if ((MTelNum>10)||(STelNum>20))
  {//�������մ��� 
    MTelNum=0;	             //��������߸���
    STelNum=0;	             //��Ȩ�����߸���
    VOL=6;	             //����Ĭ��6��
    ChargeVmin=51;           //����ѹ����Ĭ��51V
    ChargeVmax=56;           //����ѹ����Ĭ��56V
    DischargeVmin=46;        //�ŵ��ѹ����Ĭ��46V
    DischargeVmax=50;        //�ŵ��ѹ����Ĭ��50V
    Center=1;                //���Ļ�Ĭ����
    WhiteBookVoidDisplay();
    BellUp(1000);            //������������ʾ
  }
  EA=1;	             //���ж�
/*�����ѹ�������/�̶���������״̬*/
  MonitorSettings();
  ExportIAP();               //�ٴε�������
  PlayerVolume(VOL);         //����������
/*��������״̬*/
  CR=1;
  DTEStartDisplay();         //DTE����ʱ����ʾ"�º�ͨ��GSM���ֹ㲥ϵͳ������..."
  sim300Init();	             //sim300��ʼ��
  EA=0;	             //���ж�
  ClrSIM(30);	             //ɾ��SIM�������ж���
  EA=1;	             //���ж�
  ADC_CONTR = ADC_POWER|ADC_SPEEDLL|ADC_START|channel[ch];   //����ADC
  delay(1);          
  CR=0;                      //�ر�PCA��ʱ��
  ET0=1;                     //����T0�ж�
  ES=1;	             //������1�ж�*/
  TR0=1;                     //����T0
  Rx=0;
  for (i=0;i<RxIn;i++) RS3[i]='\0'; //����ַ����ջ�����
  LCDBLARelay=0;                    //��LCD����
  ClearScreen();                    //����
  BELL=0;                           //����������  
  while(1)
  { WDT_CONTR=Pre_scale_Word;       //��0,�������Ź�,Ԥ��Ƶ��=64,Լ2.2755s��λ
    delay(20);  
/*������*/
    Temp1=FindStr(RS3,"RING");
    Temp2=FindStr(RS3,"+CLIP: \"");
    if (Temp1||Temp2)  
    { //�к��봦��     
      for (i=0;i<12;i++) 
        SMSCallInTel[i]=RS3[i+Temp2+7];/*��ȡ12λ�������*/
      if (!(SMSCallInTel[11]!='\"'))	
        SMSCallInTel[11]='F';        //11λ���벻��12λ,��"F"
      SMSCallInTel[12]='\0';         //��������ַ���������	  
      if (FindStr(EnTelBook,SMSCallInTel))   
      { //�����ߺ������ڰ������Ĵ���
        delay(1300);
        SIO1SendStrs("ATA");      //��ͨ
        SIO1SendChar(0x0d);	  //<CR>
        SIO1SendChar(0x0a);	  //<LF>
        delay(2);                 //�Ե�
        if (EnPA)
        { RDSRelay=0;	  //�Ͽ�RDS��Դ�̵���       
          CallInRelay=1;          //��ͨ������Դ�̵���
          MICSRelayL=0;           //�Ͽ��������̵���       
          MP3SRelay=0;	  //�Ͽ�MP3��Դ�̵���
          VGRelay=1;              //��ͨ������MP3��ǰ�÷Ŵ���
          PASRelay=1;	  //�򿪹���
        }	 
      }
      else
      { //�����ߺ��벻���ڰ������Ĵ���
        SIO1SendStrs("ATH");      //�һ�
        SIO1SendChar(0x0d);	  //<CR>
        SIO1SendChar(0x0a);	  //<LF>
      }
      Rx=0;
      for (i=0;i<RxIn;i++) RS3[i]='\0';//����ַ����ջ�����
    }	
/*������*/
    Temp1=FindStr(RS3,"+CMTI: \"SM\",");
    delay(2);//�ȴ�ֱ���յ�����λ�÷�
    if (Temp1)
    {//�ж��Ŵ���
      Rx=0;
      Temp2=RS3[Temp1+11];  //��ȡSIM���ж���λ��
      for (i=0;i<RxIn;i++) 
        RS3[i]='\0';        //����ַ����ջ�����
      SIO1SendStrs("AT+CMGR="); //������	
      SIO1SendChar(Temp2);
      SIO1SendChar(0x0d);	  //<CR>
      SIO1SendChar(0x0a);	  //<LF>
      while (1)
      { Temp1=FindStr(RS3,"0D9168");    //��ȡ�������ߺ���λ��
        if (Temp1) break;
      }
      SMSCallInTel[12]='\0';	//���ź����ַ���������
      BellUp(50);      //�ȴ���������
      for (i=0;i<12;i++) 
        SMSCallInTel[i]=RS3[i+Temp1+5]; //��ȡPDU��ʽ�Ķ��ź���
      TelPDU();      //���ź���ת��Ϊ��Ȼ��ʽ
      if (FindStr(EnTelBook,SMSCallInTel))     //�����ߺ����Ƿ���������
      {/*���ŷ����ߺ������ڰ������Ĵ���*/ 
      //1��"����"������ӹ������
        if (FindStr(RS3,"7BA17406"))           //7BA17406Ϊ"����"unicode��    
        { //��ӹ�����봦��
          if (MTelNum==10)
          { //�����������,�ظ����ţ�"�����������(���10��),�ղŵ������Ч��"
            SmsReply('0','5','9','2','C',"7BA1740653F778015DF26EE1FF086700591A003100304E2AFF0C521A624D7686DFB52A0465E06548FF01"); 		 
            goto clrSMS;
          }
          if (FindStr(EnTelBook,SMSCallInTel)>=12*MTelNum)
          {//�ظ����ţ�"����Ȩ��Ӻ��룡"
            SmsReply('0','2','9','0','E',"60A865E067436DFB52A053F77801FF01");
            goto clrSMS;
          }
          delay(6);	   //�ȴ������������
          if ((RS3[Temp1+48]=='1')&&(RS3[Temp1+52]!='0'))
          { //���ֻ����봦��
            if (Validity(Temp1+45,11))
            {//��Ӵ���
              GainComandTel(Temp1+48,11);  //�����Ӻ���
              SMSComandTel[12]='\0';       //��õĺ�����Ϊһ���ַ���			  
              if (FindStr(EnTelBook,SMSComandTel))  
              {//��Ӻ�����������,�ظ����ţ�"�ú����Ѵ��ڣ�"
	SmsReply('0','2','9','0','E',"8BE553F778015DF25B585728FF01");
	goto clrSMS; 
              } 			 			  	
              else
              {//��Ӻ��벻��������,����Ӵ���
	for (i=12*(MTelNum+STelNum);i>12*MTelNum-1;i--)
	  EnTelBook[i+12]=EnTelBook[i];     //��������������Ȩ�������κ���12��λ��
	for (i=12*MTelNum;i<12*MTelNum+12;i++)
	  EnTelBook[i]=SMSComandTel[i];     //�Ӻ����ڰ������й������֮β
	MTelNum++;     //����������+1
	ImportIAP();		    //������EEPROM
             //�ظ����ţ�"�ú�������ӣ�"
	SmsReply('0','2','9','0','E',"8BE553F778015DF26DFB52A0FF01");
	goto clrSMS; 
              }			
            }
          }
          goto error;   //���ֻ����룬�ظ����ţ�"�������"		  
        }
      //2��"��Ȩ"���������Ȩ����	
        if (FindStr(RS3,"63886743"))         //63886743Ϊ"��Ȩ"unicode��     
        { //�����Ȩ���봦��
          if (MTelNum+STelNum>30)
          {//��Ȩ�����������ظ����ţ�"����������(���30��),�ղŵ������Ч��"
            SmsReply('0','5','7','2','A',"767D540D53555DF26EE1FF086700591A003300304E2AFF0C521A624D7686DFB52A0465E06548FF01"); 		 
            goto clrSMS;
          }
          if (FindStr(EnTelBook,SMSCallInTel)>=12*MTelNum)
          {//�ظ����ţ�"����Ȩ��Ӻ��룡"
            SmsReply('0','2','9','0','E',"60A865E067436DFB52A053F77801FF01");
            goto clrSMS;
          }
          delay(6);   //�ȴ������������
          if (Validity(Temp1+45,12))
            GainComandTel(Temp1+48,12);  //�����Ӻ���         
          else
            if (Validity(Temp1+45,11))
            { GainComandTel(Temp1+48,11);  //�����Ӻ���
              SMSComandTel[11]='F';
            }
            else
              goto  error;  //ת�ظ����ţ�"�������"
          if (SMSComandTel[0]=='0'||((SMSComandTel[0]=='1')&&(SMSComandTel[1]!='0')))
            if (FindStr(EnTelBook,SMSComandTel))  
            {//��Ӻ�����������,�ظ����ţ�"�ú����Ѵ��ڣ�"
              SmsReply('0','2','9','0','E',"8BE553F778015DF25B585728FF01");
              goto clrSMS; 
            } 			 			  	
            else
            {//��Ӻ��벻��������������Ӵ���
              for (i=0;i<13;i++)
	EnTelBook[12*(MTelNum+STelNum)+i]=SMSComandTel[i];  //�Ӻ����ڰ�����β
              STelNum++;     //��Ȩ�������+1
              ImportIAP();   //������EEPROM
             //�ظ����ţ�"�ú�������ӣ�"
              SmsReply('0','2','9','0','E',"8BE553F778015DF26DFB52A0FF01");
              goto clrSMS; 
            }
          else
            goto  error;  //ת�ظ����ţ�"�������"			          		  
        }
      //3��"�鿴"�����鿴ȫ�����趨�ĺ���	 
        if (FindStr(RS3,"67E5770B"))   //67E5770BΪ"�鿴"unicode�� 
        { /*תΪӢ�Ķ��Ÿ�ʽ*/
          SMSCallInTel[11]='\0';
          SIO1SendStrs("AT+CMGF=1");   //Ӣ�Ķ��Ÿ�ʽ
          SIO1SendChar(13);	       //<CR>
          SIO1SendChar(10);	       //<LF>
          delay(3);
          SIO1SendStrs("AT+CMGS=");    //���ŷ�������
          SIO1SendChar(0x22);	       //"""ASCII��
          SIO1SendStrs(SMSCallInTel);  //�ظ����Ŷ���
          SIO1SendChar(0x22);	       //"""ASCII��
          SIO1SendChar(13);	       //<CR>
          SIO1SendChar(10);	       //<LF>
          delay(3);	       //�ȴ��������
        //���͹������(11λ�ֻ����룩
          i=0;
          while (EnTelBook[i]!='\0')
          { if (EnTelBook[i]!='F')
              SIO1SendChar(EnTelBook[i]); //��ǰ����λ*/
            i++;                    	            
            if (i%12==0)
              if ((i==12*MTelNum)||(i==12*(MTelNum+STelNum)))
              { SIO1SendChar(46);       //"."ASCII��
                 if (i==12*MTelNum)
                 { SIO1SendChar(13);    //<CR>
                   SIO1SendChar(10);    //<LF>
                 }
              }
              else
                 SIO1SendChar(44);	               //","ASCII��
          }                	         
          SIO1SendChar(26);	  //ctrl+z
        /*תΪ���Ķ��Ÿ�ʽ*/
          delay(50);	 //�ȴ��������
          SIO1SendStrs("AT+CMGF=0");    
          SIO1SendChar(13);	        //<CR>
          SIO1SendChar(10);	        //<LF>
          delay(3);              //�ȴ��������
          goto clrSMS;
        }   	 	
      //4��"���"�������ȫ�����룬������1��ԭʼ����   
        if (FindStr(RS3,"6E059664"))   	  //6E059664Ϊ"���"unicode��
        { //������봦��
          if (FindStr(EnTelBook,SMSCallInTel)>=12*MTelNum)
          {//�ظ����ţ�"����Ȩ������룡"
            SmsReply('0','2','9','0','E',"60A865E067436E05966453F77801FF01");
            goto clrSMS;
          }
          EnTelBook[12]='\0';    //1�������ַ���������        
          MTelNum=1;     //����1���������
          STelNum=0;     //����Ȩ����
          ImportIAP();   //�������ݣ�������Ч�ı���
       //�ظ����ţ�"������1���������,������ȫ�����!"
          SmsReply('0','5','1','2','4',"4FDD75594E8600314E2A7BA1740653F77801FF0C51764F595DF2516890E86E059664FF01");
          goto clrSMS;
       }	 
     //5��"ɾ��"����ɾ��ָ���ĺ���
       if (FindStr(RS3,"52209664"))    		  //52209664Ϊ"ɾ��"unicode��
       { if (FindStr(EnTelBook,SMSCallInTel)>=12*MTelNum)
         {//�ظ����ţ�"����Ȩɾ�����룡"
           SmsReply('0','2','9','0','E',"60A865E067435220966453F77801FF01");
           goto clrSMS;
         }
         delay(6);	   //�ȴ������������
         if (Validity(Temp1+45,12))
         { GainComandTel(Temp1+48,12);   //���12λ����
           goto Delete;
         }
         if (Validity(Temp1+45,11))
         { GainComandTel(Temp1+48,11);   //���11λ����
           SMSComandTel[11]='F';
           goto Delete;
         }
         //�ظ����ţ�"�ú��벻���ڣ�"
         SmsReply('0','2','9','0','E',"8BE553F778014E0D5B585728FF01");
         delay(3);
         goto clrSMS;
         Delete:
         i=FindStr(EnTelBook,SMSComandTel);
         if (!i)
         {//�ظ����ţ�"�ú��벻���ڣ�"
           SmsReply('0','2','9','0','E',"8BE553F778014E0D5B585728FF01");
           delay(3);
           goto clrSMS;
         }
         if (i==1) 
         {//ɾ������Ϊ�������룬�ظ����ţ�"�úű�������ɾ��"
           SmsReply('0','3','1','1','0',"8BE553F74FDD75594E0D80FD5220FF01");
           delay(3);
           goto clrSMS;
         }
         if (i<12*MTelNum)
           MTelNum--;    //ɾ������Ϊ�������
         else
           STelNum--;    //ɾ������Ϊ��Ȩ����
         i+=11;
         while (EnTelBook[i]!='\0')
         { EnTelBook[i-12]=EnTelBook[i];
           i++;
         }
         EnTelBook[i-12]='\0';
         ImportIAP();   //���浽EEPROM
        //�ظ����ţ�"�ú�����ɾ����"
         SmsReply('0','2','9','0','E',"8BE553F778015DF252209664FF01"); 
         goto clrSMS;            		  		  
       }
     //6��"��ѯ"�����ϴ��������ء�������ѹ��RDS������״̬���䡢�ŵ硢��������
       if (FindStr(RS3,"67E58BE2"))    	//67E58BE2Ϊ"��ѯ"unicode��
       { SmsReplyStatusParameters();	//�ظ����ţ���ǰ״̬������������
         delay(20);   //�ȴ��������
         goto clrSMS;
       }	
     //7��"����"							
       if (FindStr(RS3,"76D1542C"))    	//76D1542CΪ"����"unicode��
       { Listen();	                //�ز����10s¼����
         goto clrSMS;
       }	 
     //8��"����"			    	  	
       if (FindStr(RS3,"64AD653E"))             //64AD653EΪ"����"unicode��
       { delay(2);	                //�ȴ������������
         if (Validity(Temp1+45,4))
         {//ѭ������
           if (((RS3[Temp1+48]=='1')||(RS3[Temp1+48]=='2'))&&(RS3[Temp1+52]!='0'))
           { SMStimeElapsed=1200*(10*(RS3[Temp1+56]-'0')+RS3[Temp1+60]-'0');  //�����ʱֵ
             SMSplayLimit=1;	                                               //���ŵ㲥��ʱ��Ч
             MP3Play(RS3[Temp1+48]-'0',RS3[Temp1+52]-'0');                    //��������¼����
             if (EnPA) 
             { RDSRelay=0;	  //�Ͽ�RDS��Դ�̵���       
               CallInRelay=0;     //�Ͽ�������Դ�̵���
               MICSRelayL=0;      //�Ͽ��������̵���       
               MP3SRelay=1;	  //��ͨMP3��Դ�̵���
               VGRelay=1;         //��ͨ������MP3��ǰ�÷Ŵ���
               PASRelay=1;	  //�򿪹���
               if (RS3[Temp1+48]=='1')
               {//�ظ����ţ�"�ѿ������ڡ�����ѭ�����š������ӡ�"
	 SmsReplyHead('0','5','3','2','6');     			    //����ͷ���ĳ�53B,�������ݳ�38B
                 SIO1SendStrs("5DF25F00673AFF01000D000A7B2C003");   //"�ѿ���!��"unicode��
	 SIO1SendChar(RS3[Temp1+52]);					        //����			  
	 SIO1SendStrs("66F253555FAA73AF64AD653E003");	    //"����ѭ������"unicode��		                
	 SIO1SendChar(RS3[Temp1+56]);		    //����ʱ��ʮλ
	 SIO1SendStrs("003");	       
	 SIO1SendChar(RS3[Temp1+60]);		    //����ʱ���λ
	 SIO1SendStrs("5206949F3002");	                    //"���ӡ�"unicode��
                 SIO1SendChar(26);	                    //ctrl+z(���Ľ���)
               }
               else
               {//�ظ����ţ�"�ѿ������ӵڡ�����ѭ�����š������ӡ�"��¼���������
	 SmsReplyHead('0','5','5','2','8');     	  //����ͷ���ĳ�55B,�������ݳ�40B
                 SIO1SendStrs("5DF25F00673AFF01000D000A4ECE7B2C003");    //"�ѿ������ӵ�"unicode��
	 SIO1SendChar(RS3[Temp1+52]);		       //����			  
	 SIO1SendStrs("66F259275FAA73AF64AD653E003");	      //"����ѭ������"unicode��
	 SIO1SendChar(RS3[Temp1+56]);		      //����ʱ��ʮλ
	 SIO1SendStrs("003");		   
	 SIO1SendChar(RS3[Temp1+60]);		   //����ʱ���λ
	 SIO1SendStrs("5206949F3002");		                //"���ӡ�"unicode��
                 SIO1SendChar(26);	                                //ctrl+z(���Ľ���)
               }
               goto clrSMS;
             }
           }
           else
             goto error;      //ת�ظ����ţ�"�������"
          }
          else
            if (Validity(Temp1+45,2)&&(RS3[Temp1+48]=='0')&&(RS3[Temp1+52]!='0'))
            { //��������
              MP3Single=1;	     //MP3ģ�鵥��������Ч
              MP3Play(RS3[Temp1+48]-'0',RS3[Temp1+52]-'0');                    //��������¼����
              if (EnPA) 
              { RDSRelay=0;	  //�Ͽ�RDS��Դ�̵���       
                CallInRelay=0;    //�Ͽ�������Դ�̵���
                MICSRelayL=0;     //�Ͽ��������̵���       
                MP3SRelay=1;	  //��ͨMP3��Դ�̵���
                VGRelay=1;        //��ͨ������MP3��ǰ�÷Ŵ���
                PASRelay=1;	  //�򿪹���
               //�ظ����ţ�"�ѿ���!�ڡ����������š�"
                SmsReplyHead('0','4','3','1','C');         //����ͷ���ĳ�43B,�������ݳ�28B
                SIO1SendStrs("5DF25F00673AFF01000D000A7B2C003");    //"�ѿ���!��"unicode��
                SIO1SendChar(RS3[Temp1+52]);		    //����			  
                SIO1SendStrs("66F2535566F264AD653E3002");		    //"���������š�"unicode��
                SIO1SendChar(26);	                                //ctrl+z(���Ľ���)
              }
              goto clrSMS;
            }
            else																 
              goto error;	//ת�ظ����ţ�"�������" 
        }	    		    
      //9��"�ػ�"�����رչ��ź�MP3
        if (FindStr(RS3,"5173673A"))   			 //5173673AΪ"�ػ�"unicode��
        { RDSRelay=0;	  //�Ͽ�RDS��Դ�̵���       
          CallInRelay=0;          //�Ͽ�������Դ�̵���
          MICSRelayL=0;           //�Ͽ��������̵���       
          MP3SRelay=0;	  //�Ͽ�MP3��Դ�̵���
          VGRelay=0;              //��ͨRDS�뺰������ǰ�÷Ŵ���
          PASRelay=0;	  //�رչ���
          StopMP3();              //MP3ͣ��
          SmsReply('0','2','3','0','8',"5DF25173673AFF01"); //�ظ����ţ�"�ѹػ���"
          goto clrSMS;
        }  
      //10��"����"��������MP3����					 
        if (FindStr(RS3,"97F391CF"))        //97F391CFΪ"����"unicode��
        { delay(1);	//�ȴ������������
          if (Validity(Temp1+45,1)) 
          { VOL=RS3[Temp1+48]-'0';   //�����������
            PlayerVolume(VOL); //����������
            ImportIAP();	 //���浽EEprom
           //�ظ����ţ�"����������������Ϊ������"
            SmsReplyHead('0','3','9','1','8');       //����ͷ���ĳ�39B,��������24B
            SIO1SendStrs("64AD653E566897F391CF5DF28BBE7F6E4E3A003");    //"����������������Ϊ"unicode��
            SIO1SendChar(RS3[Temp1+48]);	   //��������			  
            SIO1SendStrs("7EA7FF01");	   //"����"unicode��						//"����"unicode��
            SIO1SendChar(26);	       //ctrl+z(���Ľ���)
            goto clrSMS;
          }
          else
            goto error;	//ת��������ʾ��"���Ŵ���"
        }
      //11��"���"�������ó���ѹ
        if (FindStr(RS3,"51457535"))	//51457535Ϊ"���"unicode��
        { if (FindStr(EnTelBook,SMSCallInTel)>=12*MTelNum)
          {//�ظ����ţ�"����Ȩ���ó�������"
            SmsReply('0','3','5','1','4',"60A865E067438BBE7F6E5145753553C26570FF01");
            goto clrSMS;
          }
          delay(2);	//�ȴ������������
          if (Validity(Temp1+45,4))
          { i=10*(RS3[Temp1+48]-'0')+RS3[Temp1+52]-'0';  //��ó���ѹ����
            if (i<CVEnmin)
            { //�ظ����ţ�"���س������CVEnmin~CVEnmaxV���ղŵ�������Ч��"
              ChargeOutOf: 
              SmsReplyHead('0','6','3','3','0');       //����ͷ���ĳ�63B,�������ݳ�48B
              SIO1SendStrs("84C475356C605145753596504E8E003");    //"���س������"unicode��
              SIO1SendChar(CVEnmin/10%10+'0');	  //CVEnminʮλ
              SIO1SendStrs("003");             
              SIO1SendChar(CVEnmin%10+'0');   	  //CVEnmin��λ
              SIO1SendStrs("FF5E003");
              SIO1SendChar(CVEnmax/10%10+'0');	  //CVEnmaxʮλ
              SIO1SendStrs("003");
              SIO1SendChar(CVEnmax%10+'0');   	  //CVEnmax��λ
              SIO1SendStrs("0056FF01000D000A521A624D76848BBE7F6E65E06548FF01");//"V���ղŵ�������Ч��"unicode��
              SIO1SendChar(26);	                  //ctrl+z(���Ľ���)
            }							   
            else
            { ChargeVmin=i;
              i=10*(RS3[Temp1+56]-'0')+RS3[Temp1+60]-'0';  //��ó���ѹ����	
              if (i>CVEnmax)	
                goto ChargeOutOf;	  //ת�ظ����ţ�"���س������CVEnmin~CVEnmaxV���ղŵ�������Ч��"				   
              else
                ChargeVmax=i;
              ImportIAP();		  //������EEPROM
           //�ظ����ţ�"���س���ѹ������Ϊ����~����V��"
              SmsReplyHead('0','5','1','2','4');   //����ͷ���ĳ�51B,�������ݳ�36B 
              SIO1SendStrs("84C475356C60514575357535538B5DF28BBE7F6E4E3A003");    //"���س���ѹ������Ϊ"unicode��
              SIO1SendChar(RS3[Temp1+48]);    	  //���õĳ���ѹ����ʮλ
              SIO1SendStrs("003");
              SIO1SendChar(RS3[Temp1+52]);    	  //���õĳ���ѹ���޸�λ
              SIO1SendStrs("FF5E003");
              SIO1SendChar(RS3[Temp1+56]);         //���õĳ���ѹ����ʮλ
              SIO1SendStrs("003");
              SIO1SendChar(RS3[Temp1+60]);    	  //���õĳ���ѹ���޸�λ
              SIO1SendStrs("0056FF01");							  //"V��"unicode��
              SIO1SendChar(26);	                  //ctrl+z(���Ľ���)	        
            }
            goto clrSMS;	   		  	    
          }
          else
             goto error;		  	    
       }  
     //12��"�ŵ�"�������÷ŵ��ѹ
       if (FindStr(RS3,"653E7535"))	//653E7535Ϊ"�ŵ�"unicode��
       { if (FindStr(EnTelBook,SMSCallInTel)>=12*MTelNum)
         {//�ظ����ţ�"����Ȩ���÷ŵ������"
           SmsReply('0','3','5','1','4',"60A865E067438BBE7F6E653E753553C26570FF01");
           goto clrSMS;
         }
         delay(2);	//�ȴ������������
         if (Validity(Temp1+45,4))
         { i=10*(RS3[Temp1+48]-'0')+RS3[Temp1+52]-'0';  //��÷ŵ��ѹ����
           if (i<DisCVEnmin)
           {//�������޼���ֵ���ظ����ţ�"���طŵ�����VDEnmin~VDEnminV���ղŵ�������Ч��"
             DisChOutOf: 
             SmsReplyHead('0','6','3','3','0');       //����ͷ���ĳ�63B,�������ݳ�48B
             SIO1SendStrs("84C475356C60653E753596504E8E003");    //"���طŵ�����"unicode��
             DisChRange: 
             SIO1SendChar(DisCVEnmin/10%10+'0');	    //DisCVEnminʮλ
             SIO1SendStrs("003");
             SIO1SendChar(DisCVEnmin%10+'0');	    //DisCVEnmin��λ
             SIO1SendStrs("FF5E003");
             SIO1SendChar(DisCVEnmax/10%10+'0');	    //DisCVEnmaxʮλ
             SIO1SendStrs("003");
             SIO1SendChar(DisCVEnmax%10+'0');	    //DisCVEnmax��λ
             SIO1SendStrs("0056FF01000D000A521A624D76848BBE7F6E65E06548FF01");  //"V���ղŵ�������Ч��"unicode��
             SIO1SendChar(26);	          //ctrl+z(���Ľ���)
             goto clrSMS;
           }							   
            else
            { DischargeVmin=i;
              i=10*(RS3[Temp1+56]-'0')+RS3[Temp1+60]-'0';  //��÷ŵ��ѹ����	
              if (i>DisCVEnmax)
                goto DisChOutOf;	//ת�ظ����ţ�"���طŵ�����VDEnmin~VDEnminV���ղŵ�������Ч��"							   
              else
                DischargeVmax=i;
              ImportIAP();		                //������EEPROM��������Ч
           //�ظ����ţ�"���طŵ��ѹ������Ϊ����~����V��"
              SmsReplyHead('0','5','1','2','4');      //����ͷ���ĳ�51B,�������ݳ�36B
              SIO1SendStrs("84C475356C60653E75357535538B5DF28BBE7F6E4E3A003");    //"���طŵ��ѹ������Ϊ"
              goto DisChRange;  	      //ת��Χ����
            }   		  	    
          }
          else
            goto error;
        }
      //13��"����"��������MP3ģ������(������)
        if (FindStr(RS3,"65E5671F"))	//65E5671FΪ"����"unicode��
        { delay(2);	//�ȴ������������
          if (Validity(Temp1+45,6))
          { i=2000+10*(RS3[Temp1+48]-'0')+RS3[Temp1+52]-'0';  //�����(���ǰ��λ�̶�Ϊ20)
            j=10*(RS3[Temp1+56]-'0')+RS3[Temp1+60]-'0';       //�����
            k=10*(RS3[Temp1+64]-'0')+RS3[Temp1+68]-'0';       //�����
            if ((j==0)||(j>12)||(k==0)||(k>31))
              goto error;         //��Ϊ0�򳬹�12����Ϊ0�򳬹�31,��������Ϣ
            if ((j==2)&&(k>29))
              goto error;         //2�³���29,��������Ϣ
            if ((j==2)&&(k%4!=0)&&(k>28))
              goto error;         //���ܱ�4���������Ϊ������,��2�³���28,��������Ϣ
            if ((j==2)&&(k%100==0)&&(k%400!=0)&&(k==29))
              goto error;         //�ܱ�100���������ܱ�400���������Ϊ������,��2�³���28,��������Ϣ 
            if (((j==4)||(j==6)||(j==9)||(j==11))&&(k==31))
              goto error;         //4��6��9��11��Ϊ31,��������Ϣ 
            //�������մ��͵�MP3 
            S2BUF=0x7e;		   /*������������������ʼ�ֽ�*/
            while(!(S2CON&2));   //�ȴ��������
            S2CON&=0xfd;	       //���������ϱ�־
            S2BUF=6;		   /*�����������������ֽ���*/
            while(!(S2CON&2));   //�ȴ��������
            S2CON&=0xfd;	       //���������ϱ�־
            S2BUF=0xb1;	                   /*�������������������ֽ�*/
            while(!(S2CON&2));   //�ȴ��������
            S2CON&=0xfd;	       //���������ϱ�־
            S2BUF=i/256;	                  /*������ǰ��λ�ֽ�*/
            while(!(S2CON&2));   //�ȴ�������� 
            S2CON&=0xfd;	       //���������ϱ�־
            S2BUF=i%256;	                  /*��������λ�ֽ�*/
            while(!(S2CON&2));   //�ȴ�������� 
            S2CON&=0xfd;	       //���������ϱ�־
            S2BUF=j;	                  /*�������ֽ�*/
            while(!(S2CON&2));   //�ȴ�������� 
            S2CON&=0xfd;	       //���������ϱ�־
            S2BUF=k;	                  /*�������ֽ�*/
            while(!(S2CON&2));   //�ȴ�������� 
            S2CON&=0xfd;	       //���������ϱ�־
            S2BUF=0x7e;	                  /*��������������������ֽ�*/
            while(!(S2CON&2));   //�ȴ�������� 
            S2CON&=0xfd;	       //���������ϱ�־ 
          //�ظ����ţ�"����������Ϊ20����������¡����գ�"
            SmsReplyHead('0','5','1','2','4');      //����ͷ���ĳ�51B,��������36B
            SIO1SendStrs("65E5671F5DF28BBE7F6E4E3A00320030003");    //"����������Ϊ20"unicode��   
            SIO1SendChar(RS3[Temp1+48]);  
            SIO1SendStrs("003");   
            SIO1SendChar(RS3[Temp1+52]); 
            SIO1SendStrs("5E74003");      //�ѷ���"20xx��"
            SIO1SendChar(RS3[Temp1+56]); 
            SIO1SendStrs("003"); 
            SIO1SendChar(RS3[Temp1+60]); 
            SIO1SendStrs("6708003");      //�ѷ���"xx��"
            SIO1SendChar(RS3[Temp1+64]);
            SIO1SendStrs("003");  
            SIO1SendChar(RS3[Temp1+68]); 
            SIO1SendStrs("65E5FF01");     //�ѷ���"xx��!"           			     						//"����"unicode��
            SIO1SendChar(26);	          //ctrl+z(���Ľ���)
            goto clrSMS;               
          }
          else
            goto error;
        }
      //14��"ʱ��"��������MP3ģ��ʱ��(ʱ����)
        if (FindStr(RS3,"65F695F4"))	//65F6595F4Ϊ"ʱ��"unicode��
        { delay(2);              	//�ȴ������������           
          if (Validity(Temp1+45,6))
          { i=10*(RS3[Temp1+48]-'0')+RS3[Temp1+52]-'0';       //���ʱ
            j=10*(RS3[Temp1+56]-'0')+RS3[Temp1+60]-'0';       //��÷�
            k=10*(RS3[Temp1+64]-'0')+RS3[Temp1+68]-'0';       //�����
            if ((i>23)||(j>59)||(k>59))
              goto error;         //ʱ���볬��Χ,��������Ϣ
           //��ʱ���봫�͵�MP3 
            S2BUF=0x7e;		   /*����ʱ������������ʼ�ֽ�*/
            while(!(S2CON&2));   //�ȴ��������
            S2CON&=0xfd;	       //���������ϱ�־
            S2BUF=5;		   /*����ʱ�����������ֽ���*/
            while(!(S2CON&2));   //�ȴ��������
            S2CON&=0xfd;	       //���������ϱ�־
            S2BUF=0xb2;	                   /*����ʱ�������������ֽ�*/
            while(!(S2CON&2));   //�ȴ��������
            S2CON&=0xfd;	       //���������ϱ�־
            S2BUF=i;	                  /*����ʱ�ֽ�*/
            while(!(S2CON&2));   //�ȴ�������� 
            S2CON&=0xfd;	       //���������ϱ�־
            S2BUF=j;	                  /*���ͷ��ֽ�*/
            while(!(S2CON&2));   //�ȴ�������� 
            S2CON&=0xfd;	       //���������ϱ�־
            S2BUF=k;	                  /*�������ֽ�*/
            while(!(S2CON&2));   //�ȴ�������� 
            S2CON&=0xfd;	       //���������ϱ�־
            S2BUF=0x7e;	                  /*����ʱ��������������ֽ�*/
            while(!(S2CON&2));   //�ȴ�������� 
            S2CON&=0xfd;	       //���������ϱ�־ 
          //�ظ����ţ�"ʱ��������Ϊ����:����:����!"
            SmsReplyHead('0','4','5','1','E');      //����ͷ���ĳ�39B,��������30B
            SIO1SendStrs("65F695F45DF28BBE7F6E4E3A003");    //"ʱ��������Ϊ"unicode��
            SIO1SendChar(RS3[Temp1+48]);	    //ʱ��λ
            SIO1SendStrs("003");    
            SIO1SendChar(RS3[Temp1+52]);            //ʱ��λ
            SIO1SendStrs("003A003");                //":"unicode��
            SIO1SendChar(RS3[Temp1+56]);            //�ָ�λ
            SIO1SendStrs("003");  
            SIO1SendChar(RS3[Temp1+60]);            //�ֵ�λ
            SIO1SendStrs("003A003");                //":"unicode��
            SIO1SendChar(RS3[Temp1+64]);            //���λ
            SIO1SendStrs("003");  
            SIO1SendChar(RS3[Temp1+68]);     	    //���λ		  
            SIO1SendStrs("FF01");	    //"!"unicode��						//"����"unicode��
            SIO1SendChar(26);	       //ctrl+z(���Ľ���)
            goto clrSMS;      
          }
        }
        error: 
        SmsReply('0','2','5','0','A',"547D4EE495198BEFFF01"); //�ظ����ţ�"�������"
        clrSMS: 
        delay(5);
        Rx=0;
        for (i=0;i<RxIn;i++)
          RS3[i]='\0';                //����ַ����ջ�����
        ClrSIM(Temp2-'0');           //ɾ��������֮ǰ���ж���
      }
    }
/*���һ�*/
    if (FindStr(RS3,"NO CARRIER"))
    { RDSRelay=0;	     //�Ͽ�RDS��Դ�̵���       
      CallInRelay=0;                 //�Ͽ�������Դ�̵���
      MICSRelayL=0;                  //�Ͽ��������̵���       
      MP3SRelay=0;                   //�Ͽ�MP3��Դ�̵���
      VGRelay=0;                     //��ͨRDS��MIC��ǰ�÷Ŵ���
      PASRelay=0;	     //�رչ���
      Rx=0;
      for (i=0;i<RxIn;i++) 
        RS3[i]='\0';                 //����ַ����ջ�����
    }
/*���ز���*/
    if (PlayDown)                    //"����"��
    { PlayDown=0;
      LCDBLARelay=1;                 //��LCD����
      LocalPlayDisplay(MusicNum);    //��ʾ"���ڲ���...��1��"
      MP3Play(0,MusicNum);           //�������ŵ�1��
      SMSplayLimit=0;                //���Ų���ʱ
    }
    if (PreyDown)                    //"��һ��"��
    { PreyDown=0;
      LCDBLARelay=1;                 //��LCD����
      if (LocalPlay)
      { LocalPlayDisplay(MusicNum);  //��ʾ"���ڲ���...��x��"
        MP3Play(0,MusicNum);         //����������һ��
        SMSplayLimit=0;              //���Ų���ʱ
      }
      else	  
      { Page=~Page;                  //��ѯ״̬��ҳ�л�
        if (Page)
          DTEStatus1();	     //��ʾ����1�����ѹ������2�����ѹ������е��ѹ
        else
          DTEStatus2();              //��ʾRDS����״̬�����ػ�״̬��2������״̬
        LCDOff=1;                    //LCD������8s��Ч
      }			  
    }
    if (NextDown)                    //"��һ��"��
    { NextDown=0;
      LCDBLARelay=1;                 //��LCD����
      if (LocalPlay)
      { LocalPlayDisplay(MusicNum);  //��ʾ"���ڲ���...��x��"
        MP3Play(0,MusicNum);         //����������һ��
        SMSplayLimit=0;              //����ʱ
      }
      else	 
      { DateTimeDisplay();           //��ʾ����ʱ��
        LCDOff=1;                    //LCD������15s��Ч
      }	
    }
/*���RDS
    if (RDSState&&EnPA)                
    { RDSRelay=1;	     //��ͨRDS��Դ�̵���       
      CallInRelay=0;                 //�Ͽ�������Դ�̵���
      MICSRelayL=0;                  //�Ͽ��������̵���       
      MP3SRelay=0;                   //�Ͽ�MP3��Դ�̵���
      VGRelay=0;                     //��ͨRDS�뺰������ǰ�÷Ŵ���
      PASRelay=1;	     //�򿪹���
    }
    else 
    { RDSRelay=0;	     //�Ͽ�RDS��Դ�̵���       
      CallInRelay=0;                 //�Ͽ�������Դ�̵���
      MICSRelayL=0;                  //�Ͽ��������̵���       
      MP3SRelay=0;                   //�Ͽ�MP3��Դ�̵���
      VGRelay=0;                     //��ͨRDS��MIC��ǰ�÷Ŵ���
      PASRelay=0;	     //�رչ���
    } */
  }
}

/*T0�жϺ�������4�����ز���������봦��MP3busy����봦�����غ�������6·����*/
void WatchDog() interrupt 1 using 2
{ uint V;
  TH0=(65536-5*110592/12)/256;	/*T0��ʱ50ms*/ //65536-11.0592*50000/12*/
  TL0=(65536-5*110592/12)%256;
  if (++Deltt>MaxDeltt) 
    Deltt=MaxDeltt; 
  //����""����/״̬""������
  key=KeyLocalPlay;  //��Ȿ��""����/״̬""��
  if ((key^SKPlay)&&key) 
  {//"����/״̬"����Ч
    State=!State;	    //"����/״̬"�л�
    if (State) 
    { MusicNum=1;	    //���ŵ�1��
      PlayDown=1;	    //���ز��ż���Ч
      LocalPlay=1;                  //���ز���
      if (EnPA) 
      { RDSRelay=0;	    //�Ͽ�RDS��Դ�̵���       
        CallInRelay=0;              //�Ͽ�������Դ�̵���
        MICSRelayL=0;               //�Ͽ��������̵���       
        MP3SRelay=1;	    //��ͨMP3��Դ�̵���
        VGRelay=1;                  //��ͨ������MP3��ǰ�÷Ŵ���
        PASRelay=1;	    //�򿪹���
      }
      else
      { LCDBLARelay=1;              //��LCD����
        CellLowDisplay();           //��ʾ��ص�ѹ���Ͳ��ܲ���
        BellUp(1000);
        LCDBLARelay=0;              //��LCD����
        ClearScreen();
      }
    }
    else 
    { RDSRelay=0;	    //�Ͽ�RDS��Դ�̵���       
      CallInRelay=0;                //�Ͽ�������Դ�̵���
      MICSRelayL=0;                 //�Ͽ��������̵���       
      MP3SRelay=0;                  //�Ͽ�MP3��Դ�̵���
      VGRelay=0;                    //��ͨRDS��MIC��ǰ�÷Ŵ���
      PASRelay=0;	    //�رչ���
      LCDBLARelay=0;                //��LCD����
      StopMP3();   	    //MP3ͣ��
      LocalPlay=0;	    //��������ֹͣ
      ClearScreen();                //LCD����
    }
  }
  SKPlay=key;	                    //����""����/״̬""��״̬
 //����"��һ��"������
  key=KeyLocalPrevious;             //��Ȿ�ص㲥"��һ��"��
  if ((key^SKPre)&&key) 	  
  {//"��һ��"����Ч�Ҳ���
    if (LocalPlay) 
    { if (--MusicNum==0) MusicNum=9;
        EnDeltt=1;                  //������"��һ��"��"��һ��"��������MP3�������֮���ʱ���
        Deltt=0;
    }
    PreyDown=1;	                    //���ص㲥"��һ��"����Ч
  }
  SKPre=key;	                    //����"��һ��"��״̬
 //����"��һ��"������
  key=KeyLocalNext;	    //��Ȿ�ر��ص㲥"��һ��"��
  if ((key^SKNext)&&key)
  {//"��һ��"����Ч�Ҳ���
    if (LocalPlay)
    { if (++MusicNum==10) MusicNum=1;
        EnDeltt=1;                  //������"��һ��"��"��һ��"��������MP3�������֮���ʱ���
        Deltt=0;
    }
    NextDown=1;	                    //���ص㲥"��һ��"����Ч
  }  
  SKNext=key;	                    //����"��һ��"��״̬
 //MP3busy״̬����봦��
  key=MP3Busy;	                    //���MP3ģ�����״̬
  if ((key^SMP3Busy)&&(key==0))
  {if (Deltt==MaxDeltt)  ClearScreen();//MP3ģ���������,LCD����
   if (MP3Single)
   { MP3Single=0;                   //���ŵ�����Ч
     RDSRelay=0;	    //�Ͽ�RDS��Դ�̵���       
     CallInRelay=0;                 //�Ͽ�������Դ�̵���
     MICSRelayL=0;                  //�Ͽ��������̵���       
     MP3SRelay=0;                   //�Ͽ�MP3��Դ�̵���
     VGRelay=0;                     //��ͨRDS�뺰������ǰ�÷Ŵ���
     PASRelay=0;                    //�رչ���
   }
  }      	   
  SMP3Busy=key;	       //����MP3busy״̬ 
 //��Ȿ�غ���
  key=MICState;        //��Ȿ�غ���������״̬
  if (key^MIC) 
    if (key)           //�����������ж���
    { RDSRelay=0;	  //�Ͽ�RDS��Դ�̵���       
      CallInRelay=0;              //�Ͽ�������Դ�̵���
      MICSRelayL=0;               //�Ͽ��������̵���       
      MP3SRelay=0;                //�Ͽ�MP3��Դ�̵���
      VGRelay=0;                  //��ͨRDS�뺰������ǰ�÷Ŵ���
      PASRelay=0;	  //�رչ���
    }
    else 
      if (EnPA) 
      { RDSRelay=0;	  //�Ͽ�RDS��Դ�̵���       
        CallInRelay=0;            //�Ͽ�������Դ�̵���
        MICSRelayL=1;             //��ͨ�������̵���       
        MP3SRelay=0;	  //�Ͽ�MP3��Դ�̵���
        VGRelay=0;                //��ͨRDS�뺰������ǰ�÷Ŵ���
        PASRelay=1;	  //�򿪹���
      }
  MIC=key; //���溰��������״̬
 //��Ȿ��״̬��ʾ�Ƿ�15��
  if (LCDOff) 
    if (StaDispCtrl++>250) //����״̬��ʾ��ʱ����������12.5��
    { //����12.5�뵽
      StaDispCtrl=0;
      LCDOff=0;
      LCDBLARelay=0;  //��LCD����
      ClearScreen();  //LCD����
    }	
//���Ų�����ʱ   
  if (SMSplayLimit)   
    if (SMStimeElapsed--==0)
    { SMSplayLimit=0;                  //ʱ�䵽,��ʱʧЧ
      RDSRelay=0;	       //�Ͽ�RDS��Դ�̵���       
      CallInRelay=0;                   //�Ͽ�������Դ�̵���
      MICSRelayL=0;                    //�Ͽ��������̵���       
      MP3SRelay=0;                     //�Ͽ�MP3��Դ�̵���
      VGRelay=0;                       //��ͨRDS��MIC��ǰ�÷Ŵ���
      PASRelay=0;                      //�رչ���
      StopMP3();	       //MP3ͣ��
    } 
//���6·�������
  while (!(ADC_CONTR&ADC_FLAG));       //ADCת��δ����,�ȴ�
  ADC_CONTR &=!ADC_FLAG;               //���ADCת��������־
  ADC_LOW2&=3;                         // ���θ�6λ
  V=4*ADC_RES+ADC_LOW2;
  switch (ch)
  { case 0:V=10.0*V0max*V/1024;break;  //����1�����ѹ(V),�Ŵ�10�� 		 
    case 1:V=10.0*V1max*V/1024;break;  //����2�����ѹ(V),�Ŵ�10��
    case 2:V=10.0*V4max*V/1024;break;  //��ӵ�Դ��ѹ(V),�Ŵ�10�� 		
    case 3:V=10.0*V5max*V/1024;break;  //��������ѹ(V),�Ŵ�10��  
    case 4:{ V=10.0*V6max*V/1024;      //���������ѹ(V),�Ŵ�10��
             if (V<10.0*DisCVEnmin)         
               EnPA=0;	       //��ص�ѹ�������÷ŵ����޼�ֵ,��ֹ���Ŵ�
             if (V>10.0*DisCVEnmax)
               EnPA=1;	       //��ص�ѹ�������÷ŵ����޼�ֵ,�����Ŵ�
             if (V>10.0*CVEnmin)         
               LVRelay=0;	       //��ص�ѹ�������ó�����޼�ֵ,��ֹ������
             if (V<10.0*CVEnmax) 
               LVRelay=1;	       //��ص�ѹ�������ó�����޼�ֵ,���������
           } break;  
    case 5:V=10.0*V7max*V/1024;        //���ص�ѹ(V),�Ŵ�10��
  }                            
  SampleResult[3*ch]=V%10;             //��ý����λ������
  V/=10;
  SampleResult[3*ch+1]=V%10;           //��ý����λ������
  V/=10;
  SampleResult[3*ch+2]=V%10;           //��ý����λ������
  if (++ch>5) 
    ch=0;
  ADC_CONTR = ADC_POWER|ADC_SPEEDLL|ADC_START|channel[ch];      	
}

/*����1�жϡ���ͨ������1����SIM300���͵�����*/
void ReciveData(void) interrupt 4 using 1
{ if(RI)
  { RS3[Rx]=SBUF;  //������1����SIM300���͵��������������� 
    RI=0;
    if(Rx++>RxIn-2)Rx=0;    //����RxIn-1��		
  }
}

/*PCA�жϡ���DTE����ʱ���Ʒ�������Ъ������*/
void PCA(void) interrupt 7 using 1
{ CCF0=0;                //����жϱ�־
  CCAP0L=value;
  CCAP0H=value>> 8;      //���±Ƚ�ֵ
  value+=fosc/12/20;
  if (SmapleStartCnt--==0)
  { SmapleStartCnt=5;   //��������0.5s
    BELL=~BELL;//�����з�������Ъ����
    ch++;
  }
}