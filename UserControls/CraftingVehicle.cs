using Arma3FishersLifeCraftingGuide.Recipes;
using System;
using System.Collections.Generic;
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
            LoadVehiclesByType("All");
        }


        private void ButtonCategoryCar_Click(object sender, System.EventArgs e)
        {
            comboBoxVehicleList.Items.Clear();
            LoadVehiclesByType("Car");
        }

        private void ButtonCategoryTruck_Click(object sender, System.EventArgs e)
        {
            comboBoxVehicleList.Items.Clear();
            LoadVehiclesByType("Truck");
        }

        private void ButtonCategorySUV_Click(object sender, System.EventArgs e)
        {
            comboBoxVehicleList.Items.Clear();
            LoadVehiclesByType("SUV");
        }

        private void ButtonCategoryMotorcycle_Click(object sender, System.EventArgs e)
        {
            comboBoxVehicleList.Items.Clear();
            LoadVehiclesByType("Motorcycle");
        }

        private void ButtonCategoryTrailer_Click(object sender, System.EventArgs e)
        {
            comboBoxVehicleList.Items.Clear();
            LoadVehiclesByType("Trailer");
        }

        private void ButtonCategoryOther_Click(object sender, System.EventArgs e)
        {
            comboBoxVehicleList.Items.Clear();
            LoadVehiclesByType("Other");
        }

        private void LoadVehiclesByType(string selectedVehicleCategory)
        {
            switch (selectedVehicleCategory)
            {
                case "Car":
                    foreach (KeyValuePair<string, RecipeVehicles> entry in RecipeVehicles.GetVehiclesCar())
                    {
                        comboBoxVehicleList.Items.Add(entry.Key);
                    }
                    break;
                case "Truck":
                    foreach (KeyValuePair<string, RecipeVehicles> entry in RecipeVehicles.GetVehiclesTruck())
                    {
                        comboBoxVehicleList.Items.Add(entry.Key);
                    }
                    break;
                case "SUV":
                    foreach (KeyValuePair<string, RecipeVehicles> entry in RecipeVehicles.GetVehiclesSUV())
                    {
                        comboBoxVehicleList.Items.Add(entry.Key);
                    }
                    break;
                case "Motorcycle":
                    foreach (KeyValuePair<string, RecipeVehicles> entry in RecipeVehicles.GetVehiclesMotorcycle())
                    {
                        comboBoxVehicleList.Items.Add(entry.Key);
                    }
                    break;
                case "Trailer":
                    foreach (KeyValuePair<string, RecipeVehicles> entry in RecipeVehicles.GetVehiclesTrailer())
                    {
                        comboBoxVehicleList.Items.Add(entry.Key);
                    }
                    break;
                case "Other":
                    foreach (KeyValuePair<string, RecipeVehicles> entry in RecipeVehicles.GetVehiclesOther())
                    {
                        comboBoxVehicleList.Items.Add(entry.Key);
                    }
                    break;
                case "All":
                    foreach (KeyValuePair<string, RecipeVehicles> entry in RecipeVehicles.GetVehiclesCar())
                    {
                        comboBoxVehicleList.Items.Add(entry.Key);
                    }
                    foreach (KeyValuePair<string, RecipeVehicles> entry in RecipeVehicles.GetVehiclesTruck())
                    {
                        comboBoxVehicleList.Items.Add(entry.Key);
                    }
                    foreach (KeyValuePair<string, RecipeVehicles> entry in RecipeVehicles.GetVehiclesSUV())
                    {
                        comboBoxVehicleList.Items.Add(entry.Key);
                    }
                    foreach (KeyValuePair<string, RecipeVehicles> entry in RecipeVehicles.GetVehiclesMotorcycle())
                    {
                        comboBoxVehicleList.Items.Add(entry.Key);
                    }
                    foreach (KeyValuePair<string, RecipeVehicles> entry in RecipeVehicles.GetVehiclesTrailer())
                    {
                        comboBoxVehicleList.Items.Add(entry.Key);
                    }
                    foreach (KeyValuePair<string, RecipeVehicles> entry in RecipeVehicles.GetVehiclesOther())
                    {
                        comboBoxVehicleList.Items.Add(entry.Key);
                    }
                    break;
            }
        }

        //debug for now
        private void loadVehicleData()
        {
            string _vehicleName = comboBoxVehicleList.SelectedItem.ToString();

            if (RecipeVehicles.GetVehiclesCar().ContainsKey(_vehicleName))
            {
                labelVehicleRecipePart.Text = "";
                labelVehicleRecipePartQty.Text = "";

                //labelVehicleRecipePart.Text = "KEY of type CAR Found: " + _vehicleName;
                foreach (KeyValuePair<string, RecipeVehicles> entry in RecipeVehicles.GetVehiclesCar())
                {
                    string vehicleName = entry.Key;
                    var vehicleRecipe = entry.Value;
                    
                    if (vehicleName == _vehicleName)
                    {
                        //Vehicle matched, now print vehicle recipe (only include values that are not 0
                        if (vehicleRecipe._qtyEngine != 0)
                        {
                            labelVehicleRecipePart.Text += "\nEngine";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyEngine;
                        }
                        if (vehicleRecipe._qtyTransmission != 0)
                        {
                            labelVehicleRecipePart.Text += "\nTransmission";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyTransmission;
                        }
                        if (vehicleRecipe._qtyRadiator != 0)
                        {
                            labelVehicleRecipePart.Text += "\nRadiator";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyRadiator;
                        }
                        if (vehicleRecipe._qtyBrakeRotors != 0)
                        {
                            labelVehicleRecipePart.Text += "\nBrake Rotors";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyBrakeRotors;
                        }
                        if (vehicleRecipe._qtyDifferential != 0)
                        {
                            labelVehicleRecipePart.Text += "\nDifferential";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyDifferential;
                        }
                        if (vehicleRecipe._qty4WDDifferential != 0)
                        {
                            labelVehicleRecipePart.Text += "\n4WD Differential";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qty4WDDifferential;
                        }
                        if (vehicleRecipe._qtyFuelTank != 0)
                        {
                            labelVehicleRecipePart.Text += "\nFuel Tank";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyFuelTank;
                        }
                        if (vehicleRecipe._qtyChassis != 0)
                        {
                            labelVehicleRecipePart.Text += "\nChassis";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyChassis;
                        }
                        if (vehicleRecipe._qtyDriveShaft != 0)
                        {
                            labelVehicleRecipePart.Text += "\nDrive Shaft";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyDriveShaft;
                        }
                        if (vehicleRecipe._qtyExhaustPipe != 0)
                        {
                            labelVehicleRecipePart.Text += "\nExhaust Pipe";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyExhaustPipe;
                        }
                        if (vehicleRecipe._qtyWindows != 0)
                        {
                            labelVehicleRecipePart.Text += "\nWindows";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyWindows;
                        }
                        if (vehicleRecipe._qtySteelRims != 0)
                        {
                            labelVehicleRecipePart.Text += "\nSteel Rims";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtySteelRims;
                        }
                        if (vehicleRecipe._qtyAlloyRims != 0)
                        {
                            labelVehicleRecipePart.Text += "\nAlloy Rims";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyAlloyRims;
                        }
                        if (vehicleRecipe._qtyTires != 0)
                        {
                            labelVehicleRecipePart.Text += "\nTires";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyTires;
                        }
                        if (vehicleRecipe._qtyHighEndEngine != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Engine";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndEngine;
                        }
                        if (vehicleRecipe._qtyHighEndTransmission != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Transmission";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndTransmission;
                        }
                        if (vehicleRecipe._qtyHighEndRadiator != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Radiator";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndRadiator;
                        }
                        if (vehicleRecipe._qtyHighEndBrakeRotors != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Brake Rotors";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndBrakeRotors;
                        }
                        if (vehicleRecipe._qtyHighEndFuelTank != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Fuel Tank";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndFuelTank;
                        }
                        if (vehicleRecipe._qtyHighEndChassis != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Chassis";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndChassis;
                        }
                        if (vehicleRecipe._qtyHighEndTransmissionShaft != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Transmission Shaft";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndTransmissionShaft;
                        }
                        if (vehicleRecipe._qtyHighEndExhaust != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Exhaust";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndExhaust;
                        }
                        if (vehicleRecipe._qtyHighEndDifferential != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Differential";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndDifferential;
                        }
                        if (vehicleRecipe._qtyPalletsAluminum != 0)
                        {
                            labelVehicleRecipePart.Text += "\nAluminum Pallets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyPalletsAluminum;
                        }
                        if (vehicleRecipe._qtyPalletsTitanium != 0)
                        {
                            labelVehicleRecipePart.Text += "\nTitanium Pallets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyPalletsTitanium;
                        }
                        if (vehicleRecipe._qtyPalletsSteel != 0)
                        {
                            labelVehicleRecipePart.Text += "\nSteel Pallets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyPalletsSteel;
                        }
                        if (vehicleRecipe._qtySheetsSteel != 0)
                        {
                            labelVehicleRecipePart.Text += "\nSteel Sheets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtySheetsSteel;
                        }
                    }
                }
            }
            else if (RecipeVehicles.GetVehiclesTruck().ContainsKey(_vehicleName))
            {
                labelVehicleRecipePart.Text = "";
                labelVehicleRecipePartQty.Text = "";

                //labelVehicleRecipePart.Text = "KEY of type TRUCK Found: " + _vehicleName;
                foreach (KeyValuePair<string, RecipeVehicles> entry in RecipeVehicles.GetVehiclesTruck())
                {
                    string vehicleName = entry.Key;
                    var vehicleRecipe = entry.Value;

                    if (vehicleName == _vehicleName)
                    {
                        //Vehicle matched, now print vehicle recipe (only include values that are not 0
                        if (vehicleRecipe._qtyEngine != 0)
                        {
                            labelVehicleRecipePart.Text += "\nEngine";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyEngine;
                        }
                        if (vehicleRecipe._qtyTransmission != 0)
                        {
                            labelVehicleRecipePart.Text += "\nTransmission";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyTransmission;
                        }
                        if (vehicleRecipe._qtyRadiator != 0)
                        {
                            labelVehicleRecipePart.Text += "\nRadiator";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyRadiator;
                        }
                        if (vehicleRecipe._qtyBrakeRotors != 0)
                        {
                            labelVehicleRecipePart.Text += "\nBrake Rotors";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyBrakeRotors;
                        }
                        if (vehicleRecipe._qtyDifferential != 0)
                        {
                            labelVehicleRecipePart.Text += "\nDifferential";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyDifferential;
                        }
                        if (vehicleRecipe._qty4WDDifferential != 0)
                        {
                            labelVehicleRecipePart.Text += "\n4WD Differential";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qty4WDDifferential;
                        }
                        if (vehicleRecipe._qtyFuelTank != 0)
                        {
                            labelVehicleRecipePart.Text += "\nFuel Tank";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyFuelTank;
                        }
                        if (vehicleRecipe._qtyChassis != 0)
                        {
                            labelVehicleRecipePart.Text += "\nChassis";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyChassis;
                        }
                        if (vehicleRecipe._qtyDriveShaft != 0)
                        {
                            labelVehicleRecipePart.Text += "\nDrive Shaft";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyDriveShaft;
                        }
                        if (vehicleRecipe._qtyExhaustPipe != 0)
                        {
                            labelVehicleRecipePart.Text += "\nExhaust Pipe";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyExhaustPipe;
                        }
                        if (vehicleRecipe._qtyWindows != 0)
                        {
                            labelVehicleRecipePart.Text += "\nWindows";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyWindows;
                        }
                        if (vehicleRecipe._qtySteelRims != 0)
                        {
                            labelVehicleRecipePart.Text += "\nSteel Rims";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtySteelRims;
                        }
                        if (vehicleRecipe._qtyAlloyRims != 0)
                        {
                            labelVehicleRecipePart.Text += "\nAlloy Rims";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyAlloyRims;
                        }
                        if (vehicleRecipe._qtyTires != 0)
                        {
                            labelVehicleRecipePart.Text += "\nTires";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyTires;
                        }
                        if (vehicleRecipe._qtyHighEndEngine != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Engine";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndEngine;
                        }
                        if (vehicleRecipe._qtyHighEndTransmission != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Transmission";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndTransmission;
                        }
                        if (vehicleRecipe._qtyHighEndRadiator != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Radiator";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndRadiator;
                        }
                        if (vehicleRecipe._qtyHighEndBrakeRotors != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Brake Rotors";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndBrakeRotors;
                        }
                        if (vehicleRecipe._qtyHighEndFuelTank != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Fuel Tank";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndFuelTank;
                        }
                        if (vehicleRecipe._qtyHighEndChassis != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Chassis";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndChassis;
                        }
                        if (vehicleRecipe._qtyHighEndTransmissionShaft != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Transmission Shaft";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndTransmissionShaft;
                        }
                        if (vehicleRecipe._qtyHighEndExhaust != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Exhaust";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndExhaust;
                        }
                        if (vehicleRecipe._qtyHighEndDifferential != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Differential";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndDifferential;
                        }
                        if (vehicleRecipe._qtyPalletsAluminum != 0)
                        {
                            labelVehicleRecipePart.Text += "\nAluminum Pallets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyPalletsAluminum;
                        }
                        if (vehicleRecipe._qtyPalletsTitanium != 0)
                        {
                            labelVehicleRecipePart.Text += "\nTitanium Pallets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyPalletsTitanium;
                        }
                        if (vehicleRecipe._qtyPalletsSteel != 0)
                        {
                            labelVehicleRecipePart.Text += "\nSteel Pallets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyPalletsSteel;
                        }
                        if (vehicleRecipe._qtySheetsSteel != 0)
                        {
                            labelVehicleRecipePart.Text += "\nSteel Sheets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtySheetsSteel;
                        }
                    }
                }
            }
            else if (RecipeVehicles.GetVehiclesSUV().ContainsKey(_vehicleName))
            {
                labelVehicleRecipePart.Text = "";
                labelVehicleRecipePartQty.Text = "";

                //labelVehicleRecipePart.Text = "KEY of type SUV Found: " + _vehicleName;
                foreach (KeyValuePair<string, RecipeVehicles> entry in RecipeVehicles.GetVehiclesSUV())
                {
                    string vehicleName = entry.Key;
                    var vehicleRecipe = entry.Value;

                    if (vehicleName == _vehicleName)
                    {
                        //Vehicle matched, now print vehicle recipe (only include values that are not 0
                        if (vehicleRecipe._qtyEngine != 0)
                        {
                            labelVehicleRecipePart.Text += "\nEngine";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyEngine;
                        }
                        if (vehicleRecipe._qtyTransmission != 0)
                        {
                            labelVehicleRecipePart.Text += "\nTransmission";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyTransmission;
                        }
                        if (vehicleRecipe._qtyRadiator != 0)
                        {
                            labelVehicleRecipePart.Text += "\nRadiator";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyRadiator;
                        }
                        if (vehicleRecipe._qtyBrakeRotors != 0)
                        {
                            labelVehicleRecipePart.Text += "\nBrake Rotors";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyBrakeRotors;
                        }
                        if (vehicleRecipe._qtyDifferential != 0)
                        {
                            labelVehicleRecipePart.Text += "\nDifferential";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyDifferential;
                        }
                        if (vehicleRecipe._qty4WDDifferential != 0)
                        {
                            labelVehicleRecipePart.Text += "\n4WD Differential";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qty4WDDifferential;
                        }
                        if (vehicleRecipe._qtyFuelTank != 0)
                        {
                            labelVehicleRecipePart.Text += "\nFuel Tank";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyFuelTank;
                        }
                        if (vehicleRecipe._qtyChassis != 0)
                        {
                            labelVehicleRecipePart.Text += "\nChassis";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyChassis;
                        }
                        if (vehicleRecipe._qtyDriveShaft != 0)
                        {
                            labelVehicleRecipePart.Text += "\nDrive Shaft";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyDriveShaft;
                        }
                        if (vehicleRecipe._qtyExhaustPipe != 0)
                        {
                            labelVehicleRecipePart.Text += "\nExhaust Pipe";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyExhaustPipe;
                        }
                        if (vehicleRecipe._qtyWindows != 0)
                        {
                            labelVehicleRecipePart.Text += "\nWindows";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyWindows;
                        }
                        if (vehicleRecipe._qtySteelRims != 0)
                        {
                            labelVehicleRecipePart.Text += "\nSteel Rims";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtySteelRims;
                        }
                        if (vehicleRecipe._qtyAlloyRims != 0)
                        {
                            labelVehicleRecipePart.Text += "\nAlloy Rims";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyAlloyRims;
                        }
                        if (vehicleRecipe._qtyTires != 0)
                        {
                            labelVehicleRecipePart.Text += "\nTires";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyTires;
                        }
                        if (vehicleRecipe._qtyHighEndEngine != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Engine";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndEngine;
                        }
                        if (vehicleRecipe._qtyHighEndTransmission != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Transmission";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndTransmission;
                        }
                        if (vehicleRecipe._qtyHighEndRadiator != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Radiator";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndRadiator;
                        }
                        if (vehicleRecipe._qtyHighEndBrakeRotors != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Brake Rotors";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndBrakeRotors;
                        }
                        if (vehicleRecipe._qtyHighEndFuelTank != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Fuel Tank";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndFuelTank;
                        }
                        if (vehicleRecipe._qtyHighEndChassis != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Chassis";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndChassis;
                        }
                        if (vehicleRecipe._qtyHighEndTransmissionShaft != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Transmission Shaft";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndTransmissionShaft;
                        }
                        if (vehicleRecipe._qtyHighEndExhaust != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Exhaust";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndExhaust;
                        }
                        if (vehicleRecipe._qtyHighEndDifferential != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Differential";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndDifferential;
                        }
                        if (vehicleRecipe._qtyPalletsAluminum != 0)
                        {
                            labelVehicleRecipePart.Text += "\nAluminum Pallets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyPalletsAluminum;
                        }
                        if (vehicleRecipe._qtyPalletsTitanium != 0)
                        {
                            labelVehicleRecipePart.Text += "\nTitanium Pallets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyPalletsTitanium;
                        }
                        if (vehicleRecipe._qtyPalletsSteel != 0)
                        {
                            labelVehicleRecipePart.Text += "\nSteel Pallets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyPalletsSteel;
                        }
                        if (vehicleRecipe._qtySheetsSteel != 0)
                        {
                            labelVehicleRecipePart.Text += "\nSteel Sheets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtySheetsSteel;
                        }
                    }
                }
            }
            else if (RecipeVehicles.GetVehiclesMotorcycle().ContainsKey(_vehicleName))
            {
                labelVehicleRecipePart.Text = "";
                labelVehicleRecipePartQty.Text = "";

                //labelVehicleRecipePart.Text = "KEY of type MOTORCYCLE Found: " + _vehicleName;
                foreach (KeyValuePair<string, RecipeVehicles> entry in RecipeVehicles.GetVehiclesMotorcycle())
                {
                    string vehicleName = entry.Key;
                    var vehicleRecipe = entry.Value;

                    if (vehicleName == _vehicleName)
                    {
                        //Vehicle matched, now print vehicle recipe (only include values that are not 0
                        if (vehicleRecipe._qtyEngine != 0)
                        {
                            labelVehicleRecipePart.Text += "\nEngine";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyEngine;
                        }
                        if (vehicleRecipe._qtyTransmission != 0)
                        {
                            labelVehicleRecipePart.Text += "\nTransmission";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyTransmission;
                        }
                        if (vehicleRecipe._qtyRadiator != 0)
                        {
                            labelVehicleRecipePart.Text += "\nRadiator";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyRadiator;
                        }
                        if (vehicleRecipe._qtyBrakeRotors != 0)
                        {
                            labelVehicleRecipePart.Text += "\nBrake Rotors";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyBrakeRotors;
                        }
                        if (vehicleRecipe._qtyDifferential != 0)
                        {
                            labelVehicleRecipePart.Text += "\nDifferential";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyDifferential;
                        }
                        if (vehicleRecipe._qty4WDDifferential != 0)
                        {
                            labelVehicleRecipePart.Text += "\n4WD Differential";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qty4WDDifferential;
                        }
                        if (vehicleRecipe._qtyFuelTank != 0)
                        {
                            labelVehicleRecipePart.Text += "\nFuel Tank";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyFuelTank;
                        }
                        if (vehicleRecipe._qtyChassis != 0)
                        {
                            labelVehicleRecipePart.Text += "\nChassis";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyChassis;
                        }
                        if (vehicleRecipe._qtyDriveShaft != 0)
                        {
                            labelVehicleRecipePart.Text += "\nDrive Shaft";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyDriveShaft;
                        }
                        if (vehicleRecipe._qtyExhaustPipe != 0)
                        {
                            labelVehicleRecipePart.Text += "\nExhaust Pipe";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyExhaustPipe;
                        }
                        if (vehicleRecipe._qtyWindows != 0)
                        {
                            labelVehicleRecipePart.Text += "\nWindows";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyWindows;
                        }
                        if (vehicleRecipe._qtySteelRims != 0)
                        {
                            labelVehicleRecipePart.Text += "\nSteel Rims";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtySteelRims;
                        }
                        if (vehicleRecipe._qtyAlloyRims != 0)
                        {
                            labelVehicleRecipePart.Text += "\nAlloy Rims";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyAlloyRims;
                        }
                        if (vehicleRecipe._qtyTires != 0)
                        {
                            labelVehicleRecipePart.Text += "\nTires";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyTires;
                        }
                        if (vehicleRecipe._qtyHighEndEngine != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Engine";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndEngine;
                        }
                        if (vehicleRecipe._qtyHighEndTransmission != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Transmission";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndTransmission;
                        }
                        if (vehicleRecipe._qtyHighEndRadiator != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Radiator";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndRadiator;
                        }
                        if (vehicleRecipe._qtyHighEndBrakeRotors != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Brake Rotors";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndBrakeRotors;
                        }
                        if (vehicleRecipe._qtyHighEndFuelTank != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Fuel Tank";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndFuelTank;
                        }
                        if (vehicleRecipe._qtyHighEndChassis != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Chassis";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndChassis;
                        }
                        if (vehicleRecipe._qtyHighEndTransmissionShaft != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Transmission Shaft";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndTransmissionShaft;
                        }
                        if (vehicleRecipe._qtyHighEndExhaust != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Exhaust";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndExhaust;
                        }
                        if (vehicleRecipe._qtyHighEndDifferential != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Differential";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndDifferential;
                        }
                        if (vehicleRecipe._qtyPalletsAluminum != 0)
                        {
                            labelVehicleRecipePart.Text += "\nAluminum Pallets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyPalletsAluminum;
                        }
                        if (vehicleRecipe._qtyPalletsTitanium != 0)
                        {
                            labelVehicleRecipePart.Text += "\nTitanium Pallets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyPalletsTitanium;
                        }
                        if (vehicleRecipe._qtyPalletsSteel != 0)
                        {
                            labelVehicleRecipePart.Text += "\nSteel Pallets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyPalletsSteel;
                        }
                        if (vehicleRecipe._qtySheetsSteel != 0)
                        {
                            labelVehicleRecipePart.Text += "\nSteel Sheets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtySheetsSteel;
                        }
                    }
                }
            }
            else if (RecipeVehicles.GetVehiclesTrailer().ContainsKey(_vehicleName))
            {
                labelVehicleRecipePart.Text = "";
                labelVehicleRecipePartQty.Text = "";

                //labelVehicleRecipePart.Text = "KEY of type TRAILER Found: " + _vehicleName;
                foreach (KeyValuePair<string, RecipeVehicles> entry in RecipeVehicles.GetVehiclesTrailer())
                {
                    string vehicleName = entry.Key;
                    var vehicleRecipe = entry.Value;

                    if (vehicleName == _vehicleName)
                    {
                        //Vehicle matched, now print vehicle recipe (only include values that are not 0
                        if (vehicleRecipe._qtyEngine != 0)
                        {
                            labelVehicleRecipePart.Text += "\nEngine";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyEngine;
                        }
                        if (vehicleRecipe._qtyTransmission != 0)
                        {
                            labelVehicleRecipePart.Text += "\nTransmission";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyTransmission;
                        }
                        if (vehicleRecipe._qtyRadiator != 0)
                        {
                            labelVehicleRecipePart.Text += "\nRadiator";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyRadiator;
                        }
                        if (vehicleRecipe._qtyBrakeRotors != 0)
                        {
                            labelVehicleRecipePart.Text += "\nBrake Rotors";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyBrakeRotors;
                        }
                        if (vehicleRecipe._qtyDifferential != 0)
                        {
                            labelVehicleRecipePart.Text += "\nDifferential";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyDifferential;
                        }
                        if (vehicleRecipe._qty4WDDifferential != 0)
                        {
                            labelVehicleRecipePart.Text += "\n4WD Differential";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qty4WDDifferential;
                        }
                        if (vehicleRecipe._qtyFuelTank != 0)
                        {
                            labelVehicleRecipePart.Text += "\nFuel Tank";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyFuelTank;
                        }
                        if (vehicleRecipe._qtyChassis != 0)
                        {
                            labelVehicleRecipePart.Text += "\nChassis";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyChassis;
                        }
                        if (vehicleRecipe._qtyDriveShaft != 0)
                        {
                            labelVehicleRecipePart.Text += "\nDrive Shaft";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyDriveShaft;
                        }
                        if (vehicleRecipe._qtyExhaustPipe != 0)
                        {
                            labelVehicleRecipePart.Text += "\nExhaust Pipe";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyExhaustPipe;
                        }
                        if (vehicleRecipe._qtyWindows != 0)
                        {
                            labelVehicleRecipePart.Text += "\nWindows";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyWindows;
                        }
                        if (vehicleRecipe._qtySteelRims != 0)
                        {
                            labelVehicleRecipePart.Text += "\nSteel Rims";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtySteelRims;
                        }
                        if (vehicleRecipe._qtyAlloyRims != 0)
                        {
                            labelVehicleRecipePart.Text += "\nAlloy Rims";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyAlloyRims;
                        }
                        if (vehicleRecipe._qtyTires != 0)
                        {
                            labelVehicleRecipePart.Text += "\nTires";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyTires;
                        }
                        if (vehicleRecipe._qtyHighEndEngine != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Engine";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndEngine;
                        }
                        if (vehicleRecipe._qtyHighEndTransmission != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Transmission";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndTransmission;
                        }
                        if (vehicleRecipe._qtyHighEndRadiator != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Radiator";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndRadiator;
                        }
                        if (vehicleRecipe._qtyHighEndBrakeRotors != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Brake Rotors";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndBrakeRotors;
                        }
                        if (vehicleRecipe._qtyHighEndFuelTank != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Fuel Tank";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndFuelTank;
                        }
                        if (vehicleRecipe._qtyHighEndChassis != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Chassis";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndChassis;
                        }
                        if (vehicleRecipe._qtyHighEndTransmissionShaft != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Transmission Shaft";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndTransmissionShaft;
                        }
                        if (vehicleRecipe._qtyHighEndExhaust != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Exhaust";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndExhaust;
                        }
                        if (vehicleRecipe._qtyHighEndDifferential != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Differential";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndDifferential;
                        }
                        if (vehicleRecipe._qtyPalletsAluminum != 0)
                        {
                            labelVehicleRecipePart.Text += "\nAluminum Pallets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyPalletsAluminum;
                        }
                        if (vehicleRecipe._qtyPalletsTitanium != 0)
                        {
                            labelVehicleRecipePart.Text += "\nTitanium Pallets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyPalletsTitanium;
                        }
                        if (vehicleRecipe._qtyPalletsSteel != 0)
                        {
                            labelVehicleRecipePart.Text += "\nSteel Pallets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyPalletsSteel;
                        }
                        if (vehicleRecipe._qtySheetsSteel != 0)
                        {
                            labelVehicleRecipePart.Text += "\nSteel Sheets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtySheetsSteel;
                        }
                    }
                }
            }
            else if (RecipeVehicles.GetVehiclesOther().ContainsKey(_vehicleName))
            {
                labelVehicleRecipePart.Text = "";
                labelVehicleRecipePartQty.Text = "";

                //labelVehicleRecipePart.Text = "KEY of type OTHER Found: " + _vehicleName;
                foreach (KeyValuePair<string, RecipeVehicles> entry in RecipeVehicles.GetVehiclesOther())
                {
                    string vehicleName = entry.Key;
                    var vehicleRecipe = entry.Value;

                    if (vehicleName == _vehicleName)
                    {
                        //Vehicle matched, now print vehicle recipe (only include values that are not 0
                        if (vehicleRecipe._qtyEngine != 0)
                        {
                            labelVehicleRecipePart.Text += "\nEngine";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyEngine;
                        }
                        if (vehicleRecipe._qtyTransmission != 0)
                        {
                            labelVehicleRecipePart.Text += "\nTransmission";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyTransmission;
                        }
                        if (vehicleRecipe._qtyRadiator != 0)
                        {
                            labelVehicleRecipePart.Text += "\nRadiator";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyRadiator;
                        }
                        if (vehicleRecipe._qtyBrakeRotors != 0)
                        {
                            labelVehicleRecipePart.Text += "\nBrake Rotors";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyBrakeRotors;
                        }
                        if (vehicleRecipe._qtyDifferential != 0)
                        {
                            labelVehicleRecipePart.Text += "\nDifferential";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyDifferential;
                        }
                        if (vehicleRecipe._qty4WDDifferential != 0)
                        {
                            labelVehicleRecipePart.Text += "\n4WD Differential";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qty4WDDifferential;
                        }
                        if (vehicleRecipe._qtyFuelTank != 0)
                        {
                            labelVehicleRecipePart.Text += "\nFuel Tank";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyFuelTank;
                        }
                        if (vehicleRecipe._qtyChassis != 0)
                        {
                            labelVehicleRecipePart.Text += "\nChassis";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyChassis;
                        }
                        if (vehicleRecipe._qtyDriveShaft != 0)
                        {
                            labelVehicleRecipePart.Text += "\nDrive Shaft";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyDriveShaft;
                        }
                        if (vehicleRecipe._qtyExhaustPipe != 0)
                        {
                            labelVehicleRecipePart.Text += "\nExhaust Pipe";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyExhaustPipe;
                        }
                        if (vehicleRecipe._qtyWindows != 0)
                        {
                            labelVehicleRecipePart.Text += "\nWindows";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyWindows;
                        }
                        if (vehicleRecipe._qtySteelRims != 0)
                        {
                            labelVehicleRecipePart.Text += "\nSteel Rims";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtySteelRims;
                        }
                        if (vehicleRecipe._qtyAlloyRims != 0)
                        {
                            labelVehicleRecipePart.Text += "\nAlloy Rims";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyAlloyRims;
                        }
                        if (vehicleRecipe._qtyTires != 0)
                        {
                            labelVehicleRecipePart.Text += "\nTires";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyTires;
                        }
                        if (vehicleRecipe._qtyHighEndEngine != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Engine";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndEngine;
                        }
                        if (vehicleRecipe._qtyHighEndTransmission != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Transmission";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndTransmission;
                        }
                        if (vehicleRecipe._qtyHighEndRadiator != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Radiator";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndRadiator;
                        }
                        if (vehicleRecipe._qtyHighEndBrakeRotors != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Brake Rotors";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndBrakeRotors;
                        }
                        if (vehicleRecipe._qtyHighEndFuelTank != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Fuel Tank";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndFuelTank;
                        }
                        if (vehicleRecipe._qtyHighEndChassis != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Chassis";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndChassis;
                        }
                        if (vehicleRecipe._qtyHighEndTransmissionShaft != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Transmission Shaft";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndTransmissionShaft;
                        }
                        if (vehicleRecipe._qtyHighEndExhaust != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Exhaust";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndExhaust;
                        }
                        if (vehicleRecipe._qtyHighEndDifferential != 0)
                        {
                            labelVehicleRecipePart.Text += "\nHigh End Differential";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyHighEndDifferential;
                        }
                        if (vehicleRecipe._qtyPalletsAluminum != 0)
                        {
                            labelVehicleRecipePart.Text += "\nAluminum Pallets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyPalletsAluminum;
                        }
                        if (vehicleRecipe._qtyPalletsTitanium != 0)
                        {
                            labelVehicleRecipePart.Text += "\nTitanium Pallets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyPalletsTitanium;
                        }
                        if (vehicleRecipe._qtyPalletsSteel != 0)
                        {
                            labelVehicleRecipePart.Text += "\nSteel Pallets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtyPalletsSteel;
                        }
                        if (vehicleRecipe._qtySheetsSteel != 0)
                        {
                            labelVehicleRecipePart.Text += "\nSteel Sheets";
                            labelVehicleRecipePartQty.Text += "\n" + vehicleRecipe._qtySheetsSteel;
                        }
                    }
                }
            }
            else
            {
                labelVehicleRecipePart.Text = "NO KEY FOUND: " + _vehicleName;
            }

        }

        //Internal Usage

        //Change Vehicle Data upon changing vehicle
        private void ComboBoxVehicleList_SelectionChangeCommitted (object sender, EventArgs e)
        {
            loadVehicleData();
        }
    }
}
