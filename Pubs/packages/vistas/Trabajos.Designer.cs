namespace pubs.packages.vistas
{
    partial class Trabajos
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
            panel1 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            panel3 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 245);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox6);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 245);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(39, 115);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 85;
            label3.Text = "max_nivel";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ScrollBar;
            textBox3.Location = new Point(122, 115);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 84;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(255, 128, 0);
            label7.Location = new Point(39, 86);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 81;
            label7.Text = "min_nivel";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(255, 128, 0);
            label6.Location = new Point(39, 63);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 80;
            label6.Text = "des_trabajo";
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.ScrollBar;
            textBox7.Location = new Point(122, 86);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 77;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.ScrollBar;
            textBox6.Location = new Point(122, 60);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 76;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(250, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(178, 245);
            panel3.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.Location = new Point(41, 118);
            button2.Name = "button2";
            button2.Size = new Size(102, 23);
            button2.TabIndex = 85;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Location = new Point(41, 84);
            button1.Name = "button1";
            button1.Size = new Size(102, 24);
            button1.TabIndex = 84;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // Trabajos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 245);
            Controls.Add(panel1);
            Name = "Trabajos";
            Text = "Trabajos";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private TextBox textBox3;
        private Label label7;
        private Label label6;
        private TextBox textBox7;
        private TextBox textBox6;
        private Panel panel3;
        private Button button2;
        private Button button1;
    }
}