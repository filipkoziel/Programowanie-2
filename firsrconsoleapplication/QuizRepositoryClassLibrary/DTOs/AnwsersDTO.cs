using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizRepositoryClassLibrary.DTOs
{
    public class AnwsersDTO
    {
        public int Id { get; set; }

        public string AnswerText { get; set; } = null!;

        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }
    }
}
