namespace SharpPasswordGenerator
{
    partial class FormGeneratePassword
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtPasswordLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkUppercase = new System.Windows.Forms.CheckBox();
            this.chkLowercase = new System.Windows.Forms.CheckBox();
            this.chkNumber = new System.Windows.Forms.CheckBox();
            this.chkSpecialCharacter = new System.Windows.Forms.CheckBox();
            this.txtSpecialCharacter = new System.Windows.Forms.TextBox();
            this.chkNotIncludeCompromisedPassword = new System.Windows.Forms.CheckBox();
            this.txtPasswordGenerated = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCopytoClipboard = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(286, 583);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 44);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(286, 314);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(120, 44);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.buttonGenPassword_Click);
            // 
            // txtPasswordLength
            // 
            this.txtPasswordLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordLength.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLength.Location = new System.Drawing.Point(272, 22);
            this.txtPasswordLength.Name = "txtPasswordLength";
            this.txtPasswordLength.Size = new System.Drawing.Size(127, 33);
            this.txtPasswordLength.TabIndex = 13;
            this.txtPasswordLength.Text = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Password length (6-32):";
            // 
            // chkUppercase
            // 
            this.chkUppercase.AutoSize = true;
            this.chkUppercase.Checked = true;
            this.chkUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUppercase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkUppercase.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUppercase.Location = new System.Drawing.Point(40, 51);
            this.chkUppercase.Name = "chkUppercase";
            this.chkUppercase.Size = new System.Drawing.Size(182, 29);
            this.chkUppercase.TabIndex = 14;
            this.chkUppercase.Text = "Capital Characters";
            this.chkUppercase.UseVisualStyleBackColor = true;
            // 
            // chkLowercase
            // 
            this.chkLowercase.AutoSize = true;
            this.chkLowercase.Checked = true;
            this.chkLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLowercase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkLowercase.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLowercase.Location = new System.Drawing.Point(40, 85);
            this.chkLowercase.Name = "chkLowercase";
            this.chkLowercase.Size = new System.Drawing.Size(169, 29);
            this.chkLowercase.TabIndex = 15;
            this.chkLowercase.Text = "Small Characters";
            this.chkLowercase.UseVisualStyleBackColor = true;
            // 
            // chkNumber
            // 
            this.chkNumber.AutoSize = true;
            this.chkNumber.Checked = true;
            this.chkNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNumber.Location = new System.Drawing.Point(40, 119);
            this.chkNumber.Name = "chkNumber";
            this.chkNumber.Size = new System.Drawing.Size(97, 29);
            this.chkNumber.TabIndex = 16;
            this.chkNumber.Text = "Number";
            this.chkNumber.UseVisualStyleBackColor = true;
            // 
            // chkSpecialCharacter
            // 
            this.chkSpecialCharacter.AutoSize = true;
            this.chkSpecialCharacter.Checked = true;
            this.chkSpecialCharacter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpecialCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSpecialCharacter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSpecialCharacter.Location = new System.Drawing.Point(40, 153);
            this.chkSpecialCharacter.Name = "chkSpecialCharacter";
            this.chkSpecialCharacter.Size = new System.Drawing.Size(187, 29);
            this.chkSpecialCharacter.TabIndex = 17;
            this.chkSpecialCharacter.Text = "Special Characters:";
            this.chkSpecialCharacter.UseVisualStyleBackColor = true;
            // 
            // txtSpecialCharacter
            // 
            this.txtSpecialCharacter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecialCharacter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialCharacter.Location = new System.Drawing.Point(60, 187);
            this.txtSpecialCharacter.Name = "txtSpecialCharacter";
            this.txtSpecialCharacter.Size = new System.Drawing.Size(337, 33);
            this.txtSpecialCharacter.TabIndex = 18;
            this.txtSpecialCharacter.Text = "!\"\"#$%&\'()*+,-./:;<=>?@[\\]^_`{|}~";
            // 
            // chkNotIncludeCompromisedPassword
            // 
            this.chkNotIncludeCompromisedPassword.AutoSize = true;
            this.chkNotIncludeCompromisedPassword.Checked = true;
            this.chkNotIncludeCompromisedPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNotIncludeCompromisedPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkNotIncludeCompromisedPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotIncludeCompromisedPassword.Location = new System.Drawing.Point(40, 222);
            this.chkNotIncludeCompromisedPassword.Name = "chkNotIncludeCompromisedPassword";
            this.chkNotIncludeCompromisedPassword.Size = new System.Drawing.Size(349, 29);
            this.chkNotIncludeCompromisedPassword.TabIndex = 19;
            this.chkNotIncludeCompromisedPassword.Text = "Not Included Compromised password:";
            this.chkNotIncludeCompromisedPassword.UseVisualStyleBackColor = true;
            // 
            // txtPasswordGenerated
            // 
            this.txtPasswordGenerated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordGenerated.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordGenerated.Location = new System.Drawing.Point(60, 428);
            this.txtPasswordGenerated.Multiline = true;
            this.txtPasswordGenerated.Name = "txtPasswordGenerated";
            this.txtPasswordGenerated.ReadOnly = true;
            this.txtPasswordGenerated.Size = new System.Drawing.Size(343, 76);
            this.txtPasswordGenerated.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 400);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Password Generated:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 4);
            this.label3.TabIndex = 22;
            // 
            // btnCopytoClipboard
            // 
            this.btnCopytoClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopytoClipboard.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopytoClipboard.Location = new System.Drawing.Point(140, 510);
            this.btnCopytoClipboard.Name = "btnCopytoClipboard";
            this.btnCopytoClipboard.Size = new System.Drawing.Size(266, 44);
            this.btnCopytoClipboard.TabIndex = 23;
            this.btnCopytoClipboard.Text = "Copy Password to clipboard";
            this.btnCopytoClipboard.UseVisualStyleBackColor = true;
            this.btnCopytoClipboard.Click += new System.EventHandler(this.btnCopytoClipboard_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(272, 251);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(127, 33);
            this.txtQuantity.TabIndex = 25;
            this.txtQuantity.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Quantity (1-50):";
            // 
            // buttonAbout
            // 
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.Location = new System.Drawing.Point(17, 583);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(120, 44);
            this.buttonAbout.TabIndex = 26;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // FormGeneratePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(418, 639);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCopytoClipboard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPasswordGenerated);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkNotIncludeCompromisedPassword);
            this.Controls.Add(this.txtSpecialCharacter);
            this.Controls.Add(this.chkSpecialCharacter);
            this.Controls.Add(this.chkNumber);
            this.Controls.Add(this.chkLowercase);
            this.Controls.Add(this.chkUppercase);
            this.Controls.Add(this.txtPasswordLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGenerate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormGeneratePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharpPasswordGenerator";
            this.Load += new System.EventHandler(this.frmGeneratePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtPasswordLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkUppercase;
        private System.Windows.Forms.CheckBox chkLowercase;
        private System.Windows.Forms.CheckBox chkNumber;
        private System.Windows.Forms.CheckBox chkSpecialCharacter;
        private System.Windows.Forms.TextBox txtSpecialCharacter;
        private System.Windows.Forms.CheckBox chkNotIncludeCompromisedPassword;
        private System.Windows.Forms.TextBox txtPasswordGenerated;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCopytoClipboard;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAbout;
    }
}