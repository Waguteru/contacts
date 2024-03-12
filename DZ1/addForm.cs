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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DZ1
{
    public partial class addForm : Form
    {
       DataBase database = new DataBase();
        public addForm()
        {
            InitializeComponent();
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }
 
        //добавление в бд
        private void saveBut_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var name = nameTB.Text;
            var phone = phoneTB.Text;

            var addQuery = $"insert into contact (name_contact, phone) values ('{name}', '{phone}')";
            var comm = new NpgsqlCommand(addQuery, database.getConnection());

            if (checkuser())
                return;

            comm.ExecuteNonQuery();

            MessageBox.Show("Контакт добавлен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            database.closeConnection();
            Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
        //только цифры в phoneTB
        private void phoneTB_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(phoneTB.Text, "[^0-9]"))
            {
                MessageBox.Show("Вводите только цифры!");
                phoneTB.Text = phoneTB.Text.Remove(phoneTB.Text.Length - 1);
            }
        }

        private Boolean checkuser()
        {
            var name_contact = nameTB.Text;
            var phone = phoneTB.Text;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_contact, name_contact, phone from contact where name_contact = '{name_contact}' and phone = '{phone}'";

            NpgsqlCommand command = new NpgsqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("номер уже существует!");
                return true;
            }
            else
            {
                return false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearBut_Click(object sender, EventArgs e)
        {
            nameTB.Text = "";
            phoneTB.Text = "";
        }
    }
}
