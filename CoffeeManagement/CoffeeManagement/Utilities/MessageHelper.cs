﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement.Utilities
{
    public static class MessageHelper
    {
        public static DialogResult CreateYesNoQuestion(string question) {
            return MessageBox.Show(question, AppConstants.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult CreateErrorMessage(string message)
        {
            return MessageBox.Show(message, AppConstants.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
