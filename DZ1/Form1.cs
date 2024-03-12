using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace DZ1
{
    enum RowState
    {
        Exited,
        New,
        Modifided,
        ModifidedNew,
        Deleted
    }
    public partial class Form1 : Form
    {
        //подключение класса
        DataBase database = new DataBase();

        int selectedRow;
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id_contact", "id");
            dataGridView1.Columns.Add("name_contact", "Имя");
            dataGridView1.Columns.Add("phone_contact", "Номер телефона");
            dataGridView1.Columns.Add("isNew", String.Empty);
        }

        //метод для очищения textbox
        private void ClearFields () 
        {
            idTB.Text = "";
            nameTB.Text = "";
            phoneTB.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt64(2), RowState.ModifidedNew);
        }

        //метод для обновления dataGridView1
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querryString = $"select * from contact";

            NpgsqlCommand comm = new NpgsqlCommand(querryString, database.getConnection());

            database.openConnection();

            NpgsqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        //вывод информации из dataGridView1 в textbox'ы
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                idTB.Text = row.Cells[0].Value.ToString();
                nameTB.Text = row.Cells[1].Value.ToString();
                phoneTB.Text = row.Cells[2].Value.ToString();
            }
        }
        private void addBut_Click(object sender, EventArgs e)
        {
            addForm addform = new addForm();
            addform.Show();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        //обновление datagrid
        private void uptBut_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        //метод для поиска
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from contact where concat (name_contact, phone) like '%" + textBox1.Text + "%'";

            NpgsqlCommand comm = new NpgsqlCommand(searchString, database.getConnection());

            database.openConnection();

            NpgsqlDataReader read = comm.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        //метод для удаления
        private void deleteRow () {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[3].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[3].Value = RowState.Deleted;
        }
        private void deleteBut_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }
        //метод для проверки RowState
        private void Update ()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[3].Value;   

                if (rowState == RowState.Exited)
                continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from contact where id_contact = {id}";

                    var comm = new NpgsqlCommand(deleteQuery, database.getConnection());
                    comm.ExecuteNonQuery();
                    
                }

                if (rowState == RowState.Modifided)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var phone = dataGridView1.Rows[index].Cells[2].Value.ToString();

                    var changeQuery = $"update contact set name_contact = '{name}', phone = '{phone}' where id_contact = '{id}'";

                    var comm = new NpgsqlCommand(changeQuery, database.getConnection());
                    comm.ExecuteNonQuery();
                }
                
            }
            database.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Edit()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = idTB.Text;
            var name = nameTB.Text;
            var phone = phoneTB.Text;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(id, name, phone);
                dataGridView1.Rows[selectedRowIndex].Cells[3].Value = RowState.Modifided;
            }

        } 
        private void editBut_Click(object sender, EventArgs e)
        {
            Edit();
            ClearFields();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
