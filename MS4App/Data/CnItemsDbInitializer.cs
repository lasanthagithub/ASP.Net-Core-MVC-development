using MS4App.Models.CalculationViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS4App.Data
{
    public class CnItemsDbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // check for the database. If exist, nothing done. If not, create a new
            context.Database.EnsureCreated();

            // Look for data in Wine database
            if (context.CnItems.Any())
            {
                return; // DB has been seeded
            }

            // Creating some data
            var cnItems = new CnItems[]
            {
            new CnItems {CnItemId = "open_poor" , CnItemDescription = "Open Space, Poor Condition (Grass cover <50%)", A = 68, B = 79, C = 86, D = 89},
            new CnItems {CnItemId = "open_fair" , CnItemDescription = "Open Space, Fair Condition (Grass cover 50% to 75%)", A = 49, B = 69, C = 79, D = 84},
            new CnItems {CnItemId = "open_good" , CnItemDescription = "Open Space, Good Condition (Grass cover >75%)", A = 39, B = 61, C = 74, D = 80},
            new CnItems {CnItemId = "roadway_paved" , CnItemDescription = "Roadway Impervious Area, Paved", A = 98, B = 98, C = 98, D = 98},
            new CnItems {CnItemId = "curb_paved" , CnItemDescription = "Paved; Curbs and storm sewers", A = 98, B = 98, C = 98, D = 98},
            new CnItems {CnItemId = "ditches_paved" , CnItemDescription = "Paved; Open Ditches", A = 83, B = 89, C = 92, D = 93},
            new CnItems {CnItemId = "gravel" , CnItemDescription = "Gravel", A = 76, B = 85, C = 89, D = 91},
            new CnItems {CnItemId = "dirt" , CnItemDescription = "Dirt", A = 72, B = 82, C = 87, D = 89},
            new CnItems {CnItemId = "natur_desert_landscape" , CnItemDescription = "Natural Desrt Lanscaping", A = 63, B = 77, C = 85, D = 88},
            new CnItems {CnItemId = "artif_desert_landscape" , CnItemDescription = "Artificial Desrt Lanscaping", A = 96, B = 96, C = 96, D = 96},
            new CnItems {CnItemId = "urban_commercial" , CnItemDescription = "Urban Districts, Commercial and Business", A = 89, B = 92, C = 94, D = 95},
            new CnItems {CnItemId = "urban_industrial" , CnItemDescription = "Urban Districts, Industrial", A = 81, B = 88, C = 91, D = 93},
            new CnItems {CnItemId = "residential_65" , CnItemDescription = "Residential, 65% Impervious (1/8 Acre)", A = 77, B = 85, C = 90, D = 92},
            new CnItems {CnItemId = "residential_38" , CnItemDescription = "Residential, 38% Impervious (1/4 Acre)", A = 61, B = 75, C = 83, D = 87},
            new CnItems {CnItemId = "residential_30" , CnItemDescription = "Residential, 30% Impervious (1/3 Acre)", A = 57, B = 72, C = 81, D = 86},
            new CnItems {CnItemId = "residential_25" , CnItemDescription = "Residential, 25% Impervious (1/2 Acre)", A = 54, B = 70, C = 80, D = 85},
            new CnItems {CnItemId = "residential_20" , CnItemDescription = "Residential, 20% Impervious (1 Acre)", A = 51, B = 68, C = 79, D = 84},
            new CnItems {CnItemId = "residential_12" , CnItemDescription = "Residential, 12% Impervious (2 Acre)", A = 46, B = 65, C = 77, D = 82},
            new CnItems {CnItemId = "graded_new" , CnItemDescription = "Newly graded areas", A = 77, B = 86, C = 91, D = 94},
            new CnItems {CnItemId = "pasture_poor" , CnItemDescription = "Pasture, Grassland, or Range, Poor Condition", A = 68, B = 79, C = 86, D = 89},
            new CnItems {CnItemId = "pasture_fair" , CnItemDescription = "Pasture, Grassland, or Range, Fair Condition", A = 49, B = 69, C = 79, D = 84},
            new CnItems {CnItemId = "pasture_good" , CnItemDescription = "Pasture, Grassland, or Range, Good Condition", A = 39, B = 61, C = 74, D = 80},
            new CnItems {CnItemId = "protected_meadow" , CnItemDescription = "Meadow, protected from grazing", A = 30, B = 58, C = 71, D = 78},
            new CnItems {CnItemId = "brush_poor" , CnItemDescription = "Brush - Brush, weed grass combination, Poor Condition", A = 48, B = 67, C = 77, D = 83},
            new CnItems {CnItemId = "brush_fair" , CnItemDescription = "Brush - Brush, weed grass combination, Fair Condition", A = 35, B = 56, C = 70, D = 77},
            new CnItems {CnItemId = "brush_good" , CnItemDescription = "Brush - Brush, weed grass combination, Good Condition", A = 30, B = 48, C = 65, D = 73},
            new CnItems {CnItemId = "wood_grass_poor" , CnItemDescription = "Wood - Grass combination, Poor Condition", A = 57, B = 73, C = 82, D = 86},
            new CnItems {CnItemId = "wood_grass_fair" , CnItemDescription = "Wood - Grass combination, Fair Condition", A = 43, B = 65, C = 76, D = 82},
            new CnItems {CnItemId = "wood_grass_good" , CnItemDescription = "Wood - Grass combination, Good Condition", A = 32, B = 58, C = 72, D = 79},
            new CnItems {CnItemId = "wood_orchard_poor" , CnItemDescription = "Woods (Orchard or Tree Farm), Poor Condition", A = 45, B = 66, C = 77, D = 83},
            new CnItems {CnItemId = "wood_orchard_fair" , CnItemDescription = "Woods (Orchard or Tree Farm), Fair Condition", A = 36, B = 60, C = 73, D = 79},
            new CnItems {CnItemId = "wood_orchard_good" , CnItemDescription = "Woods (Orchard or Tree Farm), Good Condition", A = 30, B = 55, C = 70, D = 77},
            new CnItems {CnItemId = "farmsteads_and_construction" , CnItemDescription = "Farmsteads, buildings, lanes, driveways, and surrounding lots", A = 59, B = 74, C = 82, D = 86},
            new CnItems {CnItemId = "open_water" , CnItemDescription = "Open water, lakes, wetlands, ponds, etc.", A = 100, B = 100, C = 100, D = 100}
            };


            // Add new data to DB just for checking
            foreach (CnItems cnItem in cnItems)
            {
                context.CnItems.Add(cnItem);
            }
            //context.SaveChanges(); // uncomment for a news database
        }
    }
}
