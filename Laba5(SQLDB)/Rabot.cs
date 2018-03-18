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
    public partial class Rabot : Form
    {
        public Rabot()
        {
            InitializeComponent();
        }

        private void workersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sQLDataBaseDataSet);

        }

        private void Rabot_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQLDataBaseDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.sQLDataBaseDataSet.Workers);

        }
    }
}
