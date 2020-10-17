using System;
using System.Collections.Generic;
using System.Text;
using YoYoWebApp.Data.Models;

namespace YoYoWebApp.Data.Services.Athletes
{
    public interface IAthlete 
    {
        public List<Athlete> GetAll();
        public Athlete Get(int id);
        public void updateProgress(string query);
    }
}