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
using System.Xml.XPath;
using System.Xml.Xsl;


namespace project1
{
    
    public partial class Form1 : Form
    { 
        List<OrderDetail> testList = new List<OrderDetail>();
            XmlSerializer xs = new XmlSerializer(typeof(List<OrderDetail>));
        //public void Showlist(List<OrderDetail> testList)
        //{
        //    string t = "";
        //    foreach (OrderDetail od in testList)
        //    {

        //        t = t + od.ToString() + "\n";
                
        //    }
        //    label1.Text = t;
        //}
        public Form1()
        {   
            InitializeComponent();
           
        //    try
        //    {
        //        XmlDocument doc = new XmlDocument();
        //        doc.Load(@".\people.xml");
        //        XPathNavigator nav = doc.CreateNavigator();
        //        nav.MoveToRoot();
        //        XslTransform xt = new XslTransform();
        //        xt.Load(@".\people.xsl");
        //        XmlTextWriter writer = new XmlTextWriter(Console.Out);
        //        xt.Transform(nav, null, writer);
        //    }
        //    catch (XmlException e)
        //    {
        //        Console.WriteLine("123" + e.ToString());
        //    }
        //    catch (XsltException e)
        //    {
        //        Console.WriteLine("123" + e.ToString());
        //    }
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
            button5.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //deletelist List = new deletelist();
            //List.ShowDialog();
            using (var db = new OrderDB())
            {
                if (bindingSource1.Current != null)
                {
                    OrderDetail order = (OrderDetail)bindingSource1.Current;
                    var order1 = db.Order.SingleOrDefault(o => o.Id == order.Id);
                    db.Order.Remove(order1);
                    db.SaveChanges();                  
                    button5.PerformClick();
                }
                else { MessageBox.Show("没有选中订单"); }

                //using (FileStream fs = new FileStream("people.xml", FileMode.Create))
                //{
                //    xs.Serialize(fs, testList);
                //}
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //using (FileStream fs = new FileStream("people.xml", FileMode.Open))
            //{
            //    testList = (List<OrderDetail>)xs.Deserialize(fs);

            //}
            using (var db = new OrderDB())
            {
                bindingSource1.DataSource=db.Order.ToList();
            }
            //bindingSource1.DataSource = testList;
            //Showlist(testList);
            
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.PerformClick();
            MessageBox.Show("请输入修改后的订单");
            button1.PerformClick();
            //if (bindingSource1.Current != null)
            //{
            //    OrderDetail order = (OrderDetail)bindingSource1.Current;
            //    fixlist List = new fixlist();
            //    List.fix(order);
            //    List.ShowDialog();
            //}
            //else { MessageBox.Show("没有选中订单"); }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            XslCompiledTransform trans = new XslCompiledTransform();
            trans.Load(@"people.xsl");
            trans.Transform(@"people.xml", @".\people.html");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try { System.Diagnostics.Process.Start("people.html"); }
            catch { MessageBox.Show("请先生成文件", "提示", MessageBoxButtons.OK); };
        }
    }
}
