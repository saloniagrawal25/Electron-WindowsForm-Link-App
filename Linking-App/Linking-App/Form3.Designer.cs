namespace Linking_App
{
    partial class Form3
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
            this.openForm = new System.Windows.Forms.Button();
            this.openConnection = new System.Windows.Forms.Button();
            this.btnCryptoApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openForm
            // 
            this.openForm.Location = new System.Drawing.Point(330, 94);
            this.openForm.Name = "openForm";
            this.openForm.Size = new System.Drawing.Size(194, 65);
            this.openForm.TabIndex = 0;
            this.openForm.Text = "openForm";
            this.openForm.UseVisualStyleBackColor = true;
            this.openForm.Click += new System.EventHandler(this.openForm_Click);
            // 
            // openConnection
            // 
            this.openConnection.Location = new System.Drawing.Point(101, 94);
            this.openConnection.Name = "openConnection";
            this.openConnection.Size = new System.Drawing.Size(194, 65);
            this.openConnection.TabIndex = 1;
            this.openConnection.Text = "openConnection";
            this.openConnection.UseVisualStyleBackColor = true;
            this.openConnection.Click += new System.EventHandler(this.openConnection_Click);
            // 
            // btnCryptoApp
            // 
            this.btnCryptoApp.Location = new System.Drawing.Point(125, 219);
            this.btnCryptoApp.Name = "btnCryptoApp";
            this.btnCryptoApp.Size = new System.Drawing.Size(194, 65);
            this.btnCryptoApp.TabIndex = 2;
            this.btnCryptoApp.Text = "Open Crypto App";
            this.btnCryptoApp.UseVisualStyleBackColor = true;
            this.btnCryptoApp.Click += new System.EventHandler(this.btnCryptoApp_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCryptoApp);
            this.Controls.Add(this.openConnection);
            this.Controls.Add(this.openForm);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openForm;
        private System.Windows.Forms.Button openConnection;
        private System.Windows.Forms.Button btnCryptoApp;
    }
}