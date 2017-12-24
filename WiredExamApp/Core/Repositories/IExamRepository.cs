using WiredExamApp.Models;

namespace WiredExamApp.Core.Repositories
{
    public interface IExamRepository
    {
        void Add(Exam exam);
        void Remove(Exam exam);
        Exam GetExamById(int id);
    }
}