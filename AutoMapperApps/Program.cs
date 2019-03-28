using System;
using System.Collections.Generic;

namespace AutoMapperApps
{
    class Program
    {
        static void Main(string[] args)
        {
            //var student = new Student()
            //{
            //    Id = 1,
            //    FirstName = "Shohag",
            //    LastName = "Mia",
            //    ContactNo = "01926029000",
            //    Email = "shohaghassan14@gmail.com"
            //};
            //AutoMapper.Mapper.Initialize(configureModelSourceToDestination =>
            //{
            //    configureModelSourceToDestination.CreateMap<Student, Teacher>()
            //        .ForMember(destination => destination.FullName, opt => opt.MapFrom(a => a.FirstName));
            //});
            //var teacher = AutoMapper.Mapper.Map<Teacher>(student);

            List<Student> students = new List<Student>()
            {
                new Student(){Id=1,FirstName = "Shohag",LastName = "Mia",ContactNo = "01926029000",Email = "shohaghassan14@gmail.com"},
                new Student(){Id=1,FirstName = "Shohag",LastName = "Mia",ContactNo = "01926029000",Email = "shohaghassan14@gmail.com"},
                new Student(){Id=1,FirstName = "Shohag",LastName = "Mia",ContactNo = "01926029000",Email = "shohaghassan14@gmail.com"},
                new Student(){Id=1,FirstName = "Shohag",LastName = "Mia",ContactNo = "01926029000",Email = "shohaghassan14@gmail.com"},
                new Student(){Id=1,FirstName = "Shohag",LastName = "Mia",ContactNo = "01926029000",Email = "shohaghassan14@gmail.com"},
            };
            AutoMapper.Mapper.Initialize(configureModelSourceToDestination =>
            {
                configureModelSourceToDestination.CreateMap<Student, Teacher>();
            });

            var teachers = AutoMapper.Mapper.Map<List<Teacher>>(students);
            foreach (Teacher aTeacher in teachers)
            {
                Console.WriteLine($"Id-{aTeacher.Id}, Full Name-{aTeacher.FirstName} {aTeacher.LastName}, Contact No-{aTeacher.ContactNo} & Email-{aTeacher.Email}");
            }

            Console.ReadKey();
        }
    }
}
