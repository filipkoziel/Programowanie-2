using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDatabaseMauiApp.ViewModelModels
{
    public class Question
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string questionText;

		public string QuestionText
		{
			get { return questionText; }
			set { questionText = value; }
		}

	}
}
