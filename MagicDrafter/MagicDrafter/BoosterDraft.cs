using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicDrafter
{
    /// <summary>
    /// The BoosterDraft class.
    /// Class behind the main form.
    /// </summary>
    public partial class BoosterDraft : Form
    {
        private Pack Booster = new Pack();

        /// <summary>
        /// The BoosterDraft method.
        /// Initializer.
        /// </summary>
        public BoosterDraft()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The BoosterDraft_Load method.
        /// Method for form load.
        /// </summary>
        /// <param name="pnlTable">The panel on the calling form the card buttons will be added to.</param>
        /// <param name="sender">object sender</param>
        /// <param name="e">EventArgs</param>
        private void BoosterDraft_Load(object sender, EventArgs e)
        {
            #region Set Panel Size
            //Set the panel size to match the card width of a five card row.
            //Max of 3 rows as there can only be 15 cards.
            CardProperties CardProps = new CardProperties();
            pnlTable.Width = ((CardProps.CardWidth * 5) + 25);
            pnlTable.Height = ((CardProps.CardHeight * 3 + 50));
            #endregion

            #region Set Form Size
            //Set the form size relative to the panel size.
            this.Width = pnlTable.Width + 35;
            this.Height = pnlTable.Height + 135;
            #endregion

            tsbRandom.Visible = false;
            tslInstructions.Text = "Click New Draft to begin.";
        }

        /// <summary>
        /// The tsbNewDraft_Click method.
        /// Method for clicking the New Draft button.
        /// </summary>
        /// <param name="pnlTable">The panel on the calling form the card buttons will be added to.</param>
        /// <param name="sender">object sender</param>
        /// <param name="e">EventArgs</param>
        private void tsbNewDraft_Click(object sender, EventArgs e)
        {
            //Open the pack on the "table".
            tbWelcome.Visible = false;
            PackOpener Table = new PackOpener();
            Booster = Table.OpenPack(pnlTable, tspbProgress, tslInstructions);
            tsbRandom.Visible = true;
        }

        /// <summary>
        /// The tsbRandom_Click method.
        /// Method for clicking the Random Pick button.
        /// </summary>
        /// <param name="pnlTable">The panel on the calling form the card buttons will be added to.</param>
        /// <param name="sender">object sender</param>
        /// <param name="e">EventArgs</param>
        private void tsbRandom_Click(object sender, EventArgs e)
        {
            Drafter Drafter = new Drafter();
            Drafter.Random(Booster);
        }
    }
}
