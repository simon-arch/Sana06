namespace Inheritance
{
    public class Date
    {
        protected int Day;
        protected int Month;
        protected int Year;
        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public void SetYear(int year) {if (year > 0) Year = year;}
        public void SetMonth(int month) {if (month > 0 && month <= 12) Month = month;}
        public void SetDay(int day) {if (day > 0 && day <= 366)  Day = day;}
        public int GetDay() {return Day;}
        public int GetMonth() {return Month;}
        public int GetYear() {return Year;}
    }
    public class Person
    {
        protected string Name;
        protected string Surname;
        protected string Patronymic;
        protected Date BirthDate;
        public Person(string name, string surname, string patronymic, Date birthDate)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            BirthDate = birthDate;
        }
        public void SetName(string name) {if (name.Length > 0) Name = name;}
        public void SetSurname(string surname) {if (surname.Length > 0) Surname = surname;}
        public void SetPatronymic(string patronymic) {if (patronymic.Length > 0) Patronymic = patronymic;}
        public void SetBirthDate(Date date) {BirthDate = date;}
        public string GetName() {return Name;}
        public string GetSurname() {return Surname;}
        public string GetPatronymic() {return Patronymic;}
        public Date GetBirthDate() {return BirthDate;}
    }
    public class Enrollee : Person
    {
        protected int ZnoMark;
        protected int SchoolMark;
        protected string University;
        public Enrollee(string name, string surname, string patronymic, Date birthDate, int znoMark, int schoolMark, string university) : 
            base(name, surname, patronymic, birthDate)
        {
            ZnoMark = znoMark;
            SchoolMark = schoolMark;
            University = university;
        }
    }
    public class Student : Person
    {
        protected int Course;
        protected int Group;
        protected string Faculty;
        protected string University;
        public Student(string name, string surname, string patronymic, Date birthDate, int course, int group, string faculty, string university) :
            base(name, surname, patronymic, birthDate)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            University = university;
        }
    }
    public class Professor : Person
    {
        protected string Position;
        protected string Cathedra;
        protected string University;
        public Professor(string name, string surname, string patronymic, Date birthDate, string position, string cathedra, string university) :
            base(name, surname, patronymic, birthDate)
        {
            Position = position;
            Cathedra = cathedra;
            University = university;
        }
    }
    public class LibraryUser : Person
    {
        protected int ReaderTicket;
        protected Date IssueDate;
        protected int MonthlyContribution;
        public LibraryUser(string name, string surname, string patronymic, Date birthDate, int readerTicket, Date issueDate, int monthlyContribution) :
            base(name, surname, patronymic, birthDate)
        {
            ReaderTicket = readerTicket;
            IssueDate = issueDate;
            MonthlyContribution = monthlyContribution;
        }
    }
}
