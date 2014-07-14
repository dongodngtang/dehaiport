namespace FormUI
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.端口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.主界面皮肤设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.白名单ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.历史信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.终端状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.终端ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.口令ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.广播BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.喊话ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选播ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btAnswer = new System.Windows.Forms.Button();
            this.btDialing = new System.Windows.Forms.Button();
            this.btHandup = new System.Windows.Forms.Button();
            this.lbPortState = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.广播BToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(0, 25);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 管理ToolStripMenuItem
            // 
            this.管理ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.端口ToolStripMenuItem,
            this.打印ToolStripMenuItem,
            this.主界面皮肤设置ToolStripMenuItem,
            this.白名单ToolStripMenuItem1,
            this.查询ToolStripMenuItem});
            this.管理ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.管理ToolStripMenuItem.Name = "管理ToolStripMenuItem";
            this.管理ToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.管理ToolStripMenuItem.Text = "管 理 (&M)";
            // 
            // 端口ToolStripMenuItem
            // 
            this.端口ToolStripMenuItem.Name = "端口ToolStripMenuItem";
            this.端口ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.端口ToolStripMenuItem.Text = "端口";
            this.端口ToolStripMenuItem.Click += new System.EventHandler(this.端口ToolStripMenuItem_Click);
            // 
            // 打印ToolStripMenuItem
            // 
            this.打印ToolStripMenuItem.Name = "打印ToolStripMenuItem";
            this.打印ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.打印ToolStripMenuItem.Text = "打印";
            this.打印ToolStripMenuItem.Click += new System.EventHandler(this.打印ToolStripMenuItem_Click);
            // 
            // 主界面皮肤设置ToolStripMenuItem
            // 
            this.主界面皮肤设置ToolStripMenuItem.Name = "主界面皮肤设置ToolStripMenuItem";
            this.主界面皮肤设置ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.主界面皮肤设置ToolStripMenuItem.Text = "主界面皮肤设置";
            this.主界面皮肤设置ToolStripMenuItem.Click += new System.EventHandler(this.主界面皮肤设置ToolStripMenuItem_Click);
            // 
            // 白名单ToolStripMenuItem1
            // 
            this.白名单ToolStripMenuItem1.Name = "白名单ToolStripMenuItem1";
            this.白名单ToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.白名单ToolStripMenuItem1.Text = "白名单";
            this.白名单ToolStripMenuItem1.Click += new System.EventHandler(this.白名单ToolStripMenuItem1_Click);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.历史信息ToolStripMenuItem,
            this.终端状态ToolStripMenuItem});
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.查询ToolStripMenuItem.Text = "查询";
            // 
            // 历史信息ToolStripMenuItem
            // 
            this.历史信息ToolStripMenuItem.Name = "历史信息ToolStripMenuItem";
            this.历史信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.历史信息ToolStripMenuItem.Text = "历史信息";
            this.历史信息ToolStripMenuItem.Click += new System.EventHandler(this.历史信息ToolStripMenuItem_Click);
            // 
            // 终端状态ToolStripMenuItem
            // 
            this.终端状态ToolStripMenuItem.Name = "终端状态ToolStripMenuItem";
            this.终端状态ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.终端状态ToolStripMenuItem.Text = "终端状态";
            this.终端状态ToolStripMenuItem.Click += new System.EventHandler(this.终端状态ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.终端ToolStripMenuItem,
            this.口令ToolStripMenuItem});
            this.设置ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.设置ToolStripMenuItem.Text = "设 置 (&S)";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // 终端ToolStripMenuItem
            // 
            this.终端ToolStripMenuItem.Name = "终端ToolStripMenuItem";
            this.终端ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.终端ToolStripMenuItem.Text = "终端";
            this.终端ToolStripMenuItem.Click += new System.EventHandler(this.终端ToolStripMenuItem_Click);
            // 
            // 口令ToolStripMenuItem
            // 
            this.口令ToolStripMenuItem.Enabled = false;
            this.口令ToolStripMenuItem.Name = "口令ToolStripMenuItem";
            this.口令ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.口令ToolStripMenuItem.Text = "口令";
            this.口令ToolStripMenuItem.Click += new System.EventHandler(this.口令ToolStripMenuItem_Click);
            // 
            // 广播BToolStripMenuItem
            // 
            this.广播BToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.喊话ToolStripMenuItem,
            this.选播ToolStripMenuItem});
            this.广播BToolStripMenuItem.Name = "广播BToolStripMenuItem";
            this.广播BToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.广播BToolStripMenuItem.Text = "广 播（&B)";
            // 
            // 喊话ToolStripMenuItem
            // 
            this.喊话ToolStripMenuItem.Name = "喊话ToolStripMenuItem";
            this.喊话ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.喊话ToolStripMenuItem.Text = "喊话";
            this.喊话ToolStripMenuItem.Click += new System.EventHandler(this.喊话ToolStripMenuItem_Click);
            // 
            // 选播ToolStripMenuItem
            // 
            this.选播ToolStripMenuItem.Name = "选播ToolStripMenuItem";
            this.选播ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.选播ToolStripMenuItem.Text = "选播";
            this.选播ToolStripMenuItem.Click += new System.EventHandler(this.选播ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.关于ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.关于ToolStripMenuItem.Text = "关 于 (&A)";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // btAnswer
            // 
            this.btAnswer.BackColor = System.Drawing.SystemColors.Control;
            this.btAnswer.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAnswer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btAnswer.Location = new System.Drawing.Point(688, 303);
            this.btAnswer.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btAnswer.Name = "btAnswer";
            this.btAnswer.Size = new System.Drawing.Size(84, 48);
            this.btAnswer.TabIndex = 4;
            this.btAnswer.Text = "接 听";
            this.btAnswer.UseVisualStyleBackColor = false;
            this.btAnswer.Click += new System.EventHandler(this.btAnswer_Click);
            // 
            // btDialing
            // 
            this.btDialing.BackColor = System.Drawing.Color.Transparent;
            this.btDialing.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDialing.Location = new System.Drawing.Point(688, 363);
            this.btDialing.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btDialing.Name = "btDialing";
            this.btDialing.Size = new System.Drawing.Size(84, 48);
            this.btDialing.TabIndex = 3;
            this.btDialing.Text = "拨 号";
            this.btDialing.UseVisualStyleBackColor = false;
            this.btDialing.Click += new System.EventHandler(this.btDialing_Click);
            // 
            // btHandup
            // 
            this.btHandup.BackColor = System.Drawing.Color.Transparent;
            this.btHandup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btHandup.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btHandup.Location = new System.Drawing.Point(688, 424);
            this.btHandup.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btHandup.Name = "btHandup";
            this.btHandup.Size = new System.Drawing.Size(84, 48);
            this.btHandup.TabIndex = 5;
            this.btHandup.Text = "挂 机";
            this.btHandup.UseVisualStyleBackColor = false;
            this.btHandup.Click += new System.EventHandler(this.btHandup_Click);
            // 
            // lbPortState
            // 
            this.lbPortState.AutoSize = true;
            this.lbPortState.BackColor = System.Drawing.Color.Transparent;
            this.lbPortState.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPortState.ForeColor = System.Drawing.Color.DarkRed;
            this.lbPortState.Location = new System.Drawing.Point(13, 455);
            this.lbPortState.Name = "lbPortState";
            this.lbPortState.Size = new System.Drawing.Size(88, 16);
            this.lbPortState.TabIndex = 16;
            this.lbPortState.Text = "串口未打开";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(688, 96);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 48);
            this.button1.TabIndex = 17;
            this.button1.Text = "操 作";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 33);
            this.panel1.TabIndex = 18;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbPortState);
            this.Controls.Add(this.btHandup);
            this.Controls.Add(this.btAnswer);
            this.Controls.Add(this.btDialing);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "德海GSM广播监测系统";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 端口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem 终端ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 口令ToolStripMenuItem;
        private System.Windows.Forms.Button btAnswer;
        private System.Windows.Forms.Button btDialing;
        private System.Windows.Forms.Button btHandup;
        private System.Windows.Forms.Label lbPortState;
        private System.Windows.Forms.ToolStripMenuItem 主界面皮肤设置ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem 白名单ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 历史信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 终端状态ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 广播BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 喊话ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选播ToolStripMenuItem;

    }
}