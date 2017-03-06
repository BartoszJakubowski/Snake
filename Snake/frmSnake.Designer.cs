namespace Snake
{
    partial class frmSnake
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbMalen = new System.Windows.Forms.PictureBox();
            this.timTick = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StripStarten = new System.Windows.Forms.ToolStripMenuItem();
            this.stoppenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripGitter_einzeichnen = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbMalen)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbMalen
            // 
            this.pbMalen.Location = new System.Drawing.Point(0, 27);
            this.pbMalen.Name = "pbMalen";
            this.pbMalen.Size = new System.Drawing.Size(500, 500);
            this.pbMalen.TabIndex = 4;
            this.pbMalen.TabStop = false;
            // 
            // timTick
            // 
            this.timTick.Interval = 70;
            this.timTick.Tick += new System.EventHandler(this.timTick_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripStarten,
            this.stoppenToolStripMenuItem,
            this.StripGitter_einzeichnen,
            this.scoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // StripStarten
            // 
            this.StripStarten.Name = "StripStarten";
            this.StripStarten.Size = new System.Drawing.Size(56, 20);
            this.StripStarten.Text = "Starten";
            this.StripStarten.Click += new System.EventHandler(this.StripStarten_Click);
            // 
            // stoppenToolStripMenuItem
            // 
            this.stoppenToolStripMenuItem.Name = "stoppenToolStripMenuItem";
            this.stoppenToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.stoppenToolStripMenuItem.Text = "Stoppen";
            this.stoppenToolStripMenuItem.Click += new System.EventHandler(this.stoppenToolStripMenuItem_Click);
            // 
            // StripGitter_einzeichnen
            // 
            this.StripGitter_einzeichnen.Name = "StripGitter_einzeichnen";
            this.StripGitter_einzeichnen.Size = new System.Drawing.Size(114, 20);
            this.StripGitter_einzeichnen.Text = "Gitter einzeichnen";
            this.StripGitter_einzeichnen.Click += new System.EventHandler(this.StripGitter_einzeichnen_Click);
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.Enabled = false;
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.scoreToolStripMenuItem.Text = "Score";
            // 
            // frmSnake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 528);
            this.Controls.Add(this.pbMalen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(516, 567);
            this.MinimumSize = new System.Drawing.Size(516, 567);
            this.Name = "frmSnake";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSnake_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbMalen)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbMalen;
        private System.Windows.Forms.Timer timTick;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StripStarten;
        private System.Windows.Forms.ToolStripMenuItem StripGitter_einzeichnen;
        private System.Windows.Forms.ToolStripMenuItem stoppenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
    }
}

