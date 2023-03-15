namespace StarWar
{
    partial class Form1
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
            this.gameBox = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameBox
            // 
            this.gameBox.BackColor = System.Drawing.SystemColors.Control;
            this.gameBox.Location = new System.Drawing.Point(12, 12);
            this.gameBox.Name = "gameBox";
            this.gameBox.Size = new System.Drawing.Size(552, 510);
            this.gameBox.TabIndex = 0;
            this.gameBox.TabStop = false;
            this.gameBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameBox_MouseClick);
            this.gameBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GameBox_MouseDoubleClick);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(570, 52);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(151, 32);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(570, 14);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(151, 32);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 522);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.gameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gameBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gameBox;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnStart;
    }
}

