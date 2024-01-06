namespace Inheritance
{
    internal class ClassLibrary
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
            protected string name;
            protected string surname;
            protected string patronymic;
            protected Date birthDate;
        }
        public class Enrollee : Person
        {
            protected int znoMark;
            protected int schoolMark;
            protected string university;
        }
        public class Student : Person
        {
            protected int course;
            protected int group;
            protected string faculty;
            protected string university;
        }
        public class Professor : Person
        {
            protected string position;
            protected string cathedra;
            protected string university;
        }
        public class LibraryUser : Person
        {
            protected int readerTicket;
            protected Date issueDate;
            protected int monthlyContribution;
        }
    }
}
