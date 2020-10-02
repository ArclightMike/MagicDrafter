using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net;

namespace MagicDrafter
{
    /// <summary>
    /// The Drafter class.
    /// Contains all methods for functionality of the draft.
    /// </summary>
    class Drafter
    {
        #region Public
        /// <summary>
        /// The Random method.
        /// Picks a random card in the pack.
        /// </summary>
        /// <param name="Booster">Pack of cards.</param>
        public void Random(Pack Booster)
        {
            
            if (Booster.Cards.Count(card => (card.Enabled == false)) > 0)
            {
                foreach (var card in Booster.Cards)
                {
                    card.Enabled = true;
                }
            }

            int CardsLeft = Booster.Cards.Count(card => card.Visible);
            if (CardsLeft > 0)
            {
                Random Rand = new Random();
                int RolledNumber = Rand.Next(1, 16);
                while (Booster.Cards.Find(card => (Convert.ToInt32(card.Name) == RolledNumber)).Visible == false)
                {
                    RolledNumber = Rand.Next(1, 16);
                }
                SetRandomCardProperties(Booster, RolledNumber);
            }
        }

        /// <summary>
        /// The Select method.
        /// Tags a card for selection on first click, removes the card
        /// from the table after second click.
        /// </summary>
        /// <param name="Card">The button representation of the card selected.</param>
        public void Select(Button Card)
        {
            if ((Card.Tag == null) || (Card.Tag.ToString() == ""))
            {
                //Clear the selection tag from all other cards.
                foreach (Control control in Card.Parent.Controls.Cast<Control>())
                {
                    control.Tag = "";
                }
                //Add selection tag for this card.
                Card.Tag = "Selected";
                Card.BackColor = Color.Blue;
            }
            //Card was selected, so second click confirms the pick.
            else if (Card.Tag.ToString().Contains("Selected"))
            {
                Card.Visible = false;
                foreach (Control control in Card.Parent.Controls.Cast<Control>())
                {
                    control.Tag = "";
                    control.BackColor = Color.Black;
                }
            }
        }
        #endregion Public

        #region Private
        /// <summary>
        /// The SetRandomCardProperties method.
        /// Adjust visual properties of the card button after a random pick.
        /// </summary>
        /// <param name="Booster">Pack of cards.</param>
        /// <param name="RolledNumber">The random number rolled.</param>
        private void SetRandomCardProperties(Pack Booster, int RolledNumber)
        {
            try //Better to compare on Int, but conversion from Tag could fail.
            {
                Booster.Cards.Find(card => (Convert.ToInt32(card.Name) == RolledNumber)).BackColor = Color.Red;
            }
            catch(System.FormatException) //If it fails, try matching on string.
            {
                Booster.Cards.Find(card => (card.Name.ToString() == RolledNumber.ToString())).BackColor = Color.Red;
            }
        }
        #endregion Private
    }
}
