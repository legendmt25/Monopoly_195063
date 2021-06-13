
namespace MonopolyGame
{
    partial class NumberPlayers
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
            this.comboBoxNumberPlayers = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxNumberPlayers
            // 
            this.comboBoxNumberPlayers.FormattingEnabled = true;
            this.comboBoxNumberPlayers.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.comboBoxNumberPlayers.Location = new System.Drawing.Point(12, 12);
            this.comboBoxNumberPlayers.Name = "comboBoxNumberPlayers";
            this.comboBoxNumberPlayers.Size = new System.Drawing.Size(327, 23);
            this.comboBoxNumberPlayers.TabIndex = 0;
            this.comboBoxNumberPlayers.SelectedIndexChanged += new System.EventHandler(this.comboBoxNumberPlayers_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(74, 41);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(207, 41);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // NumberPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 94);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.comboBoxNumberPlayers);
            this.Name = "NumberPlayers";
            this.Text = "Select the number of players";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox comboBoxNumberPlayers;
    }
}