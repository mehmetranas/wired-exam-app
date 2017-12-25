using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WiredExamApp.Core.Repositories
{
    public interface IUnitOfWork
    {
        IExamRepository Exam { get; }
        IQuestionRepository Question { get; }

        void Complete();
    }
}