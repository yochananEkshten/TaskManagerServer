using Api.Entities;
using Model;
using System;

using AutoMapper;

namespace Repository
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<TaskItem, TaskItemDTO>();
            CreateMap<SaveTaskRequest, TaskItem>();
        }
    }

}
