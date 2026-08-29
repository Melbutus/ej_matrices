namespace Ej_clase1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            bt_simular = new Button();
            bt_ordenar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(138, 36);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(246, 229);
            listBox1.TabIndex = 0;
            // 
            // bt_simular
            // 
            bt_simular.Location = new Point(31, 36);
            bt_simular.Name = "bt_simular";
            bt_simular.Size = new Size(75, 23);
            bt_simular.TabIndex = 1;
            bt_simular.Text = "Simular";
            bt_simular.UseVisualStyleBackColor = true;
            bt_simular.Click += bt_simular_Click;
            // 
            // bt_ordenar
            // 
            bt_ordenar.Location = new Point(31, 95);
            bt_ordenar.Name = "bt_ordenar";
            bt_ordenar.Size = new Size(75, 23);
            bt_ordenar.TabIndex = 2;
            bt_ordenar.Text = "Ordenar";
            bt_ordenar.UseVisualStyleBackColor = true;
            bt_ordenar.Click += bt_ordenar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 18);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "Ganados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 18);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 4;
            label2.Text = "Empatados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 18);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Perdidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(340, 18);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 6;
            label4.Text = "Puntos";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 299);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bt_ordenar);
            Controls.Add(bt_simular);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button bt_simular;
        private Button bt_ordenar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
