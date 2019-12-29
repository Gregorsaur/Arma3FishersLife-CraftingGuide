using Arma3FishersLifeCraftingGuide.UserControls;
using System;
using System.Windows.Forms;

namespace Arma3FishersLifeCraftingGuide.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            //ShowCraftingHub();
        }

        private void ShowCraftingHub()
        {
            //Hide any panels currently shown
            HideCraftingPanels();

            //Create panel object, then show on main panel, then bring to front
            CraftingHub panelCraftingHub = new CraftingHub();
            panelMain.Controls.Add(panelCraftingHub);
            panelCraftingHub.BringToFront();
        }

        private void ShowCraftingVehicle()
        {
            //Hide any panels currently shown
            HideCraftingPanels();

            //Create panel object, then show on main panel, then bring to front
            CraftingVehicle panelCraftingVehicle = new CraftingVehicle();
            panelMain.Controls.Add(panelCraftingVehicle);
            panelCraftingVehicle.BringToFront();
        }

        private void ShowCraftingAircraft()
        {
            //Hide any panels currently shown
            HideCraftingPanels();

            //Create panel object, then show on main panel
            CraftingAircraft panelCraftingAircraft = new CraftingAircraft();
            panelMain.Controls.Add(panelCraftingAircraft);
        }

        private void ShowCraftingWatercraft()
        {
            //Hide any panels currently shown
            HideCraftingPanels();

            //Create panel object, then show on main panel
            CraftingWatercraft panelCraftingWatercraft = new CraftingWatercraft();
            panelMain.Controls.Add(panelCraftingWatercraft);
        }

        private void ShowCraftingVehicleParts()
        {
            //Hide any panels currently shown
            HideCraftingPanels();

            //Create panel object, then show on main panel
            CraftingVehicleParts panelCraftingVehicleParts = new CraftingVehicleParts();
            panelMain.Controls.Add(panelCraftingVehicleParts);
        }

        private void ShowCraftingFoodDrink()
        {
            //Hide any panels currently shown
            HideCraftingPanels();

            //Create panel object, then show on main panel
            CraftingFoodDrink panelCraftingFoodDrink = new CraftingFoodDrink();
            panelMain.Controls.Add(panelCraftingFoodDrink);
        }

        private void ShowCraftingWeaponsAmmo()
        {
            //Hide any panels currently shown
            HideCraftingPanels();

            //Create panel object, then show on main panel
            CraftingWeaponsAmmo panelCraftingWeaponsAmmo = new CraftingWeaponsAmmo();
            panelMain.Controls.Add(panelCraftingWeaponsAmmo);
        }

        private void ShowCraftingOther()
        {
            //Hide any panels currently shown
            HideCraftingPanels();

            //Create panel object, then show on main panel
            CraftingOther panelCraftingOther = new CraftingOther();
            panelMain.Controls.Add(panelCraftingOther);
        }

        private void HideCraftingPanels()
        {
            //Iterate thru main panel and hide all existing panels
            //Do this before showing new panel
            foreach (Control ctrl in panelMain.Controls)
            {
                ctrl.Visible = false;
            }
        }

        private void ButtonNavHome_Click(object sender, EventArgs e)
        {
            ShowCraftingHub();
        }

        private void ButtonNavVehicles_Click(object sender, EventArgs e)
        {
            ShowCraftingVehicle();
        }

        private void ButtonNavAircraft_Click(object sender, EventArgs e)
        {
            ShowCraftingAircraft();
        }

        private void ButtonNavWatercraft_Click(object sender, EventArgs e)
        {
            ShowCraftingWatercraft();
        }

        private void ButtonNavVehicleParts_Click(object sender, EventArgs e)
        {
            ShowCraftingVehicleParts();
        }

        private void ButtonNavFoodDrink_Click(object sender, EventArgs e)
        {
            ShowCraftingFoodDrink();
        }

        private void ButtonNavWeaponsAmmo_Click(object sender, EventArgs e)
        {
            ShowCraftingWeaponsAmmo();
        }

        private void ButtonNavOther_Click(object sender, EventArgs e)
        {
            ShowCraftingOther();
        }

        private void ButtonNavInfo_Click(object sender, EventArgs e)
        {
            //todo
        }
    }
}
