using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Shortcut
{
    public partial class NotionForm : Form
    {
        public NotionForm()
        {
            InitializeComponent();
            this.Load += NotionForm_Load;
        }

        private void NotionForm_Load(object sender, EventArgs e)
        {
            try
            {
                notionDataView_Load();
                notionDataView_Design();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void notionDataView_Load()
        {
            string connStr = "Server=localhost;Port=3306;Database=shortcut;Uid=root;Pwd=938002;";
            string query;
            MySqlConnection connection = new MySqlConnection(connStr);
            try
            {
                connection.Open();
                query = "select *from notion";
                MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void notionDataView_Design()
        {
            try
            {
                dataGridView.AutoGenerateColumns = true;
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                this.dataGridView.EditMode = DataGridViewEditMode.EditOnEnter;

                dataGridView.BorderStyle = BorderStyle.None;
                dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dataGridView.DefaultCellStyle.Font = new Font("KopubWorld돋움체", 11, FontStyle.Bold);
                dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
                dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                dataGridView.BackgroundColor = Color.White;

                dataGridView.EnableHeadersVisualStyles = false;
                dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("KopubWorld돋움체", 11, FontStyle.Bold);
                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 50, 72);
                dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 50, 72);
                dataGridView.RowHeadersDefaultCellStyle.Font = new Font("KopubWorld돋움체", 11, FontStyle.Bold);
                dataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
