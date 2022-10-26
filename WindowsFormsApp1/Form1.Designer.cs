namespace WindowsFormsApp1
{
    partial class Form1
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
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.calcButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.carPayLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.whyLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "年齡:";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(57, 33);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(100, 22);
            this.resultTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "性別:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calcButton);
            this.groupBox1.Controls.Add(this.femaleRadioButton);
            this.groupBox1.Controls.Add(this.maleRadioButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.resultTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 143);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "客戶資訊";
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(228, 34);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(35, 16);
            this.maleRadioButton.TabIndex = 3;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "男";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(269, 34);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(35, 16);
            this.femaleRadioButton.TabIndex = 3;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "女";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(71, 88);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(103, 29);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "計算";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.whyLabel);
            this.groupBox2.Controls.Add(this.carPayLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(21, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 132);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "計算結果";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "車資:";
            // 
            // carPayLabel
            // 
            this.carPayLabel.AutoSize = true;
            this.carPayLabel.Location = new System.Drawing.Point(69, 38);
            this.carPayLabel.Name = "carPayLabel";
            this.carPayLabel.Size = new System.Drawing.Size(36, 12);
            this.carPayLabel.TabIndex = 0;
            this.carPayLabel.Text = "carPay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "原因:";
            // 
            // whyLabel
            // 
            this.whyLabel.AutoSize = true;
            this.whyLabel.Location = new System.Drawing.Point(69, 73);
            this.whyLabel.Name = "whyLabel";
            this.whyLabel.Size = new System.Drawing.Size(51, 12);
            this.whyLabel.TabIndex = 0;
            this.whyLabel.Text = "whyLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 324);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label whyLabel;
        private System.Windows.Forms.Label carPayLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}

