using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using Ninject.Infrastructure.Language;
using WiredExamApp.Core.Models;
using WiredExamApp.Core.Repositories;
using WiredExamApp.Persistence.Model;

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

        public bool Remove(int id)
        {
            var exam = _context.Exams.FirstOrDefault(x => x.Id == id);
            if (exam == null) return false ;
            _context.Exams.Remove(exam);
            return true;
        }

        public Exam GetExamById(int id)
        {
            var exam = _context.Exams.Include(x => x.Questions).Include(x => x.Questions.Select(q => q.Selections)).FirstOrDefault(x => x.Id == id);
            return exam ?? null;
        }

        public ICollection<Exam> GetExams()
        {
            return _context.Exams.Include(x => x.Questions).ToList();
        }

        public ICollection<Title> GetExamTitles()
        {
            return _context.Exams.Select(x =>
                new Title
                {
                    ArticleTitle = x.Title,
                    Id = x.Id,
                    CreateDateTime = x.CreateDateTime
                }).ToList();
        }
    }
}