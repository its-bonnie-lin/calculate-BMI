namespace CH1_1
{
    partial class cal
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCm = new System.Windows.Forms.TextBox();
            this.txtKg = new System.Windows.Forms.TextBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(180, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入身高(cm)";
            // 
            // btnCal
            // 
            this.btnCal.AutoSize = true;
            this.btnCal.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCal.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCal.Location = new System.Drawing.Point(287, 237);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 26);
            this.btnCal.TabIndex = 1;
            this.btnCal.Text = "計算";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(180, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "請輸入體重(kg)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCm
            // 
            this.txtCm.Location = new System.Drawing.Point(317, 115);
            this.txtCm.Name = "txtCm";
            this.txtCm.Size = new System.Drawing.Size(100, 22);
            this.txtCm.TabIndex = 3;
            // 
            // txtKg
            // 
            this.txtKg.Location = new System.Drawing.Point(317, 166);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(100, 22);
            this.txtKg.TabIndex = 4;
            this.txtKg.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShow.ForeColor = System.Drawing.Color.Red;
            this.lblShow.Location = new System.Drawing.Point(184, 307);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(324, 77);
            this.lblShow.TabIndex = 5;
            this.lblShow.Text = "label3";
            // 
            // btnEnd
            // 
            this.btnEnd.ForeColor = System.Drawing.Color.Red;
            this.btnEnd.Location = new System.Drawing.Point(388, 237);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 26);
            this.btnEnd.TabIndex = 6;
            this.btnEnd.Text = "結束";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // cal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.txtKg);
            this.Controls.Add(this.txtCm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.label1);
            this.Name = "cal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCm;
        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnEnd;
    }
}

