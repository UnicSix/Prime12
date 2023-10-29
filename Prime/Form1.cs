using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime
{
    public partial class Form1 : Form
    {
        public List<bool> prime = new List<bool>();
        public Form1()
        {
            string inputFile = "Number.txt";
            System.IO.StreamReader inputData = new System.IO.StreamReader(inputFile);
            InitializeComponent();
            string line = "";
            line = inputData.ReadLine();
            int index = 0;
            BuildPrimeList(10000000);
            while (line != null)
            {
                // dataGridView1.Rows.Add("");
                checkedListBox1.Items.Add(line);
                // dataGridView1.Rows[index].Cells[0].Value = line;
                if (isPrime(int.Parse(line)))
                {
                    // dataGridView1.Rows[index].Cells[1].Value = "是";
                    checkedListBox1.SetItemChecked(index, true);
                }
                else
                {
                    // dataGridView1.Rows[index].Cells[1].Value = "否";
                    checkedListBox1.SetItemChecked(index, false);
                }

                line = inputData.ReadLine();
                index++;
            }
        }

        public void BuildPrimeList(int limit)
        {
            bool[] is_prime = new bool[limit+1];
            for (int i = 0; i < limit+1; i++)
                is_prime[i] = true;
            is_prime[0] = false;
            is_prime[1] = false;
            for(int i = 0; i < limit + 1; i++)
            {
                if (is_prime[i])
                {
                    for(int j = 2*i; j < limit; j+=i)
                    {
                        is_prime[j] = false;
                    }
                }
            }
            prime = is_prime.ToList<bool>();
        }

        public bool isPrime(int num) 
        {
            return prime[num];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
