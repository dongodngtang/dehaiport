using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using FormUI.OperationLayer;
using TomorrowSoft.BLL;
using TomorrowSoft.Model;

namespace FormUI.ManagerForms
{
    public partial class HistoryForm : Form
    {
        private readonly TomorrowSoft.BLL.HistoryRecordService _history = new HistoryRecordService();
        DataGridViewPrinter MyDataGridViewPrinter;
        private BindingSource bs = new BindingSource();
   
        public HistoryForm()
        {
            
            InitializeComponent();
            Printer.DataGridViewList = this.dataGridView1;
            bs.DataSource = _history.GetModelList("");
            GetHistoryList(bs);
          
        } 
      
        private void GetHistoryList(BindingSource bs)
        {
            
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoResizeColumn(4, DataGridViewAutoSizeColumnMode.AllCells);

           
        }
        private void btQuery_Click(object sender, EventArgs e)
        {
            StringBuilder sbQuery = new StringBuilder();
            sbQuery.AppendFormat("datetime([HandlerTime]) >= datetime('{0} 00:00') ", dtpBegin.Value.ToString("yyyy-MM-dd"));
            sbQuery.Append(" AND ");
            sbQuery.AppendFormat("datetime([HandlerTime]) <= datetime('{0}') ", dtpEnd.Value.ToString("yyyy-MM-dd HH:mm"));
            List<HistoryRecord> terminals = _history.GetModelList(sbQuery.ToString());
            bs.DataSource = terminals;
            GetHistoryList(bs);
        }

        
        private void btPrint_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                if (MessageBox.Show(string.Format(@"您确定要清除所有历史记录？"), "提示",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    _history.DeleteList("");
                    
                    MessageBox.Show("清除成功！");
                    GetHistoryList(bs);
                }
            }
            else
            {
                if(MessageBox .Show(string.Format( "您确定要删除{0}记录?",dataGridView1 .SelectedRows .Count ),"提示",
                MessageBoxButtons .OKCancel ,MessageBoxIcon.Question ) == DialogResult .OK )
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        _history.Delete(Convert.ToInt32(dataGridView1.SelectedRows[i].Cells[0].Value));
                    }
                    MessageBox.Show("删除成功！");
                    GetHistoryList(bs);
                }
            }

        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            if (LoginForm.Level == "管理员")
            {
                btClear.Visible  = true;
            }
        }
        private bool SetupThePrinting()
        {
            PrintDialog MyPrintDialog = new PrintDialog();
            MyPrintDialog.AllowCurrentPage = false;
            MyPrintDialog.AllowPrintToFile = false;
            MyPrintDialog.AllowSelection = false;
            MyPrintDialog.AllowSomePages = false;
            MyPrintDialog.PrintToFile = false;
            MyPrintDialog.ShowHelp = false;
            MyPrintDialog.ShowNetwork = false;

            if (MyPrintDialog.ShowDialog() != DialogResult.OK)
                return false;

            MyPrintDocument.DocumentName = "Customers Report";
            MyPrintDocument.PrinterSettings = MyPrintDialog.PrinterSettings;
            MyPrintDocument.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            MyPrintDocument.DefaultPageSettings.Margins = new Margins(20,20, 30, 30);

           
                MyDataGridViewPrinter = new DataGridViewPrinter(dataGridView1, MyPrintDocument, true, true, "通信记录", new Font("宋体", 10, FontStyle.Regular), Color.Black, true);
          
                //MyDataGridViewPrinter = new DataGridViewPrinter(dataGridView1, MyPrintDocument, false, true, "通信记录", new Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);

            return true;
        }
        
        private void MyPrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

            bool more = MyDataGridViewPrinter.DrawDataGridView(e.Graphics);
            if (more == true)
                e.HasMorePages = true;
          
          
        }
        private void PrintView()
        {
            if (SetupThePrinting())
            {
                PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
                MyPrintPreviewDialog.Document = MyPrintDocument;
                MyPrintPreviewDialog.ShowDialog();
            }
        }

        private void Print()
        {
            try
            {
               if (SetupThePrinting())
                MyPrintDocument.Print();
            }
            catch(Exception e )
            {
                throw new Exception(e.ToString());
            }
           
        }
    

     
    }
}
