using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace CityGym
{
    public partial class members : UserControl
    {
      
        public members()
        {
            InitializeComponent();
        }

        public string location = "C:\\Users\\mufassirmughal\\Downloads\\memberdata.csv";
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        public string fileName;
        private void button3_Click(object sender, EventArgs e)
        {
            Stream fileStream = null;

            if (openFileDialog1.ShowDialog() == DialogResult.OK && (fileStream = openFileDialog1.OpenFile()) != null)
            {
                fileName = openFileDialog1.FileName;
                txt_open.Text = fileName;
                using (fileStream)
                {
                    dataGridView1.DataSource = Helper.DataTableFromTextFile(fileName, ',');
                    int count = dataGridView1.ColumnCount;
                    if (count < 8)
                    {
                        dataGridView1.DataSource = null;
                        MessageBox.Show("Please select table with max 8 columns");
                    }
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txt_id_u.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_memberID_u.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txt_name_u.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txt_amount_u.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txt_service_u.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txt_date_u.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void members_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (fileName == null)
            {
                MessageBox.Show("Please first load the file");
            }
            if(
                string.IsNullOrWhiteSpace(txt_id.Text)
                || string.IsNullOrWhiteSpace(txt_memberID.Text)
                || string.IsNullOrWhiteSpace(txt_name.Text)
                || string.IsNullOrWhiteSpace(txt_fname.Text)
                || combo_services.SelectedItem == null
                || string.IsNullOrWhiteSpace(txt_fee.Text)
                || combo_gender.SelectedItem == null
                )
            {
                MessageBox.Show("Please fill all fields..");
            }

            else
            {
                if (!File.Exists(fileName))
                {

                    string header = "ID" + "," + "MembershipID" + "," + "Name" + "," + "FatherName" + "," + "Service" + "," + "Fee" + "," + "Gender" + "," + "Date" + Environment.NewLine;
                    File.WriteAllText(fileName, header);

                }
                string data = Environment.NewLine + txt_id.Text.ToString() + "," + txt_memberID.Text.ToString() + "," + txt_name.Text.ToString() + "," + txt_fname.Text.ToString() + "," + combo_services.SelectedItem.ToString() + "," + txt_fee.Text.ToString() + "," + combo_gender.SelectedItem.ToString() + "," + DateTime.Today.ToString("dd/MM/yyyy");
                File.AppendAllText(fileName, data);
                dataGridView1.DataSource = Helper.DataTableFromTextFile(fileName, ',');
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
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

                lines.RemoveAll(l => l.Contains(txt_id_u.Text.ToString()));
                file.Close();

                using (System.IO.StreamWriter outfile = new System.IO.StreamWriter(fileName))
                {
                    outfile.Write(String.Join(System.Environment.NewLine, lines.ToArray()));
                }

                string data = Environment.NewLine + txt_id_u.Text.ToString() + "," + txt_memberID_u.Text.ToString() + "," + txt_name_u.Text.ToString() + "," + dataGridView1.SelectedRows[0].Cells[3].Value.ToString() + "," + txt_service_u.Text.ToString() + "," + txt_amount_u.Text.ToString() + "," + dataGridView1.SelectedRows[0].Cells[6].Value.ToString() + "," + txt_date_u.Text.ToString();
                File.AppendAllText(fileName, data);

                dataGridView1.DataSource = Helper.DataTableFromTextFile(fileName, ',');
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
            
            
    }

        private void button4_Click(object sender, EventArgs e)
        {
            if (fileName == null)
            {
                MessageBox.Show("Please first load the file");
            }
            else
            {
                dataGridView1.DataSource = Helper.DataTableFromTextFile(fileName, ',');


                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("MembershipID LIKE '%{0}%'", txt_id_search.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (fileName == null)
            {
                MessageBox.Show("Please first load the file");
            }
            else
            {
                dataGridView1.DataSource = Helper.DataTableFromTextFile(fileName, ',');


                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", txt_name_search.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (fileName == null)
            {
                MessageBox.Show("Please first load the file");
            }
            else
            {
                dataGridView1.DataSource = Helper.DataTableFromTextFile(fileName, ',');


                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("FatherName LIKE '%{0}%'", txt_fname_search.Text);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_open.Text))
            {

                MessageBox.Show("Please first enter file location");
            }
            else
            {
                fileName = txt_open.Text.ToString();
                dataGridView1.DataSource = Helper.DataTableFromTextFile(fileName, ',');
                int count = dataGridView1.ColumnCount;
                if (count < 8)
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("Please select table with max 8 columns");
                }
            }
        }

        private void txt_open_TextChanged(object sender, EventArgs e)
        {

        }

        private void combo_services_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
