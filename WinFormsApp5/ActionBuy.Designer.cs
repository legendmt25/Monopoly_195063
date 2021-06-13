
namespace MonopolyGame
{
    partial class ActionBuy
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
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnLicitation = new System.Windows.Forms.Button();
            this.labelProp = new System.Windows.Forms.Label();
            this.btnBuildBuilding = new System.Windows.Forms.Button();
            this.btnBuildHouse = new System.Windows.Forms.Button();
            this.btnMortgage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(12, 25);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 54);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Text = "Купи";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnLicitation
            // 
            this.btnLicitation.Location = new System.Drawing.Point(93, 25);
            this.btnLicitation.Name = "btnLicitation";
            this.btnLicitation.Size = new System.Drawing.Size(91, 54);
            this.btnLicitation.TabIndex = 1;
            this.btnLicitation.Text = "Лицитација";
            this.btnLicitation.UseVisualStyleBackColor = true;
            this.btnLicitation.Click += new System.EventHandler(this.btnLicitation_Click);
            // 
            // labelProp
            // 
            this.labelProp.AutoSize = true;
            this.labelProp.Location = new System.Drawing.Point(12, 9);
            this.labelProp.Name = "labelProp";
            this.labelProp.Size = new System.Drawing.Size(0, 15);
            this.labelProp.TabIndex = 2;
            // 
            // btnBuildBuilding
            // 
            this.btnBuildBuilding.Location = new System.Drawing.Point(93, 85);
            this.btnBuildBuilding.Name = "btnBuildBuilding";
            this.btnBuildBuilding.Size = new System.Drawing.Size(91, 54);
            this.btnBuildBuilding.TabIndex = 4;
            this.btnBuildBuilding.Text = "Направи зграда";
            this.btnBuildBuilding.UseVisualStyleBackColor = true;
            this.btnBuildBuilding.Click += new System.EventHandler(this.btnBuildBuilding_Click);
            // 
            // btnBuildHouse
            // 
            this.btnBuildHouse.Location = new System.Drawing.Point(12, 85);
            this.btnBuildHouse.Name = "btnBuildHouse";
            this.btnBuildHouse.Size = new System.Drawing.Size(75, 54);
            this.btnBuildHouse.TabIndex = 3;
            this.btnBuildHouse.Text = "Направи Куќа";
            this.btnBuildHouse.UseVisualStyleBackColor = true;
            this.btnBuildHouse.Click += new System.EventHandler(this.btnBuildHouse_Click);
            // 
            // btnMortgage
            // 
            this.btnMortgage.Location = new System.Drawing.Point(190, 25);
            this.btnMortgage.Name = "btnMortgage";
            this.btnMortgage.Size = new System.Drawing.Size(106, 114);
            this.btnMortgage.TabIndex = 5;
            this.btnMortgage.Text = "Хипотека";
            this.btnMortgage.UseVisualStyleBackColor = true;
            this.btnMortgage.Click += new System.EventHandler(this.btnMortgage_Click);
            // 
            // ActionBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 164);
            this.Controls.Add(this.btnMortgage);
            this.Controls.Add(this.btnBuildBuilding);
            this.Controls.Add(this.btnBuildHouse);
            this.Controls.Add(this.labelProp);
            this.Controls.Add(this.btnLicitation);
            this.Controls.Add(this.btnBuy);
            this.Name = "ActionBuy";
            this.Text = "Action";
            this.Load += new System.EventHandler(this.ActionBuy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnLicitation;
        private System.Windows.Forms.Label labelProp;
        private System.Windows.Forms.Button btnBuildBuilding;
        private System.Windows.Forms.Button btnBuildHouse;
        private System.Windows.Forms.Button btnMortgage;
    }
}