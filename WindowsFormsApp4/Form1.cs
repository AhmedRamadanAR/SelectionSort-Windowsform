using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        


        public Form1()
        {
            InitializeComponent();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            Enter_your_Array.Items.Add(x);
            

        }


        private void label1_Click(object sender, EventArgs e)
        {
             
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] arr = new int[Enter_your_Array.Items.Count];
            for (int i = 0; i < Enter_your_Array.Items.Count; i++)
            {
                arr[i] = Convert.ToInt32(Enter_your_Array.Items[i]);
            }

            selectionSort(arr, Enter_your_Array.Items.Count);




            foreach (var x in arr)
                listBox2.Items.Add(x);
            button1.Enabled = false;
            button2.Enabled = false;
        

        }
   




        static void selectionSort(int[] list, int n)
        {
            int i, j;
            for (i = 0; i < n; i++)
            {
                int min = i;
                for (j = i + 1; j < n; j++)
                    if (list[j] < list[min])
                    {
                        min = j;
                    }
                int temp = list[i];
                list[i] = list[min];
                list[min] = temp;
            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Enter_your_Array.Items.Clear();
            listBox2.Items.Clear();
            button2.Enabled = true;
            button1.Enabled = true;
        }
    }

}

  

