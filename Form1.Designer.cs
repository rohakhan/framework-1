namespace FrameWork1
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.enemie2 = new System.Windows.Forms.PictureBox();
            this.Jet = new System.Windows.Forms.PictureBox();
            this.enemie1 = new System.Windows.Forms.PictureBox();
            this.enemie3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemie3)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimer);
            // 
            // enemie2
            // 
            this.enemie2.Image = global::FrameWork1.Properties.Resources.c_users_aali_desktop_skyfighter_skyfighter_resour_11;
            this.enemie2.Location = new System.Drawing.Point(590, 36);
            this.enemie2.Name = "enemie2";
            this.enemie2.Size = new System.Drawing.Size(100, 85);
            this.enemie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemie2.TabIndex = 5;
            this.enemie2.TabStop = false;
            // 
            // Jet
            // 
            this.Jet.Image = global::FrameWork1.Properties.Resources.Jet1;
            this.Jet.Location = new System.Drawing.Point(222, 23);
            this.Jet.Name = "Jet";
            this.Jet.Size = new System.Drawing.Size(110, 98);
            this.Jet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Jet.TabIndex = 3;
            this.Jet.TabStop = false;
            this.Jet.Click += new System.EventHandler(this.Jet_Click);
            // 
            // enemie1
            // 
            this.enemie1.Image = global::FrameWork1.Properties.Resources.c_users_aali_desktop_skyfighter_skyfighter_resour_1;
            this.enemie1.Location = new System.Drawing.Point(445, 21);
            this.enemie1.Name = "enemie1";
            this.enemie1.Size = new System.Drawing.Size(100, 85);
            this.enemie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemie1.TabIndex = 2;
            this.enemie1.TabStop = false;
            this.enemie1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // enemie3
            // 
            this.enemie3.Image = global::FrameWork1.Properties.Resources.c_users_aali_desktop_skyfighter_skyfighter_resour_1;
            this.enemie3.Location = new System.Drawing.Point(34, 12);
            this.enemie3.Name = "enemie3";
            this.enemie3.Size = new System.Drawing.Size(100, 85);
            this.enemie3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemie3.TabIndex = 6;
            this.enemie3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(761, 497);
            this.Controls.Add(this.enemie3);
            this.Controls.Add(this.enemie2);
            this.Controls.Add(this.Jet);
            this.Controls.Add(this.enemie1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enemie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemie3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox enemie1;
        private System.Windows.Forms.PictureBox Jet;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox enemie2;
        private System.Windows.Forms.PictureBox enemie3;
    }
}

