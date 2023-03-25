namespace WinForms_GameCore
{
    partial class MainWindow
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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)MainDisplay).BeginInit();
            SuspendLayout();
            // 
            // MainDisplay
            // 
            MainDisplay.BackColor = Color.FromArgb(20, 20, 20);
            MainDisplay.BorderStyle = BorderStyle.Fixed3D;
            MainDisplay.ErrorImage = null;
            MainDisplay.Location = new Point(155, 11);
            MainDisplay.WaitOnLoad = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 11);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 640);
            Controls.Add(button1);
            Name = "MainWindow";
            Text = "MainWindow";
            Resize += MainWindow_Resize;
            Controls.SetChildIndex(MainDisplay, 0);
            Controls.SetChildIndex(button1, 0);
            ((System.ComponentModel.ISupportInitialize)MainDisplay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}