using System.Collections.Generic;

namespace Arma3FishersLifeCraftingGuide.Recipes
{
    public class RecipeVehicleParts
    {
        public int QtyPalletsAluminum { get; set; }
        public int QtyPalletsSteel { get; set; }
        public int QtyGlass { get; set; }
        public int QtyRubber { get; set; }
        public int QtyPerCraft { get; set; }

        public RecipeVehicleParts(int qtyPalletsAluminum, int qtyPalletsSteel, int qtyGlass, int qtyRubber, int qtyPerCraft)
        {
            QtyPalletsAluminum = qtyPalletsAluminum;
            QtyPalletsSteel = qtyPalletsSteel;
            QtyGlass = qtyGlass;
            QtyRubber = qtyRubber;
            QtyPerCraft = qtyPerCraft;
        }

        public static Dictionary<string, RecipeVehicleParts> GetVehiclePartsAluminum()
        {
            var allVehiclePartsAluminum = new Dictionary<string, RecipeVehicleParts>
            {
                { "Engine", new RecipeVehicleParts(0, 2, 0, 0, 1) },
                { "Transmission", new RecipeVehicleParts(0, 1, 0, 0, 1)},
                { "Radiator", new RecipeVehicleParts(0, 1, 0, 0, 1) },
                { "Brake Rotors", new RecipeVehicleParts(0, 2, 0, 0, 4) },
                { "Differential", new RecipeVehicleParts(0, 1, 0, 0, 1) },
                { "Drive Shaft", new RecipeVehicleParts(0, 2, 0, 0, 1) },
                { "Steel Rims", new RecipeVehicleParts(0, 1, 0, 0, 10) },
                { "High End Transmission", new RecipeVehicleParts(0, 2, 0, 0, 1) },
                { "High End Radiator", new RecipeVehicleParts(0, 2, 0, 0, 1) },
                { "High End Brake Rotors", new RecipeVehicleParts(0, 4, 0, 0, 2) },
                { "High End Differential", new RecipeVehicleParts(0, 2, 0, 0, 1) }
            };

            return allVehiclePartsAluminum;
        }

        public static Dictionary<string, RecipeVehicleParts> GetVehiclePartsSteel()
        {
            var allVehiclePartsSteel = new Dictionary<string, RecipeVehicleParts>
            {
                { "4WD Differential", new RecipeVehicleParts(2, 0, 0, 0, 1) },
                { "Fuel Tank", new RecipeVehicleParts(1, 0, 0, 0, 1)},
                { "Chassis Rails", new RecipeVehicleParts(1, 0, 0, 0, 1) },
                { "Exhaust Pipes", new RecipeVehicleParts(1, 0, 0, 0, 2) },
                { "Alloy Rims", new RecipeVehicleParts(1, 0, 0, 0, 10) },
                { "High End Engine", new RecipeVehicleParts(2, 0, 0, 0, 1) },
                { "High End Fuel Tank", new RecipeVehicleParts(2, 0, 0, 0, 1) },
                { "High End Chassis Rails", new RecipeVehicleParts(4, 0, 0, 0, 1) },
                { "High End Drive Shaft", new RecipeVehicleParts(2, 0, 0, 0, 1) },
                { "High End Exhaust Pipes", new RecipeVehicleParts(2, 0, 0, 0, 2) }
            };

            return allVehiclePartsSteel;
        }

        public static Dictionary<string, RecipeVehicleParts> GetVehiclePartsOther()
        {
            var allVehiclePartsOther = new Dictionary<string, RecipeVehicleParts>
            {
                { "Tyres", new RecipeVehicleParts(0, 0, 0, 4, 8) },
                { "Windows", new RecipeVehicleParts(0, 0, 2, 0, 4)}
            };

            return allVehiclePartsOther;
        }
    }
}
