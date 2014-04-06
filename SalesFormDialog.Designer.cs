namespace WindowsFormsApplication4 {
    partial class SalesFormDialog {
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
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.saleManualBtn = new System.Windows.Forms.Button();
            this.saleBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // prevBtn
            // 
            this.prevBtn.Font = new System.Drawing.Font("Wingdings 3", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.prevBtn.Location = new System.Drawing.Point(582, 535);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(120, 120);
            this.prevBtn.TabIndex = 19;
            this.prevBtn.Text = "3";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Wingdings 3", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.nextBtn.Location = new System.Drawing.Point(708, 535);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(120, 120);
            this.nextBtn.TabIndex = 18;
            this.nextBtn.Text = "4";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // saleManualBtn
            // 
            this.saleManualBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleManualBtn.Location = new System.Drawing.Point(12, 535);
            this.saleManualBtn.Name = "saleManualBtn";
            this.saleManualBtn.Size = new System.Drawing.Size(120, 120);
            this.saleManualBtn.TabIndex = 9;
            this.saleManualBtn.Text = "%";
            this.saleManualBtn.UseVisualStyleBackColor = true;
            this.saleManualBtn.Click += new System.EventHandler(this.saleManualBtn_Click);
            // 
            // saleBox
            // 
            this.saleBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.saleBox.Location = new System.Drawing.Point(0, 0);
            this.saleBox.Name = "saleBox";
            this.saleBox.Size = new System.Drawing.Size(840, 529);
            this.saleBox.TabIndex = 20;
            this.saleBox.TabStop = false;
            this.saleBox.Text = "Active Sales";
            // 
            // SalesFormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 667);
            this.Controls.Add(this.saleBox);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.saleManualBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesFormDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Choose sale...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button saleManualBtn;
        private System.Windows.Forms.GroupBox saleBox;
    }
}