using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizRepositoryClassLibrary;
using QuizRepositoryClassLibrary.DTOs;
using System.Collections.ObjectModel;
using QuizDatabaseMauiApp.ViewModelModels;

namespace QuizDatabaseMauiApp
{
    internal class MainViewModel: BindableObject
    {
        public ObservableCollection<Question> Questions { get; set; }

        public ObservableCollection<Anwser> Anwsers { get; set; }



        private int questionNumber;
        public int QuestionNumber
        {
            get { return questionNumber; }
            set { questionNumber = value; OnPropertyChanged(); }
        }

        private Question currentQuestion;
        public Question CurrentQuestion
        {
            get { return Questions[questionNumber]; }
            set { currentQuestion = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Anwser> currentAnwsers;
        public ObservableCollection<Anwser> CurrentAnwsers
        {
            get { return new ObservableCollection<Anwser>(Anwsers.Where(n=>n.QuestionId == questionNumber).ToList()); }
            set { currentAnwsers = value; OnPropertyChanged();}
        }

        private Command? getQuestion = null;
        public Command GetQuestion
        {
            get
            {
                if (getQuestion == null)
                    getQuestion = new Command(
                        () =>
                        {
                            Questions.Clear();
                            foreach (QuestionDTO person in repository.GetAllQuestionsDTO())
                            {
                                People.Add(new Person() { Id = person.Id, Name = person.Name, Surname = person.Surname, Age = person.Age, City = person.City });
                            }
                        }
                        );
                return getQuestion;
            }
        }

        QuizRepository repository;
        public MainViewModel()
        {
            QuestionNumber = 1;
            Questions = new ObservableCollection<Question>();
            Anwsers = new ObservableCollection<Anwser>();
            repository = new QuizRepository();
        }
    }
}
