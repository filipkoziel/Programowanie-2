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

        private bool anwserUnlocked;
        public bool AnwserUnlocked
        {
            get { return anwserUnlocked; }
            set { anwserUnlocked = value; OnPropertyChanged(); }
        }

        private Question currentQuestion;
        public Question CurrentQuestion
        {
            get { return currentQuestion; }
            set { currentQuestion = value; OnPropertyChanged(); }
        }
        private ObservableCollection<Anwser> currentAnwsers;
        public ObservableCollection<Anwser> CurrentAnwsers
        {
            get { return currentAnwsers; }
            set { currentAnwsers = value; OnPropertyChanged(); }
        }

        private Anwser selectedAnwser;
        public Anwser SelectedAnwser
        {
            get { return selectedAnwser; }
            set { selectedAnwser = value; OnPropertyChanged(); }
        }

        private Anwser lockedInAnwser;
        public Anwser LockedInAnwser
        {
            get { return lockedInAnwser; }
            set { lockedInAnwser = value; OnPropertyChanged(); }
        }

        private string message;
        public string Message;
        {

        }

        private Command nextQuestion;
        public Command NextQuestion
        {
            get
            {
                if (nextQuestion == null)
                    nextQuestion = new Command(
                        () =>
                        {
                            AnwserUnlocked = true;
                            LockedInAnwser = selectedAnwser;
                            QuestionNumber++;
                            RefreshQuestionsAndAnwsers();
                        }
                        );
                return nextQuestion;

            }
        }

        private Command checkSelectedAnwser;
        public Command CheckSelectedAnwser
        {
            get
            {
                if (checkSelectedAnwser == null)
                    checkSelectedAnwser = new Command(
                        () =>
                        {
                            AnwserUnlocked = false;
                            LockedInAnwser = selectedAnwser;
                        }
                        );
                return checkSelectedAnwser;

            }

        }

        QuizRepository repository;
        public MainViewModel()
        {
            QuestionNumber = 1;
            AnwserUnlocked = true;
            repository = new QuizRepository();
            Questions = new ObservableCollection<Question>();
            GetQuestions();
            Anwsers = new ObservableCollection<Anwser>();
            GetAnwsers();
            RefreshQuestionsAndAnwsers();
        }

        void GetQuestions()
        {
            Questions.Clear();
            foreach (QuestionsDTO question in repository.GetAllQuestionsDTO())
            {
                Questions.Add(new Question() { Id = question.Id, QuestionText = question.QuestionText });
            }
        }

        void GetAnwsers()
        { 
            Anwsers.Clear();
            foreach (AnwsersDTO anwser in repository.GetAllAnwsersDTO())
            {
                Anwsers.Add(new Anwser() { Id = anwser.Id, AnswerText = anwser.AnswerText, IsCorrect = anwser.IsCorrect, QuestionId = anwser.QuestionId});
            }
        }

        void RefreshQuestionsAndAnwsers()
        {
            CurrentQuestion = Questions[questionNumber - 1];
            CurrentAnwsers = new ObservableCollection<Anwser>(Anwsers.Where(a => a.QuestionId == (questionNumber)).ToList());
        }
    }
}
