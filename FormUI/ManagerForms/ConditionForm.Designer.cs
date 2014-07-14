namespace FormUI.ManagerForms
{
    partial class ConditionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConditionForm));
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btPrint = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btQuery = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(312, 38);
            this.dtpBegin.MinimumSize = new System.Drawing.Size(4, 25);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(135, 25);
            this.dtpBegin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(257, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "日期：";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(16, 26);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(86, 48);
            this.btClear.TabIndex = 15;
            this.btClear.Text = "清除";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Visible = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "-";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(780, 562);
            this.panel6.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bindingNavigator1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 466);
            this.panel2.TabIndex = 18;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(780, 25);
            this.bindingNavigator1.TabIndex = 17;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column12,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column5});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(780, 438);
            this.dataGridView1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpBegin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btClear);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btPrint);
            this.panel1.Controls.Add(this.dtpEnd);
            this.panel1.Controls.Add(this.btQuery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 96);
            this.panel1.TabIndex = 16;
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(135, 26);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(86, 48);
            this.btPrint.TabIndex = 14;
            this.btPrint.Text = "打 印";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(473, 38);
            this.dtpEnd.MinimumSize = new System.Drawing.Size(4, 25);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(135, 25);
            this.dtpEnd.TabIndex = 12;
            // 
            // btQuery
            // 
            this.btQuery.Location = new System.Drawing.Point(644, 26);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(86, 48);
            this.btQuery.TabIndex = 13;
            this.btQuery.Text = "查 询";
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "序号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 54;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "PhoneNo";
            this.Column12.HeaderText = "终端";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 54;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Photovoltaic";
            this.Column2.HeaderText = "光伏 Ｖ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 72;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Battery";
            this.Column3.HeaderText = "蓄电池 Ｖ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 84;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PowerSource";
            this.Column4.HeaderText = "电源 Ｖ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            this.Column4.Width = 72;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "QS";
            this.Column7.HeaderText = "功放";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            this.Column7.Width = 54;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Horn1";
            this.Column8.HeaderText = "喇叭1";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 60;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Horn2";
            this.Column9.HeaderText = "喇叭2";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 60;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Horn3";
            this.Column10.HeaderText = "喇叭3";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 60;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Horn4";
            this.Column11.HeaderText = "喇叭4";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 60;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "HandlerTime";
            this.Column5.HeaderText = "日期";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 54;
            // 
            // ConditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 562);
            this.Controls.Add(this.panel6);
            this.MaximizeBox = false;
            this.Name = "ConditionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "状态查询";
            this.Load += new System.EventHandler(this.ConditionForm_Load);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btQuery;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}