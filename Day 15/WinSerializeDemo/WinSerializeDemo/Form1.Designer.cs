namespace WinSerializeDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBinSerialize = new System.Windows.Forms.Button();
            this.btnBinDeSerialize = new System.Windows.Forms.Button();
            this.txtXMLSerialize = new System.Windows.Forms.Button();
            this.btnXMLDeserialize = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(281, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.2F, System.Drawing.FontStyle.Bold);
            this.txtEmployeeID.Location = new System.Drawing.Point(459, 114);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(100, 36);
            this.txtEmployeeID.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.2F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(459, 167);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 36);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(281, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.2F, System.Drawing.FontStyle.Bold);
            this.txtSalary.Location = new System.Drawing.Point(459, 232);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 36);
            this.txtSalary.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(281, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salary";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnBinSerialize
            // 
            this.btnBinSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBinSerialize.Location = new System.Drawing.Point(221, 361);
            this.btnBinSerialize.Name = "btnBinSerialize";
            this.btnBinSerialize.Size = new System.Drawing.Size(146, 40);
            this.btnBinSerialize.TabIndex = 6;
            this.btnBinSerialize.Text = "Bin Serialize";
            this.btnBinSerialize.UseVisualStyleBackColor = true;
            this.btnBinSerialize.Click += new System.EventHandler(this.btnBinSerialize_Click);
            // 
            // btnBinDeSerialize
            // 
            this.btnBinDeSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBinDeSerialize.Location = new System.Drawing.Point(221, 418);
            this.btnBinDeSerialize.Name = "btnBinDeSerialize";
            this.btnBinDeSerialize.Size = new System.Drawing.Size(146, 40);
            this.btnBinDeSerialize.TabIndex = 7;
            this.btnBinDeSerialize.Text = "Bin Deserialize";
            this.btnBinDeSerialize.UseVisualStyleBackColor = true;
            this.btnBinDeSerialize.Click += new System.EventHandler(this.btnBinDeSerialize_Click);
            // 
            // txtXMLSerialize
            // 
            this.txtXMLSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtXMLSerialize.Location = new System.Drawing.Point(391, 361);
            this.txtXMLSerialize.Name = "txtXMLSerialize";
            this.txtXMLSerialize.Size = new System.Drawing.Size(207, 40);
            this.txtXMLSerialize.TabIndex = 8;
            this.txtXMLSerialize.Text = "XML Serialize";
            this.txtXMLSerialize.UseVisualStyleBackColor = true;
            this.txtXMLSerialize.Click += new System.EventHandler(this.txtXMLSerialize_Click);
            // 
            // btnXMLDeserialize
            // 
            this.btnXMLDeserialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXMLDeserialize.Location = new System.Drawing.Point(391, 418);
            this.btnXMLDeserialize.Name = "btnXMLDeserialize";
            this.btnXMLDeserialize.Size = new System.Drawing.Size(207, 40);
            this.btnXMLDeserialize.TabIndex = 9;
            this.btnXMLDeserialize.Text = "XML Deserialize";
            this.btnXMLDeserialize.UseVisualStyleBackColor = true;
            this.btnXMLDeserialize.Click += new System.EventHandler(this.btnXMLDeserialize_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button5.Location = new System.Drawing.Point(615, 361);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 40);
            this.button5.TabIndex = 10;
            this.button5.Text = "SOAP Serialize";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button6.Location = new System.Drawing.Point(615, 418);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(161, 40);
            this.button6.TabIndex = 11;
            this.button6.Text = "SOAP Deserialize";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 644);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnXMLDeserialize);
            this.Controls.Add(this.txtXMLSerialize);
            this.Controls.Add(this.btnBinDeSerialize);
            this.Controls.Add(this.btnBinSerialize);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBinSerialize;
        private System.Windows.Forms.Button btnBinDeSerialize;
        private System.Windows.Forms.Button txtXMLSerialize;
        private System.Windows.Forms.Button btnXMLDeserialize;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

