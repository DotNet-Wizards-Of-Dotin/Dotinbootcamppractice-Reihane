using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventExample.CustomButton
{

    public class MyButton : Button
    {
        /// <summary>
        /// قبل از کلیک
        /// </summary>
        public event EventHandler BeforeClick;

        /// <summary>
        /// بعد از کلیک
        /// </summary>
        public event EventHandler AfterClick;

        public bool Condition { get; set; }

        public MyButton()
        {
            this.BackColor = Color.GreenYellow;
            this.Click += MyButton_Click;
        }

        public void OnBeforeClick(object sender, EventArgs e)
        {
            //if (BeforeClick != null)
            //{
            //    BeforeClick(sender, e);
            //}
            BeforeClick?.Invoke(sender, e);

        }

        public void OnAfterClick(object sender, EventArgs e)
        {
            //if (AfterClick != null)
            //{
            //    AfterClick(sender, e);
            //}
            if (Condition)
                AfterClick?.Invoke(sender, e);
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            OnBeforeClick(sender, e);
            OnAfterClick(sender, e);
        }
    }
}