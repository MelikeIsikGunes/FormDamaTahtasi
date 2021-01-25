using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();

        }

        private void GenerateButtons()  //Buton Oluştur Metodu
        {
            //Button button = new Button(); //buton bir classtır
            //button.Width = 50; //buton propertyleri
            //button.Height = 50;
            //button.Text = "My button"; //Buton üzerindeki yazı
            //this.Controls.Add(button); //ekrana koy

            Button[,] buttons = new Button[8, 8]; //iki boyutlu dizi. indexno [0,1]
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++) //0.boyutun en büyük alabileceği değer -> 7
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++) //1.boyutun en büyük alabileceği değer -> 7
                {
                    buttons[i, j] = new Button(); //yeni buton oluştur
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left; //Forma göre Soldan uzaklığı. İlk buton için 0
                    buttons[i, j].Top = top;

                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }

                    this.Controls.Add(buttons[i, j]); //butonu ekrana koy
                    left += 50; //Yan yana olmaları için artırıyoruz. Yoksa üst üste olurlar.
                }
                top += 50; //İkinci satıra geçtiğinde 50 arttır.
                left = 0; //İkinci satıra geçtiğinde 0 olsun.
            }
        }
    }
}
