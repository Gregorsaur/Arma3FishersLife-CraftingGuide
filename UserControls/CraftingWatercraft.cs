using System.Windows.Forms;

namespace Arma3FishersLifeCraftingGuide.UserControls
{
    public partial class CraftingWatercraft : UserControl
    {
        private static CraftingWatercraft _instance;
        public static CraftingWatercraft Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CraftingWatercraft();
                }
                return _instance;
            }
        }
        public CraftingWatercraft()
        {
            InitializeComponent();
        }
    }
}
