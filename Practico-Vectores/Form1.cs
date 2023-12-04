using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace Practico_Vectores
{
    public partial class Form1 : Form
    {
        //------------------------------
        Vector v1, v2, v3;
        NEnt n1;

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v2.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void cargarEleXEleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1 = new Vector();
            int n1, i;
            n1 = int.Parse(Interaction.InputBox("Dim:"));
            for (i = 1; i <= n1; i++)
            {
                v1.Cargar(int.Parse(Interaction.InputBox("Elemento " + i + ":")));
            }
        }

        private void cargarEleXEleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v2 = new Vector();
            int n2, i;
            n2 = int.Parse(Interaction.InputBox("Dim:"));
            for (i = 1; i <= n2; i++)
            {
                v2.Cargar(int.Parse(Interaction.InputBox("Elemento " + i + ":")));
            }
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = v1.Descargar();
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox5.Text = v2.Descargar();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.Fibo(int.Parse(textBox1.Text));
            textBox4.Text = v1.Descargar();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.PosSubM());
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.PosMultM(int.Parse(textBox1.Text)));
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.MediaPosMult(int.Parse(textBox1.Text)));
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v2 = new Vector();
            v3 = new Vector();
            v1.SelecPyNP(v2, v3);
            v2.OrdXInter();
            textBox5.Text = v2.Descargar();
            label1.Text = "Primos";
            v3.OrdXInter();
            textBox6.Text = v3.Descargar();
            label2.Text = "No primos";
        }

        private void ejercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.InvertirV();
            textBox5.Text = v1.Descargar();
        }

        private void ejercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.TodosIguales());
        }

        private void ejercicio8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v3 = new Vector();
            v1.Intersec(v2, v3);
            textBox6.Text = v3.Descargar();
        }

        private void ejercicio9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v3 = new Vector();
            v1.UnionEle(v2, v3);
            textBox6.Text = v3.Descargar();
        }

        private void ejercicio10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            if ((int.Parse(textBox1.Text) >= 1) && (int.Parse(textBox1.Text) <= v1.RangoMax()) && (int.Parse(textBox2.Text) >= 1) && (int.Parse(textBox2.Text) <= v1.RangoMax()) && (int.Parse(textBox1.Text) <= int.Parse(textBox2.Text)))
            {
                textBox5.Text = string.Concat(v1.EstaOrdenado(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
            }
            else
            {
                textBox6.Text = v1.FueraDeRango();
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            label1.Text = "";
            label2.Text = "";
        }

        private void ejercicio1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            if ((int.Parse(textBox1.Text) >= 1) && (int.Parse(textBox1.Text) <= v1.RangoMax()))
            {
                v1.InserVPos(v2, int.Parse(textBox1.Text));
                textBox6.Text = v1.Descargar();
            }
            else
            {
                textBox6.Text = v1.FueraDeRango();
            }
        }

        private void ejercicio2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            if ((int.Parse(textBox1.Text) >= 1) && (int.Parse(textBox1.Text) <= v1.RangoMax()) && (int.Parse(textBox2.Text) >= 1) && (int.Parse(textBox2.Text) <= v1.RangoMax()) && (int.Parse(textBox1.Text) <= int.Parse(textBox2.Text)))
            {
                v1.ElimElePos(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                textBox5.Text = v1.Descargar();
            }
            else
            {
                textBox6.Text = v1.FueraDeRango();
            }
        }

        private void ejercicio3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v1.DuplicarEle();
            textBox5.Text = v1.Descargar();
        }

        private void ejercicio4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            if ((int.Parse(textBox1.Text) >= 1) && (int.Parse(textBox1.Text) <= v1.RangoMax()) && (int.Parse(textBox2.Text) >= 1) && (int.Parse(textBox2.Text) <= v1.RangoMax()) && (int.Parse(textBox1.Text) <= int.Parse(textBox2.Text)))
            {
                v1.OrdBurbuja(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                textBox5.Text = v1.Descargar();
            }
            else
            {
                textBox6.Text = v1.FueraDeRango();
            }                
        }

        private void ejercicio6ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            if (v1.EstaOrdenado(int.Parse(textBox1.Text), int.Parse(textBox2.Text)))
            {
                label3.Text = "";
                if ((int.Parse(textBox1.Text) >= 1) && (int.Parse(textBox1.Text) <= v1.RangoMax()) && (int.Parse(textBox2.Text) >= 1) && (int.Parse(textBox2.Text) <= v1.RangoMax()) && (int.Parse(textBox1.Text) <= int.Parse(textBox2.Text)))
                {
                    v1.FrecDistAB(v2, v3, int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                    textBox4.Text = v1.Descargar();
                    textBox5.Text = v2.Descargar();
                    textBox6.Text = v3.Descargar();
                }
                else
                {                    
                    label3.Text = v1.FueraDeRango();
                }
            }
            else
            {
                label3.Text = v1.Ordenar();
            }
        }

        private void ejercicio8ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
        //    if ((int.Parse(textBox1.Text) >= 1) && (int.Parse(textBox1.Text) <= v1.RangoMax()) && (int.Parse(textBox2.Text) >= 1) && (int.Parse(textBox2.Text) <= v1.RangoMax()) && (int.Parse(textBox1.Text) <= int.Parse(textBox2.Text)))
            //{
                v1.IntercalarPyNPord(int.Parse(textBox2.Text), int.Parse(textBox3.Text));
                textBox5.Text = v1.Descargar();
           // }
            //else
            //{
            //    textBox6.Text = v1.FueraDeRango();
            //}    
        }

        private void ejercicio7ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v1.segCyNC();
            textBox5.Text = v1.Descargar();
        }

        private void ordXInterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.OrdXInter();
            textBox4.Text = v1.Descargar();
        }

        private void ejercicio5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            if ((int.Parse(textBox1.Text) >= 1) && (int.Parse(textBox1.Text) <= v1.RangoMax()) && (int.Parse(textBox2.Text) >= 1) && (int.Parse(textBox2.Text) <= v1.RangoMax()) && (int.Parse(textBox1.Text) <= int.Parse(textBox2.Text)))
            {
                textBox5.Text = string.Concat(v1.EleMenosRep(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
            }
            else
            {
                textBox6.Text = v1.FueraDeRango();
            }
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox6.Text = v3.Descargar();
        }

        private void intercalarParImparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.IntercalarParyNoParord(int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox5.Text = v1.Descargar();
        }

        private void intercalarFiboNoFiboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.IntercalarfiboNOfibo(int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox5.Text = v1.Descargar();
        }

        private void segmentarParNoParToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.segmentarParyNoParord(int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox5.Text = v1.Descargar();
        }

        private void segmentarFiboNoFiboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.segmentarfiboNofibo(int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox5.Text = v1.Descargar();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            v1 = new Vector();
            v2 = new Vector();
            v3 = new Vector();
            n1 = new NEnt();
        }
    }
}
