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
using System.Data.Entity;
using System.Collections;
namespace project1
{
    public partial class newlist : Form
    {
        public List<OrderDetail> testList = new List<OrderDetail>();
        XmlSerializer xs = new XmlSerializer(typeof(List<OrderDetail>));
        string x, b, c, d,phone,number;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try{     phone = this.textBox5.Text;               
            }
            catch { };
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try { number = this.textBox6.Text; }
            catch { };
        }

        private void newlist_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

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

            //using (FileStream fs = new FileStream("people.xml", FileMode.Open))
            //{
            //    testList = (List<OrderDetail>)xs.Deserialize(fs);
            //}
            OrderDetail a = new OrderDetail();
            a.Id = x;
            a.Name = b;
            a.Customer = c;
            a.Money = Convert.ToInt32(d);
            a.Ordernumber = Convert.ToInt64(number);
            a.Phonenumber = Convert.ToInt64(phone);
            //bool repeatnumber = false;
            //foreach (OrderDetail s in testList)
            //{
            //    if (a.Ordernumber == s.Ordernumber)
            //    {
            //        MessageBox.Show("重复账单号", "提示", MessageBoxButtons.OK);
            //        repeatnumber = true;
            //    }
            //}
            //testList.Add(a);
            //if (repeatnumber)
            //{
            //    testList.Remove(a);
            //}
            //if (a.Phonenumber < 10000000000 || a.Phonenumber > 16000000000)
            //{
            //    MessageBox.Show("请输入正确的电话号码", "提示", MessageBoxButtons.OK);
            //    testList.Remove(a);
            //}


            //try
            //{
            //    string year = number.Substring(0, 4);
            //    string month = number.Substring(4, 2);
            //    string day = number.Substring(6, 2);
            //    if (a.Ordernumber > 20000000000 && a.Ordernumber < 26000000000)
            //    {
            //        if (Convert.ToInt32(year) > 2000 && Convert.ToInt32(year) < 2999 && Convert.ToInt32(month) < 13
            //          && Convert.ToInt32(month) > 0 && Convert.ToInt32(day) < 32
            //          && Convert.ToInt32(year) > 0) { }
            //        else
            //        {
            //            MessageBox.Show("请按照 年月日+三位流水号输入订单号", "提示", MessageBoxButtons.OK);
            //            testList.Remove(a);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("请按照 年月日+三位流水号输入订单号", "提示", MessageBoxButtons.OK);
            //        testList.Remove(a);
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("请按照 年月日+三位流水号输入订单号", "提示", MessageBoxButtons.OK);
            //    testList.Remove(a);
            //}
            using (var db = new OrderDB())
            {
                try
                {
                    db.Order.Add(a);
                    //db.Order.Attach(order);
                    //db.Entry(order).State = EntityState.Added;
                    db.SaveChanges();
                    MessageBox.Show("创建成功", "提示", MessageBoxButtons.OK);
                }
                catch { MessageBox.Show("ID不可以重复", "提示", MessageBoxButtons.OK); }

            }
            //using (FileStream fs = new FileStream("people.xml", FileMode.Create))
            //{
            //    xs.Serialize(fs, testList);
            //}
        }
    }
}
