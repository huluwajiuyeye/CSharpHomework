using System;
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
    
    public partial class Form1 : Form
    {       List<OrderDetail> testList = new List<OrderDetail>();
            XmlSerializer xs = new XmlSerializer(typeof(List<OrderDetail>));
        public void Showlist(List<OrderDetail> testList)
        {
            string t = "";
            foreach (OrderDetail od in testList)
            {

                t = t + od.ToString() + "\n";
                
            }
            label1.Text = t;
        }
        public Form1()
        {   
            InitializeComponent();
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newlist List = new newlist();
            List.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deletelist List = new deletelist();
            List.ShowDialog();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("people.xml", FileMode.Open))
            {
                testList = (List<OrderDetail>)xs.Deserialize(fs);

            }
            Showlist(testList);
            
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fixlist List = new fixlist();
            List.ShowDialog();
        }
    }
}
