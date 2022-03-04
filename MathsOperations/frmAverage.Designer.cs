namespace MathsOperations
{
    partial class frmAverage
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
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtNums = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lbAverage = new System.Windows.Forms.Label();
            this.lbPercentageDone = new System.Windows.Forms.Label();
            this.lbDone = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(518, 110);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(314, 33);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Change separation character in settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(732, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 36);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtNums
            // 
            this.txtNums.Location = new System.Drawing.Point(18, 152);
            this.txtNums.Multiline = true;
            this.txtNums.Name = "txtNums";
            this.txtNums.Size = new System.Drawing.Size(814, 325);
            this.txtNums.TabIndex = 3;
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(18, 116);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(86, 30);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lbAverage
            // 
            this.lbAverage.AutoSize = true;
            this.lbAverage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAverage.Location = new System.Drawing.Point(269, 118);
            this.lbAverage.Name = "lbAverage";
            this.lbAverage.Size = new System.Drawing.Size(85, 25);
            this.lbAverage.TabIndex = 5;
            this.lbAverage.Text = "Average:";
            // 
            // lbPercentageDone
            // 
            this.lbPercentageDone.AutoSize = true;
            this.lbPercentageDone.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lbPercentageDone.Location = new System.Drawing.Point(110, 118);
            this.lbPercentageDone.Name = "lbPercentageDone";
            this.lbPercentageDone.Size = new System.Drawing.Size(108, 25);
            this.lbPercentageDone.TabIndex = 6;
            this.lbPercentageDone.Text = "Completed:";
            // 
            // lbDone
            // 
            this.lbDone.AutoSize = true;
            this.lbDone.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lbDone.Location = new System.Drawing.Point(215, 118);
            this.lbDone.Name = "lbDone";
            this.lbDone.Size = new System.Drawing.Size(48, 25);
            this.lbDone.TabIndex = 7;
            this.lbDone.Text = "00%";
            this.lbDone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(374, 49);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Average",
            "Addition",
            "Multiplication",
            "",
            "Subtraction (Not finished)",
            "Division (Not finished)"});
            this.comboBox1.Location = new System.Drawing.Point(18, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 38);
            this.comboBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mode:";
            // 
            // frmAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbDone);
            this.Controls.Add(this.lbPercentageDone);
            this.Controls.Add(this.lbAverage);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtNums);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.progressBar1);
            this.Name = "frmAverage";
            this.Text = "Average";
            this.Load += new System.EventHandler(this.frmAverage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtNums;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lbAverage;
        private System.Windows.Forms.Label lbPercentageDone;
        private System.Windows.Forms.Label lbDone;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}