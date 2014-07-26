using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prov.lib
{
    public class BindData
    {
        public UIElement textMessage { get; set; }
        public void Button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("click");
            this.textMessage.Text = "new new message c#";
        }
    }
}
