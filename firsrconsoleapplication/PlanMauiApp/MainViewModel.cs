using DayPlannerRepositoryClassLibrary;
using DayPlannerRepositoryClassLibrary.DTOs;
using PlanMauiApp.ViewModelModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PlanMauiApp
{
    public class MainViewModel : BindableObject
    {


        private int selectedAvailableYearForNewPlan;
        public int SelectedAvailableYearForNewPlan
        {
            get { return selectedAvailableYearForNewPlan; }
            set {
                selectedAvailableYearForNewPlan = value; 
                OnPropertyChanged();
                SelectedAvailableYearChanged();
            }
        }

        private int selectedAvailableMonthForNewPlan;

        public int SelectedAvailableMonthForNewPlan
        {
            get { return selectedAvailableMonthForNewPlan; }
            set { 
                selectedAvailableMonthForNewPlan = value; 
                OnPropertyChanged();
                SelectedAvailableMonthChanged();
            }
        }

        private int selectedAvailableDayForNewPlan;

        public int SelectedAvailableDayForNewPlan
        {
            get { return selectedAvailableDayForNewPlan; }
            set { selectedAvailableDayForNewPlan = value; OnPropertyChanged(); }
        }

        private List<int> availableYearsForNewPlan;
        public List<int> AvailableYearsForNewPlan
        {
            get { return availableYearsForNewPlan; }
            set { availableYearsForNewPlan = value; OnPropertyChanged(); }
        }

        private List<int> availableMonthsForNewPlan;
        public List<int> AvailableMonthsForNewPlan
        {
            get { return availableMonthsForNewPlan; }
            set { availableMonthsForNewPlan = value; OnPropertyChanged(); }
        }

        private List<int> availableDaysForNewPlan;
        public List<int> AvailableDaysForNewPlan
        {
            get { return availableDaysForNewPlan; }
            set { availableDaysForNewPlan = value; OnPropertyChanged(); }
        }

        private int enteredYearForNewPlan;
        public int EnteredYearForNewPlan
        {
            get { return enteredYearForNewPlan; }
            set { enteredYearForNewPlan = value; OnPropertyChanged(); }
        }

        private int enteredMonthForNewPlan;
        public int EnteredMonthForNewPlan
        {
            get { return enteredMonthForNewPlan; }
            set { enteredMonthForNewPlan = value; OnPropertyChanged(); }
        }

        private int enteredDayForNewPlan;
        public int EnteredDayForNewPlan
        {
            get { return enteredDayForNewPlan; }
            set { enteredDayForNewPlan = value; OnPropertyChanged(); }
        }

        private string enteredTaskTextForNewPlan;
        public string EnteredTaskTextForNewPlan
        {
            get { return enteredTaskTextForNewPlan; }
            set { enteredTaskTextForNewPlan = value; OnPropertyChanged(); }
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

        private int selectedPlannedYear;
        public int SelectedPlannedYear
        {
            get { return selectedPlannedYear; }
            set
            {
                selectedPlannedYear = value;
                OnPropertyChanged();
                SelectedPlannedYearChanged();
            }
        }

        private int selectedPlannedMonth;
        public int SelectedPlannedMonth
        {
            get { return selectedPlannedMonth; }
            set
            {
                selectedPlannedMonth = value;
                OnPropertyChanged();
                SelectedPlannedMonthChanged();
            }
        }

        private int selectedPlannedDay;
        public int SelectedPlannedDay
        {
            get { return selectedPlannedDay; }
            set { selectedPlannedDay = value; OnPropertyChanged(); }
        }





        private ObservableCollection<Plan> plansForSelectedDay;
        public ObservableCollection<Plan> PlansForSelectedDay
        {
            get { return plansForSelectedDay; }
            set { plansForSelectedDay = value; OnPropertyChanged(); }
        }

        private Command addNewTaskToDatabase;
        public Command AddNewTaskToDatabase
        {
            get
            {
                if (addNewTaskToDatabase == null)
                    addNewTaskToDatabase = new Command(
                        () =>
                        {
                            repository.InsertNewPlan(selectedAvailableDayForNewPlan, selectedAvailableMonthForNewPlan, selectedAvailableYearForNewPlan, EnteredTaskTextForNewPlan);
                            RefreshListOfPlans();
                        }
                        );
                return addNewTaskToDatabase;
            }
        }

        private Command delete;
        public Command Delete
        {
            get
            {
                if (delete == null)
                    delete = new Command<Plan>(
                        (p) =>
                        {
                            repository.DeletePlanFromId(p.Id);
                            PlansForSelectedDay.Remove(p);
                        }
                        );
                return delete;
            }
        }

        private Command getPlansForDate;
        public Command GetPlansForDate
        {
            get 
            {
                if (getPlansForDate == null)
                    getPlansForDate = new Command(
                        () =>
                        {
                            if (PlansForSelectedDay == null)
                                PlansForSelectedDay = new ObservableCollection<Plan>();
                            else
                                PlansForSelectedDay.Clear();
                            foreach (PlanDTO planDTO in repository.GetPlansForDayDTO(SelectedPlannedYear, SelectedPlannedMonth, SelectedPlannedDay))
                            PlansForSelectedDay.Add(new Plan { Id = planDTO.Id, Text = planDTO.Text, Delete = Delete});
                        }
                        );
                return getPlansForDate;
            }
        }



        private void SelectedAvailableYearChanged()
        {
            List<int> months = new List<int>();
            DateTime time = new DateTime();
            DateTime start = new DateTime(SelectedAvailableYearForNewPlan, 1, 1);
            DateTime end = start.AddYears(1);
            for (DateTime i = start; i < end; i = i.AddMonths(1))
            {
                months.Add(i.Month);
            }
            AvailableMonthsForNewPlan = months;
            SelectedAvailableMonthForNewPlan = AvailableMonthsForNewPlan.FirstOrDefault();
        }

        private void SelectedAvailableMonthChanged()
        {
            List<int> days = new List<int>();
            DateTime time = new DateTime();
            DateTime start = new DateTime(SelectedAvailableYearForNewPlan, SelectedAvailableMonthForNewPlan, 1);
            DateTime end = start.AddMonths(1);
            for (DateTime i = start; i < end; i = i.AddDays(1))
            {
                days.Add(i.Day);
            }
            AvailableDaysForNewPlan = days;
            SelectedAvailableDayForNewPlan = AvailableDaysForNewPlan.FirstOrDefault();
        }

        private void SelectedPlannedYearChanged()
        {
            PlannedMonths = repository.GetPlannedMonths(SelectedPlannedYear);
            SelectedPlannedMonth = PlannedMonths.FirstOrDefault();
        }

        private void SelectedPlannedMonthChanged()
        {
            PlannedDays = repository.GetPlannedDays(SelectedPlannedMonth);
            SelectedPlannedDay = PlannedDays.FirstOrDefault();
        }

        PlanRepository repository;
		public MainViewModel()
		{
            repository = new PlanRepository();

            RefreshListOfPlans();
            repository.GetPlannedYears();

            SetAvailableYears();
            SelectedAvailableYearForNewPlan = AvailableYearsForNewPlan.FirstOrDefault();
        }

        private void SetAvailableYears()
        {
            DateTime localDate = DateTime.Today;
            AvailableYearsForNewPlan = new List<int>() { localDate.Year, localDate.Year + 1 };
        }
        private void RefreshListOfPlans()
        {
            PlannedYears = repository.GetPlannedYears();
            SelectedPlannedYear = PlannedYears.FirstOrDefault();
        }

    }
}
