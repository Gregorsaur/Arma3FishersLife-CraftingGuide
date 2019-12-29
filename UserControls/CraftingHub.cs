using System.Windows.Forms;

namespace Arma3FishersLifeCraftingGuide.UserControls
{
    public partial class CraftingHub : UserControl
    {
        private static CraftingHub _instance;
        public static CraftingHub Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CraftingHub();
                }
                return _instance;
            }
        }
        public CraftingHub()
        {
            InitializeComponent();
        }
    }
}
