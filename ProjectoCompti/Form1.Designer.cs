namespace ProjectoCompti
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputFileEntrada = new System.Windows.Forms.TextBox();
            this.BtnUpload = new System.Windows.Forms.Button();
            this.InputBig = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputFileEntrada
            // 
            this.InputFileEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputFileEntrada.Location = new System.Drawing.Point(20, 18);
            this.InputFileEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputFileEntrada.Multiline = true;
            this.InputFileEntrada.Name = "InputFileEntrada";
            this.InputFileEntrada.Size = new System.Drawing.Size(721, 32);
            this.InputFileEntrada.TabIndex = 0;
            // 
            // BtnUpload
            // 
            this.BtnUpload.Location = new System.Drawing.Point(550, 285);
            this.BtnUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(191, 50);
            this.BtnUpload.TabIndex = 1;
            this.BtnUpload.Text = "INSERT";
            this.BtnUpload.UseVisualStyleBackColor = true;
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // InputBig
            // 
            this.InputBig.Location = new System.Drawing.Point(20, 68);
            this.InputBig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputBig.Multiline = true;
            this.InputBig.Name = "InputBig";
            this.InputBig.Size = new System.Drawing.Size(721, 189);
            this.InputBig.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 396);
            this.Controls.Add(this.InputBig);
            this.Controls.Add(this.BtnUpload);
            this.Controls.Add(this.InputFileEntrada);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "PROJECTO EXERCICIO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox InputFileEntrada;
        private Button BtnUpload;
        private TextBox InputBig;
    }
}