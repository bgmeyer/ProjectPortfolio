using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTRL_ALT_ELITE_GroupProject
{
    public partial class userControlFavNFLPlayers : UserControl
    {
        private string _favPlayerName = "";
        private string _favPlayerTitle = "";
        private Image _icon;


        [Category("Custom Properties")]
        public string PlayersName
        {
            get { return _favPlayerName; }
            set { _favPlayerName = value; lblNFLPlayerName.Text = value; }
        }
        [Category("Custom Properties")]
        public string PlayerTitle
        {
            get { return _favPlayerTitle; }
            set { _favPlayerTitle = value; lblPlayerTitle.Text = value; }
        }
        [Category("Custom Properties")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; picPlayer.Image = value; }
        }

        public userControlFavNFLPlayers()
        {
            InitializeComponent();
        }
    }
}
