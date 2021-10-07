namespace Rock_Paper_Scissors_project
{
    partial class rockPaperScissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rockPaperScissors));
            this.btnRock = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.lblIntsructions = new System.Windows.Forms.Label();
            this.picRock = new System.Windows.Forms.PictureBox();
            this.lblCpu = new System.Windows.Forms.Label();
            this.picPaper = new System.Windows.Forms.PictureBox();
            this.picBlocker = new System.Windows.Forms.PictureBox();
            this.picScissors = new System.Windows.Forms.PictureBox();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlocker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.Color.Transparent;
            this.btnRock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRock.BackgroundImage")));
            this.btnRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRock.Location = new System.Drawing.Point(119, 89);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(202, 158);
            this.btnRock.TabIndex = 0;
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScissors.BackgroundImage")));
            this.btnScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScissors.Location = new System.Drawing.Point(605, 89);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(202, 158);
            this.btnScissors.TabIndex = 1;
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPaper.BackgroundImage")));
            this.btnPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaper.Location = new System.Drawing.Point(361, 89);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(202, 158);
            this.btnPaper.TabIndex = 2;
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // lblIntsructions
            // 
            this.lblIntsructions.AutoSize = true;
            this.lblIntsructions.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblIntsructions.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntsructions.ForeColor = System.Drawing.Color.Gold;
            this.lblIntsructions.Location = new System.Drawing.Point(142, 47);
            this.lblIntsructions.Name = "lblIntsructions";
            this.lblIntsructions.Size = new System.Drawing.Size(650, 27);
            this.lblIntsructions.TabIndex = 4;
            this.lblIntsructions.Text = "Select one of the three options and try to beat the cpu";
            // 
            // picRock
            // 
            this.picRock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRock.BackgroundImage")));
            this.picRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRock.Location = new System.Drawing.Point(361, 294);
            this.picRock.Name = "picRock";
            this.picRock.Size = new System.Drawing.Size(202, 158);
            this.picRock.TabIndex = 5;
            this.picRock.TabStop = false;
            // 
            // lblCpu
            // 
            this.lblCpu.AutoSize = true;
            this.lblCpu.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpu.ForeColor = System.Drawing.Color.Crimson;
            this.lblCpu.Location = new System.Drawing.Point(429, 264);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(64, 27);
            this.lblCpu.TabIndex = 6;
            this.lblCpu.Text = "CPU";
            // 
            // picPaper
            // 
            this.picPaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPaper.BackgroundImage")));
            this.picPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPaper.Location = new System.Drawing.Point(361, 294);
            this.picPaper.Name = "picPaper";
            this.picPaper.Size = new System.Drawing.Size(202, 158);
            this.picPaper.TabIndex = 7;
            this.picPaper.TabStop = false;
            // 
            // picBlocker
            // 
            this.picBlocker.Location = new System.Drawing.Point(361, 294);
            this.picBlocker.Name = "picBlocker";
            this.picBlocker.Size = new System.Drawing.Size(202, 158);
            this.picBlocker.TabIndex = 8;
            this.picBlocker.TabStop = false;
            // 
            // picScissors
            // 
            this.picScissors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picScissors.BackgroundImage")));
            this.picScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picScissors.Location = new System.Drawing.Point(361, 294);
            this.picScissors.Name = "picScissors";
            this.picScissors.Size = new System.Drawing.Size(202, 158);
            this.picScissors.TabIndex = 9;
            this.picScissors.TabStop = false;
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.ForeColor = System.Drawing.Color.Gold;
            this.lblWins.Location = new System.Drawing.Point(116, 311);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(0, 19);
            this.lblWins.TabIndex = 10;
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLosses.ForeColor = System.Drawing.Color.Crimson;
            this.lblLosses.Location = new System.Drawing.Point(754, 311);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(0, 19);
            this.lblLosses.TabIndex = 11;
            // 
            // rockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(933, 514);
            this.Controls.Add(this.lblLosses);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.picBlocker);
            this.Controls.Add(this.picScissors);
            this.Controls.Add(this.picPaper);
            this.Controls.Add(this.lblCpu);
            this.Controls.Add(this.picRock);
            this.Controls.Add(this.lblIntsructions);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnRock);
            this.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "rockPaperScissors";
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlocker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Label lblIntsructions;
        private System.Windows.Forms.PictureBox picRock;
        private System.Windows.Forms.Label lblCpu;
        private System.Windows.Forms.PictureBox picPaper;
        private System.Windows.Forms.PictureBox picBlocker;
        private System.Windows.Forms.PictureBox picScissors;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLosses;
    }
}

