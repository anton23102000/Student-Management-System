using Student_Managment_System;

public static class Program
{

    public static void Main()
    {
        var schoolClasses = new List<Class>();
        var users = new List<Teacher>();

        var manageSchool = new LoginMenu(users, schoolClasses);
        manageSchool.ShowMenu();
    }
}




