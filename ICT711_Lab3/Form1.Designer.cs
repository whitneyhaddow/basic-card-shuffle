namespace ICT711_Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Basic card shuffle
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstDeck = new System.Windows.Forms.ListBox();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnDeal = new System.Windows.Forms.Button();
            this.lstP1 = new System.Windows.Forms.ListBox();
            this.lstP2 = new System.Windows.Forms.ListBox();
            this.lstP3 = new System.Windows.Forms.ListBox();
            this.lstP4 = new System.Windows.Forms.ListBox();
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.lblP3 = new System.Windows.Forms.Label();
            this.lblP4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDeck
            // 
            this.lstDeck.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDeck.FormattingEnabled = true;
            this.lstDeck.ItemHeight = 16;
            this.lstDeck.Location = new System.Drawing.Point(15, 16);
            this.lstDeck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstDeck.Name = "lstDeck";
            this.lstDeck.Size = new System.Drawing.Size(119, 292);
            this.lstDeck.TabIndex = 0;
            // 
            // btnShuffle
            // 
            this.btnShuffle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.Location = new System.Drawing.Point(258, 79);
            this.btnShuffle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(128, 28);
            this.btnShuffle.TabIndex = 1;
            this.btnShuffle.Text = "&Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnDeal
            // 
            this.btnDeal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeal.Location = new System.Drawing.Point(393, 79);
            this.btnDeal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(132, 28);
            this.btnDeal.TabIndex = 2;
            this.btnDeal.Text = "&Deal";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // lstP1
            // 
            this.lstP1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstP1.FormattingEnabled = true;
            this.lstP1.ItemHeight = 16;
            this.lstP1.Location = new System.Drawing.Point(143, 159);
            this.lstP1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstP1.Name = "lstP1";
            this.lstP1.Size = new System.Drawing.Size(87, 148);
            this.lstP1.TabIndex = 3;
            // 
            // lstP2
            // 
            this.lstP2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstP2.FormattingEnabled = true;
            this.lstP2.ItemHeight = 16;
            this.lstP2.Location = new System.Drawing.Point(238, 160);
            this.lstP2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstP2.Name = "lstP2";
            this.lstP2.Size = new System.Drawing.Size(88, 148);
            this.lstP2.TabIndex = 4;
            // 
            // lstP3
            // 
            this.lstP3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstP3.FormattingEnabled = true;
            this.lstP3.ItemHeight = 16;
            this.lstP3.Location = new System.Drawing.Point(333, 160);
            this.lstP3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstP3.Name = "lstP3";
            this.lstP3.Size = new System.Drawing.Size(94, 148);
            this.lstP3.TabIndex = 5;
            // 
            // lstP4
            // 
            this.lstP4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstP4.FormattingEnabled = true;
            this.lstP4.ItemHeight = 16;
            this.lstP4.Location = new System.Drawing.Point(435, 160);
            this.lstP4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstP4.Name = "lstP4";
            this.lstP4.Size = new System.Drawing.Size(90, 148);
            this.lstP4.TabIndex = 6;
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1.Location = new System.Drawing.Point(141, 140);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(54, 16);
            this.lblP1.TabIndex = 7;
            this.lblP1.Text = "Player 1";
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2.Location = new System.Drawing.Point(235, 140);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(54, 16);
            this.lblP2.TabIndex = 8;
            this.lblP2.Text = "Player 2";
            // 
            // lblP3
            // 
            this.lblP3.AutoSize = true;
            this.lblP3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP3.Location = new System.Drawing.Point(331, 140);
            this.lblP3.Name = "lblP3";
            this.lblP3.Size = new System.Drawing.Size(54, 16);
            this.lblP3.TabIndex = 9;
            this.lblP3.Text = "Player 3";
            // 
            // lblP4
            // 
            this.lblP4.AutoSize = true;
            this.lblP4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP4.Location = new System.Drawing.Point(432, 140);
            this.lblP4.Name = "lblP4";
            this.lblP4.Size = new System.Drawing.Size(54, 16);
            this.lblP4.TabIndex = 10;
            this.lblP4.Text = "Player 4";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(254, 334);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 28);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Start &Again";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(393, 334);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 28);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 384);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblP4);
            this.Controls.Add(this.lblP3);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.lstP4);
            this.Controls.Add(this.lstP3);
            this.Controls.Add(this.lstP2);
            this.Controls.Add(this.lstP1);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.lstDeck);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Lab 3 - Card Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDeck;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.ListBox lstP1;
        private System.Windows.Forms.ListBox lstP2;
        private System.Windows.Forms.ListBox lstP3;
        private System.Windows.Forms.ListBox lstP4;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.Label lblP3;
        private System.Windows.Forms.Label lblP4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

