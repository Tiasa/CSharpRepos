namespace WindowsFormsApplication4 {
    partial class POSForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.recieptListBox = new System.Windows.Forms.ListBox();
            this.printButton = new System.Windows.Forms.Button();
            this.goodManualBtn = new System.Windows.Forms.Button();
            this.goodsBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnDelLast = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recieptListBox
            // 
            this.recieptListBox.BackColor = System.Drawing.SystemColors.Window;
            this.recieptListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptListBox.FormattingEnabled = true;
            this.recieptListBox.ItemHeight = 29;
            this.recieptListBox.Location = new System.Drawing.Point(720, 9);
            this.recieptListBox.Margin = new System.Windows.Forms.Padding(2);
            this.recieptListBox.Name = "recieptListBox";
            this.recieptListBox.Size = new System.Drawing.Size(277, 555);
            this.recieptListBox.TabIndex = 0;
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(720, 575);
            this.printButton.Margin = new System.Windows.Forms.Padding(2);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(275, 94);
            this.printButton.TabIndex = 1;
            this.printButton.Text = "Total: ";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // goodManualBtn
            // 
            this.goodManualBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodManualBtn.Location = new System.Drawing.Point(6, 575);
            this.goodManualBtn.Margin = new System.Windows.Forms.Padding(2);
            this.goodManualBtn.Name = "goodManualBtn";
            this.goodManualBtn.Size = new System.Drawing.Size(90, 94);
            this.goodManualBtn.TabIndex = 4;
            this.goodManualBtn.Text = "BAR CODE";
            this.goodManualBtn.UseVisualStyleBackColor = true;
            this.goodManualBtn.Click += new System.EventHandler(this.goodManualBtn_Click);
            // 
            // goodsBox
            // 
            this.goodsBox.Location = new System.Drawing.Point(11, 9);
            this.goodsBox.Margin = new System.Windows.Forms.Padding(2);
            this.goodsBox.Name = "goodsBox";
            this.goodsBox.Padding = new System.Windows.Forms.Padding(2);
            this.goodsBox.Size = new System.Drawing.Size(703, 563);
            this.goodsBox.TabIndex = 5;
            this.goodsBox.TabStop = false;
            this.goodsBox.Text = "Goods in stock";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(121, 575);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 94);
            this.button1.TabIndex = 6;
            this.button1.Text = "Beverage";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Wingdings 3", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button2.Location = new System.Drawing.Point(236, 575);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 94);
            this.button2.TabIndex = 7;
            this.button2.Text = "3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Wingdings 3", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button3.Location = new System.Drawing.Point(351, 575);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 94);
            this.button3.TabIndex = 8;
            this.button3.Text = "4";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnSale
            // 
            this.btnSale.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.Location = new System.Drawing.Point(466, 575);
            this.btnSale.Margin = new System.Windows.Forms.Padding(2);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(90, 94);
            this.btnSale.TabIndex = 5;
            this.btnSale.Text = "SALE DEAL";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnDelLast
            // 
            this.btnDelLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelLast.Location = new System.Drawing.Point(581, 575);
            this.btnDelLast.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelLast.Name = "btnDelLast";
            this.btnDelLast.Size = new System.Drawing.Size(90, 94);
            this.btnDelLast.TabIndex = 5;
            this.btnDelLast.Text = "DELETE LAST";
            this.btnDelLast.UseVisualStyleBackColor = true;
            this.btnDelLast.Click += new System.EventHandler(this.btnDelLast_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Wingdings 3", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button4.Location = new System.Drawing.Point(236, 575);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 95);
            this.button4.TabIndex = 9;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Wingdings 3", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button5.Location = new System.Drawing.Point(351, 575);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 94);
            this.button5.TabIndex = 10;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(121, 575);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 94);
            this.button6.TabIndex = 11;
            this.button6.Text = "Fast Food";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1040, 707);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnDelLast);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.goodsBox);
            this.Controls.Add(this.goodManualBtn);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.recieptListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(690, 396);
            this.Name = "POSForm";
            this.ShowIcon = false;
            this.Text = "Point of Sale";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox recieptListBox;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button goodManualBtn;
        private System.Windows.Forms.GroupBox goodsBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnDelLast;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

