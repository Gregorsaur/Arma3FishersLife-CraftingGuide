using System.Windows.Forms;

namespace Arma3FishersLifeCraftingGuide.UserControls
{
    public partial class CraftingWeaponsAmmo : UserControl
    {
        private static CraftingWeaponsAmmo _instance;
        public static CraftingWeaponsAmmo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CraftingWeaponsAmmo();
                }
                return _instance;
            }
        }
        public CraftingWeaponsAmmo()
        {
            InitializeComponent();
        }
    }
}
