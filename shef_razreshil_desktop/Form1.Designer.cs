namespace shef_razreshil_desktop
{
    partial class shef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shef));
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shefBoxTrue = new System.Windows.Forms.PictureBox();
            this.shefBoxFalse = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shefBoxTrue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shefBoxFalse)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            resources.ApplyResources(this.result, "result");
            this.result.ForeColor = System.Drawing.Color.White;
            this.result.Name = "result";
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::shef_razreshil_desktop.Properties.Resources._0OtrbkZIyG0;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // shefBoxTrue
            // 
            resources.ApplyResources(this.shefBoxTrue, "shefBoxTrue");
            this.shefBoxTrue.Image = global::shef_razreshil_desktop.Properties.Resources.lzrd_shef_разрешил;
            this.shefBoxTrue.Name = "shefBoxTrue";
            this.shefBoxTrue.TabStop = false;
            // 
            // shefBoxFalse
            // 
            resources.ApplyResources(this.shefBoxFalse, "shefBoxFalse");
            this.shefBoxFalse.Image = global::shef_razreshil_desktop.Properties.Resources.lzrd_shef_запретил;
            this.shefBoxFalse.Name = "shefBoxFalse";
            this.shefBoxFalse.TabStop = false;
            // 
            // shef
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Controls.Add(this.shefBoxFalse);
            this.Controls.Add(this.shefBoxTrue);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "shef";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shefBoxTrue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shefBoxFalse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label result;
        private PictureBox pictureBox1;
        private PictureBox shefBoxTrue;
        private PictureBox shefBoxFalse;
    }
}