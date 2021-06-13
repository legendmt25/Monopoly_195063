
namespace MonopolyGame
{
    partial class MonopolyGame
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
            this.labelMoney = new System.Windows.Forms.Label();
            this.panelChance = new System.Windows.Forms.Panel();
            this.labelChance = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelCard = new System.Windows.Forms.Label();
            this.panelSurprise = new System.Windows.Forms.Panel();
            this.labelSurprise = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.listMap = new System.Windows.Forms.ListBox();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.panelChance.SuspendLayout();
            this.panelSurprise.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(12, 9);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(0, 15);
            this.labelMoney.TabIndex = 1;
            // 
            // panelChance
            // 
            this.panelChance.Controls.Add(this.labelChance);
            this.panelChance.Location = new System.Drawing.Point(581, 12);
            this.panelChance.Name = "panelChance";
            this.panelChance.Size = new System.Drawing.Size(207, 173);
            this.panelChance.TabIndex = 2;
            this.panelChance.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChance_Paint);
            // 
            // labelChance
            // 
            this.labelChance.AutoEllipsis = true;
            this.labelChance.AutoSize = true;
            this.labelChance.Location = new System.Drawing.Point(21, 13);
            this.labelChance.MaximumSize = new System.Drawing.Size(100, 100);
            this.labelChance.Name = "labelChance";
            this.labelChance.Size = new System.Drawing.Size(0, 15);
            this.labelChance.TabIndex = 1;
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Location = new System.Drawing.Point(0, 0);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(0, 15);
            this.labelPlayer.TabIndex = 3;
            this.labelPlayer.Paint += new System.Windows.Forms.PaintEventHandler(this.labelPlayer_Paint);
            // 
            // labelCard
            // 
            this.labelCard.AutoSize = true;
            this.labelCard.Location = new System.Drawing.Point(165, 40);
            this.labelCard.Name = "labelCard";
            this.labelCard.Size = new System.Drawing.Size(0, 15);
            this.labelCard.TabIndex = 4;
            // 
            // panelSurprise
            // 
            this.panelSurprise.Controls.Add(this.labelSurprise);
            this.panelSurprise.Controls.Add(this.label1);
            this.panelSurprise.Location = new System.Drawing.Point(581, 194);
            this.panelSurprise.Name = "panelSurprise";
            this.panelSurprise.Size = new System.Drawing.Size(207, 185);
            this.panelSurprise.TabIndex = 3;
            this.panelSurprise.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSurprise_Paint);
            // 
            // labelSurprise
            // 
            this.labelSurprise.AutoEllipsis = true;
            this.labelSurprise.AutoSize = true;
            this.labelSurprise.Location = new System.Drawing.Point(15, 13);
            this.labelSurprise.MaximumSize = new System.Drawing.Size(100, 100);
            this.labelSurprise.Name = "labelSurprise";
            this.labelSurprise.Size = new System.Drawing.Size(0, 18);
            this.labelSurprise.TabIndex = 7;
            this.labelSurprise.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.MaximumSize = new System.Drawing.Size(100, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 0;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(649, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(67, 56);
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 0;
            // 
            // listMap
            // 
            this.listMap.FormattingEnabled = true;
            this.listMap.ItemHeight = 15;
            this.listMap.Location = new System.Drawing.Point(12, 224);
            this.listMap.Name = "listMap";
            this.listMap.Size = new System.Drawing.Size(563, 214);
            this.listMap.TabIndex = 6;
            // 
            // panelPlayer
            // 
            this.panelPlayer.Controls.Add(this.labelPlayer);
            this.panelPlayer.Location = new System.Drawing.Point(155, 2);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(420, 38);
            this.panelPlayer.TabIndex = 7;
            // 
            // MonopolyGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.listMap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSurprise);
            this.Controls.Add(this.labelCard);
            this.Controls.Add(this.panelChance);
            this.Controls.Add(this.labelMoney);
            this.Name = "MonopolyGame";
            this.Text = "Monopoly";
            this.Resize += new System.EventHandler(this.MonopolyGame_Resize);
            this.panelChance.ResumeLayout(false);
            this.panelChance.PerformLayout();
            this.panelSurprise.ResumeLayout(false);
            this.panelSurprise.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPlayer.ResumeLayout(false);
            this.panelPlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Panel panelChance;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelCard;
        private System.Windows.Forms.Panel panelSurprise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listMap;
        private System.Windows.Forms.Label labelChance;
        private System.Windows.Forms.Label labelSurprise;
        private System.Windows.Forms.Panel panelPlayer;
    }
}

