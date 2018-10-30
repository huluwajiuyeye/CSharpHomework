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
    public partial class newlist : Form
    {
        public List<OrderDetail> testList = new List<OrderDetail>();
        XmlSerializer xs = new XmlSerializer(typeof(List<OrderDetail>));
        string x, b, c, d;
        public newlist()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try { x = this.textBox1.Text; }
            catch { };
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try { b = this.textBox2.Text; }
            catch { };
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try { c = this.textBox3.Text; }
            catch { };
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try { d = this.textBox4.Text; }
            catch { };
        }

private void button1_Click(object sender, EventArgs e)
        {
            
            using (FileStream fs = new FileStream("people.xml", FileMode.Open))
            {
                testList = (List<OrderDetail>)xs.Deserialize(fs);
            }
            OrderDetail a = new OrderDetail();
            a.id = x;
            a.name = b;
            a.customer = c;
            a.money = Convert.ToInt32(d);
            testList.Add(a);
            using (FileStream fs = new FileStream("people.xml", FileMode.Create))
            {
                xs.Serialize(fs, testList);
            }
            
        }  
    }
}
