using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using FormUI.OperationLayer;
using FormUI.Properties;
using TomorrowSoft.BLL;
using TomorrowSoft.Model;

namespace FormUI.ManagerForms
{
    public partial class WhiteListForm : Form
    {
        private WhiteListService _service;

        public WhiteListForm()
        {
            InitializeComponent();
            _service = new WhiteListService();
         
            if (LoginForm.Level != "管理员")
            {
                btWhiteAdd.Enabled = false;
                btClear.Enabled = false;
                btDelete.Enabled = false;
                btImportWhiteList.Enabled = false;
              
            }
        }



        private void WhiteListForm_Load(object sender, EventArgs e)
        {
            GetWhiteList();
             new ControlHelpers().FormChange(this);
        }

        private void GetWhiteList()
        {
            var bs = new BindingSource();
            var whiteLists =  _service.GetModelList();
            bs.DataSource = whiteLists;
            dataGridView1.DataSource = bs;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            bindingNavigator1.BindingSource = bs;
        }

        private void btWhiteAdd_Click(object sender, EventArgs e)
        {

            Leadpanel.Visible = false;
            if(new WhiteListAddForm().ShowDialog()==DialogResult.OK)
                GetWhiteList();

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Leadpanel.Visible = false;
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请至少选择一行！");
            }
            else
            {
                if (MessageBox.Show(string.Format(@"您确定删除选中的 {0} 条标签吗？", dataGridView1.SelectedRows.Count),
                                    "提示",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    for (int index = 0; index < dataGridView1.SelectedRows.Count; index++)
                    {
                        var data = dataGridView1.SelectedRows[index].DataBoundItem as WhiteList;
                        if (data != null) _service.Delete(data.Id);
                    }
                    MessageBox.Show("删除成功！");
                    GetWhiteList();
                }

            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Leadpanel.Visible = false;
            if (MessageBox.Show("您是否清除全部白名单中的数据？",
                                "提示",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question) == DialogResult.OK)
            {
                _service.DeleteList("Id");
                MessageBox.Show("清除成功！");
                GetWhiteList();
            }
        }


        private void btImportWhiteList_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = Resources.WhiteList_Get_txt_files,
            };
        
            if (dialog.ShowDialog()!= DialogResult.OK) return;
          
            try
            {
                string str;
                using (var stream = dialog.OpenFile())
                {
                    using (var reader = new StreamReader(stream))
                    {
                        str=reader.ReadToEnd();
                        stream.Close();
                        reader.Close();
                    }
                }
                foreach (var whiteList in WhiteListSerializer(str))
                {
                    _service.Add(whiteList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            GetWhiteList();
        }

     /*   private void btExport_Click(object sender, EventArgs e)
        {

            try
            {
                using (var sw = new StreamWriter(@"D:\\白名单.txt"))
                {
                    sw.WriteLine(WhiteListDeserializer(_service.GetModelList()));
                    MessageBox.Show("导出成功！路径：D:\\白名单.txt。");
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }*/


        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择一条记录！");
                return;
            }
            var model = dataGridView1.SelectedRows[0].DataBoundItem as WhiteList;
            if (new WhiteListAddForm(model).ShowDialog()==DialogResult.OK)
                GetWhiteList();
        }


        #region 白名单转换
        private IEnumerable<WhiteList> WhiteListSerializer(string str)
        {
            //文件里面应该包含"."结束符
            var lastIndex = str.IndexOf(".", StringComparison.Ordinal);
            if (lastIndex < 1) throw new FileLoadException("请检查白名单文件，应以\".\"结尾");

            //第一个"."结束符之前的内容，才是真正的内容
            var realContent = str.Substring(0, lastIndex);

            //中控机号码&管理号码与普通终端号码的分隔符";"位置
            var splitIndex = realContent.LastIndexOf(";", StringComparison.Ordinal);

            //初始化管理号码组
            string[] managerArray= {};
            //如果白名单里面含有管理号码
            if (splitIndex>0)
            {
                //取出中控机号码+管理号码
                managerArray = realContent.Substring(0,splitIndex).Split(new[] {",", ";"}, StringSplitOptions.RemoveEmptyEntries);
                //为普通终端号码的split去掉";"
                splitIndex++;
            }

            //管理号码组初始位置为0
            var index = 0;
            //当第一个管理号码以","开头，说明第一个号码是中控机号码，index要++
            if (realContent.StartsWith(",") && managerArray.Length>0)
            {
                yield return new WhiteList
                {
                    Type = WhiteListType.中控机号码,
                    PhoneNo = managerArray[index]
                };
                index++;
            }
            //然后下面的都是管理号码
            for (var i = index; i < managerArray.Length; i++)
            {
                yield return new WhiteList
                {
                    Type = WhiteListType.管理号码,
                    PhoneNo = managerArray[i]
                };
            }
            //后面的是普通终端号码
            var userArray = realContent.Substring(splitIndex, realContent.Length - splitIndex)
                .Split(new[] {",", "."}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var user in userArray)
            {
                yield return new WhiteList
                {
                    Type=WhiteListType.授权号码,
                    PhoneNo = user
                };
            }
        }

        private string WhiteListDeserializer(IEnumerable<WhiteList> whiteLists)
        {
            string centre = string.Empty, manager = string.Empty, user = string.Empty;
            foreach (var whiteList in whiteLists)
            {
                switch (whiteList.Type)
                {
                    case WhiteListType.授权号码:
                        user += whiteList.PhoneNo + ",";
                        break;
                    case WhiteListType.管理号码:
                        manager += whiteList.PhoneNo +",";
                        break;
                    case WhiteListType.中控机号码:
                        centre = ","+whiteList.PhoneNo+",";
                        break;
                    default:
                        break;
                }
            }
            if (string.IsNullOrEmpty(centre) && string.IsNullOrEmpty(manager))
                return string.IsNullOrEmpty(user) ? string.Empty : user.TrimEnd(new[] { Convert.ToChar(",") }) + ".";
            return (centre + manager).TrimEnd(new[] { Convert.ToChar(",") }) + ";" + user.TrimEnd(new[] { Convert.ToChar(",") }) + ".";
        }

        #endregion

        

    }
}
