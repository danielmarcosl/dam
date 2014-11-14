using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADO
{
    public partial class FormAcercaDe : Form
    {
        public FormAcercaDe()
        {
            InitializeComponent();
        }

        // Hacer que se pueda mover el programa clickando en cualquier sitio
        private bool mouseIsDown = false;
        private Point firstPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                // Get the difference between the two points
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            mouseIsDown = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        //

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
