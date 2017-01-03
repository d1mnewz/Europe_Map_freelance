namespace Europe_Map_Task1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MapBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MapBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MapBox
            // 
            this.MapBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapBox.Image = global::Europe_Map_Task1.Properties.Resources.map;
            this.MapBox.Location = new System.Drawing.Point(0, 0);
            this.MapBox.Name = "MapBox";
            this.MapBox.Size = new System.Drawing.Size(884, 511);
            this.MapBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MapBox.TabIndex = 0;
            this.MapBox.TabStop = false;
            this.MapBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MapBox_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.MapBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Зародження фашизму в Європі";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MapBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MapBox;
    }
}

