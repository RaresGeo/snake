using System.Collections;
using System.Windows.Forms;

namespace Snake
{
    class playerInput
    {
        private static Hashtable keyTable = new Hashtable();

        public static bool keyPressed(Keys key)
        {
            if (keyTable[key] == null)
                return false;
            else return (bool)keyTable[key];
        }

        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }

    }
}
