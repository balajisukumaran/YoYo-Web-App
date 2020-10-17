using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Linq;
using YoYoWebApp.Data.Models;

namespace YoYoWebApp.Data.Services.FitnessRatings
{
    public class InMemoryFitnessRating : IFitnessRatingData
    {
        public Dictionary<String, FitnessRating> GetAll()
        {
            var jsonString = File.ReadAllText(".\\JSON\\fitnessrating_beeptest.json");
            var fitnessRating = JsonSerializer.Deserialize<FitnessRating[]>(jsonString);
            Dictionary<String, FitnessRating> fitnessRatingDictionary = new Dictionary<String, FitnessRating>();
            foreach (FitnessRating _fitnessRating in fitnessRating)
                fitnessRatingDictionary.Add(_fitnessRating.StartTime, _fitnessRating);
            return fitnessRatingDictionary;
        }
    }
}
