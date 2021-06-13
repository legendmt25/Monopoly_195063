
namespace MonopolyGame
{
    partial class Jail
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
            this.btnPay = new System.Windows.Forms.Button();
            this.btnUseCard = new System.Windows.Forms.Button();
            this.btnWait = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(12, 35);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 49);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnUseCard
            // 
            this.btnUseCard.Location = new System.Drawing.Point(121, 35);
            this.btnUseCard.Name = "btnUseCard";
            this.btnUseCard.Size = new System.Drawing.Size(75, 49);
            this.btnUseCard.TabIndex = 1;
            this.btnUseCard.Text = "Use card";
            this.btnUseCard.UseVisualStyleBackColor = true;
            this.btnUseCard.Click += new System.EventHandler(this.btnUseCard_Click);
            // 
            // btnWait
            // 
            this.btnWait.Location = new System.Drawing.Point(232, 35);
            this.btnWait.Name = "btnWait";
            this.btnWait.Size = new System.Drawing.Size(75, 49);
            this.btnWait.TabIndex = 2;
            this.btnWait.Text = "Wait";
            this.btnWait.UseVisualStyleBackColor = true;
            this.btnWait.Click += new System.EventHandler(this.btnWait_Click);
            // 
            // Jail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 119);
            this.Controls.Add(this.btnWait);
            this.Controls.Add(this.btnUseCard);
            this.Controls.Add(this.btnPay);
            this.Name = "Jail";
            this.Text = "Jail";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnUseCard;
        private System.Windows.Forms.Button btnWait;
    }
}