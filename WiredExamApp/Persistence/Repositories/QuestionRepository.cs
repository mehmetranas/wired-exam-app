using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WiredExamApp.Core.Repositories;
using WiredExamApp.Models;

namespace WiredExamApp.Persistence.Repositories
{
    public class QuestionRepository: IQuestionRepository
    {
        private readonly ApplicationDbContext _context;

        public QuestionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public string GetQuestionAnswerById(int id)
        {
            return _context.Questions.FirstOrDefault(x => x.Id == id)?.Answer;
        }
    }
}