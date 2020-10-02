using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicDrafter
{
    /// <summary>
    /// The Pack class.
    /// Definition of the card buttons.
    /// </summary>
    public class Pack
    {
        public string CardSet = ""; //Card set this pack is from.  For future use.
        public List<Button> Cards = new List<Button>(); //Cards in this pack.
    }
}
