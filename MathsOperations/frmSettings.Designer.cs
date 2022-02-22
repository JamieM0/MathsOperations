namespace MathsOperations
{
    partial class frmSettings
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbSeparationCharacter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeparationCharacter = new System.Windows.Forms.TextBox();
            this.btnSaveAndReturnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(348, 37);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Maths Operations - Settings";
            // 
            // lbSeparationCharacter
            // 
            this.lbSeparationCharacter.AutoSize = true;
            this.lbSeparationCharacter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeparationCharacter.Location = new System.Drawing.Point(12, 84);
            this.lbSeparationCharacter.Name = "lbSeparationCharacter";
            this.lbSeparationCharacter.Size = new System.Drawing.Size(207, 30);
            this.lbSeparationCharacter.TabIndex = 1;
            this.lbSeparationCharacter.Text = "Separation Character";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "This is the character where the values will split at regardless of spaces.";
            // 
            // txtSeparationCharacter
            // 
            this.txtSeparationCharacter.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txtSeparationCharacter.Location = new System.Drawing.Point(246, 81);
            this.txtSeparationCharacter.Name = "txtSeparationCharacter";
            this.txtSeparationCharacter.Size = new System.Drawing.Size(100, 35);
            this.txtSeparationCharacter.TabIndex = 3;
            // 
            // btnSaveAndReturnHome
            // 
            this.btnSaveAndReturnHome.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btnSaveAndReturnHome.Location = new System.Drawing.Point(626, 12);
            this.btnSaveAndReturnHome.Name = "btnSaveAndReturnHome";
            this.btnSaveAndReturnHome.Size = new System.Drawing.Size(162, 74);
            this.btnSaveAndReturnHome.TabIndex = 4;
            this.btnSaveAndReturnHome.Text = "Save and Return Home";
            this.btnSaveAndReturnHome.UseVisualStyleBackColor = true;
            this.btnSaveAndReturnHome.Click += new System.EventHandler(this.btnSaveAndReturnHome_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveAndReturnHome);
            this.Controls.Add(this.txtSeparationCharacter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSeparationCharacter);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbSeparationCharacter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeparationCharacter;
        private System.Windows.Forms.Button btnSaveAndReturnHome;
    }
}