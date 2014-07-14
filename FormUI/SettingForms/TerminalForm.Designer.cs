namespace FormUI.SettingForms
{
    partial class TerminalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminalForm));
            this.tabMeetingNum = new System.Windows.Forms.TabPage();
            this.MeetingNo_End = new System.Windows.Forms.Button();
            this.MeetingNo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabTimer = new System.Windows.Forms.TabPage();
            this.btTimeSettingOK = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Second = new System.Windows.Forms.TextBox();
            this.Minute = new System.Windows.Forms.TextBox();
            this.Hour = new System.Windows.Forms.TextBox();
            this.Day = new System.Windows.Forms.TextBox();
            this.Mouth = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabList = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TernimalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grouping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btTerminalAdd = new System.Windows.Forms.Button();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabMeetingNum.SuspendLayout();
            this.tabTimer.SuspendLayout();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMeetingNum
            // 
            this.tabMeetingNum.Controls.Add(this.MeetingNo_End);
            this.tabMeetingNum.Controls.Add(this.MeetingNo);
            this.tabMeetingNum.Controls.Add(this.label16);
            this.tabMeetingNum.Location = new System.Drawing.Point(4, 29);
            this.tabMeetingNum.Name = "tabMeetingNum";
            this.tabMeetingNum.Padding = new System.Windows.Forms.Padding(3);
            this.tabMeetingNum.Size = new System.Drawing.Size(748, 379);
            this.tabMeetingNum.TabIndex = 4;
            this.tabMeetingNum.Text = "   会  议   ";
            this.tabMeetingNum.UseVisualStyleBackColor = true;
            // 
            // MeetingNo_End
            // 
            this.MeetingNo_End.Location = new System.Drawing.Point(372, 200);
            this.MeetingNo_End.Name = "MeetingNo_End";
            this.MeetingNo_End.Size = new System.Drawing.Size(135, 54);
            this.MeetingNo_End.TabIndex = 2;
            this.MeetingNo_End.Text = "确 定";
            this.MeetingNo_End.UseVisualStyleBackColor = true;
            this.MeetingNo_End.Click += new System.EventHandler(this.MeetingNo_End_Click);
            // 
            // MeetingNo
            // 
            this.MeetingNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FormUI.Properties.Settings.Default, "MeetingPhone", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MeetingNo.Location = new System.Drawing.Point(372, 125);
            this.MeetingNo.Name = "MeetingNo";
            this.MeetingNo.Size = new System.Drawing.Size(191, 29);
            this.MeetingNo.TabIndex = 1;
            this.MeetingNo.Text = global::FormUI.Properties.Settings.Default.MeetingPhone;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(257, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 21);
            this.label16.TabIndex = 0;
            this.label16.Text = "设置号码:";
            // 
            // tabTimer
            // 
            this.tabTimer.Controls.Add(this.btTimeSettingOK);
            this.tabTimer.Controls.Add(this.label12);
            this.tabTimer.Controls.Add(this.Second);
            this.tabTimer.Controls.Add(this.Minute);
            this.tabTimer.Controls.Add(this.Hour);
            this.tabTimer.Controls.Add(this.Day);
            this.tabTimer.Controls.Add(this.Mouth);
            this.tabTimer.Controls.Add(this.Year);
            this.tabTimer.Controls.Add(this.label11);
            this.tabTimer.Controls.Add(this.label10);
            this.tabTimer.Controls.Add(this.label9);
            this.tabTimer.Controls.Add(this.label13);
            this.tabTimer.Controls.Add(this.label15);
            this.tabTimer.Location = new System.Drawing.Point(4, 29);
            this.tabTimer.Margin = new System.Windows.Forms.Padding(5);
            this.tabTimer.Name = "tabTimer";
            this.tabTimer.Padding = new System.Windows.Forms.Padding(5);
            this.tabTimer.Size = new System.Drawing.Size(748, 379);
            this.tabTimer.TabIndex = 3;
            this.tabTimer.Text = "   时  间   ";
            this.tabTimer.UseVisualStyleBackColor = true;
            // 
            // btTimeSettingOK
            // 
            this.btTimeSettingOK.Location = new System.Drawing.Point(330, 211);
            this.btTimeSettingOK.Margin = new System.Windows.Forms.Padding(5);
            this.btTimeSettingOK.Name = "btTimeSettingOK";
            this.btTimeSettingOK.Size = new System.Drawing.Size(127, 48);
            this.btTimeSettingOK.TabIndex = 29;
            this.btTimeSettingOK.Text = "确  定";
            this.btTimeSettingOK.UseVisualStyleBackColor = true;
            this.btTimeSettingOK.Click += new System.EventHandler(this.btTimeSettingOK_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(641, 137);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 19);
            this.label12.TabIndex = 28;
            this.label12.Text = "秒";
            // 
            // Second
            // 
            this.Second.Location = new System.Drawing.Point(584, 134);
            this.Second.Margin = new System.Windows.Forms.Padding(5);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(47, 29);
            this.Second.TabIndex = 27;
            // 
            // Minute
            // 
            this.Minute.Location = new System.Drawing.Point(488, 136);
            this.Minute.Margin = new System.Windows.Forms.Padding(5);
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(47, 29);
            this.Minute.TabIndex = 25;
            // 
            // Hour
            // 
            this.Hour.Location = new System.Drawing.Point(392, 133);
            this.Hour.Margin = new System.Windows.Forms.Padding(5);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(47, 29);
            this.Hour.TabIndex = 23;
            // 
            // Day
            // 
            this.Day.Location = new System.Drawing.Point(296, 133);
            this.Day.Margin = new System.Windows.Forms.Padding(5);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(47, 29);
            this.Day.TabIndex = 21;
            // 
            // Mouth
            // 
            this.Mouth.Location = new System.Drawing.Point(200, 133);
            this.Mouth.Margin = new System.Windows.Forms.Padding(5);
            this.Mouth.Name = "Mouth";
            this.Mouth.Size = new System.Drawing.Size(47, 29);
            this.Mouth.TabIndex = 20;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(104, 133);
            this.Year.Margin = new System.Windows.Forms.Padding(5);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(47, 29);
            this.Year.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(545, 139);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 19);
            this.label11.TabIndex = 26;
            this.label11.Text = "分";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(449, 137);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "时";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(353, 137);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "日";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(257, 136);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 19);
            this.label13.TabIndex = 19;
            this.label13.Text = "月";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(161, 137);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 19);
            this.label15.TabIndex = 15;
            this.label15.Text = "年";
            // 
            // tabList
            // 
            this.tabList.BackColor = System.Drawing.SystemColors.Control;
            this.tabList.Controls.Add(this.dataGridView1);
            this.tabList.Controls.Add(this.btEdit);
            this.tabList.Controls.Add(this.btDelete);
            this.tabList.Controls.Add(this.btTerminalAdd);
            this.tabList.Controls.Add(this.bindingNavigator2);
            this.tabList.Location = new System.Drawing.Point(4, 29);
            this.tabList.Margin = new System.Windows.Forms.Padding(5);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(5);
            this.tabList.Size = new System.Drawing.Size(748, 379);
            this.tabList.TabIndex = 2;
            this.tabList.Text = "   清  单   ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TernimalName,
            this.Grouping,
            this.Address,
            this.Phone,
            this.Column1,
            this.Column3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(5, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(738, 293);
            this.dataGridView1.TabIndex = 5;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 98.33973F;
            this.Id.HeaderText = "序号";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 72;
            // 
            // TernimalName
            // 
            this.TernimalName.DataPropertyName = "Name";
            this.TernimalName.FillWeight = 94.96593F;
            this.TernimalName.HeaderText = "终端名称";
            this.TernimalName.Name = "TernimalName";
            this.TernimalName.ReadOnly = true;
            this.TernimalName.Width = 110;
            // 
            // Grouping
            // 
            this.Grouping.DataPropertyName = "Grouping";
            this.Grouping.FillWeight = 71.12539F;
            this.Grouping.HeaderText = "组号";
            this.Grouping.Name = "Grouping";
            this.Grouping.ReadOnly = true;
            this.Grouping.Width = 72;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.FillWeight = 120.6177F;
            this.Address.HeaderText = "终端地址";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 110;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "PhoneNo";
            this.Phone.FillWeight = 106.83F;
            this.Phone.HeaderText = "号码";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 72;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "GroupPhone";
            this.Column1.FillWeight = 111.3847F;
            this.Column1.HeaderText = "组绑定号码";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 129;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "AllPhone";
            this.Column3.FillWeight = 96.73663F;
            this.Column3.HeaderText = "齐绑定号码";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 129;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(216, 12);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(96, 36);
            this.btEdit.TabIndex = 4;
            this.btEdit.Text = "编 辑";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(343, 12);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(96, 36);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "删 除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btTerminalAdd
            // 
            this.btTerminalAdd.Location = new System.Drawing.Point(88, 12);
            this.btTerminalAdd.Name = "btTerminalAdd";
            this.btTerminalAdd.Size = new System.Drawing.Size(96, 36);
            this.btTerminalAdd.TabIndex = 2;
            this.btTerminalAdd.Text = "添 加";
            this.btTerminalAdd.UseVisualStyleBackColor = true;
            this.btTerminalAdd.Click += new System.EventHandler(this.btTerminalAdd_Click);
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.bindingNavigatorCountItem;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator2.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigator2.Location = new System.Drawing.Point(5, 349);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator2.Size = new System.Drawing.Size(738, 25);
            this.bindingNavigator2.TabIndex = 1;
            this.bindingNavigator2.Text = "bindingNavigator2";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabList);
            this.TabControl.Controls.Add(this.tabTimer);
            this.TabControl.Controls.Add(this.tabMeetingNum);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(5);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(756, 412);
            this.TabControl.TabIndex = 0;
            // 
            // TerminalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 412);
            this.Controls.Add(this.TabControl);
            this.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TerminalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "终 端";
            this.Load += new System.EventHandler(this.TerminalForm_Load);
            this.tabMeetingNum.ResumeLayout(false);
            this.tabMeetingNum.PerformLayout();
            this.tabTimer.ResumeLayout(false);
            this.tabTimer.PerformLayout();
            this.tabList.ResumeLayout(false);
            this.tabList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabMeetingNum;
        private System.Windows.Forms.Button MeetingNo_End;
        private System.Windows.Forms.TextBox MeetingNo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabTimer;
        private System.Windows.Forms.Button btTimeSettingOK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Second;
        private System.Windows.Forms.TextBox Minute;
        private System.Windows.Forms.TextBox Hour;
        private System.Windows.Forms.TextBox Day;
        private System.Windows.Forms.TextBox Mouth;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btTerminalAdd;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TernimalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grouping;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;


    }
}