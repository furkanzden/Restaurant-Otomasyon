using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurkanOzden_221103052.Class
{
    internal class AlertShowing
    {
        public enum MessageType
        {
            Success,
            Warning,
            Danger,
            Default
        }

        public void ShowAlert(MessageType type = MessageType.Default, string headerText = "", string alertText = "")
        {
            Alert alert = new Alert(type.ToString(), headerText, alertText);
            BackGroundBlur.BlurBackground(alert);

        }

        public DialogResult ShowDialogAlert(string message)
        {
            DialogAlert alert = new DialogAlert(message);
            DialogResult result = BackGroundBlur.BlurBackground(alert);
            return result;
        }
    }
}
