using System;
using System.Windows.Forms;
using Infrastructure;
using TomorrowSoft.BLL;
using TomorrowSoft.Model;

namespace FormUI.ManagerForms
{
    public partial class WhiteListAddForm : Form
    {
        private readonly WhiteListService _service = new WhiteListService();
        
        public WhiteListAddForm()
        {
            InitializeComponent();
            InitType();
            txtPhoneNo.KeyPress += Handler.PhoneNumber;
           
        }
        private readonly WhiteList editList;
        public WhiteListAddForm(WhiteList edit):this()
        {
            editList = edit;
            this.Text = "白名单编辑";
            txtPhoneNo.Text = edit.PhoneNo;
            cbType.SelectedItem = edit.Type.ToString();
        }

        private void tbWhiteListAdd_Click(object sender, EventArgs e)
        {
            
                if (editList == null)
                {
                    try
                    {
                     AddWhilteList();
                    }catch {}
                    
                }
                else
                {   
                    EditWhiteList();
                }
           
        }
     
        private void EditWhiteList()
        {
            var model = new WhiteList()
            {
                Id = editList .Id,
                Type = Enum<WhiteListType>.Parse(cbType.Text),
                PhoneNo = txtPhoneNo.Text,
            };
            try
            {
                _service.Update(model);
                MessageBox.Show("修改成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改失败！原因：" + ex.Message + "。");
            }
        }
               
    private void AddWhilteList()
        {
            var model = new WhiteList()
            {
                Type = Enum<WhiteListType>.Parse(cbType.Text),
                PhoneNo = txtPhoneNo.Text,
            };
            try
            {
                _service.Add(model);
                MessageBox.Show("添加成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加失败！原因：" + ex.Message + "。");
            }
        }

        private void InitType()
        {
            cbType.Items.Clear();
            foreach (WhiteListType type in Enum.GetValues(typeof(WhiteListType)))
            {
                cbType.Items.Add(type.ToString());
            }
          
        }

        private void WhiteListAddForm_Load(object sender, EventArgs e)
        {
            this.txtPhoneNo.SelectAll();
            this.txtPhoneNo.Focus();
        }
    }
}
