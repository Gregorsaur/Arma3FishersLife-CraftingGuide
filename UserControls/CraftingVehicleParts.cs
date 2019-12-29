using System.Windows.Forms;

namespace Arma3FishersLifeCraftingGuide.UserControls
{
    public partial class CraftingVehicleParts : UserControl
    {
        private static CraftingVehicleParts _instance;
        public static CraftingVehicleParts Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CraftingVehicleParts();
                }
                return _instance;
            }
        }
        public CraftingVehicleParts()
        {
            InitializeComponent();
        }
    }
}
