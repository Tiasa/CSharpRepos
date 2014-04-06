namespace WindowsFormsApplication4 {
    partial class NumericInputDialog {
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
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.numEnterBtn = new System.Windows.Forms.Button();
            this.numClearBtn = new System.Windows.Forms.Button();
            this.numBackspaceBtn = new System.Windows.Forms.Button();
            this.num00btn = new System.Windows.Forms.Button();
            this.num0btn = new System.Windows.Forms.Button();
            this.numDotBtn = new System.Windows.Forms.Button();
            this.num9btn = new System.Windows.Forms.Button();
            this.num8btn = new System.Windows.Forms.Button();
            this.num7btn = new System.Windows.Forms.Button();
            this.num6btn = new System.Windows.Forms.Button();
            this.num5btn = new System.Windows.Forms.Button();
            this.num4btn = new System.Windows.Forms.Button();
            this.num3btn = new System.Windows.Forms.Button();
            this.num2btn = new System.Windows.Forms.Button();
            this.num1btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numTextBox
            // 
            this.numTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTextBox.Location = new System.Drawing.Point(12, 12);
            this.numTextBox.MaxLength = 8;
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.ReadOnly = true;
            this.numTextBox.Size = new System.Drawing.Size(661, 152);
            this.numTextBox.TabIndex = 30;
            // 
            // numEnterBtn
            // 
            this.numEnterBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.numEnterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEnterBtn.Location = new System.Drawing.Point(423, 548);
            this.numEnterBtn.Name = "numEnterBtn";
            this.numEnterBtn.Size = new System.Drawing.Size(250, 120);
            this.numEnterBtn.TabIndex = 29;
            this.numEnterBtn.Text = "ENTER";
            this.numEnterBtn.UseVisualStyleBackColor = true;
            // 
            // numClearBtn
            // 
            this.numClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numClearBtn.Location = new System.Drawing.Point(423, 296);
            this.numClearBtn.Name = "numClearBtn";
            this.numClearBtn.Size = new System.Drawing.Size(250, 120);
            this.numClearBtn.TabIndex = 28;
            this.numClearBtn.Text = "CLEAR";
            this.numClearBtn.UseVisualStyleBackColor = true;
            this.numClearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // numBackspaceBtn
            // 
            this.numBackspaceBtn.Font = new System.Drawing.Font("Wingdings 3", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.numBackspaceBtn.Location = new System.Drawing.Point(423, 170);
            this.numBackspaceBtn.Name = "numBackspaceBtn";
            this.numBackspaceBtn.Size = new System.Drawing.Size(250, 120);
            this.numBackspaceBtn.TabIndex = 20;
            this.numBackspaceBtn.Text = "!";
            this.numBackspaceBtn.UseVisualStyleBackColor = true;
            this.numBackspaceBtn.Click += new System.EventHandler(this.backspaceBtn_Click);
            // 
            // num00btn
            // 
            this.num00btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num00btn.Location = new System.Drawing.Point(138, 548);
            this.num00btn.Name = "num00btn";
            this.num00btn.Size = new System.Drawing.Size(120, 120);
            this.num00btn.TabIndex = 27;
            this.num00btn.Text = "00";
            this.num00btn.UseVisualStyleBackColor = true;
            this.num00btn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // num0btn
            // 
            this.num0btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0btn.Location = new System.Drawing.Point(12, 548);
            this.num0btn.Name = "num0btn";
            this.num0btn.Size = new System.Drawing.Size(120, 120);
            this.num0btn.TabIndex = 26;
            this.num0btn.Text = "0";
            this.num0btn.UseVisualStyleBackColor = true;
            this.num0btn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // numDotBtn
            // 
            this.numDotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDotBtn.Location = new System.Drawing.Point(264, 548);
            this.numDotBtn.Name = "numDotBtn";
            this.numDotBtn.Size = new System.Drawing.Size(120, 120);
            this.numDotBtn.TabIndex = 25;
            this.numDotBtn.Text = ".";
            this.numDotBtn.UseVisualStyleBackColor = true;
            this.numDotBtn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // num9btn
            // 
            this.num9btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9btn.Location = new System.Drawing.Point(264, 170);
            this.num9btn.Name = "num9btn";
            this.num9btn.Size = new System.Drawing.Size(120, 120);
            this.num9btn.TabIndex = 24;
            this.num9btn.Text = "9";
            this.num9btn.UseVisualStyleBackColor = true;
            this.num9btn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // num8btn
            // 
            this.num8btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8btn.Location = new System.Drawing.Point(138, 170);
            this.num8btn.Name = "num8btn";
            this.num8btn.Size = new System.Drawing.Size(120, 120);
            this.num8btn.TabIndex = 23;
            this.num8btn.Text = "8";
            this.num8btn.UseVisualStyleBackColor = true;
            this.num8btn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // num7btn
            // 
            this.num7btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7btn.Location = new System.Drawing.Point(12, 170);
            this.num7btn.Name = "num7btn";
            this.num7btn.Size = new System.Drawing.Size(120, 120);
            this.num7btn.TabIndex = 22;
            this.num7btn.Text = "7";
            this.num7btn.UseVisualStyleBackColor = true;
            this.num7btn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // num6btn
            // 
            this.num6btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6btn.Location = new System.Drawing.Point(264, 296);
            this.num6btn.Name = "num6btn";
            this.num6btn.Size = new System.Drawing.Size(120, 120);
            this.num6btn.TabIndex = 21;
            this.num6btn.Text = "6";
            this.num6btn.UseVisualStyleBackColor = true;
            this.num6btn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // num5btn
            // 
            this.num5btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5btn.Location = new System.Drawing.Point(138, 296);
            this.num5btn.Name = "num5btn";
            this.num5btn.Size = new System.Drawing.Size(120, 120);
            this.num5btn.TabIndex = 19;
            this.num5btn.Text = "5";
            this.num5btn.UseVisualStyleBackColor = true;
            this.num5btn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // num4btn
            // 
            this.num4btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4btn.Location = new System.Drawing.Point(12, 296);
            this.num4btn.Name = "num4btn";
            this.num4btn.Size = new System.Drawing.Size(120, 120);
            this.num4btn.TabIndex = 18;
            this.num4btn.Text = "4";
            this.num4btn.UseVisualStyleBackColor = true;
            this.num4btn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // num3btn
            // 
            this.num3btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3btn.Location = new System.Drawing.Point(264, 422);
            this.num3btn.Name = "num3btn";
            this.num3btn.Size = new System.Drawing.Size(120, 120);
            this.num3btn.TabIndex = 16;
            this.num3btn.Text = "3";
            this.num3btn.UseVisualStyleBackColor = true;
            this.num3btn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // num2btn
            // 
            this.num2btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2btn.Location = new System.Drawing.Point(138, 422);
            this.num2btn.Name = "num2btn";
            this.num2btn.Size = new System.Drawing.Size(120, 120);
            this.num2btn.TabIndex = 17;
            this.num2btn.Text = "2";
            this.num2btn.UseVisualStyleBackColor = true;
            this.num2btn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // num1btn
            // 
            this.num1btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1btn.Location = new System.Drawing.Point(12, 422);
            this.num1btn.Name = "num1btn";
            this.num1btn.Size = new System.Drawing.Size(120, 120);
            this.num1btn.TabIndex = 15;
            this.num1btn.Text = "1";
            this.num1btn.UseVisualStyleBackColor = true;
            this.num1btn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // NumericInputDialog
            // 
            this.AcceptButton = this.numEnterBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 670);
            this.Controls.Add(this.numTextBox);
            this.Controls.Add(this.numEnterBtn);
            this.Controls.Add(this.numClearBtn);
            this.Controls.Add(this.numBackspaceBtn);
            this.Controls.Add(this.num00btn);
            this.Controls.Add(this.num0btn);
            this.Controls.Add(this.numDotBtn);
            this.Controls.Add(this.num9btn);
            this.Controls.Add(this.num8btn);
            this.Controls.Add(this.num7btn);
            this.Controls.Add(this.num6btn);
            this.Controls.Add(this.num5btn);
            this.Controls.Add(this.num4btn);
            this.Controls.Add(this.num3btn);
            this.Controls.Add(this.num2btn);
            this.Controls.Add(this.num1btn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NumericInputDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Input Number...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.Button numEnterBtn;
        private System.Windows.Forms.Button numClearBtn;
        private System.Windows.Forms.Button numBackspaceBtn;
        private System.Windows.Forms.Button num00btn;
        private System.Windows.Forms.Button num0btn;
        private System.Windows.Forms.Button numDotBtn;
        private System.Windows.Forms.Button num9btn;
        private System.Windows.Forms.Button num8btn;
        private System.Windows.Forms.Button num7btn;
        private System.Windows.Forms.Button num6btn;
        private System.Windows.Forms.Button num5btn;
        private System.Windows.Forms.Button num4btn;
        private System.Windows.Forms.Button num3btn;
        private System.Windows.Forms.Button num2btn;
        private System.Windows.Forms.Button num1btn;

    }
}