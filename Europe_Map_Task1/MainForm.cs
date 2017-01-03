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
        // list to store each label
        List<Control> Labels = new List<Control>();
        // list to store each pictureBox;
        List<PictureBox> pBoxes = new List<PictureBox>();
        String lastCountry = "";
        int counter = 0;
        public MainForm()
        {
            InitializeComponent();
        }
       
       
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitLabels();
            InitGrids();
            InitCountriesPictures();
            this.DatesGroupBox.BackColor = Color.Transparent;
            this.DatesGroupBox.Parent = this.MapBox;

        }
        public void InitLabels()
        {
            int topMargin = 20;
            Font f = new Font("Arial", 9);
            for (int i = 0; i < 8; i++)
            {
                Labels.Add(new Label() { Font = f, Visible = false, Top = topMargin, AutoSize = true, Left = 5 });
                topMargin += 30;
            }
            Labels[0].Text = "Італія - 28 жовтня 1921 року";
            Labels[1].Text = "Болгарія - 9 вересня 1923 року";
            Labels[2].Text = "Португалія - 1926 рік";
            Labels[3].Text = "Угорщина - вересень 1932 року";
            Labels[4].Text = "Німеччина - 28 лютого 1933 року";
            Labels[5].Text = "Румунія - 1934 рік";
            Labels[6].Text = "Югославія - лютий 1939 року";
            Labels[7].Text = "Іспанія - кінець березня 1939 року";
            this.DatesGroupBox.Controls.AddRange(Labels.ToArray());
        }
        private void Item_Click(object sender, EventArgs e)
        {
            AdditionalForm adF = new AdditionalForm(lastCountry);
            adF.ShowDialog();
        }


 
        private void MapBox_MouseMove(object sender, MouseEventArgs e)
        {
            
            Point mouse = new Point(e.X, e.Y); // current position
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
                item.Parent = this.MapBox;
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
        private void InitYugoslavia()// OK
        {

            Grid current = grids.First(x => x.GridName == "Yugoslavia");
            PictureBox sp = new PictureBox();
            sp.Image = Properties.Resources.yugoslavia;
            sp.Location = new Point(current.Rectangle.X - 20, current.Rectangle.Y - 20);
            sp.Size = new Size(current.Rectangle.Width + 35, current.Rectangle.Height + 40);
            pBoxes.Add(sp);
        }
        private void InitItaly()// OK
        {
            // to add a little area in bottom left
            Grid current = grids.First(x => x.GridName == "Italy");
            PictureBox sp = new PictureBox();
            sp.Image = Properties.Resources.italy;
            sp.Location = new Point(current.Rectangle.X - 20, current.Rectangle.Y - 20);
            sp.Size = new Size(current.Rectangle.Width + 35, current.Rectangle.Height + 65);
            pBoxes.Add(sp);
        }
        private void InitPortugal()// OK
        {
            Grid current = grids.First(x => x.GridName == "Portugal");
            PictureBox sp = new PictureBox();
            sp.Image = Properties.Resources.portu;
            sp.Location = new Point(current.Rectangle.X - 10, current.Rectangle.Y - 13);
            sp.Size = new Size(current.Rectangle.Width + 20, current.Rectangle.Height + 37);
            pBoxes.Add(sp);
        }

        private void StartLabelsButton_Click(object sender, EventArgs e)
        {
            this.timer1.Interval = 2000;
            this.timer1.Start();
            this.StartLabelsButton.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Labels[counter].ForeColor = Color.Black;

            this.Labels[counter].Visible = true;

            switch (counter)
            {
                case 0:
                    this.MapBox.Image = Properties.Resources.first_italy;
                    break;
                case 1:
                    this.MapBox.Image = Properties.Resources.second_bulgary;
                    break;
                case 2:
                    this.MapBox.Image = Properties.Resources.third_portugal;
                    break;
                case 3:
                    this.MapBox.Image = Properties.Resources.fourth_hungary;
                    break;
                case 4:
                    this.MapBox.Image = Properties.Resources.fifth_germany;
                    break;
                case 5:
                    this.MapBox.Image = Properties.Resources.sixth_romania;
                    break;
                case 6:
                    this.MapBox.Image = Properties.Resources.seventh_yugoslavia;
                    break;
                case 7:
                    this.MapBox.Image = Properties.Resources.eighth_spain;
                    break;
            }

            this.MapBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.MapBox.Refresh();

            counter++;
            if (counter == 8)
            {
                timer1.Stop();
            }
        }
    }
    internal class Grid
    {
        public Rectangle Rectangle { get; set; }
        public string GridName { get; set; } // country name
        public Grid(Point location, Size size, string name)
        {
            GridName = name;
            Rectangle = new Rectangle(location, size);
        }
    }
}
