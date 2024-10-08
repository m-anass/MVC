﻿using MVC_Project.Models;

namespace MVC_Project.Reposetory
{
    public interface ICourseRepo 
    {
        List<Course> GetAll();
        Course GetById(int id);
        void Add(Course newCourse);
        void Edit(int id, Course newCourse);
        void Delete(int id);
        List<Department> GetAllDepartments();
    }
}
