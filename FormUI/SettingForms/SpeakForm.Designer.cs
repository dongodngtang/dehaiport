namespace FormUI.SettingForms
{
    partial class SpeakForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpeakForm));
            this.tbcOnDemandPlay = new System.Windows.Forms.TabControl();
            this.tapPlayOne = new System.Windows.Forms.TabPage();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btLinkOne = new System.Windows.Forms.Button();
            this.dgvPlayOne = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grouping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tapPalyGroup = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btLinkGroup = new System.Windows.Forms.Button();
            this.dgvPlayGroup = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupPhone0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tapPalyAll = new System.Windows.Forms.TabPage();
            this.btLinkAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcOnDemandPlay.SuspendLayout();
            this.tapPlayOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayOne)).BeginInit();
            this.tapPalyGroup.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayGroup)).BeginInit();
            this.tapPalyAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcOnDemandPlay
            // 
            this.tbcOnDemandPlay.Controls.Add(this.tapPlayOne);
            this.tbcOnDemandPlay.Controls.Add(this.tapPalyGroup);
            this.tbcOnDemandPlay.Controls.Add(this.tapPalyAll);
            this.tbcOnDemandPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcOnDemandPlay.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbcOnDemandPlay.Location = new System.Drawing.Point(0, 0);
            this.tbcOnDemandPlay.Name = "tbcOnDemandPlay";
            this.tbcOnDemandPlay.SelectedIndex = 0;
            this.tbcOnDemandPlay.Size = new System.Drawing.Size(732, 413);
            this.tbcOnDemandPlay.TabIndex = 1;
            // 
            // tapPlayOne
            // 
            this.tapPlayOne.Controls.Add(this.bindingNavigator1);
            this.tapPlayOne.Controls.Add(this.panel1);
            this.tapPlayOne.Controls.Add(this.dgvPlayOne);
            this.tapPlayOne.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tapPlayOne.Location = new System.Drawing.Point(4, 30);
            this.tapPlayOne.Name = "tapPlayOne";
            this.tapPlayOne.Padding = new System.Windows.Forms.Padding(3);
            this.tapPlayOne.Size = new System.Drawing.Size(724, 379);
            this.tapPlayOne.TabIndex = 0;
            this.tapPlayOne.Text = "        单 喊        ";
            this.tapPlayOne.UseVisualStyleBackColor = true;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 260);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(718, 25);
            this.bindingNavigator1.TabIndex = 2;
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btLinkOne);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 91);
            this.panel1.TabIndex = 1;
            // 
            // btLinkOne
            // 
            this.btLinkOne.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btLinkOne.Location = new System.Drawing.Point(278, 32);
            this.btLinkOne.Name = "btLinkOne";
            this.btLinkOne.Size = new System.Drawing.Size(138, 45);
            this.btLinkOne.TabIndex = 0;
            this.btLinkOne.Text = "连 通";
            this.btLinkOne.UseVisualStyleBackColor = true;
            this.btLinkOne.Click += new System.EventHandler(this.btLinkOne_Click);
            // 
            // dgvPlayOne
            // 
            this.dgvPlayOne.AllowUserToAddRows = false;
            this.dgvPlayOne.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlayOne.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPlayOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayOne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Grouping,
            this.Address,
            this.PhoneNo,
            this.GroupPhone,
            this.AllPhone});
            this.dgvPlayOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlayOne.Location = new System.Drawing.Point(3, 3);
            this.dgvPlayOne.MultiSelect = false;
            this.dgvPlayOne.Name = "dgvPlayOne";
            this.dgvPlayOne.ReadOnly = true;
            this.dgvPlayOne.RowTemplate.Height = 23;
            this.dgvPlayOne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayOne.Size = new System.Drawing.Size(718, 373);
            this.dgvPlayOne.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "端口编号";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Grouping
            // 
            this.Grouping.DataPropertyName = "Grouping";
            this.Grouping.HeaderText = "组号";
            this.Grouping.Name = "Grouping";
            this.Grouping.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "端口地址";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // PhoneNo
            // 
            this.PhoneNo.DataPropertyName = "PhoneNo";
            this.PhoneNo.HeaderText = "端口号码";
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.ReadOnly = true;
            // 
            // GroupPhone
            // 
            this.GroupPhone.DataPropertyName = "GroupPhone";
            this.GroupPhone.HeaderText = "组绑定号";
            this.GroupPhone.Name = "GroupPhone";
            this.GroupPhone.ReadOnly = true;
            // 
            // AllPhone
            // 
            this.AllPhone.DataPropertyName = "AllPhone";
            this.AllPhone.HeaderText = "齐绑定号";
            this.AllPhone.Name = "AllPhone";
            this.AllPhone.ReadOnly = true;
            // 
            // tapPalyGroup
            // 
            this.tapPalyGroup.Controls.Add(this.panel2);
            this.tapPalyGroup.Controls.Add(this.dgvPlayGroup);
            this.tapPalyGroup.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tapPalyGroup.Location = new System.Drawing.Point(4, 30);
            this.tapPalyGroup.Name = "tapPalyGroup";
            this.tapPalyGroup.Padding = new System.Windows.Forms.Padding(3);
            this.tapPalyGroup.Size = new System.Drawing.Size(724, 379);
            this.tapPalyGroup.TabIndex = 1;
            this.tapPalyGroup.Text = "        组 喊        ";
            this.tapPalyGroup.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btLinkGroup);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 88);
            this.panel2.TabIndex = 2;
            // 
            // btLinkGroup
            // 
            this.btLinkGroup.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btLinkGroup.Location = new System.Drawing.Point(284, 16);
            this.btLinkGroup.Name = "btLinkGroup";
            this.btLinkGroup.Size = new System.Drawing.Size(132, 56);
            this.btLinkGroup.TabIndex = 0;
            this.btLinkGroup.Text = "连 通";
            this.btLinkGroup.UseVisualStyleBackColor = true;
            this.btLinkGroup.Click += new System.EventHandler(this.btLinkGroup_Click);
            // 
            // dgvPlayGroup
            // 
            this.dgvPlayGroup.AllowUserToAddRows = false;
            this.dgvPlayGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlayGroup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPlayGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.GroupPhone0,
            this.Column10});
            this.dgvPlayGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlayGroup.Location = new System.Drawing.Point(3, 3);
            this.dgvPlayGroup.MultiSelect = false;
            this.dgvPlayGroup.Name = "dgvPlayGroup";
            this.dgvPlayGroup.ReadOnly = true;
            this.dgvPlayGroup.RowTemplate.Height = 23;
            this.dgvPlayGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayGroup.Size = new System.Drawing.Size(718, 373);
            this.dgvPlayGroup.TabIndex = 1;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Grouping";
            this.Column9.HeaderText = "终端组号";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // GroupPhone0
            // 
            this.GroupPhone0.DataPropertyName = "GroupPhone";
            this.GroupPhone0.HeaderText = "组绑定号";
            this.GroupPhone0.Name = "GroupPhone0";
            this.GroupPhone0.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Address";
            this.Column10.HeaderText = "终端地址区域";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // tapPalyAll
            // 
            this.tapPalyAll.Controls.Add(this.btLinkAll);
            this.tapPalyAll.Controls.Add(this.label1);
            this.tapPalyAll.Location = new System.Drawing.Point(4, 30);
            this.tapPalyAll.Name = "tapPalyAll";
            this.tapPalyAll.Padding = new System.Windows.Forms.Padding(3);
            this.tapPalyAll.Size = new System.Drawing.Size(724, 379);
            this.tapPalyAll.TabIndex = 2;
            this.tapPalyAll.Text = "        齐 喊        ";
            this.tapPalyAll.UseVisualStyleBackColor = true;
            // 
            // btLinkAll
            // 
            this.btLinkAll.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btLinkAll.Location = new System.Drawing.Point(271, 191);
            this.btLinkAll.Margin = new System.Windows.Forms.Padding(2);
            this.btLinkAll.Name = "btLinkAll";
            this.btLinkAll.Size = new System.Drawing.Size(166, 53);
            this.btLinkAll.TabIndex = 7;
            this.btLinkAll.Text = "连 通";
            this.btLinkAll.UseVisualStyleBackColor = true;
            this.btLinkAll.Click += new System.EventHandler(this.btLinkAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(238, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "齐喊将连通所有终端";
            // 
            // SpeakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 413);
            this.Controls.Add(this.tbcOnDemandPlay);
            this.Name = "SpeakForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "喊 话";
            this.Load += new System.EventHandler(this.SpeakForm_Load);
            this.tbcOnDemandPlay.ResumeLayout(false);
            this.tapPlayOne.ResumeLayout(false);
            this.tapPlayOne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayOne)).EndInit();
            this.tapPalyGroup.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayGroup)).EndInit();
            this.tapPalyAll.ResumeLayout(false);
            this.tapPalyAll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcOnDemandPlay;
        private System.Windows.Forms.TabPage tapPlayOne;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btLinkOne;
        private System.Windows.Forms.DataGridView dgvPlayOne;
        private System.Windows.Forms.TabPage tapPalyGroup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btLinkGroup;
        private System.Windows.Forms.DataGridView dgvPlayGroup;
        private System.Windows.Forms.TabPage tapPalyAll;
        private System.Windows.Forms.Button btLinkAll;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grouping;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupPhone0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;

    }
}