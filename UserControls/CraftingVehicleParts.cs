using Arma3FishersLifeCraftingGuide.Recipes;
using System.Collections.Generic;
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

        //Store num of times button clicked so we don't add parts multiple times
        int numClicksAluminum = 0;
        int numClicksSteel = 0;
        int numClicksOther = 0;
        private void ButtonPartsSteel_Click(object sender, System.EventArgs e)
        {
            numClicksSteel++;
            numClicksAluminum = 0;
            numClicksOther = 0;
            labelDebug.Text = "";

            if (numClicksSteel == 1)
            {
                foreach (KeyValuePair<string, RecipeVehicleParts> entry in RecipeVehicleParts.GetVehiclePartsSteel())
                {
                    string partName = entry.Key;
                    var partValues = entry.Value;

                    int qtySteel = partValues._qtyPalletsSteel;

                    labelDebug.Text += partName + "  ---  " + qtySteel + "x Steel Pallets\n";
                }
            }
            else
            {
                return;
            }
        }

        private void ButtonPartsAluminum_Click(object sender, System.EventArgs e)
        {
            numClicksSteel = 0;
            numClicksAluminum++;
            numClicksOther = 0;
            labelDebug.Text = "";

            if (numClicksAluminum == 1)
            {
                foreach (KeyValuePair<string, RecipeVehicleParts> entry in RecipeVehicleParts.GetVehiclePartsAluminum())
                {
                    string partName = entry.Key;
                    var partValues = entry.Value;

                    int qtyAluminum = partValues._qtyPalletsAluminum;

                    labelDebug.Text += partName + "  ---  " + qtyAluminum + "x Aluminum Pallets\n";
                }
            }
            else
            {
                return;
            }
        }

        private void ButtonPartsOther_Click(object sender, System.EventArgs e)
        {
            numClicksSteel = 0;
            numClicksAluminum = 0;
            numClicksOther++;
            labelDebug.Text = "";

            if (numClicksOther == 1)
            {
                foreach (KeyValuePair<string, RecipeVehicleParts> entry in RecipeVehicleParts.GetVehiclePartsOther())
                {
                    string partName = entry.Key;
                    var partValues = entry.Value;

                    int qtyRubber = partValues._qtyRubber;
                    int qtyGlass = partValues._qtyGlass;

                    if (qtyGlass == 0)
                    {
                        //part does not use glass, therefor uses rubber
                        labelDebug.Text += partName + "  ---  " + qtyRubber + "x Rubber\n";
                    }
                    else
                    {
                        labelDebug.Text += partName + "  ---  " + qtyGlass + "x Glass\n";
                    }
                }
            }
            else
            {
                return;
            }
        }
    }
}
