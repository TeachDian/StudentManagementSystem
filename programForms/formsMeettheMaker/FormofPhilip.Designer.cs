namespace StudentManagementSystem.programForms.formsMeettheMaker
{
    partial class FormofPhilip
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.f2AdmbtnLogout = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1180, 780);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(20, 20);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(928, 740);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(948, 20);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 740);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.f2AdmbtnLogout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(968, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 740);
            this.panel2.TabIndex = 7;
            // 
            // f2AdmbtnLogout
            // 
            this.f2AdmbtnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.f2AdmbtnLogout.FlatAppearance.BorderSize = 0;
            this.f2AdmbtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f2AdmbtnLogout.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.f2AdmbtnLogout.IconColor = System.Drawing.Color.DimGray;
            this.f2AdmbtnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.f2AdmbtnLogout.IconSize = 70;
            this.f2AdmbtnLogout.Location = new System.Drawing.Point(0, 650);
            this.f2AdmbtnLogout.Name = "f2AdmbtnLogout";
            this.f2AdmbtnLogout.Size = new System.Drawing.Size(192, 90);
            this.f2AdmbtnLogout.TabIndex = 6;
            this.f2AdmbtnLogout.Text = "LOGOUT";
            this.f2AdmbtnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.f2AdmbtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.f2AdmbtnLogout.UseVisualStyleBackColor = true;
            this.f2AdmbtnLogout.Click += new System.EventHandler(this.f2AdmbtnLogout_Click);
            // 
            // FormofPhilip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 780);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormofPhilip";
            this.Text = "FormofPhilip";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton f2AdmbtnLogout;
        private Panel panel4;
        private Panel panel3;
    }
}