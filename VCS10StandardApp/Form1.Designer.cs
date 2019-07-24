namespace VCS10StandardApp
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
            this.DllTest1 = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.UsernameEdit = new System.Windows.Forms.TextBox();
            this.PasswdEdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DllTest1
            // 
            this.DllTest1.Location = new System.Drawing.Point(12, 12);
            this.DllTest1.Name = "DllTest1";
            this.DllTest1.Size = new System.Drawing.Size(185, 29);
            this.DllTest1.TabIndex = 3;
            this.DllTest1.Text = "proselecta2_ws.dll - call Blackbox";
            this.DllTest1.UseVisualStyleBackColor = true;
            this.DllTest1.Click += new System.EventHandler(this.DllTest1_Click);
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(16, 59);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogTextBox.Size = new System.Drawing.Size(590, 489);
            this.LogTextBox.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(437, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Username:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label1.Visible = false;
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(439, 31);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(56, 13);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Password:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label2.Visible = false;
            // 
            // UsernameEdit
            // 
            this.UsernameEdit.Location = new System.Drawing.Point(498, 6);
            this.UsernameEdit.Name = "UsernameEdit";
            this.UsernameEdit.Size = new System.Drawing.Size(109, 20);
            this.UsernameEdit.TabIndex = 1;
            this.UsernameEdit.Text = "<enter>";
            this.UsernameEdit.Visible = false;
            // 
            // PasswdEdit
            // 
            this.PasswdEdit.Location = new System.Drawing.Point(498, 28);
            this.PasswdEdit.Name = "PasswdEdit";
            this.PasswdEdit.Size = new System.Drawing.Size(109, 20);
            this.PasswdEdit.TabIndex = 2;
            this.PasswdEdit.Text = "<enter>";
            this.PasswdEdit.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 563);
            this.Controls.Add(this.PasswdEdit);
            this.Controls.Add(this.UsernameEdit);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.DllTest1);
            this.Name = "Form1";
            this.Text = "proselecta2_ws.dll - Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button DllTest1;
        internal System.Windows.Forms.TextBox LogTextBox;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox UsernameEdit;
        internal System.Windows.Forms.TextBox PasswdEdit;

    }
}

