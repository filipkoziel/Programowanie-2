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

        private bool nextQuestionUnlocked;
        public bool NextQuestionUnlocked
        {
            get { return nextQuestionUnlocked; }
            set { nextQuestionUnlocked = value; OnPropertyChanged(); }
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
        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged(); }
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
                            Message = string.Empty;
                            ChangeCurrentQuestion();
                            ChangeCurrentAnwsers();
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
                            if (selectedAnwser.IsCorrect)
                            {
                                SelectedAnwser.Color = "lawngreen";
                                Message = "Dobra Odpowiedź";
                            }
                            else
                            {
                                SelectedAnwser.Color = "red";
                                foreach(Anwser anwser in currentAnwsers)
                                {
                                    if (anwser.IsCorrect)
                                        anwser.Color = "lawngreen";
                                }
                                Message = "Zła Odpowiedź";
                            }
                        }
                        );
                return checkSelectedAnwser;

            }

        }

        QuizRepository repository;
        public MainViewModel()
        {
            QuestionNumber = 0;
            AnwserUnlocked = true;
            NextQuestionUnlocked = true;
            repository = new QuizRepository();
            currentQuestion = new Question();
            ChangeCurrentQuestion();
            currentAnwsers = new ObservableCollection<Anwser>();
            ChangeCurrentAnwsers();
        }

        void ChangeCurrentQuestion()
        {
            var question = repository.GetQuestionDTO(questionNumber);
            if (question != null)
            {
                CurrentQuestion = new Question() { Id = question.Id, QuestionText = question.QuestionText };
                questionNumber = question.Id;
            }
            else
            { 
                NextQuestionUnlocked = false;
                AnwserUnlocked = false;
            }
        }

        void ChangeCurrentAnwsers()
        { 
            currentAnwsers.Clear();
            foreach (AnwsersDTO anwser in repository.GetCurrentAnwsersDTO(currentQuestion.Id))
            {
                CurrentAnwsers.Add(new Anwser() { Id = anwser.Id, AnswerText = anwser.AnswerText, IsCorrect = anwser.IsCorrect, QuestionId = anwser.QuestionId, Color = "black"});
            }
        }
    }
}
