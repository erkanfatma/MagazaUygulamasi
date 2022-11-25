namespace MagazaUygulamasi
{
    partial class ProductDetail
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
            this.btnFindProduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNameText = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFindProduct
            // 
            this.btnFindProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindProduct.Location = new System.Drawing.Point(12, 12);
            this.btnFindProduct.Name = "btnFindProduct";
            this.btnFindProduct.Size = new System.Drawing.Size(271, 68);
            this.btnFindProduct.TabIndex = 5;
            this.btnFindProduct.Text = "Geri";
            this.btnFindProduct.UseVisualStyleBackColor = true;
            this.btnFindProduct.Click += new System.EventHandler(this.btnFindProduct_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(738, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNameText
            // 
            this.lblNameText.AutoSize = true;
            this.lblNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameText.Location = new System.Drawing.Point(55, 129);
            this.lblNameText.Name = "lblNameText";
            this.lblNameText.Size = new System.Drawing.Size(78, 46);
            this.lblNameText.TabIndex = 7;
            this.lblNameText.Text = "Adı";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(230, 129);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 46);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "xxx";
            // 
            // ProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 740);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNameText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFindProduct);
            this.Name = "ProductDetail";
            this.Text = "ProductDetail";
            this.Load += new System.EventHandler(this.ProductDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNameText;
        private System.Windows.Forms.Label lblName;
    }
}