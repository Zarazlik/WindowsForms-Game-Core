namespace PetriaChivilisation
{
    partial class CoreForm
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MaxFpsLable1 = new System.Windows.Forms.Label();
            this.FpsLabel1 = new System.Windows.Forms.Label();
            this.FpsLimiter = new System.Windows.Forms.Timer(this.components);
            this.MinFpsLable1 = new System.Windows.Forms.Label();
            this.FpsCounterTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LogicLabel2 = new System.Windows.Forms.Label();
            this.LogicLabel1 = new System.Windows.Forms.Label();
            this.FpsLabel2 = new System.Windows.Forms.Label();
            this.MinFpsLable2 = new System.Windows.Forms.Label();
            this.MaxFpsLable2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(265, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 720);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MaxFpsLable1
            // 
            this.MaxFpsLable1.AutoSize = true;
            this.MaxFpsLable1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxFpsLable1.Location = new System.Drawing.Point(6, 51);
            this.MaxFpsLable1.Name = "MaxFpsLable1";
            this.MaxFpsLable1.Size = new System.Drawing.Size(42, 23);
            this.MaxFpsLable1.TabIndex = 2;
            this.MaxFpsLable1.Text = "Max";
            // 
            // FpsLabel1
            // 
            this.FpsLabel1.AutoSize = true;
            this.FpsLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FpsLabel1.Location = new System.Drawing.Point(6, 23);
            this.FpsLabel1.Name = "FpsLabel1";
            this.FpsLabel1.Size = new System.Drawing.Size(44, 28);
            this.FpsLabel1.TabIndex = 3;
            this.FpsLabel1.Text = "FPS";
            // 
            // FpsLimiter
            // 
            this.FpsLimiter.Interval = 1;
            this.FpsLimiter.Tick += new System.EventHandler(this.FpsLimiter_Tick);
            // 
            // MinFpsLable1
            // 
            this.MinFpsLable1.AutoSize = true;
            this.MinFpsLable1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinFpsLable1.Location = new System.Drawing.Point(95, 51);
            this.MinFpsLable1.Name = "MinFpsLable1";
            this.MinFpsLable1.Size = new System.Drawing.Size(39, 23);
            this.MinFpsLable1.TabIndex = 4;
            this.MinFpsLable1.Text = "Min";
            // 
            // FpsCounterTimer
            // 
            this.FpsCounterTimer.Interval = 1000;
            this.FpsCounterTimer.Tick += new System.EventHandler(this.FpsCounterTimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LogicLabel2);
            this.groupBox1.Controls.Add(this.LogicLabel1);
            this.groupBox1.Controls.Add(this.FpsLabel2);
            this.groupBox1.Controls.Add(this.MinFpsLable2);
            this.groupBox1.Controls.Add(this.MaxFpsLable2);
            this.groupBox1.Controls.Add(this.FpsLabel1);
            this.groupBox1.Controls.Add(this.MinFpsLable1);
            this.groupBox1.Controls.Add(this.MaxFpsLable1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 111);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FPS control";
            // 
            // LogicLabel2
            // 
            this.LogicLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LogicLabel2.AutoSize = true;
            this.LogicLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogicLabel2.Location = new System.Drawing.Point(99, 85);
            this.LogicLabel2.Name = "LogicLabel2";
            this.LogicLabel2.Size = new System.Drawing.Size(37, 23);
            this.LogicLabel2.TabIndex = 11;
            this.LogicLabel2.Text = "000";
            // 
            // LogicLabel1
            // 
            this.LogicLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LogicLabel1.AutoSize = true;
            this.LogicLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogicLabel1.Location = new System.Drawing.Point(6, 85);
            this.LogicLabel1.Name = "LogicLabel1";
            this.LogicLabel1.Size = new System.Drawing.Size(87, 23);
            this.LogicLabel1.TabIndex = 10;
            this.LogicLabel1.Text = "Logic (ms)";
            // 
            // FpsLabel2
            // 
            this.FpsLabel2.AutoSize = true;
            this.FpsLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FpsLabel2.Location = new System.Drawing.Point(61, 23);
            this.FpsLabel2.Name = "FpsLabel2";
            this.FpsLabel2.Size = new System.Drawing.Size(45, 28);
            this.FpsLabel2.TabIndex = 7;
            this.FpsLabel2.Text = "000";
            // 
            // MinFpsLable2
            // 
            this.MinFpsLable2.AutoSize = true;
            this.MinFpsLable2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinFpsLable2.Location = new System.Drawing.Point(140, 51);
            this.MinFpsLable2.Name = "MinFpsLable2";
            this.MinFpsLable2.Size = new System.Drawing.Size(37, 23);
            this.MinFpsLable2.TabIndex = 6;
            this.MinFpsLable2.Text = "000";
            // 
            // MaxFpsLable2
            // 
            this.MaxFpsLable2.AutoSize = true;
            this.MaxFpsLable2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxFpsLable2.Location = new System.Drawing.Point(52, 51);
            this.MaxFpsLable2.Name = "MaxFpsLable2";
            this.MaxFpsLable2.Size = new System.Drawing.Size(37, 23);
            this.MaxFpsLable2.TabIndex = 5;
            this.MaxFpsLable2.Text = "000";
            // 
            // CoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1455, 1050);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "CoreForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Label MaxFpsLable1;
        private Label FpsLabel1;
        private System.Windows.Forms.Timer FpsLimiter;
        private Label MinFpsLable1;
        private System.Windows.Forms.Timer FpsCounterTimer;
        private GroupBox groupBox1;
        private Label MaxFpsLable2;
        private Label MinFpsLable2;
        private Label FpsLabel2;
        private Label LogicLabel2;
        private Label LogicLabel1;
    }
}