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

        public QuestionsDTO? GetQuestionDTO(int number)
        {
            return context.Questions
                .OrderBy(p => p.Id)
                .Where(q => q.Id > number)
                .Select(q => new QuestionsDTO() { Id = q.Id, QuestionText = q.QuestionText })
                .FirstOrDefault();
        }

        public List<AnwsersDTO> GetCurrentAnwsersDTO(int number)
        {
            return context.Answers
                .Where(a => a.QuestionId == number)
                .Select(a => new AnwsersDTO() { Id = a.Id, AnswerText = a.AnswerText, IsCorrect = a.IsCorrect, QuestionId = a.QuestionId })
                .ToList();
        }
    }
}
