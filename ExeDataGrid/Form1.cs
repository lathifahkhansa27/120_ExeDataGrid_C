using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeDataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

            // datagridView1.ColumnDefaultCellStyle.Font 

            dataGridView1.Columns[0].DefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dataGridView1.Columns[1].DefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dataGridView1.Columns[2].DefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dataGridView1.Columns[3].DefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dataGridView1.Columns[4].DefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dataGridView1.Columns[5].DefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);



            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Purple ;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.BlueViolet;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.DarkGreen;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.DeepPink;
            dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Brown;
            dataGridView1.Columns[5].DefaultCellStyle.ForeColor = Color.Olive;



            dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.Pink;
            dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.Orange;
            dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.DarkGreen;
            dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.Maroon;
            dataGridView1.Columns[5].DefaultCellStyle.SelectionBackColor = Color.Chocolate;


            // datagridView1.ColumnsHaedersDefaultCellStyle.Aligment

            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
















        }
    }
}
