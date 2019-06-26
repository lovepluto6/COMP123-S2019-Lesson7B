using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson7B
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// this.is the HelloWorld Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            Start();
        }
        /// <summary>
        /// The start method is used for property initialization
        /// </summary>
        public void Start()
        {
            HelloWorldlabel.BackColor = Color.Black;
            HelloWorldlabel.ForeColor = Color.White;
            HelloWorldlabel.Text = "Hellow, Pluto";
        }
        /// <summary>
        /// This method is the event hardler for the ClickMeButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickMebutton_Click(object sender, EventArgs e)
        {
            //if (HelloWorldlabel.Text == "Clicked!")
            //{
            //    HelloWorldlabel.Text = "UnClicked";
            //}
            //else
            //{
            //    HelloWorldlabel.Text = "Clicked!";
            //}
            HelloWorldlabel.Text = (HelloWorldlabel.Text == "Clicked!") ? "Unclicked!" : "Clicked!";

            int x = new Random().Next(1,49);
            HelloWorldlabel.Text =x.ToString();
                
        }
    }
}
