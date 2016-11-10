using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeManagement.Utilities;
using CoffeeManagement.DTOs;

namespace CoffeeManagement.Views.Popups
{
    public partial class JoinTable : Form
    {
        Bill _bill;
        List<Table> _tables;
        public JoinTable(Bill currentBill, List<Table> tables)
        {
            InitializeComponent();
            _bill = currentBill;
            _tables = tables;
            try
            {
                this.tableListTB.Text = string.Join(";", _bill.Tables.Select(t => t.Name));
            }
            catch (NullReferenceException e)
            {
                MessageHelper.CreateErrorMessage("Dữ liệu bàn chưa có!");
                //DialogResult = DialogResult.Abort;
                this.Close();
                return;
            }
            

            foreach (Table t in _tables)
            {
                this.newTableCB.Items.Add(t.Name);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (MessageHelper.CreateYesNoQuestion("Bạn thực sự muốn gộp bàn?") == DialogResult.Yes)
            {
                // Do joining Table List, Bill Data.
                MessageHelper.CreateMessage("Chức năng đang xây dựng");
            }
        }
    }
}
