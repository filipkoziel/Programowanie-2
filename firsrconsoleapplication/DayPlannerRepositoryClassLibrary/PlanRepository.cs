using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DayPlannerRepositoryClassLibrary.DTOs;
using DayPlannerRepositoryClassLibrary.models;
using Microsoft.EntityFrameworkCore;

namespace DayPlannerRepositoryClassLibrary
{
    public class PlanRepository
    {
        public PlanDBContext context = new PlanDBContext();

        public List<int> GetPlannedYears()
        {
            return context.Plannerdays
                .Select(d => d.Year)
                .Distinct()
                .ToList();
        }
        public List<int> GetPlannedMonths(int selectedYear)
        {
            return context.Plannerdays
                .Where(d => d.Year == selectedYear)
                .Select(d => d.Month)
                .Distinct()
                .ToList();
        }
        public List<int> GetPlannedDays(int selectedMonth)
        {
            return context.Plannerdays
                .Where (d => d.Month == selectedMonth)
                .Select(d => d.Day)
                .Distinct()
                .ToList();
        }

        public List<string> GetPlan(int selectedYear, int selectedMonth, int SelectedDay)
        {
            return context.Plans
                .Include(p => p.Plannerday)
                .Where(p => p.Plannerday.Year == selectedYear)
                .Select(p => p.Text)
                .ToList();
        }

        public void InsertNewPlan(int day, int month, int year, string text)
        {
            Plannerday? plannerday = context.Plannerdays.FirstOrDefault(pd => pd.Day == day && pd.Month == month && pd.Year == year);
            if (plannerday == null)
            {
                plannerday = new Plannerday() {Day = day, Month = month, Year = year };
                context.Plannerdays.Add(plannerday);
                context.SaveChanges();
            }

            Plan plan = new Plan() { Text = text , PlannerdayId = plannerday.Id};
            context.Plans.Add(plan);
            context.SaveChanges();
        }
    }
}
