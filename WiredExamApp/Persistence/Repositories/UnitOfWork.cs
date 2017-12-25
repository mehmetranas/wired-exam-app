using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WiredExamApp.Core.Repositories;
using WiredExamApp.Models;

namespace WiredExamApp.Persistence.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IExamRepository Exam { get; }
        public IQuestionRepository Question { get; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Exam = new ExamRepository(_context);
            Question = new QuestionRepository(_context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}