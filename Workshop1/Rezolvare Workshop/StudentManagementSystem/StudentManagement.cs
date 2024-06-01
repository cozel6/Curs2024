﻿using StudentManagementSystem;
using StudentManagementSystem.Extensions;
using StudentManagementSystem.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
     public class StudentManagement
    {
        private Repository<Student> studentRepository = new Repository<Student>();
        private Repository<Course> courseRepository = new Repository<Course>();
        private Repository<Teacher> teacherRepository = new Repository<Teacher>();

        public void AddStudent(string name , int grade , string address , int age)
        {
            studentRepository.Add(new Student(name, age, grade, address));
        }

        public void AddCourse(int courseId, Subject name, int duration, Teacher teacher)
        {
            courseRepository.Add(new Course(courseId, name, duration, teacher));
        }

        public void AddTeacher(string name, int age, string email, string phoneNumber)
        {
            teacherRepository.Add(new Teacher(name, age, email, phoneNumber));
        }

        public void EnrollStudentInCourse(string studentName, Subject courseName)
        {
            var student = studentRepository.GetAll().FindByName(studentName);

            if (student == null)
            {
                Console.WriteLine($"Unable to enroll student {studentName} to course {courseName} because student does not exist.");
                return;
            }

            var course = courseRepository.GetAll().FindByName(courseName);
            if (course == null)
            {
                Console.WriteLine($"Unable to enroll student {studentName} to course {courseName} because course does not exist.");
                return;
            }

            course.Enroll(student);
        }

        public void DisplayStudentsInCourse(Subject courseName)
        {
            var course = courseRepository.GetAll().FindByName(courseName);
            
            Console.WriteLine($"Students enrolled in course {course?.Name}:");
            
            foreach (var student in course.EnrolledStudents)
            {
                Console.WriteLine(student.GetDetails());
            }
        }

        // Method to display all courses a student is enrolled in
        public void DisplayCoursesForStudent(string studentName)
        {
            var student = studentRepository.GetAll().FindByName(studentName);

            Console.WriteLine($"Courses enrolled by {student?.Name}:");
            foreach (var course in courseRepository.GetAll().Where(c => c.EnrolledStudents.Contains(student)))
            {
                Console.WriteLine(course.Name);
            }
        }

        // Method to find all students with a grade above a certain value
        public IEnumerable<Student> FindStudentsWithGradeAbove(int grade)
        {
            return studentRepository.GetAll().FilterByGrade(grade);
        }

        // Method to find all courses with a duration longer than a certain duration
        public IEnumerable<Course> FindCoursesWithDurationLongerThan(int duration)
        {
            return courseRepository.GetAll().Where(c => c.Duration > duration);
        }

        // Method to find all teachers with an email address ending with a specific domain
        public IEnumerable<Teacher> FindTeachersWithEmailEndingWith(string domain)
        {
            return teacherRepository.GetAll().Where(t => t.Email.EndsWith(domain));
        }

        public IEnumerable<Teacher> FindTeachersWithPhoneNumberStartingWith(string prefix)
        {
            return teacherRepository.GetAll().Where(t => t.PhoneNumber.StartsWith(prefix));
        }

        public void DisplayStudentsInCoursesReport()
        {
            // Create an anonymous type report of students with their course names
            var studentCourseReport = studentRepository.GetAll()
                .Select(s => new
                {
                    StudentName = s.Name,
                    Courses = courseRepository.GetAll()
                        .Where(c => c.EnrolledStudents.Contains(s))
                        .Select(c => c.Name)
                        .ToList()
                });

            Console.WriteLine("Student Course Report:");
            foreach (var report in studentCourseReport)
            {
                Console.WriteLine($"Student: {report.StudentName}, Courses: {string.Join(", ", report.Courses)}");
            }
        }
    }
}
