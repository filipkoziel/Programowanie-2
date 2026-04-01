using DayPlannerRepositoryClassLibrary.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayPlannerRepositoryClassLibrary.DTOs
{
    internal class PlanDTO
    {
        public int Id { get; set; }

        public string Text { get; set; } = null!;

        public int PlannerdayId { get; set; }

        public virtual Plannerday Plannerday { get; set; } = null!;
    }
}
