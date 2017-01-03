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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StartLabelsButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MapBox = new System.Windows.Forms.PictureBox();
            this.DatesGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.MapBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartLabelsButton
            // 
            this.StartLabelsButton.Location = new System.Drawing.Point(12, 464);
            this.StartLabelsButton.Name = "StartLabelsButton";
            this.StartLabelsButton.Size = new System.Drawing.Size(126, 47);
            this.StartLabelsButton.TabIndex = 1;
            this.StartLabelsButton.Text = "Показати  хід зародження фашизму в Європі.";
            this.StartLabelsButton.UseVisualStyleBackColor = true;
            this.StartLabelsButton.Click += new System.EventHandler(this.StartLabelsButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // DatesGroupBox
            // 
            this.DatesGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DatesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.DatesGroupBox.Name = "DatesGroupBox";
            this.DatesGroupBox.Size = new System.Drawing.Size(211, 257);
            this.DatesGroupBox.TabIndex = 2;
            this.DatesGroupBox.TabStop = false;
            this.DatesGroupBox.Text = "Важливі дати";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.DatesGroupBox);
            this.Controls.Add(this.StartLabelsButton);
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
        private System.Windows.Forms.Button StartLabelsButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox DatesGroupBox;
    }
}

