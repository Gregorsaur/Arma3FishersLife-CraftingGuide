using System.Windows.Forms;

namespace Arma3FishersLifeCraftingGuide.UserControls
{
    public partial class CraftingFoodDrink : UserControl
    {
        private static CraftingFoodDrink _instance;
        public static CraftingFoodDrink Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CraftingFoodDrink();
                }
                return _instance;
            }
        }
        public CraftingFoodDrink()
        {
            InitializeComponent();
        }
    }
}
