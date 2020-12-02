using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.ListView.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SfComboBox_sample
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            sfComboBox1.DataSource = GetTable();
            //Bind the Display member and Value member to the data source
            sfComboBox1.DisplayMember = "Patient";
            sfComboBox1.ValueMember = "Drug";

            foreach (var selectedItems in this.sfComboBox1.DropDownListView.View.Items.ToList())
            {
                //Programmatically add the checked items
                this.sfComboBox1.DropDownListView.CheckedItems.Add(selectedItems);
            }
        }
        private DataTable GetTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Dosage", typeof(int));
            table.Columns.Add("Drug", typeof(string));
            table.Columns.Add("Patient", typeof(string));

            // Here we add five DataRows.
            table.Rows.Add(25, "Indocin", "David");
            table.Rows.Add(50, "Enebrel", "Sam");
            table.Rows.Add(10, "Hydralazine", "Christoff");
            table.Rows.Add(21, "Combivent", "Janet");
            table.Rows.Add(100, "Dilantin", "Melanie");
            return table;    
        }
    }
}
