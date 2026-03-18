using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizRepositoryClassLibrary.DTOs;
using QuizRepositoryClassLibrary.Models;

namespace QuizRepositoryClassLibrary
{
    public class QuizRepository
    {
        public QuizDBContext context;

        public QuizRepository()
        {
            context = new QuizDBContext();
        }

        public List<Question> GetAllQuestions()
        {
            return context.Questions
                .OrderBy(p => p.Id)
                .ToList();
        }

        public List<Answer> GetAllAnwsers()
        {
            return context.Answers
                .OrderBy(p => p.Id)
                .ToList();
        }

        public List<QuestionsDTO> GetAllQuestionsDTO()
        {
            return context.Questions
                .OrderBy(q => q.Id)
                .Select(q => new QuestionsDTO() { Id = q.Id, QuestionText = q.QuestionText })
                .ToList();
        }

        public List<AnwsersDTO> GetAllAnwsersDTO()
        {
            return context.Answers
                .OrderBy(a => a.Id)
                .Select(a => new AnwsersDTO() { Id = a.Id, AnswerText = a.AnswerText, IsCorrect = a.IsCorrect, QuestionId = a.QuestionId })
                .ToList();
        }
    }
}
