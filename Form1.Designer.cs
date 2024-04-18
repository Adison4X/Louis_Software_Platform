
namespace Louis_AI
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Min_window_btn = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.icon_img = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_img)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gold;
            this.flowLayoutPanel1.BackgroundImage = global::Louis_AI.Properties.Resources.gold;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 119);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(276, 992);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.BackgroundImage = global::Louis_AI.Properties.Resources.gold;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Min_window_btn);
            this.panel3.Controls.Add(this.close_btn);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.icon_img);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1920, 119);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Min_window_btn
            // 
            this.Min_window_btn.AutoSize = true;
            this.Min_window_btn.BackColor = System.Drawing.Color.Transparent;
            this.Min_window_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Min_window_btn.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min_window_btn.ForeColor = System.Drawing.Color.Black;
            this.Min_window_btn.Location = new System.Drawing.Point(1724, 53);
            this.Min_window_btn.Name = "Min_window_btn";
            this.Min_window_btn.Size = new System.Drawing.Size(75, 43);
            this.Min_window_btn.TabIndex = 8;
            this.Min_window_btn.Text = "____";
            this.Min_window_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Min_window_btn.Click += new System.EventHandler(this.Min_window_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.ImageLocation = "D:\\C sharp sample\\Louis_AI\\imgs\\icons8-close.png";
            this.close_btn.Location = new System.Drawing.Point(1826, 34);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(63, 62);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_btn.TabIndex = 6;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(276, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(782, 74);
            this.label1.TabIndex = 5;
            this.label1.Text = "Louis Software Platform";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // icon_img
            // 
            this.icon_img.BackColor = System.Drawing.Color.Transparent;
            this.icon_img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_img.ImageLocation = "D:\\C sharp sample\\Louis_AI\\imgs\\Louis_ai-removebg.png";
            this.icon_img.Location = new System.Drawing.Point(63, -15);
            this.icon_img.Name = "icon_img";
            this.icon_img.Size = new System.Drawing.Size(151, 146);
            this.icon_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_img.TabIndex = 3;
            this.icon_img.TabStop = false;
            this.icon_img.Click += new System.EventHandler(this.icon_img_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1920, 1111);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Louis AI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox icon_img;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.Label minimize_window;
        private System.Windows.Forms.Label Min_window_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

