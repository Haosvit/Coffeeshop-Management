using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement.WinformControls
{
    public class HintTextBox : TextBox
    {

        private string _hint = "Type here";
        /// <summary>
        /// Gets or sets hint for textbox
        /// </summary>
        public string Hint
        {
            get { return _hint; }
            set { 
                _hint = value;
                if (!string.IsNullOrEmpty(value)) 
                {
                    Text = value;
                }
            }
        }

        // save password char
        private char _passwordChar = '\0';

        private bool _isPasswordField;
        public bool IsPasswordField
        {
            get { return _isPasswordField; }
            set
            {
                _isPasswordField = value;

                if (value)
                {
                    if (PasswordChar == '\0')
                    {
                        PasswordChar = '*';
                    }
                    _passwordChar = PasswordChar;
                }
            }
        }
        
        /// <summary>
        /// Whether watermark effect is enabled or not
        /// </summary>
        private bool _watermarkActive = true;
        /// <summary>
        /// Gets or Sets whether watermark effect is enabled or not
        /// </summary>
        public bool WatermarkActive
        {
            get { return _watermarkActive; }
            set { _watermarkActive = value; }
        }

        /// <summary>
        /// Create a new TextBox that supports watermak hint
        /// </summary>
        public HintTextBox()
        {
            this._watermarkActive = true;
            this.Text = _hint;
            this.ForeColor = Color.Gray;

            GotFocus += (source, e) =>
            {
                RemoveWatermak();
            };

            LostFocus += (source, e) =>
            {
                ApplyWatermark();
            };

        }

        /// <summary>
        /// Remove watermark from the textbox
        /// </summary>
        public void RemoveWatermak()
        {
            if (this._watermarkActive)
            {
                this._watermarkActive = false;
                this.Text = "";
                this.ForeColor = Color.Black;

                if (IsPasswordField)
                {
                    PasswordChar = _passwordChar;
                }
            }
        }

        /// <summary>
        /// Applywatermak immediately
        /// </summary>
        public void ApplyWatermark()
        {
            if (!this._watermarkActive && string.IsNullOrEmpty(this.Text)
                || ForeColor == Color.Gray)
            {
                this._watermarkActive = true;
                this.Text = _hint;
                this.ForeColor = Color.Gray;

                if (IsPasswordField)
                {
                    this.PasswordChar = '\0';
                }
            }
        }

        /// <summary>
        /// Apply watermak to the textbox. 
        /// </summary>
        /// <param name="newText">Text to apply</param>
        public void ApplyWatermark(string newText)
        {
            Hint = newText;
            ApplyWatermark();
        }

    }
}
