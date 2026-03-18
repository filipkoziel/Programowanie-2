using QuizRepositoryClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizRepositoryClassLibrary.DTOs
{
    public class QuestionsDTO
    {
        public int Id { get; set; }
        
        public string QuestionText { get; set; } = null!;
    }
}
