using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int abiertas, puntos = 0;
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cover_Dereck1_Click(object sender, EventArgs e)
        {
            cover_Dereck1.Visible = false;
            Dereck1.Visible = true;
            abiertas++;
            if (abiertas == 2)
            {
                if(Dereck2.Visible == true)
                {
                    abiertas = 0;
                    puntos = puntos + 10;
                    L_puntos.Text = puntos.ToString();
                }

                      if (Dereck1.Visible == false || Dereck2.Visible == false)
                        {
                        Dereck1.Visible = false;
                        Dereck2.Visible = false;
                        cover_Dereck1.Visible = true;
                        cover_Dereck2.Visible = true;
                        abiertas = 0;
                        }
                   
                     if (penelope1.Visible == false || penelope2.Visible == false){
                        penelope1.Visible = false;
                        penelope2.Visible = false;
                        cover_penelope1.Visible = true;
                        cover_penelope2.Visible = true;
                        abiertas = 0;
                    }

                    if (eclipse1.Visible == false || eclipse2.Visible == false)
                    {
                        eclipse1.Visible = false;
                        eclipse2.Visible = false;
                        cover_eclipse1.Visible = true;
                        cover_eclipse2.Visible = true;
                        abiertas = 0;
                    }

                    if (conejo1.Visible == false || conejo2.Visible == false)
                    {
                        conejo1.Visible = false;
                        conejo2.Visible = false;
                        cover_conejo1.Visible = true;
                        cover_conejo2.Visible = true;
                        abiertas = 0;
                    }

                    if (ray1.Visible == false || ray2.Visible == false)
                    {
                        ray1.Visible = false;
                        ray2.Visible = false;
                        cover_ray1.Visible = true;
                        cover_ray2.Visible = true;
                        abiertas = 0;
                    }

                    if (callisto1.Visible == false || callisto2.Visible == false)
                    {
                        callisto1.Visible = false;
                        callisto2.Visible = false;
                        cover_callisto1.Visible = true;
                        cover_callisto2.Visible = true;
                        abiertas = 0;
                    }
                
            }
        }

        private void cover_Dereck2_Click_1(object sender, EventArgs e)
        {
            cover_Dereck2.Visible = false;
            Dereck2.Visible = true;
            abiertas++;
            if (abiertas == 2)
            {
                if (Dereck1.Visible == true)
                {
                    abiertas = 0;
                    puntos = puntos + 10;
                    L_puntos.Text = puntos.ToString(); ;
                }

                if (Dereck1.Visible == false || Dereck2.Visible == false)
                {
                    Dereck1.Visible = false;
                    Dereck2.Visible = false;
                    cover_Dereck1.Visible = true;
                    cover_Dereck2.Visible = true;
                    abiertas = 0;
                }

                if (penelope1.Visible == false || penelope2.Visible == false)
                {
                    penelope1.Visible = false;
                    penelope2.Visible = false;
                    cover_penelope1.Visible = true;
                    cover_penelope2.Visible = true;
                    abiertas = 0;
                }

                if (eclipse1.Visible == false || eclipse2.Visible == false)
                {
                    eclipse1.Visible = false;
                    eclipse2.Visible = false;
                    cover_eclipse1.Visible = true;
                    cover_eclipse2.Visible = true;
                    abiertas = 0;
                }

                if (conejo1.Visible == false || conejo2.Visible == false)
                {
                    conejo1.Visible = false;
                    conejo2.Visible = false;
                    cover_conejo1.Visible = true;
                    cover_conejo2.Visible = true;
                    abiertas = 0;
                }

                if (ray1.Visible == false || ray2.Visible == false)
                {
                    ray1.Visible = false;
                    ray2.Visible = false;
                    cover_ray1.Visible = true;
                    cover_ray2.Visible = true;
                    abiertas = 0;
                }

                if (callisto1.Visible == false || callisto2.Visible == false)
                {
                    callisto1.Visible = false;
                    callisto2.Visible = false;
                    cover_callisto1.Visible = true;
                    cover_callisto2.Visible = true;
                    abiertas = 0;
                }
            }
        }
        
        private void cover_penelope1_Click(object sender, EventArgs e)
        {
            cover_penelope1.Visible = false;
            penelope1.Visible = true;
            abiertas++;
            if (abiertas == 2)
            {
                if (penelope2.Visible == true)
                {
                    abiertas = 0;
                    puntos = puntos + 10;
                    L_puntos.Text = puntos.ToString();
                }

                if (Dereck1.Visible == false || Dereck2.Visible == false)
                {
                    Dereck1.Visible = false;
                    Dereck2.Visible = false;
                    cover_Dereck1.Visible = true;
                    cover_Dereck2.Visible = true;
                    abiertas = 0;
                }

                if (penelope1.Visible == false || penelope2.Visible == false)
                {
                    penelope1.Visible = false;
                    penelope2.Visible = false;
                    cover_penelope1.Visible = true;
                    cover_penelope2.Visible = true;
                    abiertas = 0;
                }

                if (eclipse1.Visible == false || eclipse2.Visible == false)
                {
                    eclipse1.Visible = false;
                    eclipse2.Visible = false;
                    cover_eclipse1.Visible = true;
                    cover_eclipse2.Visible = true;
                    abiertas = 0;
                }

                if (conejo1.Visible == false || conejo2.Visible == false)
                {
                    conejo1.Visible = false;
                    conejo2.Visible = false;
                    cover_conejo1.Visible = true;
                    cover_conejo2.Visible = true;
                    abiertas = 0;
                }

                if (ray1.Visible == false || ray2.Visible == false)
                {
                    ray1.Visible = false;
                    ray2.Visible = false;
                    cover_ray1.Visible = true;
                    cover_ray2.Visible = true;
                    abiertas = 0;
                }

                if (callisto1.Visible == false || callisto2.Visible == false)
                {
                    callisto1.Visible = false;
                    callisto2.Visible = false;
                    cover_callisto1.Visible = true;
                    cover_callisto2.Visible = true;
                    abiertas = 0;
                }

            }
        }
        private void cover_penelope2_Click_1(object sender, EventArgs e)
        {
            cover_penelope2.Visible = false;
            penelope2.Visible = true;
            abiertas++;
            if (abiertas == 2)
            {
                if (penelope1.Visible == true)
                {
                    abiertas = 0;
                    puntos = puntos + 10;
                    L_puntos.Text = puntos.ToString();
                }

                if (Dereck1.Visible == false || Dereck2.Visible == false)
                {
                    Dereck1.Visible = false;
                    Dereck2.Visible = false;
                    cover_Dereck1.Visible = true;
                    cover_Dereck2.Visible = true;
                    abiertas = 0;
                }

                if (penelope1.Visible == false || penelope2.Visible == false)
                {
                    penelope1.Visible = false;
                    penelope2.Visible = false;
                    cover_penelope1.Visible = true;
                    cover_penelope2.Visible = true;
                    abiertas = 0;
                }

                if (eclipse1.Visible == false || eclipse2.Visible == false)
                {
                    eclipse1.Visible = false;
                    eclipse2.Visible = false;
                    cover_eclipse1.Visible = true;
                    cover_eclipse2.Visible = true;
                    abiertas = 0;
                }

                if (conejo1.Visible == false || conejo2.Visible == false)
                {
                    conejo1.Visible = false;
                    conejo2.Visible = false;
                    cover_conejo1.Visible = true;
                    cover_conejo2.Visible = true;
                    abiertas = 0;
                }

                if (ray1.Visible == false || ray2.Visible == false)
                {
                    ray1.Visible = false;
                    ray2.Visible = false;
                    cover_ray1.Visible = true;
                    cover_ray2.Visible = true;
                    abiertas = 0;
                }

                if (callisto1.Visible == false || callisto2.Visible == false)
                {
                    callisto1.Visible = false;
                    callisto2.Visible = false;
                    cover_callisto1.Visible = true;
                    cover_callisto2.Visible = true;
                    abiertas = 0;
                }

            }
        }

        private void cover_callisto1_Click(object sender, EventArgs e)
        {
            cover_callisto1.Visible = false;
            callisto1.Visible = true;
            abiertas++;
            if (abiertas == 2)
            {
                if (callisto2.Visible == true)
                {
                    abiertas = 0;
                    puntos = puntos + 10;
                    L_puntos.Text = puntos.ToString();
                }

                if (Dereck1.Visible == false || Dereck2.Visible == false)
                {
                    Dereck1.Visible = false;
                    Dereck2.Visible = false;
                    cover_Dereck1.Visible = true;
                    cover_Dereck2.Visible = true;
                    abiertas = 0;
                }

                if (penelope1.Visible == false || penelope2.Visible == false)
                {
                    penelope1.Visible = false;
                    penelope2.Visible = false;
                    cover_penelope1.Visible = true;
                    cover_penelope2.Visible = true;
                    abiertas = 0;
                }

                if (eclipse1.Visible == false || eclipse2.Visible == false)
                {
                    eclipse1.Visible = false;
                    eclipse2.Visible = false;
                    cover_eclipse1.Visible = true;
                    cover_eclipse2.Visible = true;
                    abiertas = 0;
                }

                if (conejo1.Visible == false || conejo2.Visible == false)
                {
                    conejo1.Visible = false;
                    conejo2.Visible = false;
                    cover_conejo1.Visible = true;
                    cover_conejo2.Visible = true;
                    abiertas = 0;
                }

                if (ray1.Visible == false || ray2.Visible == false)
                {
                    ray1.Visible = false;
                    ray2.Visible = false;
                    cover_ray1.Visible = true;
                    cover_ray2.Visible = true;
                    abiertas = 0;
                }

                if (callisto1.Visible == false || callisto2.Visible == false)
                {
                    callisto1.Visible = false;
                    callisto2.Visible = false;
                    cover_callisto1.Visible = true;
                    cover_callisto2.Visible = true;
                    abiertas = 0;
                }

            }
        }
        private void cover_callisto2_Click_1(object sender, EventArgs e)
        {
            cover_callisto2.Visible = false;
            callisto2.Visible = true;
            abiertas++;
            if (abiertas == 2)
            {
                if (callisto1.Visible == true)
                {
                    abiertas = 0;
                    puntos = puntos + 10;
                    L_puntos.Text = puntos.ToString();
                }

                if (Dereck1.Visible == false || Dereck2.Visible == false)
                {
                    Dereck1.Visible = false;
                    Dereck2.Visible = false;
                    cover_Dereck1.Visible = true;
                    cover_Dereck2.Visible = true;
                    abiertas = 0;
                }

                if (penelope1.Visible == false || penelope2.Visible == false)
                {
                    penelope1.Visible = false;
                    penelope2.Visible = false;
                    cover_penelope1.Visible = true;
                    cover_penelope2.Visible = true;
                    abiertas = 0;
                }

                if (eclipse1.Visible == false || eclipse2.Visible == false)
                {
                    eclipse1.Visible = false;
                    eclipse2.Visible = false;
                    cover_eclipse1.Visible = true;
                    cover_eclipse2.Visible = true;
                    abiertas = 0;
                }

                if (conejo1.Visible == false || conejo2.Visible == false)
                {
                    conejo1.Visible = false;
                    conejo2.Visible = false;
                    cover_conejo1.Visible = true;
                    cover_conejo2.Visible = true;
                    abiertas = 0;
                }

                if (ray1.Visible == false || ray2.Visible == false)
                {
                    ray1.Visible = false;
                    ray2.Visible = false;
                    cover_ray1.Visible = true;
                    cover_ray2.Visible = true;
                    abiertas = 0;
                }

                if (callisto1.Visible == false || callisto2.Visible == false)
                {
                    callisto1.Visible = false;
                    callisto2.Visible = false;
                    cover_callisto1.Visible = true;
                    cover_callisto2.Visible = true;
                    abiertas = 0;
                }

            }
        }
       
        private void cover_ray1_Click(object sender, EventArgs e)
        {
            cover_ray1.Visible = false;
            ray1.Visible = true;
            abiertas++;
            if (abiertas == 2)
            {
                if (ray2.Visible == true)
                {
                    abiertas = 0;
                    puntos = puntos + 10;
                    L_puntos.Text = puntos.ToString();
                }

                if (Dereck1.Visible == false || Dereck2.Visible == false)
                {
                    Dereck1.Visible = false;
                    Dereck2.Visible = false;
                    cover_Dereck1.Visible = true;
                    cover_Dereck2.Visible = true;
                    abiertas = 0;
                }

                if (penelope1.Visible == false || penelope2.Visible == false)
                {
                    penelope1.Visible = false;
                    penelope2.Visible = false;
                    cover_penelope1.Visible = true;
                    cover_penelope2.Visible = true;
                    abiertas = 0;
                }

                if (eclipse1.Visible == false || eclipse2.Visible == false)
                {
                    eclipse1.Visible = false;
                    eclipse2.Visible = false;
                    cover_eclipse1.Visible = true;
                    cover_eclipse2.Visible = true;
                    abiertas = 0;
                }

                if (conejo1.Visible == false || conejo2.Visible == false)
                {
                    conejo1.Visible = false;
                    conejo2.Visible = false;
                    cover_conejo1.Visible = true;
                    cover_conejo2.Visible = true;
                    abiertas = 0;
                }

                if (ray1.Visible == false || ray2.Visible == false)
                {
                    ray1.Visible = false;
                    ray2.Visible = false;
                    cover_ray1.Visible = true;
                    cover_ray2.Visible = true;
                    abiertas = 0;
                }

                if (callisto1.Visible == false || callisto2.Visible == false)
                {
                    callisto1.Visible = false;
                    callisto2.Visible = false;
                    cover_callisto1.Visible = true;
                    cover_callisto2.Visible = true;
                    abiertas = 0;
                }

            }
        }
        private void cover__ray2_Click(object sender, EventArgs e)
        {
            cover_ray2.Visible = false;
            ray2.Visible = true;
            abiertas++;
            if (abiertas == 2)
            {
                if (ray1.Visible == true)
                {
                    abiertas = 0;
                    puntos = puntos + 10;
                    L_puntos.Text = puntos.ToString();
                }

                if (Dereck1.Visible == false || Dereck2.Visible == false)
                {
                    Dereck1.Visible = false;
                    Dereck2.Visible = false;
                    cover_Dereck1.Visible = true;
                    cover_Dereck2.Visible = true;
                    abiertas = 0;
                }

                if (penelope1.Visible == false || penelope2.Visible == false)
                {
                    penelope1.Visible = false;
                    penelope2.Visible = false;
                    cover_penelope1.Visible = true;
                    cover_penelope2.Visible = true;
                    abiertas = 0;
                }

                if (eclipse1.Visible == false || eclipse2.Visible == false)
                {
                    eclipse1.Visible = false;
                    eclipse2.Visible = false;
                    cover_eclipse1.Visible = true;
                    cover_eclipse2.Visible = true;
                    abiertas = 0;
                }

                if (conejo1.Visible == false || conejo2.Visible == false)
                {
                    conejo1.Visible = false;
                    conejo2.Visible = false;
                    cover_conejo1.Visible = true;
                    cover_conejo2.Visible = true;
                    abiertas = 0;
                }

                if (ray1.Visible == false || ray2.Visible == false)
                {
                    ray1.Visible = false;
                    ray2.Visible = false;
                    cover_ray1.Visible = true;
                    cover_ray2.Visible = true;
                    abiertas = 0;
                }

                if (callisto1.Visible == false || callisto2.Visible == false)
                {
                    callisto1.Visible = false;
                    callisto2.Visible = false;
                    cover_callisto1.Visible = true;
                    cover_callisto2.Visible = true;
                    abiertas = 0;
                }

            }
        }

        private void cover_conejo1_Click(object sender, EventArgs e)
        {
            cover_conejo1.Visible = false;
            conejo1.Visible = true;
            abiertas++;
            if (abiertas == 2)
            {
                if (conejo2.Visible == true)
                {
                    abiertas = 0;
                    puntos = puntos + 10;
                    L_puntos.Text = puntos.ToString();
                }

                if (Dereck1.Visible == false || Dereck2.Visible == false)
                {
                    Dereck1.Visible = false;
                    Dereck2.Visible = false;
                    cover_Dereck1.Visible = true;
                    cover_Dereck2.Visible = true;
                    abiertas = 0;
                }

                if (penelope1.Visible == false || penelope2.Visible == false)
                {
                    penelope1.Visible = false;
                    penelope2.Visible = false;
                    cover_penelope1.Visible = true;
                    cover_penelope2.Visible = true;
                    abiertas = 0;
                }

                if (eclipse1.Visible == false || eclipse2.Visible == false)
                {
                    eclipse1.Visible = false;
                    eclipse2.Visible = false;
                    cover_eclipse1.Visible = true;
                    cover_eclipse2.Visible = true;
                    abiertas = 0;
                }

                if (conejo1.Visible == false || conejo2.Visible == false)
                {
                    conejo1.Visible = false;
                    conejo2.Visible = false;
                    cover_conejo1.Visible = true;
                    cover_conejo2.Visible = true;
                    abiertas = 0;
                }

                if (ray1.Visible == false || ray2.Visible == false)
                {
                    ray1.Visible = false;
                    ray2.Visible = false;
                    cover_ray1.Visible = true;
                    cover_ray2.Visible = true;
                    abiertas = 0;
                }

                if (callisto1.Visible == false || callisto2.Visible == false)
                {
                    callisto1.Visible = false;
                    callisto2.Visible = false;
                    cover_callisto1.Visible = true;
                    cover_callisto2.Visible = true;
                    abiertas = 0;
                }

            }
        }
        private void cover_conejo2_Click(object sender, EventArgs e)
        {
            cover_conejo2.Visible = false;
            conejo2.Visible = true;
            abiertas++;
            if (abiertas == 2)
            {
                if (conejo1.Visible == true)
                {
                    abiertas = 0;
                    puntos = puntos + 10;
                    L_puntos.Text = puntos.ToString();
                }

                if (Dereck1.Visible == false || Dereck2.Visible == false)
                {
                    Dereck1.Visible = false;
                    Dereck2.Visible = false;
                    cover_Dereck1.Visible = true;
                    cover_Dereck2.Visible = true;
                    abiertas = 0;
                }

                if (penelope1.Visible == false || penelope2.Visible == false)
                {
                    penelope1.Visible = false;
                    penelope2.Visible = false;
                    cover_penelope1.Visible = true;
                    cover_penelope2.Visible = true;
                    abiertas = 0;
                }

                if (eclipse1.Visible == false || eclipse2.Visible == false)
                {
                    eclipse1.Visible = false;
                    eclipse2.Visible = false;
                    cover_eclipse1.Visible = true;
                    cover_eclipse2.Visible = true;
                    abiertas = 0;
                }

                if (conejo1.Visible == false || conejo2.Visible == false)
                {
                    conejo1.Visible = false;
                    conejo2.Visible = false;
                    cover_conejo1.Visible = true;
                    cover_conejo2.Visible = true;
                    abiertas = 0;
                }

                if (ray1.Visible == false || ray2.Visible == false)
                {
                    ray1.Visible = false;
                    ray2.Visible = false;
                    cover_ray1.Visible = true;
                    cover_ray2.Visible = true;
                    abiertas = 0;
                }

                if (callisto1.Visible == false || callisto2.Visible == false)
                {
                    callisto1.Visible = false;
                    callisto2.Visible = false;
                    cover_callisto1.Visible = true;
                    cover_callisto2.Visible = true;
                    abiertas = 0;
                }

            }
        }

        private void cover_eclipse1_Click_1(object sender, EventArgs e)
        {
            cover_eclipse1.Visible = false;
            eclipse1.Visible = true;
            abiertas++;
            if (abiertas == 2)
            {
                if (eclipse2.Visible == true)
                {
                    abiertas = 0;
                    puntos = puntos + 10;
                    L_puntos.Text = puntos.ToString();
                }

                if (Dereck1.Visible == false || Dereck2.Visible == false)
                {
                    Dereck1.Visible = false;
                    Dereck2.Visible = false;
                    cover_Dereck1.Visible = true;
                    cover_Dereck2.Visible = true;
                    abiertas = 0;
                }

                if (penelope1.Visible == false || penelope2.Visible == false)
                {
                    penelope1.Visible = false;
                    penelope2.Visible = false;
                    cover_penelope1.Visible = true;
                    cover_penelope2.Visible = true;
                    abiertas = 0;
                }

                if (eclipse1.Visible == false || eclipse2.Visible == false)
                {
                    eclipse1.Visible = false;
                    eclipse2.Visible = false;
                    cover_eclipse1.Visible = true;
                    cover_eclipse2.Visible = true;
                    abiertas = 0;
                }

                if (conejo1.Visible == false || conejo2.Visible == false)
                {
                    conejo1.Visible = false;
                    conejo2.Visible = false;
                    cover_conejo1.Visible = true;
                    cover_conejo2.Visible = true;
                    abiertas = 0;
                }

                if (ray1.Visible == false || ray2.Visible == false)
                {
                    ray1.Visible = false;
                    ray2.Visible = false;
                    cover_ray1.Visible = true;
                    cover_ray2.Visible = true;
                    abiertas = 0;
                }

                if (callisto1.Visible == false || callisto2.Visible == false)
                {
                    callisto1.Visible = false;
                    callisto2.Visible = false;
                    cover_callisto1.Visible = true;
                    cover_callisto2.Visible = true;
                    abiertas = 0;
                }

            }
        }
        private void cover_eclipse2_Click(object sender, EventArgs e)
        {
            cover_eclipse2.Visible = false;
            eclipse2.Visible = true;
            abiertas++;
            if (abiertas == 2)
            {
                if (eclipse1.Visible == true)
                {
                    abiertas = 0;
                    puntos = puntos + 10;
                    L_puntos.Text = puntos.ToString();
                }

                if (Dereck1.Visible == false || Dereck2.Visible == false)
                {
                    Dereck1.Visible = false;
                    Dereck2.Visible = false;
                    cover_Dereck1.Visible = true;
                    cover_Dereck2.Visible = true;
                    abiertas = 0;
                }

                if (penelope1.Visible == false || penelope2.Visible == false)
                {
                    penelope1.Visible = false;
                    penelope2.Visible = false;
                    cover_penelope1.Visible = true;
                    cover_penelope2.Visible = true;
                    abiertas = 0;
                }

                if (eclipse1.Visible == false || eclipse2.Visible == false)
                {
                    eclipse1.Visible = false;
                    eclipse2.Visible = false;
                    cover_eclipse1.Visible = true;
                    cover_eclipse2.Visible = true;
                    abiertas = 0;
                }

                if (conejo1.Visible == false || conejo2.Visible == false)
                {
                    conejo1.Visible = false;
                    conejo2.Visible = false;
                    cover_conejo1.Visible = true;
                    cover_conejo2.Visible = true;
                    abiertas = 0;
                }

                if (ray1.Visible == false || ray2.Visible == false)
                {
                    ray1.Visible = false;
                    ray2.Visible = false;
                    cover_ray1.Visible = true;
                    cover_ray2.Visible = true;
                    abiertas = 0;
                }

                if (callisto1.Visible == false || callisto2.Visible == false)
                {
                    callisto1.Visible = false;
                    callisto2.Visible = false;
                    cover_callisto1.Visible = true;
                    cover_callisto2.Visible = true;
                    abiertas = 0;
                }

            }
        }

    }
}
