using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Europe_Map
{
    //    Назва проекту: Зародження фашизму в Європі.Завдання як таких два (Visual
    //Studio Windows Form C#).
    //1. Необхідно взяти карту Європи, можливо 30-40х років, якщо не получиться
    //то на сучасній, на ній необхідно щоб були обов'язково наступні країни:
    //Італія
    //Німеччина
    //Іспанія
    //Болгарія
    //Угорщина
    //Румунія
    //Югославія
    //Португалія
    // Коли наводиш на любу з перелічених вище країн вона підсвічується і можна
    //перейти на іншу форму.
    //2. Вихідна та сама карта, по кнопці за таймером темніють або міняють колір
    //на темний країни, висвічується назва країни та дата в наступній
    //послідовності:
    //Італія - 28 жовтня 1921 року
    //Болгарія - 9 вересня 1923 року
    //Португалія - 1926 рік
    //Угорщина - вересень 1932 року
    //Німеччина - 28 лютого 1933 року
    //Румунія - 1934 рік
    //Югославія - лютий 1939 року
    //Іспанія - кінець березня 1939 року
    //Коли країна погасла вона і залишається темною.
    public partial class MapForm : Form
    {
        // form for task 2
        // realization via a bunch of pictures with faded countries.

        // or to cut every country and fade them one by one
        List<Control> Labels = new List<Control>();
        int counter = 0;
        public MapForm()
        {
            InitializeComponent();
            //listView1.Items.Add("hello");
            //listView1.Items[0].Selected = true;
            //listView1.RedrawItems();
            InitLabels();
            ButtonLabelsBox.Controls.AddRange(Labels.ToArray());
            this.timer1.Interval = 2000;
            //this.timer1.Start();
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




        }


        private void button1_Click(object sender, EventArgs e)
        {

            this.ShowLabelsButton.Enabled = false;
            this.timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Labels[counter].ForeColor = Color.Black;

            this.Labels[counter].Visible = true;
            
            switch (counter)
            {
                case 0:
                    this.MapPBox.Image = Properties.Resources.first_italy;
                    break;
                case 1:
                    this.MapPBox.Image = Properties.Resources.second_bulgary;
                    break;
                case 2:
                    this.MapPBox.Image = Properties.Resources.third_portugal;
                    break;
                case 3:
                    this.MapPBox.Image = Properties.Resources.fourth_hungary;
                    break;
                case 4:
                    this.MapPBox.Image = Properties.Resources.fifth_germany;
                    break;
                case 5:
                    this.MapPBox.Image = Properties.Resources.sixth_romania;
                    break;
                case 6:
                    this.MapPBox.Image = Properties.Resources.seventh_yugoslavia;
                    break;
                case 7:
                    this.MapPBox.Image = Properties.Resources.eighth_spain;
                    break;
            }
            
            this.MapPBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.MapPBox.Refresh();

            counter++;
            if (counter == 8)
            {
                timer1.Stop();
            }
        }

        private void ButtonLabelsBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
