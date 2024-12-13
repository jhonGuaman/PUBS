namespace pubs.packages.vistas
{
    partial class TituloAutor
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
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 146);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(285, 80);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 47;
            label7.Text = "regalias";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(253, 56);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 46;
            label6.Text = "orden_Autores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 80);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 45;
            label2.Text = "id_Titulo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 51);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 44;
            label1.Text = "id_autor";
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.InactiveCaption;
            textBox7.Location = new Point(338, 77);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 43;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.InactiveCaption;
            textBox6.Location = new Point(338, 48);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 42;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Location = new Point(90, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 41;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(90, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 40;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(482, 97);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Location = new Point(222, 43);
            button2.Name = "button2";
            button2.Size = new Size(132, 31);
            button2.TabIndex = 51;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Location = new Point(99, 43);
            button1.Name = "button1";
            button1.Size = new Size(98, 32);
            button1.TabIndex = 50;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // TituloAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 242);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TituloAutor";
            Text = "TituloAutor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label2;
        private Label label1;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox2;
        private TextBox textBox1;
        private Panel panel2;
        private Button button2;
        private Button button1;
    }
}