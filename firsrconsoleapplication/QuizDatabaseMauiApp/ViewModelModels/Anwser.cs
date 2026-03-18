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

        private int anwserText;

        public int AnswerText
        {
            get { return anwserText; }
            set { anwserText = value; }
        }

        private int isCorrect;

        public int IsCorrect
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
