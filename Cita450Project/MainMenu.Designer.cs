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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.custumerOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.signInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectOperationToolStripMenuItem,
            this.customerOperationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectOperationToolStripMenuItem
            // 
            this.selectOperationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.signInToolStripMenuItem});
            this.selectOperationToolStripMenuItem.Name = "selectOperationToolStripMenuItem";
            this.selectOperationToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.selectOperationToolStripMenuItem.Text = "User Operations";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 85);
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
            this.label2.Location = new System.Drawing.Point(333, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ice CO.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Database Application";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 137);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What is this?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 112);
            this.label4.TabIndex = 0;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(472, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 137);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "What can I do?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 112);
            this.label5.TabIndex = 0;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // signInToolStripMenuItem
            // 
            this.signInToolStripMenuItem.Name = "signInToolStripMenuItem";
            this.signInToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.signInToolStripMenuItem.Text = "Sign In";
            this.signInToolStripMenuItem.Click += new System.EventHandler(this.signInToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem signInToolStripMenuItem;
    }
}