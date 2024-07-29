namespace Vista.Formularios
{
    partial class frmMMP
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
            labelResultados = new Label();
            panelMM1 = new Panel();
            labelSigmaIngresar = new Label();
            textBoxTs1 = new TextBox();
            labelMu = new Label();
            textBoxQ1 = new TextBox();
            buttonCalcular = new Button();
            label2 = new Label();
            labelLambda = new Label();
            textBoxW0 = new TextBox();
            labelWq1 = new Label();
            panelResultados = new Panel();
            groupBox4 = new GroupBox();
            labelWq1Descripcion = new Label();
            labelWq1Valor = new Label();
            groupBox7 = new GroupBox();
            labelWs1Descripcion = new Label();
            labelWs1Valor = new Label();
            labelWs1 = new Label();
            panelMM1.SuspendLayout();
            panelResultados.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // labelResultados
            // 
            labelResultados.AutoSize = true;
            labelResultados.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResultados.Location = new Point(79, 13);
            labelResultados.Name = "labelResultados";
            labelResultados.Size = new Size(162, 32);
            labelResultados.TabIndex = 0;
            labelResultados.Text = "Resultados";
            // 
            // panelMM1
            // 
            panelMM1.BackColor = SystemColors.ControlLightLight;
            panelMM1.BorderStyle = BorderStyle.FixedSingle;
            panelMM1.Controls.Add(labelSigmaIngresar);
            panelMM1.Controls.Add(textBoxTs1);
            panelMM1.Controls.Add(labelMu);
            panelMM1.Controls.Add(textBoxQ1);
            panelMM1.Controls.Add(buttonCalcular);
            panelMM1.Controls.Add(label2);
            panelMM1.Controls.Add(labelLambda);
            panelMM1.Controls.Add(textBoxW0);
            panelMM1.Location = new Point(12, 12);
            panelMM1.Name = "panelMM1";
            panelMM1.Size = new Size(258, 280);
            panelMM1.TabIndex = 11;
            // 
            // labelSigmaIngresar
            // 
            labelSigmaIngresar.AutoSize = true;
            labelSigmaIngresar.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSigmaIngresar.Location = new Point(3, 174);
            labelSigmaIngresar.Name = "labelSigmaIngresar";
            labelSigmaIngresar.Size = new Size(46, 22);
            labelSigmaIngresar.TabIndex = 11;
            labelSigmaIngresar.Text = "Ts1:";
            // 
            // textBoxTs1
            // 
            textBoxTs1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTs1.Location = new Point(3, 199);
            textBoxTs1.Name = "textBoxTs1";
            textBoxTs1.Size = new Size(250, 26);
            textBoxTs1.TabIndex = 3;
            textBoxTs1.KeyDown += textBoxTs1_KeyDown;
            // 
            // labelMu
            // 
            labelMu.AutoSize = true;
            labelMu.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMu.Location = new Point(3, 118);
            labelMu.Name = "labelMu";
            labelMu.Size = new Size(41, 22);
            labelMu.TabIndex = 9;
            labelMu.Text = "Q1:";
            // 
            // textBoxQ1
            // 
            textBoxQ1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxQ1.Location = new Point(3, 145);
            textBoxQ1.Name = "textBoxQ1";
            textBoxQ1.Size = new Size(250, 26);
            textBoxQ1.TabIndex = 2;
            textBoxQ1.KeyDown += textBoxQ1_KeyDown;
            // 
            // buttonCalcular
            // 
            buttonCalcular.BackColor = Color.FromArgb(64, 64, 64);
            buttonCalcular.FlatStyle = FlatStyle.Flat;
            buttonCalcular.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCalcular.ForeColor = SystemColors.ControlLightLight;
            buttonCalcular.Location = new Point(69, 231);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(120, 32);
            buttonCalcular.TabIndex = 4;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = false;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(84, 13);
            label2.Name = "label2";
            label2.Size = new Size(90, 32);
            label2.TabIndex = 2;
            label2.Text = "M/M/P";
            // 
            // labelLambda
            // 
            labelLambda.AutoSize = true;
            labelLambda.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLambda.Location = new Point(3, 59);
            labelLambda.Name = "labelLambda";
            labelLambda.Size = new Size(45, 22);
            labelLambda.TabIndex = 1;
            labelLambda.Text = "W0:";
            // 
            // textBoxW0
            // 
            textBoxW0.BorderStyle = BorderStyle.FixedSingle;
            textBoxW0.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxW0.Location = new Point(3, 86);
            textBoxW0.Name = "textBoxW0";
            textBoxW0.Size = new Size(250, 26);
            textBoxW0.TabIndex = 1;
            textBoxW0.KeyDown += textBoxW0_KeyDown;
            // 
            // labelWq1
            // 
            labelWq1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelWq1.AutoSize = true;
            labelWq1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWq1.Location = new Point(64, 11);
            labelWq1.Name = "labelWq1";
            labelWq1.Size = new Size(66, 29);
            labelWq1.TabIndex = 0;
            labelWq1.Text = "Wq1:";
            // 
            // panelResultados
            // 
            panelResultados.BackColor = SystemColors.ControlLightLight;
            panelResultados.BorderStyle = BorderStyle.FixedSingle;
            panelResultados.Controls.Add(groupBox4);
            panelResultados.Controls.Add(groupBox7);
            panelResultados.Controls.Add(labelResultados);
            panelResultados.Location = new Point(276, 12);
            panelResultados.Name = "panelResultados";
            panelResultados.Size = new Size(320, 280);
            panelResultados.TabIndex = 12;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(labelWq1Descripcion);
            groupBox4.Controls.Add(labelWq1Valor);
            groupBox4.Controls.Add(labelWq1);
            groupBox4.Location = new Point(35, 145);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(250, 80);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            // 
            // labelWq1Descripcion
            // 
            labelWq1Descripcion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelWq1Descripcion.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWq1Descripcion.Location = new Point(6, 40);
            labelWq1Descripcion.Name = "labelWq1Descripcion";
            labelWq1Descripcion.Size = new Size(238, 37);
            labelWq1Descripcion.TabIndex = 2;
            labelWq1Descripcion.Text = "Tiempo que pasa el cliente de clase 1 en cola";
            labelWq1Descripcion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelWq1Valor
            // 
            labelWq1Valor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelWq1Valor.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWq1Valor.Location = new Point(126, 19);
            labelWq1Valor.Name = "labelWq1Valor";
            labelWq1Valor.Size = new Size(66, 18);
            labelWq1Valor.TabIndex = 1;
            labelWq1Valor.Text = "0.00000";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(labelWs1Descripcion);
            groupBox7.Controls.Add(labelWs1Valor);
            groupBox7.Controls.Add(labelWs1);
            groupBox7.Location = new Point(35, 59);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(250, 80);
            groupBox7.TabIndex = 8;
            groupBox7.TabStop = false;
            // 
            // labelWs1Descripcion
            // 
            labelWs1Descripcion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelWs1Descripcion.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWs1Descripcion.Location = new Point(6, 40);
            labelWs1Descripcion.Name = "labelWs1Descripcion";
            labelWs1Descripcion.Size = new Size(238, 37);
            labelWs1Descripcion.TabIndex = 2;
            labelWs1Descripcion.Text = "Tiempo que pasa el cliente de clase 1 en el sistema";
            labelWs1Descripcion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelWs1Valor
            // 
            labelWs1Valor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelWs1Valor.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWs1Valor.Location = new Point(123, 19);
            labelWs1Valor.Name = "labelWs1Valor";
            labelWs1Valor.Size = new Size(66, 18);
            labelWs1Valor.TabIndex = 1;
            labelWs1Valor.Text = "0.00000";
            // 
            // labelWs1
            // 
            labelWs1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelWs1.AutoSize = true;
            labelWs1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWs1.Location = new Point(64, 11);
            labelWs1.Name = "labelWs1";
            labelWs1.Size = new Size(63, 29);
            labelWs1.TabIndex = 0;
            labelWs1.Text = "Ws1:";
            // 
            // frmMMP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 304);
            Controls.Add(panelMM1);
            Controls.Add(panelResultados);
            Name = "frmMMP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMMP";
            panelMM1.ResumeLayout(false);
            panelMM1.PerformLayout();
            panelResultados.ResumeLayout(false);
            panelResultados.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelResultados;
        private Panel panelMM1;
        private Label labelSigmaIngresar;
        private TextBox textBoxTs1;
        private Label labelMu;
        private TextBox textBoxQ1;
        private Button buttonCalcular;
        private Label label2;
        private Label labelLambda;
        private TextBox textBoxW0;
        private Label labelWq1;
        private Panel panelResultados;
        private GroupBox groupBox4;
        private Label labelWq1Descripcion;
        private Label labelWq1Valor;
        private GroupBox groupBox7;
        private Label labelWs1Descripcion;
        private Label labelWs1Valor;
        private Label labelWs1;
    }
}