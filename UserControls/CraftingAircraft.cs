using System.Windows.Forms;

namespace Arma3FishersLifeCraftingGuide.UserControls
{
    public partial class CraftingAircraft : UserControl
    {
        private static CraftingAircraft _instance;
        public static CraftingAircraft Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CraftingAircraft();
                }
                return _instance;
            }
        }
        public CraftingAircraft()
        {
            InitializeComponent();
        }
    }
}
