using FurkanOzden_221103052.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FurkanOzden_221103052.Class
{
    public class BackGroundBlur
    {
        

        public static DialogResult BlurBackground(Form Model)
        {
            Form Background = new Form();
            using (Model)
            {
                Background.StartPosition = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.5d;
                Background.BackColor = System.Drawing.Color.Black;
                Background.Size = FormMain.Instance.Size;
                Background.Location = FormMain.Instance.Location;
                Background.ShowInTaskbar = false;
                Background.Show();
                Model.Owner = Background;
                Model.ShowDialog(Background);
                Background.Dispose();
                return Model.DialogResult;
            }
        }

        









    }
}
