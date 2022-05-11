using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTSP_Cameras
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            vlcControl1.Audio.Volume = 0;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnFlux_Click(object sender, EventArgs e)
        {
            string IP = TxtIP.Text;
            string Secret = TxtSecret.Text;

            vlcControl1.Play(new Uri("rtsp://admin:"+Secret+"@"+IP+"/cam/realmonitor?channel=1&subtype=0&unicast=true&proto=Onvif"));
            ConnectedTo.Text = "Connected to: " + IP;

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2CheckBox1.Checked)
            {
                this.TopMost = true;
            }
            if(!guna2CheckBox1.Checked)
            {
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox2.Checked)
            {
                vlcControl1.Audio.Volume = 100;
            }
            if (!guna2CheckBox2.Checked)
            {
                vlcControl1.Audio.Volume = 0;

            }

        }
    }
}
