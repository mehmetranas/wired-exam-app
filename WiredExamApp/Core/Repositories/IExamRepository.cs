using System.Collections.Generic;
using WiredExamApp.Core.Models;

namespace WiredExamApp.Core.Repositories
{
    public interface IExamRepository
    {
        void Add(Exam exam);
        bool Remove(int id);
        Exam GetExamById(int id);
        ICollection<Exam> GetExams();
        ICollection<Title> GetExamTitles();
    }
}