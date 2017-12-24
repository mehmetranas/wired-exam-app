using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WiredExamApp.Core.Repositories;
using WiredExamApp.Models;

namespace WiredExamApp.Persistence.Repositories
{
    public class ExamRepository: IExamRepository
    {
        private readonly ApplicationDbContext _context;

        public ExamRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Exam exam)
        {
            _context.Exams.Add(exam);
        }

        public void Remove(Exam exam)
        {
            throw new NotImplementedException();
        }

        public Exam GetExamById(int id)
        {
            throw new NotImplementedException();
        }
    }
}