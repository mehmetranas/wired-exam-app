using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using WiredExamApp.Core.DTOs;
using WiredExamApp.Core.Models;

namespace WiredExamApp.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<QuestionDto, Question>();
            CreateMap<ExamDto, Exam>();
            CreateMap<SelectionDto, Selection>();
        }
    }
}