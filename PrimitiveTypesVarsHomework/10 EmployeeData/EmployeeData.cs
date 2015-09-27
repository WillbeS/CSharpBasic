using System;

    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            byte age = 27;
            char gender = 'f';
            long personalID = 8306112507;
            int employeeNum = 27563571;

            Console.WriteLine("First name : {0}\n Last name: {1}\n Age: {2}\n Gender: {3}\n Personal ID: {4}\n Unique Employee number: {5}",
                firstName, lastName, age, gender, personalID, employeeNum);
        }
    }

