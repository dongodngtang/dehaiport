namespace FormUI.ManagerForms
{
    partial class WhiteListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhiteListForm));
            this.panelWhiteList = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panelWhite = new System.Windows.Forms.Panel();
            this.btEdit = new System.Windows.Forms.Button();
            this.btImportWhiteList = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btWhiteAdd = new System.Windows.Forms.Button();
            this.Leadpanel = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelWhiteList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.panelWhite.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWhiteList
            // 
            this.panelWhiteList.Controls.Add(this.dataGridView1);
            this.panelWhiteList.Controls.Add(this.bindingNavigator1);
            this.panelWhiteList.Controls.Add(this.panelWhite);
            this.panelWhiteList.Controls.Add(this.Leadpanel);
            this.panelWhiteList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWhiteList.Location = new System.Drawing.Point(0, 0);
            this.panelWhiteList.Name = "panelWhiteList";
            this.panelWhiteList.Size = new System.Drawing.Size(704, 373);
            this.panelWhiteList.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(704, 280);
            this.dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "序号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Type";
            this.Column2.HeaderText = "权限";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PhoneNo";
            this.Column3.HeaderText = "号码";
            this.Column3.Name = "Column3";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 348);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(704, 25);
            this.bindingNavigator1.TabIndex = 3;
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
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.SystemColors.Control;
            this.panelWhite.Controls.Add(this.btEdit);
            this.panelWhite.Controls.Add(this.btImportWhiteList);
            this.panelWhite.Controls.Add(this.btDelete);
            this.panelWhite.Controls.Add(this.btClear);
            this.panelWhite.Controls.Add(this.btWhiteAdd);
            this.panelWhite.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWhite.Location = new System.Drawing.Point(0, 0);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(704, 68);
            this.panelWhite.TabIndex = 1;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(218, 18);
            this.btEdit.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 35);
            this.btEdit.TabIndex = 6;
            this.btEdit.Text = "编 辑";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btImportWhiteList
            // 
            this.btImportWhiteList.Location = new System.Drawing.Point(511, 18);
            this.btImportWhiteList.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.btImportWhiteList.Name = "btImportWhiteList";
            this.btImportWhiteList.Size = new System.Drawing.Size(75, 35);
            this.btImportWhiteList.TabIndex = 5;
            this.btImportWhiteList.Text = "导 入";
            this.btImportWhiteList.UseVisualStyleBackColor = true;
            this.btImportWhiteList.Click += new System.EventHandler(this.btImportWhiteList_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(316, 18);
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 35);
            this.btDelete.TabIndex = 1;
            this.btDelete.Text = "删 除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(414, 18);
            this.btClear.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 35);
            this.btClear.TabIndex = 2;
            this.btClear.Text = "清 除";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btWhiteAdd
            // 
            this.btWhiteAdd.Location = new System.Drawing.Point(120, 18);
            this.btWhiteAdd.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.btWhiteAdd.Name = "btWhiteAdd";
            this.btWhiteAdd.Size = new System.Drawing.Size(75, 35);
            this.btWhiteAdd.TabIndex = 0;
            this.btWhiteAdd.Text = "添 加";
            this.btWhiteAdd.UseVisualStyleBackColor = true;
            this.btWhiteAdd.Click += new System.EventHandler(this.btWhiteAdd_Click);
            // 
            // Leadpanel
            // 
            this.Leadpanel.Location = new System.Drawing.Point(1, 64);
            this.Leadpanel.Name = "Leadpanel";
            this.Leadpanel.Size = new System.Drawing.Size(702, 284);
            this.Leadpanel.TabIndex = 5;
            this.Leadpanel.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // WhiteListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 373);
            this.Controls.Add(this.panelWhiteList);
            this.Name = "WhiteListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "白名单";
            this.Load += new System.EventHandler(this.WhiteListForm_Load);
            this.panelWhiteList.ResumeLayout(false);
            this.panelWhiteList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.panelWhite.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWhiteList;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btWhiteAdd;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btImportWhiteList;
        private System.Windows.Forms.Panel Leadpanel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;

    }
}