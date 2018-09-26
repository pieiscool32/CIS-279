using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TexasHoldEm
{
    class Window
    {
        public static void SetTelemetry(GameForm form, int _player)
        {
            if (form.round.playerHand != null)
            {
                //player's hand cards
                form.setImage(form.container[_player].cards[0], form.cards[form.round.playerHand[_player].handCards[0] - 1]);
                form.setImage(form.container[_player].cards[1], form.cards[form.round.playerHand[_player].handCards[1] - 1]);
            }
            //other info for the player
            form.setInfo(form.container[_player].right[0], form.round.player[_player].name);
            form.setInfo(form.container[_player].right[1], $"Odds: {form.round.player[_player].winOdds * 100}%");
            form.setInfo(form.container[_player].right[2], $"Score: {form.round.player[_player].bestScore}");
            form.setInfo(form.container[_player].right[3], $"{form.round.player[_player].handType}");
            form.setInfo(form.container[_player].right[4], $"Hand: {form.round.player[_player].numCombos}");
            form.setInfo(form.container[_player].right[5], $"Combos: {form.round.player[_player].numOtherCombos}");
            form.setInfo(form.container[_player].left[0], $"Money: ${form.round.money[_player]}");
            form.setInfo(form.container[_player].left[1], $"Other Score: {form.round.player[_player].bestOtherScore}");
            form.setInfo(form.container[_player].left[2], $"Other Avg: {form.round.player[_player].averageOtherScore}");
            form.setInfo(form.container[_player].left[3], $"Won: {form.round.player[_player].numBeat}"); 
            form.setInfo(form.container[_player].left[4], $"Lost: {form.round.player[_player].numLose}");
            form.setInfo(form.container[_player].left[5], $"High: {form.round.player[_player].highCard}");
        }

        public static void resize(DebugForm form)
        {
            form.Size = new Size(form.Size.Width + 190, form.Size.Height);
        }

        public static Label makeLabel(DebugForm form, int x, int y)
        {
            Label label = new Label();
            label.Location = new Point(x, y);
            label.AutoSize = true;
            label.Text = "string";
            label.Parent = form;
            return label;
        }

        public static PictureBox makePicture(DebugForm form, int x, int y)
        {
            PictureBox pic = new PictureBox();
            pic.Location = new Point(x, y);
            pic.Size = new Size(72, 96);
            pic.Image = null;
            pic.Parent = form;
            return pic;
        }
    }
}
