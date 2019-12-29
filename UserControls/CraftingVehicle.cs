using System.Windows.Forms;

namespace Arma3FishersLifeCraftingGuide.UserControls
{
    public partial class CraftingVehicle : UserControl
    {
        private static CraftingVehicle _instance;
        public static CraftingVehicle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CraftingVehicle();
                }
                return _instance;
            }
        }
        public CraftingVehicle()
        {
            InitializeComponent();
        }
    }
}
