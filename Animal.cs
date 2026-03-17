using System;
using System.Collections.Generic;
using System.Text;

namespace LivestockGui
{
    internal class Animal
    {
        // Properties
        private string animalName;
        private string animalSpecies;
        private string animalID;
        private double farmBudget;
        private bool isOnFarm;
        private double foodCostPerKg;
        private double[] dailyFoodKg; // stores food intake


        // Methods

        // Constructor
        public Animal(string animalID, string animalName, string animalSpecies, double foodCostPerKg, double farmBudget)
            {
            this.animalID = animalID;
            this.animalName = animalName;
            this.animalSpecies = animalSpecies;
            this.foodCostPerKg = foodCostPerKg;
            this.farmBudget = farmBudget;

            isOnFarm = true;

            dailyFoodKg = new double[7];
        }

        // Getters
        public string GetAnimalId()
        {
            return animalID;
        }

        public string GetAnimalName()
        {
            return animalName;
        }

        public string GetAnimalSpecies()
        {
            return animalSpecies;
        }

        public bool GetIsOnFarm()
        {
            return isOnFarm;
        }

        public double GetBudget()
        {
            return farmBudget;
        }

    }

}