using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arma3FishersLifeCraftingGuide.Recipes
{
    class RecipeVehicles
    {
        public int _qtyEngine { get; set; }
        public int _qtyTransmission { get; set; }
        public int _qtyRadiator { get; set; }
        public int _qtyBrakeRotors { get; set; }
        public int _qtyDifferential { get; set; }
        public int _qty4WDDifferential { get; set; }
        public int _qtyFuelTank { get; set; }
        public int _qtyChassis { get; set; }
        public int _qtyDriveShaft { get; set; }
        public int _qtyExhaustPipe { get; set; }
        public int _qtyWindows { get; set; }
        public int _qtySteelRims { get; set; }
        public int _qtyAlloyRims { get; set; }
        public int _qtyTires { get; set; }
        public int _qtyHighEndEngine { get; set; }
        public int _qtyHighEndTransmission { get; set; }
        public int _qtyHighEndRadiator { get; set; }
        public int _qtyHighEndBrakeRotors { get; set; }
        public int _qtyHighEndFuelTank { get; set; }
        public int _qtyHighEndChassis { get; set; }
        public int _qtyHighEndTransmissionShaft { get; set; }
        public int _qtyHighEndExhaust { get; set; }
        public int _qtyHighEndDifferential { get; set; }
        public int _qtyPalletsAluminum { get; set; }
        public int _qtyPalletsTitanium { get; set; }
        public int _qtyPalletsSteel { get; set; }
        public int _qtySheetsSteel { get; set; }

        public RecipeVehicles(int qtyEngine, int qtyTransmission, int qtyRadiator, int qtyBrakeRotors, int qtyDifferential, int qty4WDDifferential, int qtyFuelTank, int qtyChassis, int qtyDriveShaft, int qtyExhaustPipe, int qtyWindows, int qtySteelRims, int qtyAlloyRims, int qtyTires, int qtyHighEndEngine, int qtyHighEndTransmission, int qtyHighEndRadiator, int qtyHighEndBrakeRotors, int qtyHighEndFuelTank, int qtyHighEndChassis, int qtyHighEndTransmissionShaft, int qtyHighEndExhaust, int qtyHighEndDifferential, int qtyPalletsAluminum, int qtyPalletsTitanium, int qtyPalletsSteel, int qtySheetsSteel)
        {
            _qtyEngine = qtyEngine;
            _qtyTransmission = qtyTransmission;
            _qtyRadiator = qtyRadiator;
            _qtyBrakeRotors = qtyBrakeRotors;
            _qtyDifferential = qtyDifferential;
            _qty4WDDifferential = qty4WDDifferential;
            _qtyFuelTank = qtyFuelTank;
            _qtyChassis = qtyChassis;
            _qtyDriveShaft = qtyDriveShaft;
            _qtyExhaustPipe = qtyExhaustPipe;
            _qtyWindows = qtyWindows;
            _qtySteelRims = qtySteelRims;
            _qtyAlloyRims = qtyAlloyRims;
            _qtyTires = qtyTires;
            _qtyHighEndEngine = qtyHighEndEngine;
            _qtyHighEndTransmission = qtyHighEndTransmission;
            _qtyHighEndRadiator = qtyHighEndRadiator;
            _qtyHighEndBrakeRotors = qtyHighEndBrakeRotors;
            _qtyHighEndFuelTank = qtyHighEndFuelTank;
            _qtyHighEndChassis = qtyHighEndChassis;
            _qtyHighEndTransmissionShaft = qtyHighEndTransmissionShaft;
            _qtyHighEndExhaust = qtyHighEndExhaust;
            _qtyHighEndDifferential = qtyHighEndDifferential;
            _qtyPalletsAluminum = qtyPalletsAluminum;
            _qtyPalletsTitanium = qtyPalletsTitanium;
            _qtyPalletsSteel = qtyPalletsSteel;
            _qtySheetsSteel = qtySheetsSteel;
        }

        

        public static Dictionary<string, RecipeVehicles> GetVehiclesCar()
        {
            var allVehiclesCar = new Dictionary<string, RecipeVehicles>
            {
                { "Ford Mustang", new RecipeVehicles(0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 4, 1, 1, 1, 4, 1, 1, 2, 1, 0, 16, 0, 0, 0) },
                { "BMW M3 E92", new RecipeVehicles(1, 0, 1, 4, 0, 0, 0, 1, 0, 1, 4, 0, 4, 4, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0) },
                { "Ford Crown Victoria [Rusted]", new RecipeVehicles(1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Ford Crown Victoria", new RecipeVehicles(1, 1, 0, 4, 0, 0, 1, 0, 0, 1, 2, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Dodge Charger", new RecipeVehicles(0, 0, 1, 4, 0, 0, 0, 0, 0, 0, 2, 0, 4, 4, 1, 1, 0, 0, 1, 1, 1, 1, 1, 12, 0, 0, 0) },
                { "Lamborghini Gallardo", new RecipeVehicles(0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 1, 2, 4, 1, 1, 2, 1, 0, 0, 35, 0, 0) },
                { "Chevrolet Camaro", new RecipeVehicles(1, 1, 1, 4, 1, 0, 1, 1, 0, 1, 2, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Chevrolet Corvette ZR1", new RecipeVehicles(0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 4, 1, 1, 4, 4, 1, 1, 2, 1, 0, 0, 25, 0, 0) },
                { "1969 Dodge Charger R/T", new RecipeVehicles(1, 1, 2, 4, 1, 0, 1, 1, 0, 1, 4, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Honda CR-X", new RecipeVehicles(1, 1, 0, 4, 0, 0, 1, 0, 0, 1, 4, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Porsche 911 GT2", new RecipeVehicles(0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 4, 4, 1, 1, 4, 4, 1, 1, 2, 1, 0, 0, 30, 0, 0) },
                { "Challenger Hellcat", new RecipeVehicles(0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 4, 1, 1, 2, 4, 1, 1, 2, 1, 0, 18, 0, 0, 0) },
                { "Dodge Charger 2015", new RecipeVehicles(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 4, 4, 1, 1, 1, 2, 1, 1, 1, 1, 1, 16, 0, 0, 0) },
                { "Ford Crown Victoria Taxi", new RecipeVehicles(1, 1, 0, 4, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Mercedes CLS63 AMG", new RecipeVehicles(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 4, 4, 1, 1, 1, 2, 1, 1, 1, 1, 1, 0, 0, 0, 0) },
                { "Lamborghini Urus", new RecipeVehicles(0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 6, 0, 4, 4, 1, 1, 2, 4, 1, 1, 2, 1, 0, 0, 20, 0, 0) }
            };
            return allVehiclesCar;
        }

        public static Dictionary<string, RecipeVehicles> GetVehiclesTruck()
        {
            var allVehiclesTrucks = new Dictionary<string, RecipeVehicles>
            {
                { "Ford F150", new RecipeVehicles(1, 0, 1, 4, 0, 1, 1, 0, 0, 1, 2, 0, 4, 4, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0) },
                { "Dodge Ram", new RecipeVehicles(1, 1, 0, 4, 1, 0, 1, 1, 0, 0, 2, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Chevrolet Silverado", new RecipeVehicles(0, 0, 2, 0, 0, 1, 1, 0, 0, 1, 4, 0, 4, 4, 1, 1, 0, 4, 0, 1, 1, 0, 0, 0, 0, 0, 0) },
                { "Fuel Truck", new RecipeVehicles(1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 2, 4, 0, 4, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Peterbilt 362 Tow Truck", new RecipeVehicles(1, 1, 2, 6, 2, 0, 0, 1, 1, 0, 2, 6, 0, 6, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Ford F-150 Marker Lights", new RecipeVehicles(1, 0, 1, 4, 0, 1, 1, 0, 0, 1, 4, 0, 4, 4, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0) },
                { "Mail Truck", new RecipeVehicles(1, 1, 1, 4, 0, 0, 0, 0, 1, 1, 1, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Peterbilt 362", new RecipeVehicles(0, 1, 2, 0, 2, 0, 0, 1, 1, 1, 3, 6, 0, 6, 1, 0, 0, 6, 2, 0, 0, 0, 0, 0, 0, 0, 0) },
            };
            return allVehiclesTrucks;
        }

        public static Dictionary<string, RecipeVehicles> GetVehiclesSUV()
        {
            var allVehiclesSUV = new Dictionary<string, RecipeVehicles>
            {
                { "Chevrolet Tahoe", new RecipeVehicles(1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 4, 0, 4, 4, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Jeep Wrangler", new RecipeVehicles(1, 1, 0, 4, 1, 0, 1, 1, 0, 0, 3, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "2011 BMW X5", new RecipeVehicles(1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 4, 0, 4, 4, 0, 1, 0, 2, 1, 0, 0, 0, 0, 15, 0, 0, 0) },
                { "2012 Range Rover", new RecipeVehicles(0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 4, 0, 4, 4, 1, 1, 1, 4, 1, 1, 2, 1, 0, 10, 0, 0, 0) },
            };
            return allVehiclesSUV;
        }

        public static Dictionary<string, RecipeVehicles> GetVehiclesMotorcycle()
        {
            var allVehiclesMotorcycle = new Dictionary<string, RecipeVehicles>
            {
                { "Harley Davidson Fat Boy", new RecipeVehicles(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 2, 2, 1, 1, 1, 2, 1, 1, 1, 1, 1, 0, 3, 0, 0) },
                { "BMW R1100R Street Fighter", new RecipeVehicles(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 4, 2, 1, 1, 1, 2, 2, 1, 1, 1, 1, 0, 3, 0, 0) },
                { "Harley Davidson Knucklehead", new RecipeVehicles(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 3, 2, 1, 1, 1, 2, 1, 1, 1, 1, 1, 0, 3, 0, 0) }
            };
            return allVehiclesMotorcycle;
        }

        public static Dictionary<string, RecipeVehicles> GetVehiclesTrailer()
        {
            var allVehiclesTrailer = new Dictionary<string, RecipeVehicles>
            {
                { "Semi Boat Trailer", new RecipeVehicles(0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6) },
                { "Box Trailer", new RecipeVehicles(0, 0, 0, 6, 2, 0, 0, 1, 0, 0, 0, 6, 0, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Lowloader Trailer", new RecipeVehicles(0, 0, 0, 6, 2, 0, 0, 1, 0, 0, 0, 6, 0, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Tanker Trailer", new RecipeVehicles(0, 0, 0, 4, 2, 0, 0, 1, 0, 0, 0, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Drill Trailer", new RecipeVehicles(1, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Boat Trailer", new RecipeVehicles(0, 0, 0, 2, 1, 0, 0, 1, 0, 0, 0, 2, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Car Trailer", new RecipeVehicles(0, 0, 0, 4, 1, 0, 0, 1, 0, 0, 0, 4, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
            };
            return allVehiclesTrailer;
        }

        public static Dictionary<string, RecipeVehicles> GetVehiclesOther()
        {
            var allVehiclesOther = new Dictionary<string, RecipeVehicles>
            {
                { "Scooter", new RecipeVehicles(1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Quad", new RecipeVehicles(1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) },
                { "Mini Excavator", new RecipeVehicles(0, 1, 1, 4, 0, 1, 1, 1, 1, 1, 1, 4, 0, 4, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0) },
                { "Van Transport", new RecipeVehicles(1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 6, 0, 4, 4, 0, 0, 1, 4, 0, 0, 1, 0, 0, 0, 0, 0, 0) },
                { "Monster Truck", new RecipeVehicles(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 4, 8, 2, 2, 2, 4, 4, 2, 2, 2, 2, 0, 9, 0, 0) }
            };
            return allVehiclesOther;
        }
    }
}
