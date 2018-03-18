using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba5_SQLDB_
{
    public partial class Form1 : Form
    {
        Rabot WorkersForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.groupBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sQLDataBaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQLDataBaseDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.sQLDataBaseDataSet.Workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQLDataBaseDataSet.Info". При необходимости она может быть перемещена или удалена.
            this.infoTableAdapter.Fill(this.sQLDataBaseDataSet.Info);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQLDataBaseDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.sQLDataBaseDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQLDataBaseDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.sQLDataBaseDataSet.Group);
            

        }

        private void infoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkersForm = new Rabot();
            WorkersForm.ShowDialog();
            WorkersForm.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(this.clientsTableAdapter.CountOfClinets(groupDataGridView.CurrentRow.Index));
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQLDataBaseDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.sQLDataBaseDataSet.Workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQLDataBaseDataSet.Info". При необходимости она может быть перемещена или удалена.
            this.infoTableAdapter.Fill(this.sQLDataBaseDataSet.Info);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQLDataBaseDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.sQLDataBaseDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQLDataBaseDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.sQLDataBaseDataSet.Group);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            clientsBindingSource.Filter = "FIO = '" + textBox2.Text + "'";
        }
    }
}
