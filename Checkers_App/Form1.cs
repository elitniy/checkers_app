using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers_App
{
    public partial class Form1 : Form
    {
        int count = 0;
        bool movExtra = false;
        PictureBox selectioado = null;

        List<PictureBox> azules = new List<PictureBox>();
        List<PictureBox> rojas = new List<PictureBox>();



        public Form1()
        {
            InitializeComponent();
            cargalistas();
        }
        private void cargalistas()
        {
            azules.Add(azul1);
            azules.Add(azul2);
            azules.Add(azul3);
            azules.Add(azul4);
            azules.Add(azul5);
            azules.Add(azul6);
            azules.Add(azul7);
            azules.Add(azul8);
            azules.Add(azul9);
            azules.Add(azul10);
            azules.Add(azul11);
            azules.Add(azul12);

            rojas.Add(roja1);
            rojas.Add(roja2);
            rojas.Add(roja3);
            rojas.Add(roja4);
            rojas.Add(roja5);
            rojas.Add(roja6);
            rojas.Add(roja7);
            rojas.Add(roja8);
            rojas.Add(roja9);
            rojas.Add(roja10);
            rojas.Add(roja11);
            rojas.Add(roja12);
        }
        public void selection(object objeto)
        {
            try { selectioado.BackColor = Color.Gray; }
            catch { }
            PictureBox ficha = (PictureBox)objeto;
            selectioado = ficha;
            selectioado.BackColor = Color.Lime;

        }
        private void cuadroClick(object sender, MouseEventArgs e)
        {
            movimento((PictureBox)sender);
        }
        private void movimento(PictureBox cuadro)
        {
            if(selectioado !=null)
            {
                if (true)
                {
                    string color = selectioado.Name.ToString().Substring(0, 4);
                    Point anterior = selectioado.Location;
                    selectioado.Location = cuadro.Location;
                    int avance = anterior.Y - cuadro.Location.Y;
                    if (true)
                    {
                        ifqueen(color);
                        count++;
                        selectioado.BackColor = Color.Gray;
                        selectioado = null;
                        movExtra = false;
                    }
                    else
                    {
                        movExtra = true;
                    }
                }

            }
        }
        private void ifqueen(string color)
        {
            if(color == "azul" && selectioado.Location.Y==400)
            {
                selectioado.BackgroundImage = Properties.Resources.black1;
                selectioado.Tag = "queen";
            }
            else if (color == "roja" && selectioado.Location.Y == 50)
            {
                selectioado.BackgroundImage = Properties.Resources.white1;
                selectioado.Tag = "queen";
            }
        }
        private void selectionRoja(object sender, MouseEventArgs e)
        {
            selection(sender);
        }
        private void seectionAzul(object sender, MouseEventArgs e)
        {
            selection(sender);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
