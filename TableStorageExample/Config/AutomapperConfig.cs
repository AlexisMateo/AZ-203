using AutoMapper;
using TableStorageExample.Models;

namespace TableStorageExample.Config
{
    public static class AutomapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<EmployeeEntity, Employee>().ReverseMap();
            });

        }
        
    }
}