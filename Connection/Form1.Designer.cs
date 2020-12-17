namespace Connection
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
            this.sqlOpenButton = new System.Windows.Forms.Button();
            this.firebirdOpenButton = new System.Windows.Forms.Button();
            this.sqlStatusLabel = new System.Windows.Forms.Label();
            this.firebirdStatusLabel = new System.Windows.Forms.Label();
            this.firebirdCloseButton = new System.Windows.Forms.Button();
            this.sqlCloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sqlOpenButton
            // 
            this.sqlOpenButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sqlOpenButton.Location = new System.Drawing.Point(8, 35);
            this.sqlOpenButton.Name = "sqlOpenButton";
            this.sqlOpenButton.Size = new System.Drawing.Size(142, 28);
            this.sqlOpenButton.TabIndex = 0;
            this.sqlOpenButton.Text = "SQL Connection Open";
            this.sqlOpenButton.UseVisualStyleBackColor = true;
            this.sqlOpenButton.Click += new System.EventHandler(this.sqlOpenButton_Click);
            // 
            // firebirdOpenButton
            // 
            this.firebirdOpenButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firebirdOpenButton.Location = new System.Drawing.Point(337, 34);
            this.firebirdOpenButton.Name = "firebirdOpenButton";
            this.firebirdOpenButton.Size = new System.Drawing.Size(163, 30);
            this.firebirdOpenButton.TabIndex = 1;
            this.firebirdOpenButton.Text = "Firebird Connection Open";
            this.firebirdOpenButton.UseVisualStyleBackColor = true;
            this.firebirdOpenButton.Click += new System.EventHandler(this.firebirdOpenButton_Click);
            // 
            // sqlStatusLabel
            // 
            this.sqlStatusLabel.AutoSize = true;
            this.sqlStatusLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sqlStatusLabel.Location = new System.Drawing.Point(79, 122);
            this.sqlStatusLabel.Name = "sqlStatusLabel";
            this.sqlStatusLabel.Size = new System.Drawing.Size(0, 18);
            this.sqlStatusLabel.TabIndex = 2;
            this.sqlStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firebirdStatusLabel
            // 
            this.firebirdStatusLabel.AutoSize = true;
            this.firebirdStatusLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firebirdStatusLabel.Location = new System.Drawing.Point(398, 122);
            this.firebirdStatusLabel.Name = "firebirdStatusLabel";
            this.firebirdStatusLabel.Size = new System.Drawing.Size(0, 18);
            this.firebirdStatusLabel.TabIndex = 3;
            this.firebirdStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firebirdCloseButton
            // 
            this.firebirdCloseButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firebirdCloseButton.Location = new System.Drawing.Point(506, 35);
            this.firebirdCloseButton.Name = "firebirdCloseButton";
            this.firebirdCloseButton.Size = new System.Drawing.Size(166, 28);
            this.firebirdCloseButton.TabIndex = 4;
            this.firebirdCloseButton.Text = "Firebird Connection Close";
            this.firebirdCloseButton.UseVisualStyleBackColor = true;
            this.firebirdCloseButton.Click += new System.EventHandler(this.firebirdCloseButton_Click);
            // 
            // sqlCloseButton
            // 
            this.sqlCloseButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sqlCloseButton.Location = new System.Drawing.Point(156, 35);
            this.sqlCloseButton.Name = "sqlCloseButton";
            this.sqlCloseButton.Size = new System.Drawing.Size(142, 28);
            this.sqlCloseButton.TabIndex = 5;
            this.sqlCloseButton.Text = "SQL Connection Close";
            this.sqlCloseButton.UseVisualStyleBackColor = true;
            this.sqlCloseButton.Click += new System.EventHandler(this.sqlCloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sql Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Firebird Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Connection Test";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 194);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sqlCloseButton);
            this.Controls.Add(this.firebirdCloseButton);
            this.Controls.Add(this.firebirdStatusLabel);
            this.Controls.Add(this.sqlStatusLabel);
            this.Controls.Add(this.firebirdOpenButton);
            this.Controls.Add(this.sqlOpenButton);
            this.Name = "Form1";
            this.Text = "Connection Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sqlOpenButton;
        private System.Windows.Forms.Button firebirdOpenButton;
        private System.Windows.Forms.Label sqlStatusLabel;
        private System.Windows.Forms.Label firebirdStatusLabel;
        private System.Windows.Forms.Button firebirdCloseButton;
        private System.Windows.Forms.Button sqlCloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

