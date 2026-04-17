using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace LivestockGui
{
    public class Animal
    {
        // Properties
        private string animalName;
        private string animalSpecies;
        private string animalId;
        private bool isOnFarm;
        private double foodCostPerKg;
        private double[] dailyFoodKg; // stores food intake
        private string? foodType;
        private double budget;


        // Methods

        // Constructor
        public Animal(string animalId, string animalName, string animalSpecies, double foodCostPerKg, double budget)
        {
            this.animalId = animalId;
            this.animalName = animalName;
            this.animalSpecies = animalSpecies;
            this.foodCostPerKg = foodCostPerKg;
            this.budget = budget;

            isOnFarm = true;
            dailyFoodKg = new double[7];
        }

        public Animal(string animalName, string? animalSpecies, string? foodType, double budget)
        {
            this.animalName = animalName;
            this.animalSpecies = animalSpecies;
            this.foodType = foodType;
            this.budget = budget;
        }

        // Getters
        public string GetAnimalId()
        {
            return animalId;
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
            return budget;
        }

        // Setters
        // Day 0: Monday, Day 6: Sunday
        // Kg has to be below 500kg
        public void SetDailyFood(int day, double kg)
        {
            if (day >= 0 && day <= 6)
            {
                if (kg >= 0 && kg <= 100)
                {
                    dailyFoodKg[day] = kg;
                }
                // If day is invalid (less than 0 or more than 6) or food kg is higher than 500kg then it isn't saved
            }
        }


        // Sets whether the animal is on the farm or not
        public void SetOnFarm(bool value)
        {
            isOnFarm = value;
        }

        // Calculations
        // Returns total food over week
        public double GetWeeklyIntake()
        {
            double total = 0;

            for (int i = 0; i < dailyFoodKg.Length; i++)
            {
                total += dailyFoodKg[i];
            }

            return total;
        }

        // Returns the total weekly food cost
        public double GetWeeklyCost()
        {
            return GetWeeklyIntake() * foodCostPerKg;
        }

        // Returns the daily food intake
        public double GetDailyAverage()
        {
            return GetWeeklyIntake() / 7;
        }

        // Budget
        public bool CheckBudget()
        {
            return GetWeeklyCost() > budget;
        }

        // Budget status and string return
        public string CheckBudgetStatus()
        {
            double weeklyCost = GetWeeklyCost();
            double difference = Math.Abs(weeklyCost - budget);

            if (weeklyCost > budget)
            {
                return $"Over budget by ${difference:F2}";
            }

            else if (weeklyCost == budget)
            {
                return "Exactly on budget";
            }
            else
            {
                return $"Under budget by ${difference:F2}";
            }
        }

        // Info and string returns
        // Animal Summary
        public string AnimalSummary()
        {
            return $"{animalId} | {animalName} ({animalSpecies}) | Weekly cost: ${GetWeeklyCost():F2}";
        }

        // Animal Info
        public string GetAnimalInfo()
        {
            string[] dayNames = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            
            string info = $"\n----------- Animal Info -----------" +
              $"\nID:       {animalId}" +
              $"\nName:     {animalName}" +
              $"\nSpecies:  {animalSpecies}" +
              $"\nOn Farm:  {isOnFarm}" +
              $"\n\n--- Weekly Feeding ---";

            // food intake per day loop
            for (int i = 0; i < dailyFoodKg.Length; i++)
            {
                info += $"\n{dayNames[i]}: {dailyFoodKg[i]:F2} kg";
            }

            // Info
            info += $"\n\nTotal Intake:  {GetWeeklyIntake():F2} kg" +
                    $"\nDaily Average: {GetDailyAverage():F2} kg" +
                    $"\nWeekly Cost:   ${GetWeeklyCost():F2}" +
                    $"\nBudget:        ${budget:F2}" +
                    $"\nStatus:        {CheckBudgetStatus()}";

            return info;
        }
    }
}

