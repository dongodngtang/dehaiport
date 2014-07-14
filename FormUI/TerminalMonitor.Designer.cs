namespace FormUI
{
    partial class TerminalMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminalMonitor));
            this.listView1 = new System.Windows.Forms.ListView();
            this.btFloodWarn = new System.Windows.Forms.Button();
            this.btTest = new System.Windows.Forms.Button();
            this.btSlaggWarn = new System.Windows.Forms.Button();
            this.btRainFull = new System.Windows.Forms.Button();
            this.btTestMusic = new System.Windows.Forms.Button();
            this.btWaterLevel = new System.Windows.Forms.Button();
            this.terminalCall = new System.Windows.Forms.Button();
            this.terminalHangUp = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.串口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.历史记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.历史查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.状态查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.白名单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.终端ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.口令管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.告警ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.定时查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.定时开关机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbPortState = new System.Windows.Forms.Label();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.音量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.电压ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.白名单ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加管理号码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加授权号码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除号码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空白名单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.定时播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设定延时广播ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.终端防盗加锁ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.终端防盗解锁ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.c型终端ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btPowerAlert = new System.Windows.Forms.Button();
            this.btStopMusic = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btAlarm = new System.Windows.Forms.Button();
            this.btOpenCTerminal = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(838, 464);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.terminalList_MouseUp);
            // 
            // btFloodWarn
            // 
            this.btFloodWarn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btFloodWarn.Location = new System.Drawing.Point(901, 274);
            this.btFloodWarn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btFloodWarn.Name = "btFloodWarn";
            this.btFloodWarn.Size = new System.Drawing.Size(75, 31);
            this.btFloodWarn.TabIndex = 2;
            this.btFloodWarn.Text = "泄洪告警";
            this.btFloodWarn.UseVisualStyleBackColor = true;
            this.btFloodWarn.Click += new System.EventHandler(this.btFloodWarn_Click);
            // 
            // btTest
            // 
            this.btTest.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btTest.Location = new System.Drawing.Point(1025, 274);
            this.btTest.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(75, 31);
            this.btTest.TabIndex = 3;
            this.btTest.Text = "查询";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // btSlaggWarn
            // 
            this.btSlaggWarn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSlaggWarn.Location = new System.Drawing.Point(901, 318);
            this.btSlaggWarn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btSlaggWarn.Name = "btSlaggWarn";
            this.btSlaggWarn.Size = new System.Drawing.Size(75, 31);
            this.btSlaggWarn.TabIndex = 4;
            this.btSlaggWarn.Text = "排渣告警";
            this.btSlaggWarn.UseVisualStyleBackColor = true;
            this.btSlaggWarn.Click += new System.EventHandler(this.btSlaggWarn_Click);
            // 
            // btRainFull
            // 
            this.btRainFull.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.btRainFull.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRainFull.Location = new System.Drawing.Point(901, 406);
            this.btRainFull.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btRainFull.Name = "btRainFull";
            this.btRainFull.Size = new System.Drawing.Size(75, 31);
            this.btRainFull.TabIndex = 7;
            this.btRainFull.Text = "文本广播";
            this.btRainFull.UseVisualStyleBackColor = true;
            this.btRainFull.Click += new System.EventHandler(this.btRainFull_Click);
            // 
            // btTestMusic
            // 
            this.btTestMusic.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btTestMusic.Location = new System.Drawing.Point(1025, 362);
            this.btTestMusic.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btTestMusic.Name = "btTestMusic";
            this.btTestMusic.Size = new System.Drawing.Size(75, 31);
            this.btTestMusic.TabIndex = 8;
            this.btTestMusic.Text = "音乐";
            this.btTestMusic.UseVisualStyleBackColor = true;
            this.btTestMusic.Click += new System.EventHandler(this.btTestMusic_Click);
            // 
            // btWaterLevel
            // 
            this.btWaterLevel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btWaterLevel.Location = new System.Drawing.Point(901, 450);
            this.btWaterLevel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btWaterLevel.Name = "btWaterLevel";
            this.btWaterLevel.Size = new System.Drawing.Size(75, 31);
            this.btWaterLevel.TabIndex = 9;
            this.btWaterLevel.Text = "记忆组播";
            this.btWaterLevel.UseVisualStyleBackColor = true;
            this.btWaterLevel.Click += new System.EventHandler(this.btWaterLevel_Click);
            // 
            // terminalCall
            // 
            this.terminalCall.BackColor = System.Drawing.Color.Transparent;
            this.terminalCall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("terminalCall.BackgroundImage")));
            this.terminalCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.terminalCall.Location = new System.Drawing.Point(901, 499);
            this.terminalCall.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.terminalCall.Name = "terminalCall";
            this.terminalCall.Size = new System.Drawing.Size(75, 37);
            this.terminalCall.TabIndex = 10;
            this.terminalCall.UseVisualStyleBackColor = false;
            this.terminalCall.Click += new System.EventHandler(this.terminalCall_Click);
            // 
            // terminalHangUp
            // 
            this.terminalHangUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("terminalHangUp.BackgroundImage")));
            this.terminalHangUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.terminalHangUp.Location = new System.Drawing.Point(1025, 499);
            this.terminalHangUp.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.terminalHangUp.Name = "terminalHangUp";
            this.terminalHangUp.Size = new System.Drawing.Size(75, 37);
            this.terminalHangUp.TabIndex = 11;
            this.terminalHangUp.UseVisualStyleBackColor = true;
            this.terminalHangUp.Click += new System.EventHandler(this.terminialHungUp_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "GreenChecked");
            this.imageList.Images.SetKeyName(1, "Green");
            this.imageList.Images.SetKeyName(2, "Red");
            this.imageList.Images.SetKeyName(3, "RedChecked");
            this.imageList.Images.SetKeyName(4, "RunningChecked");
            this.imageList.Images.SetKeyName(5, "Running");
            this.imageList.Images.SetKeyName(6, "Stoped");
            this.imageList.Images.SetKeyName(7, "StopedChecked");
            // 
            // listBox1
            // 
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(901, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 172);
            this.listBox1.TabIndex = 12;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(0, 35);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1136, 35);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 管理ToolStripMenuItem
            // 
            this.管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.串口ToolStripMenuItem,
            this.打印ToolStripMenuItem,
            this.历史记录ToolStripMenuItem,
            this.白名单ToolStripMenuItem});
            this.管理ToolStripMenuItem.Name = "管理ToolStripMenuItem";
            this.管理ToolStripMenuItem.Size = new System.Drawing.Size(59, 31);
            this.管理ToolStripMenuItem.Text = "管理(&M)";
            // 
            // 串口ToolStripMenuItem
            // 
            this.串口ToolStripMenuItem.Name = "串口ToolStripMenuItem";
            this.串口ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.串口ToolStripMenuItem.Text = "端口";
            this.串口ToolStripMenuItem.Click += new System.EventHandler(this.串口ToolStripMenuItem_Click);
            // 
            // 打印ToolStripMenuItem
            // 
            this.打印ToolStripMenuItem.Name = "打印ToolStripMenuItem";
            this.打印ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.打印ToolStripMenuItem.Text = "打印";
            this.打印ToolStripMenuItem.Click += new System.EventHandler(this.打印ToolStripMenuItem_Click);
            // 
            // 历史记录ToolStripMenuItem
            // 
            this.历史记录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.历史查询ToolStripMenuItem,
            this.状态查询ToolStripMenuItem});
            this.历史记录ToolStripMenuItem.Name = "历史记录ToolStripMenuItem";
            this.历史记录ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.历史记录ToolStripMenuItem.Text = "历史";
            // 
            // 历史查询ToolStripMenuItem
            // 
            this.历史查询ToolStripMenuItem.Name = "历史查询ToolStripMenuItem";
            this.历史查询ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.历史查询ToolStripMenuItem.Text = "历史查询";
            this.历史查询ToolStripMenuItem.Click += new System.EventHandler(this.历史查询ToolStripMenuItem_Click);
            // 
            // 状态查询ToolStripMenuItem
            // 
            this.状态查询ToolStripMenuItem.Name = "状态查询ToolStripMenuItem";
            this.状态查询ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.状态查询ToolStripMenuItem.Text = "状态查询";
            this.状态查询ToolStripMenuItem.Click += new System.EventHandler(this.状态查询ToolStripMenuItem_Click);
            // 
            // 白名单ToolStripMenuItem
            // 
            this.白名单ToolStripMenuItem.Name = "白名单ToolStripMenuItem";
            this.白名单ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.白名单ToolStripMenuItem.Text = "白名单";
            this.白名单ToolStripMenuItem.Click += new System.EventHandler(this.白名单ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.终端ToolStripMenuItem,
            this.口令管理ToolStripMenuItem,
            this.告警ToolStripMenuItem,
            this.定时查询ToolStripMenuItem,
            this.定时开关机ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(59, 31);
            this.设置ToolStripMenuItem.Text = "设置(&S)";
            // 
            // 终端ToolStripMenuItem
            // 
            this.终端ToolStripMenuItem.Name = "终端ToolStripMenuItem";
            this.终端ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.终端ToolStripMenuItem.Text = "终端";
            this.终端ToolStripMenuItem.Click += new System.EventHandler(this.终端ToolStripMenuItem_Click);
            // 
            // 口令管理ToolStripMenuItem
            // 
            this.口令管理ToolStripMenuItem.Name = "口令管理ToolStripMenuItem";
            this.口令管理ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.口令管理ToolStripMenuItem.Text = "口令";
            this.口令管理ToolStripMenuItem.Click += new System.EventHandler(this.口令管理ToolStripMenuItem_Click);
            // 
            // 告警ToolStripMenuItem
            // 
            this.告警ToolStripMenuItem.Name = "告警ToolStripMenuItem";
            this.告警ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.告警ToolStripMenuItem.Text = "告警时间";
            this.告警ToolStripMenuItem.Click += new System.EventHandler(this.告警ToolStripMenuItem_Click);
            // 
            // 定时查询ToolStripMenuItem
            // 
            this.定时查询ToolStripMenuItem.Name = "定时查询ToolStripMenuItem";
            this.定时查询ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.定时查询ToolStripMenuItem.Text = "定时检测";
            this.定时查询ToolStripMenuItem.Click += new System.EventHandler(this.定时查询ToolStripMenuItem_Click);
            // 
            // 定时开关机ToolStripMenuItem
            // 
            this.定时开关机ToolStripMenuItem.Name = "定时开关机ToolStripMenuItem";
            this.定时开关机ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.定时开关机ToolStripMenuItem.Text = "定时开关机";
            this.定时开关机ToolStripMenuItem.Click += new System.EventHandler(this.定时开关机ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(59, 31);
            this.关于ToolStripMenuItem.Text = "关于(&A)";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // lbPortState
            // 
            this.lbPortState.AutoSize = true;
            this.lbPortState.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPortState.ForeColor = System.Drawing.Color.Red;
            this.lbPortState.Location = new System.Drawing.Point(14, 546);
            this.lbPortState.Name = "lbPortState";
            this.lbPortState.Size = new System.Drawing.Size(32, 16);
            this.lbPortState.TabIndex = 14;
            this.lbPortState.Text = "COM";
            this.lbPortState.UseWaitCursor = true;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.状态ToolStripMenuItem,
            this.音量ToolStripMenuItem,
            this.电压ToolStripMenuItem,
            this.白名单ToolStripMenuItem1,
            this.定时播放ToolStripMenuItem,
            this.设定延时广播ToolStripMenuItem,
            this.终端防盗加锁ToolStripMenuItem,
            this.终端防盗解锁ToolStripMenuItem,
            this.c型终端ToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(149, 202);
            // 
            // 状态ToolStripMenuItem
            // 
            this.状态ToolStripMenuItem.Name = "状态ToolStripMenuItem";
            this.状态ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.状态ToolStripMenuItem.Text = "检测";
            this.状态ToolStripMenuItem.Click += new System.EventHandler(this.状态ToolStripMenuItem_Click);
            // 
            // 音量ToolStripMenuItem
            // 
            this.音量ToolStripMenuItem.Name = "音量ToolStripMenuItem";
            this.音量ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.音量ToolStripMenuItem.Text = "设置音量";
            this.音量ToolStripMenuItem.Click += new System.EventHandler(this.音量ToolStripMenuItem_Click);
            // 
            // 电压ToolStripMenuItem
            // 
            this.电压ToolStripMenuItem.Name = "电压ToolStripMenuItem";
            this.电压ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.电压ToolStripMenuItem.Text = "设置电压";
            this.电压ToolStripMenuItem.Click += new System.EventHandler(this.电压ToolStripMenuItem_Click);
            // 
            // 白名单ToolStripMenuItem1
            // 
            this.白名单ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看ToolStripMenuItem,
            this.添加管理号码ToolStripMenuItem,
            this.添加授权号码ToolStripMenuItem,
            this.删除号码ToolStripMenuItem,
            this.清空白名单ToolStripMenuItem});
            this.白名单ToolStripMenuItem1.Name = "白名单ToolStripMenuItem1";
            this.白名单ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.白名单ToolStripMenuItem1.Text = "白名单";
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.查看ToolStripMenuItem.Text = "查看";
            this.查看ToolStripMenuItem.Click += new System.EventHandler(this.查看ToolStripMenuItem_Click);
            // 
            // 添加管理号码ToolStripMenuItem
            // 
            this.添加管理号码ToolStripMenuItem.Name = "添加管理号码ToolStripMenuItem";
            this.添加管理号码ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.添加管理号码ToolStripMenuItem.Text = "添加管理号码";
            this.添加管理号码ToolStripMenuItem.Click += new System.EventHandler(this.添加管理号码ToolStripMenuItem_Click);
            // 
            // 添加授权号码ToolStripMenuItem
            // 
            this.添加授权号码ToolStripMenuItem.Name = "添加授权号码ToolStripMenuItem";
            this.添加授权号码ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.添加授权号码ToolStripMenuItem.Text = "添加授权号码";
            this.添加授权号码ToolStripMenuItem.Click += new System.EventHandler(this.添加授权号码ToolStripMenuItem_Click);
            // 
            // 删除号码ToolStripMenuItem
            // 
            this.删除号码ToolStripMenuItem.Name = "删除号码ToolStripMenuItem";
            this.删除号码ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.删除号码ToolStripMenuItem.Text = "删除号码";
            this.删除号码ToolStripMenuItem.Click += new System.EventHandler(this.删除号码ToolStripMenuItem_Click);
            // 
            // 清空白名单ToolStripMenuItem
            // 
            this.清空白名单ToolStripMenuItem.Name = "清空白名单ToolStripMenuItem";
            this.清空白名单ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.清空白名单ToolStripMenuItem.Text = "清空白名单";
            this.清空白名单ToolStripMenuItem.Click += new System.EventHandler(this.清空白名单ToolStripMenuItem_Click);
            // 
            // 定时播放ToolStripMenuItem
            // 
            this.定时播放ToolStripMenuItem.Name = "定时播放ToolStripMenuItem";
            this.定时播放ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.定时播放ToolStripMenuItem.Text = "定时广播";
            this.定时播放ToolStripMenuItem.Click += new System.EventHandler(this.定时播放ToolStripMenuItem_Click);
            // 
            // 设定延时广播ToolStripMenuItem
            // 
            this.设定延时广播ToolStripMenuItem.Name = "设定延时广播ToolStripMenuItem";
            this.设定延时广播ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.设定延时广播ToolStripMenuItem.Text = "设定延时广播";
            this.设定延时广播ToolStripMenuItem.Click += new System.EventHandler(this.设定延时广播ToolStripMenuItem_Click);
            // 
            // 终端防盗加锁ToolStripMenuItem
            // 
            this.终端防盗加锁ToolStripMenuItem.Name = "终端防盗加锁ToolStripMenuItem";
            this.终端防盗加锁ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.终端防盗加锁ToolStripMenuItem.Text = "终端防盗加锁";
            this.终端防盗加锁ToolStripMenuItem.Click += new System.EventHandler(this.终端防盗加锁ToolStripMenuItem_Click);
            // 
            // 终端防盗解锁ToolStripMenuItem
            // 
            this.终端防盗解锁ToolStripMenuItem.Name = "终端防盗解锁ToolStripMenuItem";
            this.终端防盗解锁ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.终端防盗解锁ToolStripMenuItem.Text = "终端防盗解锁";
            this.终端防盗解锁ToolStripMenuItem.Click += new System.EventHandler(this.终端防盗解锁ToolStripMenuItem_Click);
            // 
            // c型终端ToolStripMenuItem
            // 
            this.c型终端ToolStripMenuItem.Name = "c型终端ToolStripMenuItem";
            this.c型终端ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.c型终端ToolStripMenuItem.Text = "C型终端";
            this.c型终端ToolStripMenuItem.Click += new System.EventHandler(this.c型终端ToolStripMenuItem_Click);
            // 
            // btPowerAlert
            // 
            this.btPowerAlert.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btPowerAlert.Location = new System.Drawing.Point(901, 362);
            this.btPowerAlert.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btPowerAlert.Name = "btPowerAlert";
            this.btPowerAlert.Size = new System.Drawing.Size(75, 31);
            this.btPowerAlert.TabIndex = 15;
            this.btPowerAlert.Text = "发电告警";
            this.btPowerAlert.UseVisualStyleBackColor = true;
            this.btPowerAlert.Click += new System.EventHandler(this.btPowerAlert_Click);
            // 
            // btStopMusic
            // 
            this.btStopMusic.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btStopMusic.Location = new System.Drawing.Point(1025, 318);
            this.btStopMusic.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btStopMusic.Name = "btStopMusic";
            this.btStopMusic.Size = new System.Drawing.Size(75, 31);
            this.btStopMusic.TabIndex = 16;
            this.btStopMusic.Text = "停播";
            this.btStopMusic.UseVisualStyleBackColor = true;
            this.btStopMusic.Click += new System.EventHandler(this.btStopMusic_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "选终端时：如果不勾选，则是选择全部。";
            // 
            // btAlarm
            // 
            this.btAlarm.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAlarm.Location = new System.Drawing.Point(1025, 450);
            this.btAlarm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btAlarm.Name = "btAlarm";
            this.btAlarm.Size = new System.Drawing.Size(75, 31);
            this.btAlarm.TabIndex = 19;
            this.btAlarm.Text = "警报";
            this.btAlarm.UseVisualStyleBackColor = true;
            this.btAlarm.Click += new System.EventHandler(this.btAlarm_Click);
            // 
            // btOpenCTerminal
            // 
            this.btOpenCTerminal.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btOpenCTerminal.Location = new System.Drawing.Point(1025, 406);
            this.btOpenCTerminal.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btOpenCTerminal.Name = "btOpenCTerminal";
            this.btOpenCTerminal.Size = new System.Drawing.Size(75, 31);
            this.btOpenCTerminal.TabIndex = 18;
            this.btOpenCTerminal.Text = "检测";
            this.btOpenCTerminal.UseVisualStyleBackColor = true;
            this.btOpenCTerminal.Click += new System.EventHandler(this.btOpenCTerminal_Click);
            // 
            // TerminalMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 572);
            this.Controls.Add(this.btAlarm);
            this.Controls.Add(this.btOpenCTerminal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btStopMusic);
            this.Controls.Add(this.btPowerAlert);
            this.Controls.Add(this.lbPortState);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btWaterLevel);
            this.Controls.Add(this.terminalHangUp);
            this.Controls.Add(this.terminalCall);
            this.Controls.Add(this.btRainFull);
            this.Controls.Add(this.btTestMusic);
            this.Controls.Add(this.btSlaggWarn);
            this.Controls.Add(this.btTest);
            this.Controls.Add(this.btFloodWarn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listView1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TerminalMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "德海GSM广播监测系统";
            this.Load += new System.EventHandler(this.TerminalMonitor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btFloodWarn;
        private System.Windows.Forms.Button btTest;
        private System.Windows.Forms.Button btSlaggWarn;
        private System.Windows.Forms.Button btRainFull;
        private System.Windows.Forms.Button btTestMusic;
        private System.Windows.Forms.Button btWaterLevel;
        private System.Windows.Forms.Button terminalCall;
        private System.Windows.Forms.Button terminalHangUp;
        private System.Windows.Forms.ImageList imageList;
        public  System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 串口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 白名单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 历史记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 终端ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 口令管理ToolStripMenuItem;
        private System.Windows.Forms.Label lbPortState;
        private System.Windows.Forms.ToolStripMenuItem 历史查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 状态查询ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem 状态ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 音量ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 电压ToolStripMenuItem;
        private System.Windows.Forms.Button btPowerAlert;
        private System.Windows.Forms.ToolStripMenuItem 告警ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 白名单ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加管理号码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加授权号码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除号码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空白名单ToolStripMenuItem;
        private System.Windows.Forms.Button btStopMusic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 定时开关机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 定时播放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设定延时广播ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 终端防盗加锁ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 终端防盗解锁ToolStripMenuItem;
        private System.Windows.Forms.Button btAlarm;
        private System.Windows.Forms.Button btOpenCTerminal;
        private System.Windows.Forms.ToolStripMenuItem 定时查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem c型终端ToolStripMenuItem;
    }
}