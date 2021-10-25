using System.Windows.Forms;

namespace _7_holes
{
    public class Hole {
        public Button button;
        public string color;
        public bool isEmpty = true;

        public Hole(Button button)
        {
            this.button = button;
            color = "No color";
        }

        public Hole(Button button, string color)
        {
            this.button = button;
            this.color = color;
            this.isEmpty = false;
        }
    }
}
