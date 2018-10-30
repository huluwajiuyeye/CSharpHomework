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
    public partial class deletelist : Form
    {
        List<OrderDetail> testList = new List<OrderDetail>();
        XmlSerializer xs = new XmlSerializer(typeof(List<OrderDetail>));
        public deletelist()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("people.xml", FileMode.Open))
            {
                testList = (List<OrderDetail>)xs.Deserialize(fs);

            }
            int b;
            try { b = Convert.ToInt32(textBox1.Text); testList.RemoveAt(b - 1); }
            catch { }

            using (FileStream fs = new FileStream("people.xml", FileMode.Create))
            {
                xs.Serialize(fs, testList);
            }
        }
    }
}
