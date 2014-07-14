#include <STC12C5A60S2.h>

/*sim300��ʼ��*/
void sim300Init()
{ Startsim300=0;		 
  delay(700);	                //Լ7s,����sim300
  Startsim300=1;  
  delay(2000);	                //Լ20s
  SIO1SendStrs("ATE1");         //�л���
  SIO1SendChar(0x0d);	        //<CR>
  SIO1SendChar(0x0a);           //<LF>
  delay(3);
  SIO1SendStrs("ATE1");         //�л���
  SIO1SendChar(0x0d);	        //<CR>*/
  SIO1SendChar(0x0a);           //<LF>
  delay(3);	       
  SIO1SendStrs("ATV1");         //��OK��ʽ����
  SIO1SendChar(0x0d);	        //<CR>
  SIO1SendChar(0x0a);	        //<LF>
  delay(3); 
  SIO1SendStrs("AT+CLIP=1");    //������ʾ
  SIO1SendChar(0x0d);	        //<CR>
  SIO1SendChar(0x0a);	        //<LF>
  delay(4);
  SIO1SendStrs("AT+CNMI=2,1");  //�����Ȼ��棬�������߿�������֪ͨ���浽Ĭ�ϵ��ڴ�λ�ã�����TE����֪ͨ
  SIO1SendChar(0x0d);	        //<CR>
  SIO1SendChar(0x0a);	        //<LF>
  delay(4);
  SIO1SendStrs("AT+CMGF=0");    //���Ķ��Ÿ�ʽ
  SIO1SendChar(0x0D);	        //<CR>
  SIO1SendChar(0x0a);	        //<LF>
  delay(3); 
  // ClrSIM(50);	  //ɾ��SIM��������50������
}

/*���Ͷ���ͷ*/
//���:mhs�������ĳ���(10����)��λ
//     mts�������ĳ���(10����)ʮλ
//     mus�������ĳ���(10����)��λ,
//     cts�������������ֽ���(16����)ʮλ
//     cus�������������ֽ���(16����)��λ 
void SmsReplyHead(uchar mhs,uchar mts,uchar mus,uchar cts,uchar cus)
{ uchar i;
  TelPDU();     //���ź���ת��ΪPDU��ʽ
  SIO1SendStrs("AT+CMGS=");                           //���ŷ�������
  if (mhs!='0')
    SIO1SendChar(mhs);								  //���ĳ���(10����)��λ
  SIO1SendChar(mts);	                              //���ĳ���(10����)ʮλ	
  SIO1SendChar(mus);	                              //���ĳ���(10����)��λ,��25B
  SIO1SendChar(13);	                                  //<CR>
  SIO1SendChar(10);	                                  //<LF>
  delay(3);
  SIO1SendStrs("0011000D9168");                       //������ʼ��
  for (i=0;i<12;i++)
    SIO1SendChar(SMSCallInTel[i]);                    //���Żظ�����   
  SIO1SendStrs("0008A0");                             //PDU08���������������ʱ��
  SIO1SendChar(cts);                                  //���������ֽ���(16����)ʮλ
  SIO1SendChar(cus);                                  //���������ֽ���(16����)��λ  
}
					 
/*���Żظ���������0��1~2.1��1~2.2��3.1��3.2��4��9*/
//���:mhs�������ĳ���(10����)��λ
//     mts�������ĳ���(10����)ʮλ
//     mus�������ĳ���(10����)��λ,
//     cts�������������ֽ���(16����)ʮλ
//     cus�������������ֽ���(16����)��λ
// Content�������������ַ���
void SmsReply(uchar  Mhs,uchar Mts,uchar  Mus,uchar Cts,uchar Cus,uchar *Content)                              
{ SmsReplyHead(Mhs,Mts,Mus,Cts,Cus);     			  //����ͷ
  SIO1SendStrs(Content);                              //��������
  SIO1SendChar(26);	                                  //ctrl+z(���Ľ���)	
}

/*DTE��ǰ״̬�����ò����ظ�*/
//�����ѹ������.��V
//��ص�ѹ������.��V
//������ѹ����.����V
//RDS���ѿ����أ�
//���ŵ�Դ���ѿ����أ�
//����ѹ������~����V
//�ŵ��ѹ������~����V
//���������� 7EA7   
void SmsReplyStatusParameters(void)
{ SmsReplyHead('1','5','5','8','C');   //����ͷ���ĳ�140B,�������ݳ�140B
 //�������.��V   (�����й�18B)    
  SIO1SendStrs("51494F0F003");         //"���"unicode��
  SIO1SendChar(SampleResult[2]+'0'); 	               //�����ѹʮλ
  SIO1SendStrs("003");				               
  SIO1SendChar(SampleResult[1]+'0');	               //�����ѹ��λ
  SIO1SendStrs("002E003");		                   //.unicode��
  SIO1SendChar(SampleResult[0]+'0');	               //�����ѹС�����1λ
  SIO1SendStrs("0056000D000A");		               //V��<CR>��<LF>unicode��       
 //��ء���.��V  (�����й�18B) 
  SIO1SendStrs("75356C60003");         //"���"unicode��
  SIO1SendChar(SampleResult[14]+'0');  	               //��ص�ѹʮλ
  SIO1SendStrs("003");				  
  SIO1SendChar(SampleResult[13]+'0'); 	               //��ص�ѹ��λ
  SIO1SendStrs("002E003");		  
  SIO1SendChar(SampleResult[12]+'0');  	               //��ص�ѹС�����1λ
  SIO1SendStrs("0056000D000A");		 			   //V��<CR>��<LF>unicode��
  //��Դ��.����V   (�����й�18B) 
  SIO1SendStrs("75356E90003");         //"��Դ"unicode�롢����unicode��߸�3λ
  SIO1SendChar(SampleResult[17]+'0');  	               //������ѹ����λ
  SIO1SendStrs("002E003");				  		   //С����
  SIO1SendChar(SampleResult[16]+'0'); 	               //������ѹС�����1λ
  SIO1SendStrs("003");		  
  SIO1SendChar(SampleResult[15]+'0');  	               //������ѹС�����2λ
  SIO1SendStrs("0056000D000A");		 
 //RDS�ѿ�(��)  (�����й�14B)  
  if (1)
    SIO1SendStrs("0052004400535DF25F00000D000A");  //"RDS:�ѿ�"��<CR>��<LF>unicode��
  else
    SIO1SendStrs("0052004400535DF25173000D000A");  //"RDS:�ѹ�"��<CR>��<LF>unicode��             
 //�����ѿ�(��) (�����й�12B)	
  if (1)
    SIO1SendStrs("529F653E5DF25F00000D000A");  //"�����ѿ�"��<CR>��<LF>unicode��
  else
    SIO1SendStrs("529F653E5DF25173000D000A");  //"�����ѹ�"��<CR>��<LF>unicode��        
 //��������(�쳣) (�����й�12B) 
  if (1)
    SIO1SendStrs("558753ED6B635E38000D000A");	//��������
  else
    SIO1SendStrs("558753ED5F025E38000D000A");	//�����쳣
//������~����V	 (�����й�20B)
  SIO1SendStrs("51457535003");		   //"���"unicode�� 
  SIO1SendChar(ChargeVmin/10%10+'0');
  SIO1SendStrs("003");
  SIO1SendChar(ChargeVmin%10+'0');
  SIO1SendStrs("FF5E003");
  SIO1SendChar(ChargeVmax/10%10+'0');
  SIO1SendStrs("003");
  SIO1SendChar(ChargeVmax%10+'0');
  SIO1SendStrs("0056000D000A");
//�ŵ����~����V   (�����й�20B)
  SIO1SendStrs("653E7535003");		   //"�ŵ�"unicode�� 
  SIO1SendChar(DischargeVmin/10%10+'0');
  SIO1SendStrs("003");
  SIO1SendChar(DischargeVmin%10+'0');
  SIO1SendStrs("FF5E003");
  SIO1SendChar(DischargeVmax/10%10+'0');
  SIO1SendStrs("003");
  SIO1SendChar(DischargeVmax%10+'0');
  SIO1SendStrs("0056000D000A");
//��������     (��8B)
  SIO1SendStrs("97F391CF003");
  SIO1SendChar(VOL+'0');
  SIO1SendStrs("7EA7");    	  
  SIO1SendChar(26);	         //ctrl+z(���Ľ���)	
}

/*�����������ź��¼����10s*/
void Listen(void)
{ uchar i;
  SIO1SendStrs("AT+COLP=1");             //���ųɹ���ֱ����ʾ
  SIO1SendChar(0x0d);	         //<CR>
  SIO1SendChar(0x0a);	         //<LF>
  SIO1SendStrs("ATD");                   
  for (i=0;i<11;i++)                     //����
    SIO1SendChar(SMSCallInTel[i]);       //����λ 
  SIO1SendChar(0x0d);	         //<CR>	  
  SIO1SendChar(0x0a);	         //<LF>
  MP3Play(0,MusicNum);                   //�������ŵ�1��
  delay(1000);	  	         //����10s
  SIO1SendStrs("ATH");                   //�һ�
  SIO1SendChar(0x0d);	         //<CR>
  SIO1SendChar(0x0a);	         //<LF>
  StopMP3();		         //ͣ��
}

/*ɾ��SIM����ǰn������*/
//��ڣ�SMSNum ��ɾ�������1������
void ClrSIM(uchar n)
{ uchar k,i,j; 
  for (k=1;k<n+1;k++)
  { if (k<10)
    { SIO1SendStrs("AT+CMGD=");  /*ɾ��ָ��*/
      SIO1SendChar(k+'0');	  /*��k��*/
      SIO1SendChar(13);	  /*<CR>*/
      SIO1SendChar(10);	  /*<LF>*/
      delay(4);
    }
    else
    { i=k/10;
      j=k%10;
      SIO1SendStrs("AT+CMGD=");  /*ɾ��ָ��*/
      SIO1SendChar(i+'0');	  /*��k��*/
      SIO1SendChar(j+'0');	 
      SIO1SendChar(13);	  /*<CR>*/
      SIO1SendChar(10);	  /*<LF>*/
      delay(4);
    } 
  }
}



