using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthTracker.Models
{
    public class FormData
    {
        public int Id { get; set; }
        public string Mood { get; set; }
        public string Breakfast { get; set; }
        public string Lunch { get; set; }
        public string Dinner { get; set; }
        public string Snacks { get; set; }
        public bool ExerciseBehaviors { get; set; }
        public string BehaviorActivity { get; set; }
        public bool Smoked { get; set; }
        public bool Drank { get; set; }
        public bool Sexed { get; set; }

        public FormData()
        {
        }
    }
}
