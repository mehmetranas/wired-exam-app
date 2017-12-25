using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WiredExamApp.Models;

namespace WiredExamApp.Core.Repositories
{
    public interface IUnitOfWork
    {
        IExamRepository Exam { get; }

        void Complete();
    }
}