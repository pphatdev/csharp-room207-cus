namespace FormInput
{
    partial class Form
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
            this.Heading = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.InputName = new System.Windows.Forms.TextBox();
            this.LabelAge = new System.Windows.Forms.Label();
            this.InputAddress = new System.Windows.Forms.TextBox();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.InputAge = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Romnea", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(236, 18);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(353, 59);
            this.Heading.TabIndex = 0;
            this.Heading.Text = "Student Information";
            this.Heading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Suwannaphum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(243, 108);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(81, 31);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "Name :";
            // 
            // InputName
            // 
            this.InputName.Font = new System.Drawing.Font("Suwannaphum", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputName.Location = new System.Drawing.Point(362, 104);
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(227, 35);
            this.InputName.TabIndex = 3;
            // 
            // LabelAge
            // 
            this.LabelAge.AutoSize = true;
            this.LabelAge.Font = new System.Drawing.Font("Suwannaphum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAge.Location = new System.Drawing.Point(243, 163);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(61, 31);
            this.LabelAge.TabIndex = 4;
            this.LabelAge.Text = "Age :";
            // 
            // InputAddress
            // 
            this.InputAddress.Font = new System.Drawing.Font("Suwannaphum", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAddress.Location = new System.Drawing.Point(362, 216);
            this.InputAddress.Multiline = true;
            this.InputAddress.Name = "InputAddress";
            this.InputAddress.Size = new System.Drawing.Size(227, 61);
            this.InputAddress.TabIndex = 7;
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Font = new System.Drawing.Font("Suwannaphum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddress.Location = new System.Drawing.Point(243, 214);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(102, 31);
            this.LabelAddress.TabIndex = 6;
            this.LabelAddress.Text = "Address :";
            // 
            // InputAge
            // 
            this.InputAge.Font = new System.Drawing.Font("Suwannaphum", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAge.Location = new System.Drawing.Point(362, 160);
            this.InputAge.Name = "InputAge";
            this.InputAge.Size = new System.Drawing.Size(227, 35);
            this.InputAge.TabIndex = 5;
            this.InputAge.WordWrap = false;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Kh Ang B.Rodtha", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(514, 302);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 37);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.ClickSave);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Kh Ang B.Rodtha", 10.2F);
            this.CancelButton.Location = new System.Drawing.Point(433, 302);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CancelButton.Size = new System.Drawing.Size(75, 37);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.ClickCancel);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.InputAddress);
            this.Controls.Add(this.LabelAddress);
            this.Controls.Add(this.InputAge);
            this.Controls.Add(this.LabelAge);
            this.Controls.Add(this.InputName);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.Heading);
            this.Name = "Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Input";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.Label LabelAge;
        private System.Windows.Forms.TextBox InputAddress;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.TextBox InputAge;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
    }
}

