using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Algo_Insertion_Sort
{
    public partial class Insertion_Sort : Form
    {
        public int n1;
        public int n2;
        public int n3;
        public int n4;
        public int n5;
        public int n6;
        public int n7;
        public int n8;
        int[] array = new int[8];
        public Insertion_Sort()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* n1 = int.Parse(textBox1.Text);
            n2 = int.Parse(textBox2.Text);
            n3 = int.Parse(textBox3.Text);
            n4 = int.Parse(textBox4.Text);
            n5 = int.Parse(textBox5.Text);
            n6 = int.Parse(textBox6.Text);
            n7 = int.Parse(textBox7.Text);
            n8 = int.Parse(textBox8.Text);
            array = new int[] { n1, n2, n3, n4, n5, n6, n7, n8 };*/
        }
        private void Sort_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(textBox1.Text);
            n2 = int.Parse(textBox2.Text);
            n3 = int.Parse(textBox3.Text);
            n4 = int.Parse(textBox4.Text);
            n5 = int.Parse(textBox5.Text);
            n6 = int.Parse(textBox6.Text);
            n7 = int.Parse(textBox7.Text);
            n8 = int.Parse(textBox8.Text);
            array = new int[] { n1, n2, n3, n4, n5, n6, n7, n8 };
            int a = 0;
            var key = 0;
            for (int i=1;i<array.Length;i++)
            {
                key = array[i];
                int j = i - 1;
                while(j>=0 && array[j]>key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                    array[j + 1] = key;
                }
                output.Items[a].Text = string.Join(",", array);
                a++;
                output.Items[a].Text = "key= " + key.ToString();
                a++;
            }
            a++;
            output.Items[a].Text = string.Join(",", array);
            //output.Items[a].Text = string.Join(",", array);
            //for(int i=0;i<array.Length;i++)
            //{
            //   output.Items[a].Text = array[i].ToString();
            //    a++;
           // }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            array = new int[8];
            for (int i = 0; i < 41; i++)
            {
                output.Items[i].Text ="";
            }
        }

        private void output_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
