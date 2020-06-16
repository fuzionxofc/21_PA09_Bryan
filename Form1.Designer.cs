namespace _21_PA09_Bryan
{
    partial class Form1
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
            this.lbl_amount = new System.Windows.Forms.Label();
            this.lbl_selectcurrency = new System.Windows.Forms.Label();
            this.lbl_value = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.rdb_USdollars = new System.Windows.Forms.RadioButton();
            this.rdb_JapaneseYen = new System.Windows.Forms.RadioButton();
            this.txt_convertedAmt = new System.Windows.Forms.TextBox();
            this.txt_error = new System.Windows.Forms.TextBox();
            this.rdb_MalaysianRinggit = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(92, 48);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(43, 13);
            this.lbl_amount.TabIndex = 0;
            this.lbl_amount.Text = "Amount";
            this.lbl_amount.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lbl_selectcurrency
            // 
            this.lbl_selectcurrency.AutoSize = true;
            this.lbl_selectcurrency.Location = new System.Drawing.Point(53, 105);
            this.lbl_selectcurrency.Name = "lbl_selectcurrency";
            this.lbl_selectcurrency.Size = new System.Drawing.Size(82, 13);
            this.lbl_selectcurrency.TabIndex = 1;
            this.lbl_selectcurrency.Text = "Select Currency";
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.Location = new System.Drawing.Point(101, 164);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(34, 13);
            this.lbl_value.TabIndex = 2;
            this.lbl_value.Text = "Value";
            this.lbl_value.Click += new System.EventHandler(this.Lbl_value_Click);
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(173, 45);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(100, 20);
            this.txt_amount.TabIndex = 3;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(330, 93);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(75, 23);
            this.btn_convert.TabIndex = 4;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.Btn_convert_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(330, 126);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // rdb_USdollars
            // 
            this.rdb_USdollars.AutoSize = true;
            this.rdb_USdollars.Location = new System.Drawing.Point(173, 103);
            this.rdb_USdollars.Name = "rdb_USdollars";
            this.rdb_USdollars.Size = new System.Drawing.Size(75, 17);
            this.rdb_USdollars.TabIndex = 6;
            this.rdb_USdollars.TabStop = true;
            this.rdb_USdollars.Text = "US Dollars";
            this.rdb_USdollars.UseVisualStyleBackColor = true;
            // 
            // rdb_JapaneseYen
            // 
            this.rdb_JapaneseYen.AutoSize = true;
            this.rdb_JapaneseYen.Location = new System.Drawing.Point(173, 126);
            this.rdb_JapaneseYen.Name = "rdb_JapaneseYen";
            this.rdb_JapaneseYen.Size = new System.Drawing.Size(93, 17);
            this.rdb_JapaneseYen.TabIndex = 7;
            this.rdb_JapaneseYen.TabStop = true;
            this.rdb_JapaneseYen.Text = "Japanese Yen";
            this.rdb_JapaneseYen.UseVisualStyleBackColor = true;
            // 
            // txt_convertedAmt
            // 
            this.txt_convertedAmt.Location = new System.Drawing.Point(173, 164);
            this.txt_convertedAmt.Name = "txt_convertedAmt";
            this.txt_convertedAmt.ReadOnly = true;
            this.txt_convertedAmt.Size = new System.Drawing.Size(100, 20);
            this.txt_convertedAmt.TabIndex = 8;
            // 
            // txt_error
            // 
            this.txt_error.Location = new System.Drawing.Point(12, 201);
            this.txt_error.Name = "txt_error";
            this.txt_error.ReadOnly = true;
            this.txt_error.Size = new System.Drawing.Size(428, 20);
            this.txt_error.TabIndex = 9;
            // 
            // rdb_MalaysianRinggit
            // 
            this.rdb_MalaysianRinggit.AutoSize = true;
            this.rdb_MalaysianRinggit.Location = new System.Drawing.Point(173, 80);
            this.rdb_MalaysianRinggit.Name = "rdb_MalaysianRinggit";
            this.rdb_MalaysianRinggit.Size = new System.Drawing.Size(108, 17);
            this.rdb_MalaysianRinggit.TabIndex = 10;
            this.rdb_MalaysianRinggit.TabStop = true;
            this.rdb_MalaysianRinggit.Text = "Malaysian Ringgit";
            this.rdb_MalaysianRinggit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 233);
            this.Controls.Add(this.rdb_MalaysianRinggit);
            this.Controls.Add(this.txt_error);
            this.Controls.Add(this.txt_convertedAmt);
            this.Controls.Add(this.rdb_JapaneseYen);
            this.Controls.Add(this.rdb_USdollars);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.lbl_selectcurrency);
            this.Controls.Add(this.lbl_amount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label lbl_selectcurrency;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.RadioButton rdb_USdollars;
        private System.Windows.Forms.RadioButton rdb_JapaneseYen;
        private System.Windows.Forms.TextBox txt_convertedAmt;
        private System.Windows.Forms.TextBox txt_error;
        private System.Windows.Forms.RadioButton rdb_MalaysianRinggit;
    }
}

