
namespace braingame
{
    partial class Form1
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
            this.btn_ss = new System.Windows.Forms.Button();
            this.ptb_Color = new System.Windows.Forms.PictureBox();
            this.rdB_level2 = new System.Windows.Forms.RadioButton();
            this.rdB_level1 = new System.Windows.Forms.RadioButton();
            this.pnl_Ptb = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Color)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ss
            // 
            this.btn_ss.Location = new System.Drawing.Point(1273, 12);
            this.btn_ss.Name = "btn_ss";
            this.btn_ss.Size = new System.Drawing.Size(112, 34);
            this.btn_ss.TabIndex = 0;
            this.btn_ss.Text = "Sẵn sàng";
            this.btn_ss.UseVisualStyleBackColor = true;
            this.btn_ss.Click += new System.EventHandler(this.btn_ss_Click);
            // 
            // ptb_Color
            // 
            this.ptb_Color.BackColor = System.Drawing.Color.White;
            this.ptb_Color.Location = new System.Drawing.Point(1273, 161);
            this.ptb_Color.Name = "ptb_Color";
            this.ptb_Color.Size = new System.Drawing.Size(70, 70);
            this.ptb_Color.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Color.TabIndex = 1;
            this.ptb_Color.TabStop = false;
            // 
            // rdB_level2
            // 
            this.rdB_level2.AutoSize = true;
            this.rdB_level2.Location = new System.Drawing.Point(1273, 91);
            this.rdB_level2.Name = "rdB_level2";
            this.rdB_level2.Size = new System.Drawing.Size(87, 29);
            this.rdB_level2.TabIndex = 2;
            this.rdB_level2.Text = "level 2";
            this.rdB_level2.UseVisualStyleBackColor = true;
            this.rdB_level2.CheckedChanged += new System.EventHandler(this.rdB_level2_CheckedChanged);
            // 
            // rdB_level1
            // 
            this.rdB_level1.AutoSize = true;
            this.rdB_level1.Location = new System.Drawing.Point(1273, 56);
            this.rdB_level1.Name = "rdB_level1";
            this.rdB_level1.Size = new System.Drawing.Size(87, 29);
            this.rdB_level1.TabIndex = 2;
            this.rdB_level1.Text = "level 1";
            this.rdB_level1.UseVisualStyleBackColor = true;
            this.rdB_level1.CheckedChanged += new System.EventHandler(this.rdB_level1_CheckedChanged);
            // 
            // pnl_Ptb
            // 
            this.pnl_Ptb.Location = new System.Drawing.Point(0, 1);
            this.pnl_Ptb.Name = "pnl_Ptb";
            this.pnl_Ptb.Size = new System.Drawing.Size(1267, 755);
            this.pnl_Ptb.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1278, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 124);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn phải ghi nhớ màu\r\ncủa các ô và chọn ô có\r\nmàu giống với yêu cầu\r\nbạn đc chọn " +
    "sai 4 lần";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1273, 121);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(150, 34);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1477, 756);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Ptb);
            this.Controls.Add(this.rdB_level1);
            this.Controls.Add(this.rdB_level2);
            this.Controls.Add(this.ptb_Color);
            this.Controls.Add(this.btn_ss);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Color)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ss;
        private System.Windows.Forms.PictureBox ptb_Color;
        private System.Windows.Forms.RadioButton rdB_level2;
        private System.Windows.Forms.RadioButton rdB_level1;
        private System.Windows.Forms.Panel pnl_Ptb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

