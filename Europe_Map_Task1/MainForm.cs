using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Europe_Map_Task1
{
    public partial class MainForm : Form
    {

        //list to store each grid
        List<Grid> grids = new List<Grid>();
        // list to store each pictureBox;
        List<PictureBox> pBoxes = new List<PictureBox>();
        String lastCountry = "";
        public MainForm()
        {
            InitializeComponent();
        }
       
       
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitGrids();
            InitCountriesPictures();

        }

        private void Item_Click(object sender, EventArgs e)
        {
            AdditionalForm adF = new AdditionalForm(lastCountry);
            adF.ShowDialog();
        }


 
        private void MapBox_MouseMove(object sender, MouseEventArgs e)
        {
            
            Point mouse = new Point(e.X, e.Y);
            Grid current = grids.Find(delegate (Grid g)
            { return g.Rectangle.Contains(mouse) == true; });
            PictureBox p = new PictureBox();
            foreach (var item in pBoxes)
            {
                item.Enabled = false;
                item.Visible = false;
            }
            if (current != null)
            {
                lastCountry = current.GridName;
                
                switch (current.GridName)
                {
                    case "Spain":
                        
                        pBoxes[0].Enabled = true;
                        pBoxes[0].Visible = true;
                        
                        break;
                    case "Portugal":
                        pBoxes[1].Enabled = true;
                        pBoxes[1].Visible = true;
                       
                        break;
                    case "Italy":
                        pBoxes[2].Enabled = true;
                        pBoxes[2].Visible = true;
                        break;
                    case "Germany":
                        pBoxes[3].Enabled = true;
                        pBoxes[3].Visible = true;
                        break;
                    case "Yugoslavia":
                        pBoxes[4].Enabled = true;
                        pBoxes[4].Visible = true;
                        break;
                    case "Hungary":
                        pBoxes[5].Enabled = true;
                        pBoxes[5].Visible = true;
                        break;
                    case "Bulgaria":
                        pBoxes[6].Enabled = true;
                        pBoxes[6].Visible = true;
                        break;
                    case "Romania":
                        pBoxes[7].Enabled = true;
                        pBoxes[7].Visible = true;
                        break;
                } 
            }
            
            
            

        }
        private void InitGrids()
        {
            // portugal
            // Y   X
            // 302 90
            // 321 124
            // 391 77
            // 386 51
            // OK



            grids.Add(new Grid(new Point(51, 301), new Size(124 - 51, 391 - 302), "Portugal"));

            grids.Add(new Grid(new Point(90, 293), new Size(267 - 90, 465 - 293), "Spain"));

            // spain
            // X  Y
            // 150 293
            // 267 358
            // 128 465
            // 79 400

            grids.Add(new Grid(new Point(350, 300), new Size(507 - 350, 478 - 300), "Italy"));
            //italy 
            // X    Y
            // 350 311
            // 407 478
            // 431 300
            // 507 446
            grids.Add(new Grid(new Point(365, 166), new Size(514 - 372, 275 - 166), "Germany"));
            // Germany 
            // X    Y
            // 387 170
            // 372 275
            // 458 240
            // 514 166
            grids.Add(new Grid(new Point(469, 315), new Size(585 - 469, 424 - 315), "Yugoslavia"));
            // Yugoslavia
            // X    Y
            // 469 315
            // 555 424
            // 551 331
            // 585 407    
            grids.Add(new Grid(new Point(493, 285), new Size(581 - 493, 321 - 285), "Hungary"));
            // Hungary 
            // X    Y
            // 504 287
            // 493 315
            // 564 321
            // 581 285
            grids.Add(new Grid(new Point(585, 296), new Size(677 - 585, 371 - 296), "Romania"));
            // Romania
            // X    Y
            // 585 296
            // 677 296
            // 585 360
            // 675 371 
            grids.Add(new Grid(new Point(588, 375), new Size(672 - 588, 423 - 375), "Bulgaria"));
            // Bulgaria
            // X    Y
            // 588 375
            // 592 423
            // 672 416
            // 668 386
        }
        private void InitCountriesPictures()
        {
            InitSpain();
            InitPortugal();
            InitItaly();
            InitGermany();
            InitYugoslavia();
            InitHungary();
            InitBulgaria();
            InitRomania();
            foreach (var item in pBoxes)
            {
                item.Enabled = false;
                item.Visible = false;
                item.Parent = MapBox;
                item.BackColor = Color.Transparent;
                item.SizeMode = PictureBoxSizeMode.StretchImage;
                item.Click += Item_Click;
            }
        }
        private void InitSpain() // OK
        {

            Grid current = grids.First(x => x.GridName == "Spain");
            PictureBox sp = new PictureBox();
            sp.Location = new Point(current.Rectangle.X - 18, current.Rectangle.Y - 30);
            sp.Size = new Size(current.Rectangle.Width + 20, current.Rectangle.Height + 15);
            sp.Image = Properties.Resources.spain;
            pBoxes.Add(sp);
        }

        private void InitRomania() // OK
        {

            Grid current = grids.First(x => x.GridName == "Romania");
            PictureBox sp = new PictureBox();
            sp.Image = Properties.Resources.romania;
            sp.Location = new Point(current.Rectangle.X - 47, current.Rectangle.Y - 23);
            sp.Size = new Size(current.Rectangle.Width + 85, current.Rectangle.Height + 55);
            pBoxes.Add(sp);
        }
        private void InitBulgaria() // OK
        {

            Grid current = grids.First(x => x.GridName == "Bulgaria");
            PictureBox sp = new PictureBox();
            sp.Image = Properties.Resources.bulgary;
            sp.Location = new Point(current.Rectangle.X - 17, current.Rectangle.Y - 15);
            sp.Size = new Size(current.Rectangle.Width + 35, current.Rectangle.Height + 35);
            pBoxes.Add(sp);
        }
        private void InitGermany() // oK
        {

            Grid current = grids.First(x => x.GridName == "Germany");
            PictureBox sp = new PictureBox();
            sp.Image = Properties.Resources.germany;
            sp.Location = new Point(current.Rectangle.X - 20, current.Rectangle.Y - 30);
            sp.Size = new Size(current.Rectangle.Width + 60, current.Rectangle.Height + 60);
            pBoxes.Add(sp);
        }
        private void InitHungary() // OK
        {

            Grid current = grids.First(x => x.GridName == "Hungary");
            PictureBox sp = new PictureBox();
            sp.Image = Properties.Resources.hungary;
            sp.Location = new Point(current.Rectangle.X - 27, current.Rectangle.Y - 31);
            sp.Size = new Size(current.Rectangle.Width + 60, current.Rectangle.Height + 70);
            pBoxes.Add(sp);
        }
        private void InitYugoslavia()
        {

            Grid current = grids.First(x => x.GridName == "Yugoslavia");
            PictureBox sp = new PictureBox();
            sp.Image = Properties.Resources.yugoslavia;
            sp.Location = new Point(current.Rectangle.X - 20, current.Rectangle.Y - 20);
            sp.Size = new Size(current.Rectangle.Width + 35, current.Rectangle.Height + 40);
            pBoxes.Add(sp);
        }
        private void InitItaly()
        {
            // to add a little area in bottom left
            Grid current = grids.First(x => x.GridName == "Italy");
            PictureBox sp = new PictureBox();
            sp.Image = Properties.Resources.italy;
            sp.Location = new Point(current.Rectangle.X - 20, current.Rectangle.Y - 20);
            sp.Size = new Size(current.Rectangle.Width + 35, current.Rectangle.Height + 65);
            pBoxes.Add(sp);
        }
        private void InitPortugal()
        {
            Grid current = grids.First(x => x.GridName == "Portugal");
            PictureBox sp = new PictureBox();
            sp.Image = Properties.Resources.portu;
            sp.Location = new Point(current.Rectangle.X - 10, current.Rectangle.Y - 13);
            sp.Size = new Size(current.Rectangle.Width + 20, current.Rectangle.Height + 37);
            pBoxes.Add(sp);
        }

    }
    class Grid
    {
        public Rectangle Rectangle { get; set; }
        public string GridName { get; set; }
        public Grid(Point location, Size size, string name)
        {
            GridName = name;
            Rectangle = new Rectangle(location, size);
        }
    }
}
