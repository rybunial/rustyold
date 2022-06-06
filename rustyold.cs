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
        public int postacx = 20;
        public int postacy = 100;
        public void engine(int pozycjax, int pozycjay)
        {
            rtbtext.Text =pozycjax.ToString() + ' ' + pozycjay.ToString();
            if (pozycjax == 250 && pozycjay == 120)
            { 
                rtbtext.Text = "Dotarles do zamku";
            }

            if (pozycjax == 20 && pozycjay == 320)
            {
                rtbtext.Text = "Dotarles do kopalni";
            }
        }
        public rustyold()
        {
            InitializeComponent();
            rtbtext.Text = "Witaj w Rusty Old";
            _player = new player(0, 0, 0);
            
            _player.Inventory.Add(new InventoryItem("Text"));
            _maps = new maps();
            //  rtbworld.Visible = false;
            // dgvworld.SendToBack();
            int ilo = 0;

     
            foreach (wlr wlrs in _maps.Wlrs)
            {
                ilo++;
                if (wlrs.Obiekt == " ")
                {
                    var lab = new Label
                    {

                        Name = "label" + ilo,
                        Size = new Size(20, 15),
                        ForeColor = Color.White,
                        BackColor = Color.Brown,
                        Location = new Point(wlrs.Pozycjax, wlrs.Pozycjay),

                        Text = wlrs.Obiekt,


                    };
                    this.Controls.Add(lab);
                }
                else if (wlrs.Obiekt == "#")
                {

                    var lab = new Label
                    {

                        Name = "label" + ilo,
                        Size = new Size(20, 15),
                        ForeColor = Color.White,
                        BackColor = Color.Black,
                        Location = new Point(wlrs.Pozycjax, wlrs.Pozycjay),

                        Text = wlrs.Obiekt,


                    };

                    this.Controls.Add(lab);
                }
                else if (wlrs.Obiekt == "$")
                {

                    var lab = new Label
                    {

                        Name = "label" + ilo,
                        Size = new Size(20, 15),
                        ForeColor = Color.White,
                        BackColor = Color.Yellow,
                        Location = new Point(wlrs.Pozycjax, wlrs.Pozycjay),

                        Text = wlrs.Obiekt,


                    };

                    this.Controls.Add(lab);
                }
                else
                {

                    var lab = new Label
                    {

                        Name = "label" + ilo,
                        Size = new Size(20, 15),
                        ForeColor = Color.White,
                        BackColor = Color.DarkOliveGreen,
                        Location = new Point(wlrs.Pozycjax, wlrs.Pozycjay),

                        Text = wlrs.Obiekt,


                    };

                    this.Controls.Add(lab);
                }
                
                
                //   dgvworld. = wlrs.Obiekt.ToString();
              //lab.BringToFront();

            //    rtbtext.Text = ilo.ToString() + '-' + wlrs.Pozycjax.ToString() + '-' + wlrs.Pozycjay.ToString();
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
