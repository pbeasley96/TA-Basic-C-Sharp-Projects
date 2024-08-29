﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Collections;

namespace ConsoleApFinalChallengeAssignment
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public Grade Grade { get; set; }
    }
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {

        }
        // Entities        
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Phillip" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();

                Console.Write("Student has been saved sucessfully!");
                Console.ReadLine();
            }
        }
    }
}
