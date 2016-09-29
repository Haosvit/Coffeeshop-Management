using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeManagement.DTOs;
using CoffeeManagement.BO;

namespace CoffeeManagement.Views.Popups
{
    public partial class DeleteItem : Form
    {
        private int thisItemId;
        public DeleteItem(int itemId)
        {
            InitializeComponent();
            thisItemId = itemId;
            //Item chosenItem = new ItemBO().getItemById(itemId);
            //this.messageLB.Text = "Bạn có chắc chắn xóa " + chosenItem.Name + " không?";
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            //new ItemBO().setDeletedById(thisItemId);
            this.DialogResult = DialogResult.Yes;
        }
    }
}
