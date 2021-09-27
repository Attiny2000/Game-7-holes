using System.Windows.Forms;

namespace _7_holes
{
    class NoSelectButton : Button
    {

        public NoSelectButton()
        {

            SetStyle(ControlStyles.Selectable, false);

        }
    }
}
