using System;
using System.Collections;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ED_Taller_6
{
    public partial class Form1 : Form
    {
        private int c = 0;
        private ListBox current;

        private ListaDoble<string> listaA = new ListaDoble<string>();
        private ListaDoble<string> listaB = new ListaDoble<string>();
        private ListaDoble<string> listaC = new ListaDoble<string>();

        private ListaDoble<string> listaActual;

        public Form1()
        {
            InitializeComponent();
            ClearLabels();
            label1.Text = string.Empty;
            quitar.Click += Pop;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listaActual == null)
            {
                MessageBox.Show("Seleccione una lista");
                return;
            }

            if (textBox1.Text == "")
            {
                MessageBox.Show("Ingrese un valor");
                return;
            }

            if (listaActual.Count >= 5)
            {
                MessageBox.Show("Máximo 5 elementos");
                return;
            }

            listaActual.AddLast(textBox1.Text);
            c++;
            updateLeibol();
            RefrescarListBox();
        }

        private void Pop(object sender, EventArgs e)
        {
            if (listaActual == null || listaActual.Count == 0) return;

            listaActual.RemoveLast();
            c--;
            updateLeibol();
            RefrescarListBox();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            stackA.Items.Clear();
            stackB.Items.Clear();
            stackC.Items.Clear();

            listaA = new ListaDoble<string>();
            listaB = new ListaDoble<string>();
            listaC = new ListaDoble<string>();
            listaActual = null;

            c = 0;
            updateLeibol();
            ClearLabels();
        }

        private void RefrescarListBox()
        {
            current.Items.Clear();

            foreach (var item in listaActual.ToList())
            {
                current.Items.Add(item);
            }
        }

        private void updateLeibol()
        {
            label1.Text = "Contador: " + c;
        }

        private void ClearLabels()
        {
            txtA.Text = string.Empty;
            txtB.Text = string.Empty;
            txtC.Text = string.Empty;
        }

        private void selectA_Click(object sender, EventArgs e)
        {
            ClearLabels();
            txtA.Text = "selected";
            current = stackA;
            listaActual = listaA;
        }

        private void selectB_Click(object sender, EventArgs e)
        {
            ClearLabels();
            txtB.Text = "selected";
            current = stackB;
            listaActual = listaB;
        }

        private void selectC_Click(object sender, EventArgs e)
        {
            ClearLabels();
            txtC.Text = "selected";
            current = stackC;
            listaActual = listaC;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}