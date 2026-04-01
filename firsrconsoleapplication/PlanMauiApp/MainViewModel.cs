using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanMauiApp.ViewModelModels;
using DayPlannerRepositoryClassLibrary;
using DayPlannerRepositoryClassLibrary.DTOs;


namespace PlanMauiApp
{
    public class MainViewModel : BindableObject
    {
        private int selectedYear;
        public int SelectedYear
        {
            get { return selectedYear; }
            set { selectedYear = value; OnPropertyChanged(); }
        }

        private int selectedMonth;
        public int SelectedMonth
        {
            get { return selectedMonth; }
            set { selectedMonth = value; OnPropertyChanged(); }
        }

        private int selectedDay;
        public int SelectedDay
        {
            get { return selectedDay; }
            set { selectedDay = value; OnPropertyChanged(); }
        }


        private List<int> plannedYears;
		public List<int> PlannedYears
        {
			get { return plannedYears; }
			set { plannedYears = value; OnPropertyChanged(); }
		}

        private List<int> plannedMonths;
        public List<int> PlannedMonths
        {
            get { return plannedMonths; }
            set { plannedMonths = value; OnPropertyChanged(); }
        }

        private List<int> plannedDays;
        public List<int> PlannedDays
        {
            get { return plannedDays; }
            set { plannedDays = value; OnPropertyChanged(); }
        }
        

        PlanRepository repository;
		public MainViewModel()
		{
            repository = new PlanRepository();
			PlannedYears = repository.GetPlannedYears();
            SelectedYear = PlannedYears.FirstOrDefault();
            PlannedMonths = repository.GetPlannedMonths(SelectedYear);
            SelectedMonth = PlannedMonths.FirstOrDefault();
            PlannedDays = repository.GetPlannedDays(SelectedMonth);
            selectedDay = PlannedDays.FirstOrDefault();

        }
	}
}
