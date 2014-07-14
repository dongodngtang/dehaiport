using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FormUI.Properties;
using TomorrowSoft.Model;

namespace FormUI.OperationLayer
{
    public class ControlHelpers
    {
       

        /// <summary>
        ///DataGridView去掉第一列中重复的值
        /// </summary>
        /// <param name="dataGridView"></param>
        public static List<Terminal> DataGridViewCellSetNull(DataGridView dataGridView)
        {
            var isCell = new List<Terminal>();
            for (int i = 0; i < dataGridView.Rows.Count-1; i++)
            {
                string groupNo = dataGridView.Rows[i].Cells["Grouping"].Value.ToString();
                string address = dataGridView.Rows[i].Cells["Address"].Value.ToString();
                string groupPhone = dataGridView.Rows[i].Cells["GroupPhone"].Value.ToString();
                var Group = new Terminal()
                    {
                        Grouping = groupNo,
                        Address = address,
                        GroupPhone = groupPhone
                    };
                if (!isCell.Exists(x=>x.Grouping ==Group.Grouping))
                {
                    isCell.Add(Group);
                }
            }
            return isCell;
        }

        private static void SetTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                    SetTag(con);
            }
        }
        private static void SetControls(float newx, float newy, Control cons)
        {
            foreach (Control con in cons.Controls)
            {

                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
                float a = Convert.ToSingle(mytag[0]) * newx;
                con.Width = (int)a;
                a = Convert.ToSingle(mytag[1]) * newy;
                con.Height = (int)(a);
                a = Convert.ToSingle(mytag[2]) * newx;
                con.Left = (int)(a);
                a = Convert.ToSingle(mytag[3]) * newy;
                con.Top = (int)(a);
                Single currentSize = Convert.ToSingle(mytag[4]) * newy;
                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                if (con.Controls.Count > 0)
                {
                    SetControls(newx, newy, con);
                }
            }
          
        }
        private  float X;
        private  float Y;
        private Form newForm = null;
        /// <summary>
        /// 窗体最大化
        /// </summary>
        public  void FormChange(Form form)
        {
            
            newForm = form;
            form.Resize += FormResize;
            X = form.Width;
            Y = form.Height;
            SetTag(form);
 
        }
         void FormResize(object sender, EventArgs eventArgs)
        {
            // throw new Exception("The method or operation is not implemented.");  
            float newx = (newForm.Width) / X;
            //  float newy = (this.Height - this.statusStrip1.Height) / (Y - y);  
            float newy = newForm.Height / Y;
            //            y = this.statusStrip1.Height;   
            SetControls(newx, newy, newForm);
            //            this.Text = this.Width.ToString() + " " + this.Height.ToString();

        }  
    }
}