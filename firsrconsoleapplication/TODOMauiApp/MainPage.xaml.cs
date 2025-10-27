using System.Collections.ObjectModel;
using TODOMauiApp.Data;

namespace TODOMauiApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<TaskItem> TaskCollection { get; set; }

        private TaskItem selectedTask;
        public TaskItem SelectedTask
        {
            get { return selectedTask; }
            set { selectedTask = value; }
        }




        public MainPage()
        {
            TaskCollection = new ObservableCollection<TaskItem>()
            {
                new (){ Title="Umyj naczynia", IsCompleted=false },
                new (){ Title="Wynieś śmieci", IsCompleted=true },
                new (){ Title="Podlej rośliny", IsCompleted=true },
                new (){ Title="Nakarm psa", IsCompleted=false },
                new (){ Title="Wstaw pranie", IsCompleted=true },
                new (){ Title="Powieś pranie", IsCompleted=false },
            };
            SelectedTask = TaskCollection.First();

            InitializeComponent();
        }


    }
}
