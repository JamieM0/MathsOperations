namespace MathsOperations
{
    partial class frmHome
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
            this.btnGoToAverage = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnStartWI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(264, 342);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(281, 63);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnGoToAverage
            // 
            this.btnGoToAverage.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToAverage.Location = new System.Drawing.Point(264, 133);
            this.btnGoToAverage.Name = "btnGoToAverage";
            this.btnGoToAverage.Size = new System.Drawing.Size(281, 75);
            this.btnGoToAverage.TabIndex = 1;
            this.btnGoToAverage.Text = "Start";
            this.btnGoToAverage.UseVisualStyleBackColor = true;
            this.btnGoToAverage.Click += new System.EventHandler(this.btnGoToAverage_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(13, 13);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(670, 65);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Welcome to Maths Operations";
            // 
            // btnStartWI
            // 
            this.btnStartWI.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartWI.Location = new System.Drawing.Point(264, 225);
            this.btnStartWI.Name = "btnStartWI";
            this.btnStartWI.Size = new System.Drawing.Size(281, 44);
            this.btnStartWI.TabIndex = 3;
            this.btnStartWI.Text = "Start (Without Instructions)";
            this.btnStartWI.UseVisualStyleBackColor = true;
            this.btnStartWI.Click += new System.EventHandler(this.btnStartWI_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStartWI);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnGoToAverage);
            this.Controls.Add(this.btnSettings);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnGoToAverage;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnStartWI;
    }
}