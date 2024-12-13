namespace pubs.packages.vistas
{
    partial class Editores
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
            button2 = new Button();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 326);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(224, 224, 224);
            button2.Location = new Point(21, 57);
            button2.Name = "button2";
            button2.Size = new Size(102, 43);
            button2.TabIndex = 39;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.Location = new Point(159, 56);
            button1.Name = "button1";
            button1.Size = new Size(76, 44);
            button1.TabIndex = 38;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(83, 200);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 35;
            label7.Text = "Pais";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(32, 157);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 34;
            label6.Text = "ciudad_editor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(32, 106);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 30;
            label2.Text = "nombre_editor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(61, 62);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 29;
            label1.Text = "id_editor";
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Menu;
            textBox7.Location = new Point(117, 197);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 26;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Menu;
            textBox6.Location = new Point(117, 149);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 25;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.Location = new Point(117, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Location = new Point(117, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(278, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(308, 145);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(278, 145);
            panel3.Name = "panel3";
            panel3.Size = new Size(308, 181);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = pubs.Properties.Resources.editores;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Editores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 326);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Editores";
            Text = "Editores";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label label7;
        private Label label6;
        private Label label2;
        private Label label1;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox2;
        private TextBox textBox1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
    }
}