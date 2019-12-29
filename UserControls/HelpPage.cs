using System.Windows.Forms;

namespace Arma3FishersLifeCraftingGuide.UserControls
{
    public partial class HelpPage : UserControl
    {
        private static HelpPage _instance;
        public static HelpPage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HelpPage();
                }
                return _instance;
            }
        }
        public HelpPage()
        {
            InitializeComponent();
        }
    }
}
