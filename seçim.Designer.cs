namespace aytnethesaplama
{
    partial class Seçim
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
            this.btnTyt = new System.Windows.Forms.Button();
            this.btnAyt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTyt
            // 
            this.btnTyt.Location = new System.Drawing.Point(106, 56);
            this.btnTyt.Name = "btnTyt";
            this.btnTyt.Size = new System.Drawing.Size(130, 99);
            this.btnTyt.TabIndex = 0;
            this.btnTyt.Text = "TYT";
            this.btnTyt.UseVisualStyleBackColor = true;
            this.btnTyt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAyt
            // 
            this.btnAyt.Location = new System.Drawing.Point(106, 194);
            this.btnAyt.Name = "btnAyt";
            this.btnAyt.Size = new System.Drawing.Size(130, 116);
            this.btnAyt.TabIndex = 1;
            this.btnAyt.Text = "AYT";
            this.btnAyt.UseVisualStyleBackColor = true;
            this.btnAyt.Click += new System.EventHandler(this.btnAyt_Click);
            // 
            // Seçim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAyt);
            this.Controls.Add(this.btnTyt);
            this.Name = "Seçim";
            this.Text = "Seçim";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnTyt;
        private Button btnAyt;
    }
}