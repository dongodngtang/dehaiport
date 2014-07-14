namespace FormUI.ManagerForms
{
    partial class Alarm
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
            this.btOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtＭinute = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(85, 114);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(66, 31);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "确认";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "警报时间：";
            // 
            // txtＭinute
            // 
            this.txtＭinute.Location = new System.Drawing.Point(85, 64);
            this.txtＭinute.Name = "txtＭinute";
            this.txtＭinute.Size = new System.Drawing.Size(73, 21);
            this.txtＭinute.TabIndex = 2;
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 207);
            this.Controls.Add(this.txtＭinute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOk);
            this.Name = "Alarm";
            this.Text = "警报";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtＭinute;
    }
}