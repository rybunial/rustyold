using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using engine;

namespace rustyold
{
    public partial class rustyold : Form
    {
        public player _player;
        public maps _maps;
        public int postacx = 100;
        public int postacy = 100;
        public void engine(int pozycjax, int pozycjay)
        {
            rtbtext.Text =pozycjax.ToString() + ' ' + pozycjay.ToString();
            if (pozycjax == 300 && pozycjay == 100)
            { 
                rtbtext.Text = "Dotarles do zamku";
            }
        }
        public rustyold()
        {
            InitializeComponent();

            _player = new player(0, 0, 0);
            
            _player.Inventory.Add(new InventoryItem("Text"));
            _maps = new maps();
            //  rtbworld.Visible = false;
            dgvworld.SendToBack();
            int ilo = 0;

     
            foreach (wlr wlrs in _maps.Wlrs)
            {
                int pozx0 = 50;
                int pozy0 = 30;
                for (int pozy = 1; pozy < 30; pozy++)
                {
                    pozy0 = pozy0 + 10;
                    for (int pozx = 1; pozx < 44; pozx++)
                    {
                        if (pozx == 1)
                        {
                            pozx0 = 21;
                        }
                        else
                        {
                            pozx0 = pozx0 + 19;
                        }
                        // Wlrs.Add(new wlr(pozx0, pozy0, pozycja[pozy, pozx].ToString()));

                        rtbworld.Text = _maps.Wlrs[1].ToString();
                        
                        String nazwa = pozx0.ToString() + ' ' + pozy0.ToString() + ' ' + pozycja[pozy, pozx].ToString();
                        Console.WriteLine(nazwa);

                    }
                    pozx0 = 21;
                }
                /*  ilo++;

                   var lab = new Label
                   {

                       Name = "label" + ilo,
                       Size = new Size(20, 20),
                       ForeColor = Color.White,
                       BackColor = Color.DarkOliveGreen,
                       Location = new Point(wlrs.Pozycjax, wlrs.Pozycjay),

                        Text = wlrs.Obiekt,


                   };

                   this.Controls.Add(lab);*//
             //   dgvworld. = wlrs.Obiekt.ToString();
               // lab.BringToFront();
                
                rtbtext.Text = ilo.ToString() + '-' + wlrs.Pozycjax.ToString() + '-' + wlrs.Pozycjay.ToString();
            }
            lblexp.Text = _player.Exp.ToString();
            lblGold.Text = _player.Gold.ToString();
            lbllevel.Text = _player.Level.ToString();

           
           
        }
       
        private void btngora_Click(object sender, EventArgs e)
        {
            postacy = postacy - 10;
            postac.Location = new Point(postacx, postacy);
            engine(postac.Location.X, postac.Location.Y);

        }

        private void btndol_Click(object sender, EventArgs e)
        {
            postacy = postacy + 10;
            postac.Location = new Point(postacx, postacy);
            engine(postac.Location.X, postac.Location.Y);
        }

        private void btnlewo_Click(object sender, EventArgs e)
        {
            postacx = postacx - 10;
            postac.Location = new Point(postacx, postacy);
            engine(postac.Location.X, postac.Location.Y);
        }

        private void btnprawo_Click(object sender, EventArgs e)
        {
            postacx = postacx + 10;
            postac.Location = new Point(postacx, postacy);
            engine(postac.Location.X, postac.Location.Y);
        }
    }
}
