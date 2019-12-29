using System.Windows.Forms;

namespace Arma3FishersLifeCraftingGuide.UserControls
{
    public partial class CraftingOther : UserControl
    {
        private static CraftingOther _instance;
        public static CraftingOther Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CraftingOther();
                }
                return _instance;
            }
        }
        public CraftingOther()
        {
            InitializeComponent();
        }
    }
}
