using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDatabaseMauiApp.ViewModelModels
{
    public class Anwser
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string anwserText;

        public string AnswerText
        {
            get { return anwserText; }
            set { anwserText = value; }
        }

        private bool isCorrect;

        public bool IsCorrect
        {
            get { return isCorrect; }
            set { isCorrect = value; }
        }

        private int questionId;

        public int QuestionId
        {
            get { return questionId; }
            set { questionId = value; }
        }
    }
}
