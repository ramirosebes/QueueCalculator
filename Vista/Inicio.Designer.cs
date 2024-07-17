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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            mM1ToolStripMenuItem = new ToolStripMenuItem();
            mM2ToolStripMenuItem = new ToolStripMenuItem();
            mM2ToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.BackgroundImageLayout = ImageLayout.None;
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mM1ToolStripMenuItem, mM2ToolStripMenuItem, mM2ToolStripMenuItem1 });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(336, 537);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip3";
            // 
            // mM1ToolStripMenuItem
            // 
            mM1ToolStripMenuItem.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mM1ToolStripMenuItem.Name = "mM1ToolStripMenuItem";
            mM1ToolStripMenuItem.Size = new Size(329, 37);
            mM1ToolStripMenuItem.Text = "M/M/1";
            mM1ToolStripMenuItem.Click += mM1ToolStripMenuItem_Click;
            // 
            // mM2ToolStripMenuItem
            // 
            mM2ToolStripMenuItem.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mM2ToolStripMenuItem.Name = "mM2ToolStripMenuItem";
            mM2ToolStripMenuItem.Size = new Size(329, 37);
            mM2ToolStripMenuItem.Text = "M/M/1/N";
            mM2ToolStripMenuItem.Click += mM2ToolStripMenuItem_Click;
            // 
            // mM2ToolStripMenuItem1
            // 
            mM2ToolStripMenuItem1.Name = "mM2ToolStripMenuItem1";
            mM2ToolStripMenuItem1.Size = new Size(329, 37);
            mM2ToolStripMenuItem1.Text = "M/M/2";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(336, 537);
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

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mM1ToolStripMenuItem;
        private ToolStripMenuItem mM2ToolStripMenuItem;
        private ToolStripMenuItem mM2ToolStripMenuItem1;
    }
}