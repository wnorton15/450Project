namespace Cita450Project
{
    partial class AddCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerNameInput = new System.Windows.Forms.TextBox();
            this.CustomerPriceInput = new System.Windows.Forms.TextBox();
            this.CustomerAddressInput = new System.Windows.Forms.TextBox();
            this.SubmitCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Adress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer Price";
            // 
            // CustomerNameInput
            // 
            this.CustomerNameInput.Location = new System.Drawing.Point(255, 123);
            this.CustomerNameInput.Name = "CustomerNameInput";
            this.CustomerNameInput.Size = new System.Drawing.Size(245, 26);
            this.CustomerNameInput.TabIndex = 4;
            // 
            // CustomerPriceInput
            // 
            this.CustomerPriceInput.Location = new System.Drawing.Point(255, 200);
            this.CustomerPriceInput.Name = "CustomerPriceInput";
            this.CustomerPriceInput.Size = new System.Drawing.Size(100, 26);
            this.CustomerPriceInput.TabIndex = 6;
            // 
            // CustomerAddressInput
            // 
            this.CustomerAddressInput.Location = new System.Drawing.Point(255, 160);
            this.CustomerAddressInput.Name = "CustomerAddressInput";
            this.CustomerAddressInput.Size = new System.Drawing.Size(245, 26);
            this.CustomerAddressInput.TabIndex = 7;
            // 
            // SubmitCustomer
            // 
            this.SubmitCustomer.Location = new System.Drawing.Point(63, 296);
            this.SubmitCustomer.Name = "SubmitCustomer";
            this.SubmitCustomer.Size = new System.Drawing.Size(113, 47);
            this.SubmitCustomer.TabIndex = 8;
            this.SubmitCustomer.Text = "Submit";
            this.SubmitCustomer.UseVisualStyleBackColor = true;
            this.SubmitCustomer.Click += new System.EventHandler(this.SubmitCustomer_Click);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubmitCustomer);
            this.Controls.Add(this.CustomerAddressInput);
            this.Controls.Add(this.CustomerPriceInput);
            this.Controls.Add(this.CustomerNameInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCustomer";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CustomerNameInput;
        private System.Windows.Forms.TextBox CustomerPriceInput;
        private System.Windows.Forms.TextBox CustomerAddressInput;
        private System.Windows.Forms.Button SubmitCustomer;
    }
}