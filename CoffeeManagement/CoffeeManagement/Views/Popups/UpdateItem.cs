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
namespace CoffeeManagement.Views.Popups
{
    public partial class UpdateItem : Form
    {
        public UpdateItem(int itemId)
        {
            InitializeComponent();
            // Item item = new ItemBO().getItemById(itemId);
            //this.itemNameTB.Text = item.Name;
            // ...
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (MessageHelper.CreateYesNoQuestion("Bạn chắc chắn muốn thoát mà không lưu?") == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            // Item item = new Item(......);
            // new ItemBO().updateItem(item);
        }
    }
}
