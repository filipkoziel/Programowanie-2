using DayPlannerRepositoryClassLibrary.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanMauiApp.ViewModelModels
{
    public class Plan
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public Command Delete { get; set; }
    }
}

