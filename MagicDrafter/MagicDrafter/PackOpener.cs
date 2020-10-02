using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicDrafter
{
    /// <summary>
    /// The PackOpener class.
    /// Contains all methods for "opening the pack".
    /// Sets up the panel with buttons, and assigns card images
    /// to those buttons.
    /// </summary>
    class PackOpener
    {
        #region Public

        /// <summary>
        /// The OpenPack method.
        /// Primary method for opening the pack.
        /// //Open the pack, set up the cards as buttons, add the card to the opened booster.
        /// </summary>
        /// <param name="pnlTable">The panel on the calling form the card buttons will be added to.</param>
        /// <param name="ShowProgress">The progress bar on the calling form.</param>
        /// <param name="DraftStatus">The status label on the calling form.</param>
        public Pack OpenPack(Panel pnlTable, ToolStripProgressBar ShowProgress, ToolStripLabel DraftStatus)
        {
            Pack Booster = new Pack();
            try
            {
                pnlTable.Controls.Clear();
                pnlTable.Visible = true;

                Button LastButton = null;
                int PanelRightMargin = pnlTable.Right; //Set the begin margin.

                #region Set Up Progress Bar
                ShowProgress.Step = 1;
                ShowProgress.Maximum = 14;
                ShowProgress.Visible = true;
                DraftStatus.Text = "Opening Pack";
                #endregion Set Up Progress Bar

                CreateCards(pnlTable, ShowProgress, LastButton, Booster, DraftStatus); //TODO: Make this threaded.

                #region Clean Up Progress Bar
                ShowProgress.Visible = false;
                ShowProgress.Value = 0;
                DraftStatus.Text = "Click a card twice to select it.  Click Random Pick to randomly pick a card.";
                #endregion Clean Up Progress Bar
            }
            catch(WebException e) //The web call for the card image probably failed.
            {
                DraftStatus.Text = e.Message;
                ShowProgress.Visible = false;
                MessageBox.Show(e.Message + " Check your Internet connection and try again.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Booster;
        }

        #endregion Public

        #region Private
        /// <summary>
        /// The CreateCards method.
        /// Creates card buttons.
        /// </summary>
        /// <param name="pnlTable">The panel on the calling form the card buttons will be added to.</param>
        /// <param name="ShowProgress">The progress bar on the calling form.</param>
        /// <param name="Booster">Pack of cards.</param>
        private void CreateCards(Panel pnlTable, ToolStripProgressBar ShowProgress, Button LastButton, Pack Booster, ToolStripLabel DraftStatus)
        {
                for (int card = 1; card <= 15; card++)
                {
                    ShowProgress.PerformStep(); //Show the progress

                    #region Card Property Setup
                    //The cards are buttons on the panel. Set the button properties to match the card properties.
                    CardProperties CardProps = new CardProperties();
                    Button btnCard = new Button();
                    btnCard.Name = card.ToString();
                    btnCard.Width = CardProps.CardWidth;
                    btnCard.Height = CardProps.CardHeight;
                    btnCard.Click += Card_Click;
                    btnCard.Text = card.ToString();
                    btnCard.BackColor = Color.Black;
                    btnCard.Image = CardArt();
                    #endregion

                    #region Set Card Position
                    if (card == 1)
                    {
                        btnCard.Left = pnlTable.Left;
                        btnCard.Top = pnlTable.Top;
                    }
                    else
                    {
                        btnCard.Left = LastButton.Right + 5;

                        if (btnCard.Left > (pnlTable.Right - 5))
                        {
                            btnCard.Left = pnlTable.Left;
                            btnCard.Top = LastButton.Bottom + 5;
                        }
                        else
                        {
                            btnCard.Top = LastButton.Top;
                        }
                    }
                    #endregion

                    #region Add Card
                    pnlTable.Controls.Add(btnCard); //Add the button to the panel.
                    LastButton = btnCard; //Set the last button so we know where to begin on the next one.
                    Booster.Cards.Add(btnCard); //Add the card to the opened booster.
                    #endregion
                }
        }

        /// <summary>
        /// The Card_Click method.
        /// Click even for card buttons.
        /// This has to be here as we have added the buttons dynamically, and we need to define their click functionality.
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">EventArgs</param>
        private void Card_Click(object sender, EventArgs e)
        {
            Button card = (Button)sender; //Get the button we are on.
            Drafter Draft = new Drafter();
            Draft.Select(card);
        }

        /// <summary>
        /// The CardArt method.
        /// Gets card art a card button.
        /// </summary>
        private Image CardArt()
        {
            Image Image = null;

            try
            {
                //Get a random card image from scryfall.
                //TODO: Fix the random image retrievel to get 1 rare, 3 uncommon, 10 common, and 1 land.
                var request = WebRequest.Create("https://api.scryfall.com/cards/random?format=image&version=small&q=e:znr%20is:booster");

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    Image = Image.FromStream(stream);
                }
            }
            catch(WebException e)
            {
                throw new System.Net.WebException("Could not reach api.scryfall.com for card images.", e);
            }

            return Image;
        }
        #endregion Private
    }
}
