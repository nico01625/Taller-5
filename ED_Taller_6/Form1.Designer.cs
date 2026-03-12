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

            button1.Text = "Add";
            button1.Location = new Point(249, 301);
            button1.Click += button1_Click;

            label1.Location = new Point(249, 265);
            label1.AutoSize = true;

            stackA.Location = new Point(29, 34);
            stackA.Size = new Size(145, 104);

            stackB.Location = new Point(230, 34);
            stackB.Size = new Size(145, 104);

            stackC.Location = new Point(438, 34);
            stackC.Size = new Size(145, 104);

            Limpiar.Text = "Clear";
            Limpiar.Location = new Point(506, 265);
            Limpiar.Click += Limpiar_Click;

            textBox1.Location = new Point(230, 238);
            textBox1.Width = 121;

            quitar.Text = "Pop";
            quitar.Location = new Point(29, 265);
            quitar.Click += Pop;

            txtA.Location = new Point(71, 12);
            txtA.AutoSize = true;

            txtB.Location = new Point(277, 12);
            txtB.AutoSize = true;

            txtC.Location = new Point(482, 12);
            txtC.AutoSize = true;

            selectA.Text = "Select";
            selectA.Location = new Point(50, 142);
            selectA.Click += selectA_Click;

            selectB.Text = "Select";
            selectB.Location = new Point(260, 142);
            selectB.Click += selectB_Click;

            selectC.Text = "Select";
            selectC.Location = new Point(461, 142);
            selectC.Click += selectC_Click;

            ClientSize = new Size(635, 338);
            Controls.AddRange(new Control[] {
                button1,label1,stackA,stackB,stackC,
                Limpiar,textBox1,quitar,
                txtA,txtB,txtC,
                selectA,selectB,selectC
            });

            Text = "Lista Doblemente Enlazada";
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