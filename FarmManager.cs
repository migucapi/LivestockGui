using System;
using System.Collections.Generic;
using System.Text;

namespace LivestockGui
{
    public class FarmManager
    {
        // Food Prices (constants)
        private const double PRICE_HAY = 1.50;
        private const double PRICE_GRAIN = 2.50;
        private const double PRICE_SILAGE = 1.20;
        private const double PRICE_PELLETS = 3.00;
        private const double PRICE_GRASS = 0.80;
        private const double PRICE_CORN = 2.00;
        private const double PRICE_FISHMEAL = 4.50;
        private const double PRICE_MOLASSES = 1.80;
        private const double PRICE_STRAW = 0.90;
        private const double PRICE_VEGETABLES = 1.10;


        // List of all the animals on the farm
        private List<Animal> animalList;

        // The available species types the user can choose from
        private List<string> animalTypes;

        // Food types list (uses food type price)
        private List<string> foodTypes;

        // Max Animals
        private int maxAnimals;


        // Constructor
        public FarmManager()
        {
            animalList = new List<Animal>();
            maxAnimals = 500;

            // Animal Species
            animalTypes = new List<string>()
            {
                "Cow",
                "Sheep",
                "Pig",
                "Chicken",
                "Horse",
                "Goat",
                "Duck",
                "Alpaca",
                "Deer",
                "Turkey",
            };

            // Food Types 
            foodTypes = new List<string>()
            {
                "Hay",
                "Grain",
                "Silage",
                "Pellets",
                "Grass",
                "Corn",
                "Fishmeal",
                "Molasses",
                "Straw",
                "Vegetables",
            };

        }

        // Getters
        // Returns the list of avaialable animal types or species
        public List<string> GetAnimalTypes()
        {
            return animalTypes;
        }

        // Returns the list of avaialable food types or 
        public List<string> GetFoodTypes()
        {
            return foodTypes;
        }

        // Returns the max number of animals
        public int GetMaxAnimals()
        {
            return maxAnimals;
        }

        // Get food prices
        // Returns the price per kg for the food types
        public double GetFoodPrice(string foodType)
        {
            switch (foodType)
            {
                case "Hay": return PRICE_HAY;
                case "Grain": return PRICE_GRAIN;
                case "Silage": return PRICE_SILAGE;
                case "Pellets": return PRICE_PELLETS;
                case "Grass": return PRICE_GRASS;
                case "Corn": return PRICE_CORN;
                case "Fishmeal": return PRICE_FISHMEAL;
                case "Molasses": return PRICE_MOLASSES;
                case "Straw": return PRICE_STRAW;
                case "Vegetables": return PRICE_VEGETABLES;
                default: return PRICE_GRAIN;
                    // fallback to grain price
            }
        }


        // Makes a unique id for each animal
        private string GenerateId()
        {
            int nextId = animalList.Count + 1;
            return "Animal" + nextId;
        }

        // Gets the number of animals on farm
        // Only counts the active animals
        public int GetAnimalCount()
        {
            int count = 0;

            foreach (Animal animal in animalList)
            {
                if (animal.GetIsOnFarm() == true)
                {
                    count++;
                }
            }

            return count;
        }

        // Searches the list for an animal with a matching ID
        public Animal GetAnimalById(string id)
        {
            foreach (Animal animal in animalList)
            {
                if (animal.GetAnimalId() == id)
                {
                    return animal;
                }
            }

            // no match found
            return null;
        }


        // Get All Animals
        public List<Animal> GetAllAnimals()

        {
            List<Animal> activeAnimals = new List<Animal>();

            foreach (Animal animal in animalList)
            {
                if (animal.GetIsOnFarm() == true)
                {
                    activeAnimals.Add(animal);
                }
            }

            return activeAnimals;
        }


        // Get Weekly Cost
        // Gets the total feeding cost across all active animals for the week
        public double GetTotalWeeklyCost()
        {
            double total = 0;

            foreach (Animal animal in GetAllAnimals())
            {
                total += animal.GetWeeklyCost();
            }

            return total;
        }

        // Get Weekly Species Cost
        // Gets the total feeding cost across a species for the week
        public double GetTotalWeeklyIntake()
        {
            double total = 0;

            foreach (Animal animal in GetAllAnimals())
            {
                total += animal.GetWeeklyIntake();
            }

            return total;
        }


        // Animal and Food
        // Adds Animal
        // Creates animal and adds to list
        public void AddAnimal(string animalName, string animalSpecies, string foodType, double budget)
        {
            // will not add if farm is full only adds if animal count is less than max animals
            if (GetAnimalCount() < maxAnimals)
            {

                // generate a unique ID for the new animal
                string id = GenerateId();

                // gets the correct price for food type
                double costPerKg = GetFoodPrice(foodType);

                Animal newAnimal = new Animal(id, animalName, animalSpecies, costPerKg, budget);
                animalList.Add(newAnimal);


            }

        }

        // Removes Animal
        // Sets IsOnFarm to false so the animal is not active or registered on farm
        public void RemoveAnimal(string id)
        {
            Animal animal = GetAnimalById(id);

            if (animal != null)
            {
                animal.SetOnFarm(false);
            }

        }


        // Update Daily Food
        // Finds the animal by ID and updates its food intake for a given day
        public void UpdateDailyFood(string id, int day, double kg)
        {
            Animal animal = GetAnimalById(id);

            if (animal != null)
            {
                animal.SetDailyFood(day, kg);
            }
        }



        // A list of all animals in a string
        public List<string> GetAnimalSummaries()
        {
            List<string> summaries = new List<string>();

            foreach (Animal a in animalList)
            {
                summaries.Add(a.AnimalSummary());
            }

            return summaries;
        }

        // Creates a a summary report and gets it
        public string GetSummaryReport()
        {
            string report = "===================================\n";
            report += "       WEEKLY FEEDING REPORT\n";
            report += "===================================\n";

            List<Animal> animals = GetAllAnimals();

            if (animals.Count == 0)
            {
                report += "No animals on the farm.\n";
            }
            else
            {
                // list each animal's summary
                foreach (Animal animal in animals)
                {
                    report += animal.AnimalSummary() + "\n";
                }

                report += "-----------------------------------\n";
                report += $"Total Animals:  {GetAnimalCount()}\n";
                report += $"Total Intake:   {GetTotalWeeklyIntake():F2} kg\n";
                report += $"Total Cost:     ${GetTotalWeeklyCost():F2}\n";
            }

            report += "===================================";

            return report;
        }


    }
}


