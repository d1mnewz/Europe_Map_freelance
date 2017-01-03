namespace Europe_Map
{
    partial class MapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapForm));
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.ButtonLabelsBox = new System.Windows.Forms.GroupBox();
            this.ShowLabelsButton = new System.Windows.Forms.Button();
            this.MapPBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GroupBox.SuspendLayout();
            this.ButtonLabelsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.ButtonLabelsBox);
            this.GroupBox.Controls.Add(this.MapPBox);
            this.GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox.Location = new System.Drawing.Point(0, 0);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(970, 533);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            // 
            // ButtonLabelsBox
            // 
            this.ButtonLabelsBox.Controls.Add(this.ShowLabelsButton);
            this.ButtonLabelsBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonLabelsBox.Location = new System.Drawing.Point(3, 16);
            this.ButtonLabelsBox.Name = "ButtonLabelsBox";
            this.ButtonLabelsBox.Size = new System.Drawing.Size(216, 514);
            this.ButtonLabelsBox.TabIndex = 1;
            this.ButtonLabelsBox.TabStop = false;
            this.ButtonLabelsBox.Enter += new System.EventHandler(this.ButtonLabelsBox_Enter);
            // 
            // ShowLabelsButton
            // 
            this.ShowLabelsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ShowLabelsButton.Location = new System.Drawing.Point(3, 463);
            this.ShowLabelsButton.Name = "ShowLabelsButton";
            this.ShowLabelsButton.Size = new System.Drawing.Size(210, 48);
            this.ShowLabelsButton.TabIndex = 0;
            this.ShowLabelsButton.Text = "Показати хід зародження фашизму в Європі";
            this.ShowLabelsButton.UseVisualStyleBackColor = true;
            this.ShowLabelsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MapPBox
            // 
            this.MapPBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MapPBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.MapPBox.Image = ((System.Drawing.Image)(resources.GetObject("MapPBox.Image")));
            this.MapPBox.Location = new System.Drawing.Point(225, 16);
            this.MapPBox.Name = "MapPBox";
            this.MapPBox.Size = new System.Drawing.Size(742, 514);
            this.MapPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MapPBox.TabIndex = 0;
            this.MapPBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 533);
            this.Controls.Add(this.GroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MapForm";
            this.Text = "Зародження фашизму в Європі";
            this.GroupBox.ResumeLayout(false);
            this.ButtonLabelsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MapPBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.PictureBox MapPBox;
        private System.Windows.Forms.GroupBox ButtonLabelsBox;
        private System.Windows.Forms.Button ShowLabelsButton;
        private System.Windows.Forms.Timer timer1;
    }
}

