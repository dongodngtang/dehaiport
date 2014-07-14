namespace FormUI.SettingForms
{
    partial class BattryParatemerSetting
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
            this.btTabParamOK = new System.Windows.Forms.Button();
            this.DisChargeMax = new System.Windows.Forms.TextBox();
            this.DisChargeMin = new System.Windows.Forms.TextBox();
            this.ChargeMax = new System.Windows.Forms.TextBox();
            this.ChargeMin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btTabParamOK
            // 
            this.btTabParamOK.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btTabParamOK.Location = new System.Drawing.Point(179, 248);
            this.btTabParamOK.Margin = new System.Windows.Forms.Padding(5);
            this.btTabParamOK.Name = "btTabParamOK";
            this.btTabParamOK.Size = new System.Drawing.Size(127, 53);
            this.btTabParamOK.TabIndex = 22;
            this.btTabParamOK.Text = "确   定";
            this.btTabParamOK.UseVisualStyleBackColor = true;
            this.btTabParamOK.Click += new System.EventHandler(this.btTabParamOK_Click);
            // 
            // DisChargeMax
            // 
            this.DisChargeMax.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DisChargeMax.Location = new System.Drawing.Point(179, 190);
            this.DisChargeMax.Margin = new System.Windows.Forms.Padding(5);
            this.DisChargeMax.Name = "DisChargeMax";
            this.DisChargeMax.Size = new System.Drawing.Size(127, 26);
            this.DisChargeMax.TabIndex = 21;
            // 
            // DisChargeMin
            // 
            this.DisChargeMin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DisChargeMin.Location = new System.Drawing.Point(179, 140);
            this.DisChargeMin.Margin = new System.Windows.Forms.Padding(5);
            this.DisChargeMin.Name = "DisChargeMin";
            this.DisChargeMin.Size = new System.Drawing.Size(127, 26);
            this.DisChargeMin.TabIndex = 20;
            // 
            // ChargeMax
            // 
            this.ChargeMax.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChargeMax.Location = new System.Drawing.Point(179, 95);
            this.ChargeMax.Margin = new System.Windows.Forms.Padding(5);
            this.ChargeMax.Name = "ChargeMax";
            this.ChargeMax.Size = new System.Drawing.Size(127, 26);
            this.ChargeMax.TabIndex = 19;
            // 
            // ChargeMin
            // 
            this.ChargeMin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChargeMin.Location = new System.Drawing.Point(179, 49);
            this.ChargeMin.Margin = new System.Windows.Forms.Padding(5);
            this.ChargeMin.Name = "ChargeMin";
            this.ChargeMin.Size = new System.Drawing.Size(127, 26);
            this.ChargeMin.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(57, 143);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "放电电压上限:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(57, 193);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "放电电压下限:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(57, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "充电电压下限:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(57, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "充电电压上限:";
            // 
            // BattryParatemerSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 347);
            this.Controls.Add(this.btTabParamOK);
            this.Controls.Add(this.DisChargeMax);
            this.Controls.Add(this.DisChargeMin);
            this.Controls.Add(this.ChargeMax);
            this.Controls.Add(this.ChargeMin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "BattryParatemerSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTabParamOK;
        private System.Windows.Forms.TextBox DisChargeMax;
        private System.Windows.Forms.TextBox DisChargeMin;
        private System.Windows.Forms.TextBox ChargeMax;
        private System.Windows.Forms.TextBox ChargeMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}