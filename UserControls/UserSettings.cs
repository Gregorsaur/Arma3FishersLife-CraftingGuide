using System.Windows.Forms;

namespace Arma3FishersLifeCraftingGuide.UserControls
{
    public partial class UserSettings : UserControl
    {
        private static UserSettings _instance;
        public static UserSettings Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserSettings();
                }
                return _instance;
            }
        }
        public UserSettings()
        {
            InitializeComponent();
        }
    }
}
