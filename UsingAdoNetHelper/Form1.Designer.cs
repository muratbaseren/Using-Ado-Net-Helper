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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.Location = new System.Drawing.Point(16, 74);
            this.btnRunQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRunQuery.Name = "btnRunQuery";
            this.btnRunQuery.Size = new System.Drawing.Size(100, 58);
            this.btnRunQuery.TabIndex = 0;
            this.btnRunQuery.Text = "RunQuery";
            this.btnRunQuery.UseVisualStyleBackColor = true;
            this.btnRunQuery.Click += new System.EventHandler(this.btnRunQuery_Click);
            // 
            // btnGetTable
            // 
            this.btnGetTable.Location = new System.Drawing.Point(124, 74);
            this.btnGetTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetTable.Name = "btnGetTable";
            this.btnGetTable.Size = new System.Drawing.Size(100, 58);
            this.btnGetTable.TabIndex = 0;
            this.btnGetTable.Text = "GetTable";
            this.btnGetTable.UseVisualStyleBackColor = true;
            this.btnGetTable.Click += new System.EventHandler(this.btnGetTable_Click);
            // 
            // btnRunProc
            // 
            this.btnRunProc.Location = new System.Drawing.Point(232, 74);
            this.btnRunProc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRunProc.Name = "btnRunProc";
            this.btnRunProc.Size = new System.Drawing.Size(100, 58);
            this.btnRunProc.TabIndex = 0;
            this.btnRunProc.Text = "RunProc";
            this.btnRunProc.UseVisualStyleBackColor = true;
            this.btnRunProc.Click += new System.EventHandler(this.btnRunProc_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "KMB Ado Net Helper Sample";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 147);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRunProc);
            this.Controls.Add(this.btnGetTable);
            this.Controls.Add(this.btnRunQuery);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KMB Ado.Net Helper";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRunQuery;
        private System.Windows.Forms.Button btnGetTable;
        private System.Windows.Forms.Button btnRunProc;
        private System.Windows.Forms.Label label1;
    }
}

