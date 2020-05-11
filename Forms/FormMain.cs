using Arma3FishersLifeCraftingGuide.UserControls;
using System;
using System.Windows.Forms;

namespace Arma3FishersLifeCraftingGuide.Forms
{
    public partial class FormMain : Form
    {
        static FormMain _obj;

        public static FormMain Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FormMain();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public FormMain()
        {
            InitializeComponent();
            ShowCraftingHub();
            panelNavSide.Height = buttonNavHome.Height;
            panelNavSide.Top = buttonNavHome.Top;
        }

        private void ShowCraftingHub()
        {
            if (!panelContainer.Controls.Contains(CraftingHub.Instance))
            {
                panelContainer.Controls.Add(CraftingHub.Instance);
                CraftingHub.Instance.Dock = DockStyle.Fill;
                CraftingHub.Instance.BringToFront();
            }
            else
            {
                CraftingHub.Instance.BringToFront();
            }
        }

        private void ShowCraftingVehicle()
        {
            if (!panelContainer.Controls.Contains(CraftingVehicle.Instance))
            {
                panelContainer.Controls.Add(CraftingVehicle.Instance);
                CraftingVehicle.Instance.Dock = DockStyle.Fill;
                CraftingVehicle.Instance.BringToFront();
            }
            else
            {
                CraftingVehicle.Instance.BringToFront();
            }
        }

        private void ShowCraftingAircraft()
        {
         if (!panelContainer.Controls.Contains(CraftingAircraft.Instance))
            {
                panelContainer.Controls.Add(CraftingAircraft.Instance);
                CraftingAircraft.Instance.Dock = DockStyle.Fill;
                CraftingAircraft.Instance.BringToFront();
            }   
         else
            {
                CraftingAircraft.Instance.BringToFront();
            }
        }

        private void ShowCraftingWatercraft()
        {
            if (!panelContainer.Controls.Contains(CraftingWatercraft.Instance))
            {
                panelContainer.Controls.Add(CraftingWatercraft.Instance);
                CraftingWatercraft.Instance.Dock = DockStyle.Fill;
                CraftingWatercraft.Instance.BringToFront();
            }
            else
            {
                CraftingWatercraft.Instance.BringToFront();
            }
        }

        private void ShowCraftingVehicleParts()
        {
            if (!panelContainer.Controls.Contains(CraftingVehicleParts.Instance))
            {
                panelContainer.Controls.Add(CraftingVehicleParts.Instance);
                CraftingVehicleParts.Instance.Dock = DockStyle.Fill;
                CraftingVehicleParts.Instance.BringToFront();
            }
            else
            {
                CraftingVehicleParts.Instance.BringToFront();
            }
        }

        private void ShowCraftingFoodDrink()
        {
            if (!panelContainer.Controls.Contains(CraftingFoodDrink.Instance))
            {
                panelContainer.Controls.Add(CraftingFoodDrink.Instance);
                CraftingFoodDrink.Instance.Dock = DockStyle.Fill;
                CraftingFoodDrink.Instance.BringToFront();
            }
            else
            {
                CraftingFoodDrink.Instance.BringToFront();
            }
        }

        private void ShowCraftingWeaponsAmmo()
        {
            if (!panelContainer.Controls.Contains(CraftingWeaponsAmmo.Instance))
            {
                panelContainer.Controls.Add(CraftingWeaponsAmmo.Instance);
                CraftingWeaponsAmmo.Instance.Dock = DockStyle.Fill;
                CraftingWeaponsAmmo.Instance.BringToFront();
            }
            else
            {
                CraftingWeaponsAmmo.Instance.BringToFront();
            }
        }

        private void ShowCraftingOther()
        {
            if (!panelContainer.Controls.Contains(CraftingOther.Instance))
            {
                panelContainer.Controls.Add(CraftingOther.Instance);
                CraftingOther.Instance.Dock = DockStyle.Fill;
                CraftingOther.Instance.BringToFront();
            }
            else
            {
                CraftingOther.Instance.BringToFront();
            }
        }

        private void ShowUserSettings()
        {
            if (!panelContainer.Controls.Contains(UserSettings.Instance))
            {
                panelContainer.Controls.Add(UserSettings.Instance);
                UserSettings.Instance.Dock = DockStyle.Fill;
                UserSettings.Instance.BringToFront();
            }
            else
            {
                UserSettings.Instance.BringToFront();
            }
        }

        private void ShowHelpPage()
        {
            if (!panelContainer.Controls.Contains(HelpPage.Instance))
            {
                panelContainer.Controls.Add(HelpPage.Instance);
                HelpPage.Instance.Dock = DockStyle.Fill;
                HelpPage.Instance.BringToFront();
            }
            else
            {
                HelpPage.Instance.BringToFront();
            }
        }

        private void ButtonNavHome_Click(object sender, EventArgs e)
        {
            ShowCraftingHub();

            panelNavSide.Height = buttonNavHome.Height;
            panelNavSide.Top = buttonNavHome.Top;
        }

        private void ButtonNavVehicles_Click(object sender, EventArgs e)
        {
            ShowCraftingVehicle();

            panelNavSide.Height = buttonNavVehicles.Height;
            panelNavSide.Top = buttonNavVehicles.Top;
        }

        private void ButtonNavAircraft_Click(object sender, EventArgs e)
        {
            ShowCraftingAircraft();

            panelNavSide.Height = buttonNavAircraft.Height;
            panelNavSide.Top = buttonNavAircraft.Top;
        }

        private void ButtonNavWatercraft_Click(object sender, EventArgs e)
        {
            ShowCraftingWatercraft();

            panelNavSide.Height = buttonNavWatercraft.Height;
            panelNavSide.Top = buttonNavWatercraft.Top;
        }

        private void ButtonNavVehicleParts_Click(object sender, EventArgs e)
        {
            ShowCraftingVehicleParts();

            panelNavSide.Height = buttonNavVehicleParts.Height;
            panelNavSide.Top = buttonNavVehicleParts.Top;
        }

        private void ButtonNavFoodDrink_Click(object sender, EventArgs e)
        {
            ShowCraftingFoodDrink();

            panelNavSide.Height = buttonNavFoodDrink.Height;
            panelNavSide.Top = buttonNavFoodDrink.Top;
        }

        private void ButtonNavWeaponsAmmo_Click(object sender, EventArgs e)
        {
            ShowCraftingWeaponsAmmo();

            panelNavSide.Height = buttonNavWeaponsAmmo.Height;
            panelNavSide.Top = buttonNavWeaponsAmmo.Top;
        }

        private void ButtonNavOther_Click(object sender, EventArgs e)
        {
            ShowCraftingOther();

            panelNavSide.Height = buttonNavOther.Height;
            panelNavSide.Top = buttonNavOther.Top;
        }

        private void ButtonNavSettings_Click(object sender, EventArgs e)
        {
            ShowUserSettings();

            panelNavSide.Height = buttonNavSettings.Height;
            panelNavSide.Top = buttonNavSettings.Top;
        }

        private void ButtonNavHelp_Click(object sender, EventArgs e)
        {
            ShowHelpPage();

            panelNavSide.Height = buttonNavHelp.Height;
            panelNavSide.Top = buttonNavHelp.Top;
        }

        private void staticLabelFooter1_Click(object sender, EventArgs e)
        {

        }
    }
}
