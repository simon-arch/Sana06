namespace Inheritance;
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
    public void SetYear(int year) {if(year > 0) Year = year;}
    public void SetMonth(int month) {if(month > 0 && month <= 12) Month = month;}
    public void SetDay(int day) {if(day > 0 && day <= 366)  Day = day;}
    public int GetDay() {return Day;}
    public int GetMonth() {return Month;}
    public int GetYear() {return Year;}
}
public class ZnoList
{
    protected int ZnoPriority1;
    protected int ZnoPriority2;
    protected int ZnoPriority3;
    protected int ZnoPriority4;
    public ZnoList(int znoPriority1, int znoPriority2, int znoPriority3, int znoPriority4)
    {
        ZnoPriority1 = znoPriority1;
        ZnoPriority2 = znoPriority2;
        ZnoPriority3 = znoPriority3;
        ZnoPriority4 = znoPriority4;
    }
    public void setZnoPriority1(int znoPriority1) {if(ZnoPriority1 > 0 && ZnoPriority1 <= 200) ZnoPriority1 = znoPriority1;}
    public void setZnoPriority2(int znoPriority2) {if(ZnoPriority2 > 0 && ZnoPriority2 <= 200) ZnoPriority2 = znoPriority2;}
    public void setZnoPriority3(int znoPriority3) {if(ZnoPriority3 > 0 && ZnoPriority3 <= 200) ZnoPriority3 = znoPriority3;}
    public void setZnoPriority4(int znoPriority4) {if(ZnoPriority4 > 0 && ZnoPriority4 <= 200) ZnoPriority4 = znoPriority4;}
    public int getZnoPriority1() {return ZnoPriority1;}
    public int getZnoPriority2() {return ZnoPriority2;}
    public int getZnoPriority3() {return ZnoPriority3;}
    public int getZnoPriority4() {return ZnoPriority4;}

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
    public virtual string ShowInfo()
    {
        return $"ПІБ: {Surname} {Name} {Patronymic}\n" +
            $"  > Дата народження: {((int)BirthDate.GetDay()).ToString().PadLeft(2,'0')}." +
                $"{((int)BirthDate.GetMonth()).ToString().PadLeft(2, '0')}." +
                    $"{((int)BirthDate.GetYear()).ToString().PadLeft(4, '0')}\n";
    }
    public void SetName(string name) {if(name.Length > 0) Name = name;}
    public void SetSurname(string surname) {if(surname.Length > 0) Surname = surname;}
    public void SetPatronymic(string patronymic) {if(patronymic.Length > 0) Patronymic = patronymic;}
    public void SetBirthDate(Date date) {BirthDate = date;}
    public string GetName() {return Name;}
    public string GetSurname() {return Surname;}
    public string GetPatronymic() {return Patronymic;}
    public Date GetBirthDate() {return BirthDate;}
}
public class Enrollee : Person
{
    protected ZnoList ZnoMarks;
    protected int SchoolMark;
    protected string University;
    public Enrollee(string name, string surname, string patronymic, Date birthDate, ZnoList znoMarks, int schoolMark, string university) : 
        base(name, surname, patronymic, birthDate)
    {
        ZnoMarks = znoMarks;
        SchoolMark = schoolMark;
        University = university;
    }
    public override string ShowInfo()
    {
        return $"[Абітурієнт]\n{base.ShowInfo()}[Результати ЗНО]\n" +
            $"  - Математика: {(int)ZnoMarks.getZnoPriority1()}\n" +
            $"  - Українська мова: {(int)ZnoMarks.getZnoPriority2()}\n" +
            $"  - Історія України: {(int)ZnoMarks.getZnoPriority3()}\n" +
            $"  - Предмет на вибір: {(int)ZnoMarks.getZnoPriority4()}\n" +
            $"> Бали за документ про освіту: {SchoolMark}\n" +
            $"> Вищий навчальний заклад: {University}\n";
    }
    public void SetZnoMarks(ZnoList znomarks) {ZnoMarks = znomarks;}
    public void SetSchoolMark(int schoolmark) {if(SchoolMark > 0 && SchoolMark <= 12) SchoolMark = schoolmark;}
    public void SetUniversity(string university) {if(University.Length > 0) University = university;}
    public ZnoList GetZnoMarks() {return ZnoMarks;}
    public int GetSchoolMark() {return SchoolMark;}
    public string GetUniversity() {return University;}
}
public class Student : Person
{
    protected int Course;
    protected string Group;
    protected string Faculty;
    protected string University;
    public Student(string name, string surname, string patronymic, Date birthDate, int course, string group, string faculty, string university) :
        base(name, surname, patronymic, birthDate)
    {
        Course = course;
        Group = group;
        Faculty = faculty;
        University = university;
    }
    public override string ShowInfo()
    {
        return $"[Студент]\n{base.ShowInfo()}- Факультет: {Faculty}\n- Курс: {Course}\n" +
            $"- Група: {Group}\n- Вищий навчальний заклад: {University}\n";
    }
    public void setCourse(int course) {if(course >= 1 && course <= 4) Course = course;}
    public void setGroup(string group) {if(group.Length > 0) Group = group;}
    public void setFaculty(string faculty) {if(faculty.Length > 0) Faculty = faculty;}
    public void setUniversity(string university) {if(university.Length > 0) University = university;}
    public int getCourse() {return Course;}
    public string getGroup() {return Group;}
    public string getFaculty() {return Faculty;}
    public string getUniversity() {return University;}

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
    public override string ShowInfo()
    {
        return $"[Викладач]\n{base.ShowInfo()}- Посада: {Position}\n" +
            $"- Кафедра: {Cathedra}\n- Вищий навчальний заклад: {University}\n";
    }
    public void setPosition(string position) {if(position.Length > 0) Position = position;}
    public void setCathedra(string cathedra) {if(cathedra.Length > 0) Cathedra = cathedra;}
    public void setUniversity(string university) {if(university.Length > 0) University = university;}
    public string getPosition() {return Position;}
    public string getCathedra() {return Cathedra;}
    public string getUniversity() {return University;}
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
    public override string ShowInfo()
    {
        return $"[Користувач бібліотеки]\n{base.ShowInfo()}- Номер читацького квитка: #{ReaderTicket}\n" +
            $"  > Дата видачі: {((int)BirthDate.GetDay()).ToString().PadLeft(2, '0')}." +
                $"{((int)BirthDate.GetMonth()).ToString().PadLeft(2, '0')}." +
                    $"{((int)BirthDate.GetYear()).ToString().PadLeft(4, '0')}\n" +
            $"- Розмір щомісячного читацького внеску: {MonthlyContribution}грн";
    }
    public void setReaderTicket(int readerTicket) {if(readerTicket > 0) ReaderTicket = readerTicket;}
    public void setIssueDate(Date issueDate) {IssueDate = issueDate;}
    public void setMonthlyContribution(int monthlyContribution) {if(monthlyContribution >= 0) MonthlyContribution = monthlyContribution;}
    public int getReaderTicket() {return ReaderTicket;}
    public Date getIssueDate() {return IssueDate;}
    public int getMonthlyContribution() {return MonthlyContribution;}
}