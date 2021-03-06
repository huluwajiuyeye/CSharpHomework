﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace project1
{

    public partial class fixlist : Form
    {
        public List<OrderDetail> testList = new List<OrderDetail>();
        XmlSerializer xs = new XmlSerializer(typeof(List<OrderDetail>));
        public fixlist()
        {
            InitializeComponent();
        }
        string newa, newb, newc, newd,newe,newf,newg;

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try { newg = this.textBox6.Text; }
            catch { };
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try { newf = this.textBox7.Text; }
            catch { };
        } 

private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try { newa = this.textBox1.Text; }
            catch { };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("people.xml", FileMode.Open))
            {
                testList = (List<OrderDetail>)xs.Deserialize(fs);
            }          
            int n = 0;     
            foreach (OrderDetail s in testList)
            {
                n += 1;
                if (n == Convert.ToInt32(newa))
                {
                    s.id = newb;
                    s.name = newc;
                    s.customer = newd;
                    s.money = Convert.ToInt32(newe);
                    s.ordernumber= Convert.ToInt64(newf);
                    s.phonenumber= Convert.ToInt64(newg);
                }
            };
            using (FileStream fs = new FileStream("people.xml", FileMode.Create))
            {
                xs.Serialize(fs, testList);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try { newb = this.textBox2.Text; }
            catch { };
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try { newc = this.textBox3.Text; }
            catch { };
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try { newd = this.textBox4.Text; }
            catch { };
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try { newe = this.textBox5.Text; }
            catch { };
        }
    }
}
