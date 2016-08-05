namespace UsingAdoNetHelper
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
            this.btnRunQuery = new System.Windows.Forms.Button();
            this.btnGetTable = new System.Windows.Forms.Button();
            this.btnRunProc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.Location = new System.Drawing.Point(12, 12);
            this.btnRunQuery.Name = "btnRunQuery";
            this.btnRunQuery.Size = new System.Drawing.Size(75, 42);
            this.btnRunQuery.TabIndex = 0;
            this.btnRunQuery.Text = "RunQuery";
            this.btnRunQuery.UseVisualStyleBackColor = true;
            this.btnRunQuery.Click += new System.EventHandler(this.btnRunQuery_Click);
            // 
            // btnGetTable
            // 
            this.btnGetTable.Location = new System.Drawing.Point(12, 60);
            this.btnGetTable.Name = "btnGetTable";
            this.btnGetTable.Size = new System.Drawing.Size(75, 42);
            this.btnGetTable.TabIndex = 0;
            this.btnGetTable.Text = "GetTable";
            this.btnGetTable.UseVisualStyleBackColor = true;
            this.btnGetTable.Click += new System.EventHandler(this.btnGetTable_Click);
            // 
            // btnRunProc
            // 
            this.btnRunProc.Location = new System.Drawing.Point(12, 108);
            this.btnRunProc.Name = "btnRunProc";
            this.btnRunProc.Size = new System.Drawing.Size(75, 42);
            this.btnRunProc.TabIndex = 0;
            this.btnRunProc.Text = "RunProc";
            this.btnRunProc.UseVisualStyleBackColor = true;
            this.btnRunProc.Click += new System.EventHandler(this.btnRunProc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 175);
            this.Controls.Add(this.btnRunProc);
            this.Controls.Add(this.btnGetTable);
            this.Controls.Add(this.btnRunQuery);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRunQuery;
        private System.Windows.Forms.Button btnGetTable;
        private System.Windows.Forms.Button btnRunProc;
    }
}

