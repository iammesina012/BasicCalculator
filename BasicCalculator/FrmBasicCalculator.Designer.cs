namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.cbOperations = new System.Windows.Forms.ComboBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.lblBasicCalculator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Lime;
            this.lblResult.Location = new System.Drawing.Point(62, 386);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 46);
            this.lblResult.TabIndex = 13;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Black;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(45, 326);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4);
            this.lblTotal.Multiline = true;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(375, 136);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total:";
            // 
            // btnCompute
            // 
            this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.Location = new System.Drawing.Point(137, 511);
            this.btnCompute.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(168, 49);
            this.btnCompute.TabIndex = 11;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // cbOperations
            // 
            this.cbOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperations.FormattingEnabled = true;
            this.cbOperations.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbOperations.Location = new System.Drawing.Point(177, 172);
            this.cbOperations.Margin = new System.Windows.Forms.Padding(4);
            this.cbOperations.Name = "cbOperations";
            this.cbOperations.Size = new System.Drawing.Size(104, 33);
            this.cbOperations.TabIndex = 10;
            // 
            // txtSecond
            // 
            this.txtSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecond.Location = new System.Drawing.Point(43, 237);
            this.txtSecond.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecond.Multiline = true;
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSecond.Size = new System.Drawing.Size(375, 56);
            this.txtSecond.TabIndex = 9;
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.Location = new System.Drawing.Point(43, 82);
            this.txtFirst.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirst.Multiline = true;
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFirst.Size = new System.Drawing.Size(375, 56);
            this.txtFirst.TabIndex = 8;
            // 
            // lblBasicCalculator
            // 
            this.lblBasicCalculator.AutoSize = true;
            this.lblBasicCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicCalculator.Location = new System.Drawing.Point(35, 26);
            this.lblBasicCalculator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasicCalculator.Name = "lblBasicCalculator";
            this.lblBasicCalculator.Size = new System.Drawing.Size(264, 39);
            this.lblBasicCalculator.TabIndex = 7;
            this.lblBasicCalculator.Text = "Basic Calculator";
            // 
            // FrmBasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 609);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.cbOperations);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.lblBasicCalculator);
            this.Name = "FrmBasicCalculator";
            this.Text = "FrmBasicCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox lblTotal;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.ComboBox cbOperations;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label lblBasicCalculator;
    }
}

