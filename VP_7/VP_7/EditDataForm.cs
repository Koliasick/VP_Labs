using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_7
{
    public partial class EditDataForm : Form
    {
        private bool _editingNewRow;

        public EditDataForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            videoTapeBindingSource.Clear();
            var dataList = Program.GetTapes();
            foreach (var dataEntry in dataList) 
            {
                videoTapeBindingSource.Add(dataEntry);
            }
            dataGridView1.DataSource = videoTapeBindingSource;
            UpdateList();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            authorBindingSource.Clear();
            var dataList = Program.GetAuthors();
            foreach (var dataEntry in dataList)
            {
                authorBindingSource.Add(dataEntry);
            }
            dataGridView1.DataSource = authorBindingSource;
            UpdateList();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            agencyBindingSource.Clear();
            var dataList = Program.GetAgencies();
            foreach (var dataEntry in dataList)
            {
                agencyBindingSource.Add(dataEntry);
            }
            dataGridView1.DataSource = agencyBindingSource;
            UpdateList();
        }

        private void UpdateList() 
        {
            dataGridView1.Columns.GetFirstColumn(DataGridViewElementStates.None).ReadOnly = true;
        }

        private void EditDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.SaveChanges();
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            _editingNewRow = true;
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var deletedRow = e.Row;
            Program.Delete(deletedRow.DataBoundItem);
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (_editingNewRow) 
            {
                var addedRow = dataGridView1.Rows[e.RowIndex];
                if (dataGridView1.DataSource == videoTapeBindingSource)
                {
                    var dataEntry = (VideoTape)addedRow.DataBoundItem;
                    Program.AddTape(dataEntry);
                }
                else if (dataGridView1.DataSource == authorBindingSource)
                {
                    var dataEntry = (Author)addedRow.DataBoundItem;
                    Program.AddAuthor(dataEntry);
                }
                else
                {
                    var dataEntry = (Agency)addedRow.DataBoundItem;
                    Program.AddAgency(dataEntry);
                }
            }
            _editingNewRow = false;
        }
    }
}
