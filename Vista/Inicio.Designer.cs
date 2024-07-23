namespace Vista
{
    partial class Inicio
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
            menuStrip1 = new MenuStrip();
            menuMM1 = new ToolStripMenuItem();
            menuMM1N = new ToolStripMenuItem();
            menuMM2 = new ToolStripMenuItem();
            menuMG1_MD1 = new ToolStripMenuItem();
            menuMMP = new ToolStripMenuItem();
            panelContenedor = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(64, 64, 64);
            menuStrip1.BackgroundImageLayout = ImageLayout.None;
            menuStrip1.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuMM1, menuMM1N, menuMM2, menuMG1_MD1, menuMMP });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(949, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip3";
            // 
            // menuMM1
            // 
            menuMM1.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuMM1.ForeColor = SystemColors.ControlLightLight;
            menuMM1.Name = "menuMM1";
            menuMM1.Size = new Size(67, 29);
            menuMM1.Text = "M/M/1";
            menuMM1.Click += mM1ToolStripMenuItem_Click;
            // 
            // menuMM1N
            // 
            menuMM1N.Font = new Font("Bahnschrift Condensed", 15.75F);
            menuMM1N.ForeColor = SystemColors.ControlLightLight;
            menuMM1N.Name = "menuMM1N";
            menuMM1N.Size = new Size(82, 29);
            menuMM1N.Text = "M/M/1/N";
            menuMM1N.Click += mM2ToolStripMenuItem_Click;
            // 
            // menuMM2
            // 
            menuMM2.Font = new Font("Bahnschrift Condensed", 15.75F);
            menuMM2.ForeColor = SystemColors.ControlLightLight;
            menuMM2.Name = "menuMM2";
            menuMM2.Size = new Size(68, 29);
            menuMM2.Text = "M/M/2";
            menuMM2.Click += mM2ToolStripMenuItem1_Click;
            // 
            // menuMG1_MD1
            // 
            menuMG1_MD1.Font = new Font("Bahnschrift Condensed", 15.75F);
            menuMG1_MD1.ForeColor = SystemColors.ControlLightLight;
            menuMG1_MD1.Name = "menuMG1_MD1";
            menuMG1_MD1.Size = new Size(121, 29);
            menuMG1_MD1.Text = "M/G/1 - M/D/1";
            menuMG1_MD1.Click += mG1MD1ToolStripMenuItem_Click;
            // 
            // menuMMP
            // 
            menuMMP.Font = new Font("Bahnschrift Condensed", 15.75F);
            menuMMP.ForeColor = SystemColors.ControlLightLight;
            menuMMP.Name = "menuMMP";
            menuMMP.Size = new Size(69, 29);
            menuMMP.Text = "M/M/P";
            menuMMP.Click += menuMMP_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.ControlLightLight;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 33);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(949, 524);
            panelContenedor.TabIndex = 5;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(949, 557);
            Controls.Add(panelContenedor);
            Controls.Add(menuStrip1);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Inicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuMM1;
        private ToolStripMenuItem menuMM1N;
        private ToolStripMenuItem menuMM2;
        private ToolStripMenuItem menuMG1_MD1;
        private ToolStripMenuItem menuMMP;
        private Panel panelContenedor;
    }
}