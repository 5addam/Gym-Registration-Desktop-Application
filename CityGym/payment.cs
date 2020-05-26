using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace CityGym
{
    public partial class payment : UserControl
    {
        public payment()
        {
            InitializeComponent();
            
        }
        public string location = "C:\\Users\\mufassirmughal\\Downloads\\feepaymentdata.csv";
        private void button1_Click(object sender, EventArgs e)
        {
            if (fileName == null)
            {
                MessageBox.Show("Please First load the file..");
            }
            if(
                string.IsNullOrWhiteSpace(txt_id.Text)
                || string.IsNullOrWhiteSpace(txt_pID.Text)
                || string.IsNullOrWhiteSpace(txt_amount.Text)
                || string.IsNullOrWhiteSpace(txt_date.Text)
                || string.IsNullOrWhiteSpace(txt_active.Text)
                )
            {
                MessageBox.Show("Please fill all fileds..");
            }
            else
            {
                if (!File.Exists(fileName))
                {

                    string header = "FeePaymentID" + "," + "MembershipID" + "," + "Date" + "," + "Amount" + "," + "Active" + Environment.NewLine;
                    File.WriteAllText(fileName, header);

                }

                string info = Environment.NewLine + txt_pID.Text.ToString() + "," + txt_id.Text.ToString() + "," + txt_date.Text.ToString() + "," + txt_amount.Text.ToString() + "," + txt_active.Text.ToString();
                File.AppendAllText(fileName, info);

                dataGridView1.DataSource = Helper.DataTableFromTextFile(fileName, ',');
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public string fileName;
        private void button3_Click(object sender, EventArgs e)
        {
            Stream fileStream = null;

            if (openFileDialog1.ShowDialog() == DialogResult.OK && (fileStream = openFileDialog1.OpenFile()) != null)
            {
                fileName = openFileDialog1.FileName;

                txt_open.Text = fileName.ToString();
                using (fileStream)
                {

                    dataGridView1.DataSource = Helper.DataTableFromTextFile(fileName, ',');
                    int count = dataGridView1.ColumnCount;
                    if (count > 5)
                    {
                        dataGridView1.DataSource = null;
                        MessageBox.Show("Please select a table with 5 columns only");
                    }
                }
            }


        }

        private void dataGridView1_TabIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txt_pID_u.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_ID_u.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txt_date_u.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
           txt_amount_u.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
           txt_active_u.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fileName == null)
            {
                MessageBox.Show("Please First load the file..");
            }
            else
            {

                dataGridView1.DataSource = Helper.DataTableFromTextFile(fileName, ',');


                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("MembershipID LIKE '%{0}%'", txt_search_id.Text);
            }
        }

        private void txt_open_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_open.Text))
            {
                MessageBox.Show("Please first enter file location");
            }
            else
            {
                fileName = txt_open.Text.ToString();
                dataGridView1.DataSource = Helper.DataTableFromTextFile(fileName, ',');
                int count = dataGridView1.ColumnCount;
                if (count > 5)
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("Please select a table with 5 columns only");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (fileName == null)
            {
                MessageBox.Show("Please first load the file");
            }
            else
            {

                List<String> lines = new List<string>();
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(fileName);

                while ((line = file.ReadLine()) != null)
                {
                    lines.Add(line);
                }

                lines.RemoveAll(l => l.Contains(txt_pID_u.Text.ToString()));
                file.Close();

                using (System.IO.StreamWriter outfile = new System.IO.StreamWriter(fileName))
                {
                    outfile.Write(String.Join(System.Environment.NewLine, lines.ToArray()));
                }

                string data = Environment.NewLine + txt_pID_u.Text.ToString() + "," + txt_ID_u.Text.ToString() + "," + txt_date_u.Text.ToString() + "," + txt_amount_u.Text.ToString() + "," + txt_active_u.Text.ToString();
                File.AppendAllText(fileName, data);

                dataGridView1.DataSource = Helper.DataTableFromTextFile(fileName, ',');
            }
        }
    }
}
