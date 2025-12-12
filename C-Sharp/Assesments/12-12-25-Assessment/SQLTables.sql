
create database EduTrack

------Student table---------
create table Students (
    StudentId int identity(1,1) primary key,
    FullName varchar(100) NOT NULL,
    Email varchar(100) UNIQUE,
    Department varchar(50) NOT NULL,
    YearOfStudy int NOT NULL
);
insert into Students (FullName, Email, Department, YearOfStudy)
values 
('Sairam', 'sairamnaidu@gmail.com', 'Computer Science', 2),
('Venkat', 'Venkat@gmail.com', 'Electrical Engineering', 3),
('Karthik', 'Karthik@gmail.com', 'Mechanical Engineering', 1),
('Siva', 'siva@gmail.com', 'Civil Engineering', 4),
('Rajesh', 'rajesh@gmail.com', 'Computer Science', 3);

select * from Students


----------Courses table--------------
create table Courses (
    CourseId int identity(1,1) primary key,
    CourseName varchar(100) NOT NULL,
    Credits int NOT NULL,
    Semester varchar(20) NOT NULL
);

insert into  Courses (CourseName, Credits, Semester)
values
('Programming', 4, 'Fall'),
('Data Structures', 3, 'Spring'),
('Digital Electronics', 3, 'Fall'),
('Thermodynamics', 4, 'Spring'),
('Mathematics', 3, 'Fall');

insert into Courses (CourseName, Credits, Semester)
values ('Database Systems', 3, 'Spring');

select * from Courses


------------Enrollement tables---------------

create table Enrollments (
    EnrollmentId int identity(1,1) primary key,
    StudentId int NOT NULL,
    CourseId int NOT NULL,
    EnrollDate datetime NOT NULL,
    Grade varchar(5) NULL,
    foreign key (StudentId) references Students(StudentId),
    foreign key (CourseId) references Courses(CourseId)
);

insert into Enrollments (StudentId, CourseId, EnrollDate, Grade)
values
(1, 1, '2025-09-01', 'A'),
(1, 2, '2025-08-29', 'B+'),
(2, 3, '2025-09-03', 'A-'),
(3, 4, '2025-08-30', NULL),
(4, 5, '2025-09-01', 'B');

select * from Enrollments

--------Stored Procedure--------
create procedure usp_GetCoursesBySemester (@semester varchar(20))
as
begin
    select CourseId, CourseName, Credits, Semester
    from Courses
    where Semester = @semester;
end

