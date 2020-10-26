namespace Cita450Project
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.custumerOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectOperationToolStripMenuItem,
            this.customerOperationsToolStripMenuItem,
            this.aboutApplicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectOperationToolStripMenuItem
            // 
            this.selectOperationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.updateUserInfoToolStripMenuItem});
            this.selectOperationToolStripMenuItem.Name = "selectOperationToolStripMenuItem";
            this.selectOperationToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.selectOperationToolStripMenuItem.Text = "Admin Operations";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // updateUserInfoToolStripMenuItem
            // 
            this.updateUserInfoToolStripMenuItem.Name = "updateUserInfoToolStripMenuItem";
            this.updateUserInfoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.updateUserInfoToolStripMenuItem.Text = "Update User Info";
            this.updateUserInfoToolStripMenuItem.Click += new System.EventHandler(this.updateUserInfoToolStripMenuItem_Click);
            // 
            // customerOperationsToolStripMenuItem
            // 
            this.customerOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.custumerOrdersToolStripMenuItem});
            this.customerOperationsToolStripMenuItem.Name = "customerOperationsToolStripMenuItem";
            this.customerOperationsToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.customerOperationsToolStripMenuItem.Text = "Customer Operations";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // custumerOrdersToolStripMenuItem
            // 
            this.custumerOrdersToolStripMenuItem.Name = "custumerOrdersToolStripMenuItem";
            this.custumerOrdersToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.custumerOrdersToolStripMenuItem.Text = "Custumer Orders";
            this.custumerOrdersToolStripMenuItem.Click += new System.EventHandler(this.custumerOrdersToolStripMenuItem_Click);
            // 
            // aboutApplicationToolStripMenuItem
            // 
            this.aboutApplicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpInfoToolStripMenuItem,
            this.aboutAppToolStripMenuItem});
            this.aboutApplicationToolStripMenuItem.Name = "aboutApplicationToolStripMenuItem";
            this.aboutApplicationToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.aboutApplicationToolStripMenuItem.Text = "Application Info";
            // 
            // helpInfoToolStripMenuItem
            // 
            this.helpInfoToolStripMenuItem.Name = "helpInfoToolStripMenuItem";
            this.helpInfoToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.helpInfoToolStripMenuItem.Text = "Help Info";
            // 
            // aboutAppToolStripMenuItem
            // 
            this.aboutAppToolStripMenuItem.Name = "aboutAppToolStripMenuItem";
            this.aboutAppToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.aboutAppToolStripMenuItem.Text = "About App";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO THE\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(160, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ice CO.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Application";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(13, 245);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Log Out";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 294);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem custumerOrdersToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem aboutApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAppToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ToolStripMenuItem updateUserInfoToolStripMenuItem;
    }
}