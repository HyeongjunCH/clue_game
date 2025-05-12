namespace Clue
{
    partial class Suggest
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
            this.cmbChara = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.txbRoom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbChara
            // 
            this.cmbChara.FormattingEnabled = true;
            this.cmbChara.Items.AddRange(new object[] {
            "Green",
            "Mustard",
            "Peacock",
            "Plum",
            "Scarlett",
            "White"});
            this.cmbChara.Location = new System.Drawing.Point(127, 198);
            this.cmbChara.Name = "cmbChara";
            this.cmbChara.Size = new System.Drawing.Size(121, 32);
            this.cmbChara.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "이(가)";
            // 
            // cmbItems
            // 
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Items.AddRange(new object[] {
            "촛대",
            "단검",
            "파이프",
            "리볼버",
            "밧줄",
            "랜치"});
            this.cmbItems.Location = new System.Drawing.Point(445, 198);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(121, 32);
            this.cmbItems.TabIndex = 2;
            // 
            // txbRoom
            // 
            this.txbRoom.Enabled = false;
            this.txbRoom.Location = new System.Drawing.Point(236, 108);
            this.txbRoom.Name = "txbRoom";
            this.txbRoom.Size = new System.Drawing.Size(100, 35);
            this.txbRoom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "(으)로";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "이(가)";
            // 
            // btnSug
            // 
            this.btnSug.Location = new System.Drawing.Point(236, 301);
            this.btnSug.Name = "btnSug";
            this.btnSug.Size = new System.Drawing.Size(280, 82);
            this.btnSug.TabIndex = 6;
            this.btnSug.Text = "살인을 했어!";
            this.btnSug.UseVisualStyleBackColor = true;
            this.btnSug.Click += new System.EventHandler(this.btnSug_Click);
            // 
            // Suggest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSug);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbRoom);
            this.Controls.Add(this.cmbItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbChara);
            this.Name = "Suggest";
            this.Text = "Suggest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.TextBox txbRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSug;
    }
}