using System;
using System.Collections.Generic;
using System.Text;
using YoYoWebApp.Data.Models;

namespace YoYoWebApp.Data.Services.FitnessRatings
{
    interface IFitnessRatingData
    {
        public Dictionary<String, FitnessRating> GetAll();
    }
}
