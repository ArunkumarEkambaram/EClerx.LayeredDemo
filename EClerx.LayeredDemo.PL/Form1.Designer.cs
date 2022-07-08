namespace EClerx.LayeredDemo.PL
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
            this.TxtState = new System.Windows.Forms.TextBox();
            this.BtnGet = new System.Windows.Forms.Button();
            this.GridEmployee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter State";
            // 
            // TxtState
            // 
            this.TxtState.Location = new System.Drawing.Point(155, 51);
            this.TxtState.Name = "TxtState";
            this.TxtState.Size = new System.Drawing.Size(200, 31);
            this.TxtState.TabIndex = 1;
            // 
            // BtnGet
            // 
            this.BtnGet.AutoSize = true;
            this.BtnGet.Location = new System.Drawing.Point(373, 47);
            this.BtnGet.Name = "BtnGet";
            this.BtnGet.Size = new System.Drawing.Size(91, 35);
            this.BtnGet.TabIndex = 2;
            this.BtnGet.Text = "Get Data";
            this.BtnGet.UseVisualStyleBackColor = true;
            this.BtnGet.Click += new System.EventHandler(this.BtnGet_Click);
            // 
            // GridEmployee
            // 
            this.GridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmployee.Location = new System.Drawing.Point(29, 116);
            this.GridEmployee.Name = "GridEmployee";
            this.GridEmployee.RowHeadersWidth = 51;
            this.GridEmployee.RowTemplate.Height = 24;
            this.GridEmployee.Size = new System.Drawing.Size(725, 260);
            this.GridEmployee.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 415);
            this.Controls.Add(this.GridEmployee);
            this.Controls.Add(this.BtnGet);
            this.Controls.Add(this.TxtState);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtState;
        private System.Windows.Forms.Button BtnGet;
        private System.Windows.Forms.DataGridView GridEmployee;
    }
}

