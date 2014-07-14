using System;
using System.Windows.Forms;

namespace Infrastructure
{
    public static class Handler
    {
        /// <summary>
        /// 只能输入数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void PhoneNumber(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void Nuber09(object sender,KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }  
        }
    }
}