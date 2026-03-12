using static System.Net.Mime.MediaTypeNames;

namespace ED_Taller_6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            stackA = new ListBox();
            Limpiar = new Button();
            textBox1 = new TextBox();
            stackB = new ListBox();
            stackC = new ListBox();
            quitar = new Button();
            txtA = new Label();
            txtB = new Label();
            txtC = new Label();
            selectA = new Button();
            selectB = new Button();
            selectC = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(249, 301);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 265);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 1;
            // 
            // stackA
            // 
            stackA.Location = new Point(29, 34);
            stackA.Name = "stackA";
            stackA.Size = new Size(145, 104);
            stackA.TabIndex = 2;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(506, 265);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(75, 23);
            Limpiar.TabIndex = 5;
            Limpiar.Text = "Clear";
            Limpiar.Click += Limpiar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(230, 238);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 31);
            textBox1.TabIndex = 6;
            // 
            // stackB
            // 
            stackB.Location = new Point(230, 34);
            stackB.Name = "stackB";
            stackB.Size = new Size(145, 104);
            stackB.TabIndex = 3;
            // 
            // stackC
            // 
            stackC.Location = new Point(438, 34);
            stackC.Name = "stackC";
            stackC.Size = new Size(145, 104);
            stackC.TabIndex = 4;
            // 
            // quitar
            // 
            quitar.Location = new Point(29, 265);
            quitar.Name = "quitar";
            quitar.Size = new Size(75, 23);
            quitar.TabIndex = 7;
            quitar.Text = "Pop";
            quitar.Click += Pop;
            // 
            // txtA
            // 
            txtA.AutoSize = true;
            txtA.Location = new Point(71, 12);
            txtA.Name = "txtA";
            txtA.Size = new Size(0, 25);
            txtA.TabIndex = 8;
            // 
            // txtB
            // 
            txtB.AutoSize = true;
            txtB.Location = new Point(277, 12);
            txtB.Name = "txtB";
            txtB.Size = new Size(0, 25);
            txtB.TabIndex = 9;
            // 
            // txtC
            // 
            txtC.AutoSize = true;
            txtC.Location = new Point(482, 12);
            txtC.Name = "txtC";
            txtC.Size = new Size(0, 25);
            txtC.TabIndex = 10;
            // 
            // selectA
            // 
            selectA.Location = new Point(50, 142);
            selectA.Name = "selectA";
            selectA.Size = new Size(92, 32);
            selectA.TabIndex = 11;
            selectA.Text = "Select";
            selectA.Click += selectA_Click;
            // 
            // selectB
            // 
            selectB.Location = new Point(260, 142);
            selectB.Name = "selectB";
            selectB.Size = new Size(91, 32);
            selectB.TabIndex = 12;
            selectB.Text = "Select";
            selectB.Click += selectB_Click;
            // 
            // selectC
            // 
            selectC.Location = new Point(461, 142);
            selectC.Name = "selectC";
            selectC.Size = new Size(89, 32);
            selectC.TabIndex = 13;
            selectC.Text = "Select";
            selectC.Click += selectC_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(679, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(stackA);
            Controls.Add(stackB);
            Controls.Add(stackC);
            Controls.Add(Limpiar);
            Controls.Add(textBox1);
            Controls.Add(quitar);
            Controls.Add(txtA);
            Controls.Add(txtB);
            Controls.Add(txtC);
            Controls.Add(selectA);
            Controls.Add(selectB);
            Controls.Add(selectC);
            Name = "Form1";
            Text = "Lista Doblemente Enlazada";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private Label label1;
        private ListBox stackA;
        private Button Limpiar;
        private TextBox textBox1;
        private ListBox stackB;
        private ListBox stackC;
        private Button quitar;
        private Label txtA;
        private Label txtB;
        private Label txtC;
        private Button selectA;
        private Button selectB;
        private Button selectC;
    }
}