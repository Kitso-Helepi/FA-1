using System;

namespace HomeAffairsDigitalIdentityProcessor
{
    public class CitizenProfile
    {
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public int Age { get; private set; }
        public string CitizenshipStatus { get; set; }
        public string ValidationResult { get; private set; }

        public CitizenProfile(string fullName, string idNumber, string citizenshipStatus)
        {
            FullName = fullName;
            IDNumber = idNumber;
            CitizenshipStatus = citizenshipStatus;
            Age = CalculateAge();
            ValidationResult = ValidateID();
        }

        private int CalculateAge()
        {
            if (string.IsNullOrEmpty(IDNumber) || IDNumber.Length < 6)
                return 0;

            try
            {
                string yearStr = IDNumber.Substring(0, 2);
                string monthStr = IDNumber.Substring(2, 2);
                string dayStr = IDNumber.Substring(4, 2);

                int year = int.Parse(yearStr);
                int month = int.Parse(monthStr);
                int day = int.Parse(dayStr);

                int currentYearLastTwo = DateTime.Now.Year % 100;
                int fullYear = year > currentYearLastTwo ? 1900 + year : 2000 + year;

                DateTime birthDate = new DateTime(fullYear, month, day);
                DateTime today = DateTime.Today;

                int age = today.Year - birthDate.Year;
                if (birthDate > today.AddYears(-age))
                    age--;

                return age;
            }
            catch
            {
                return 0;
            }
        }

        public string ValidateID()
        {
            if (string.IsNullOrEmpty(IDNumber) || IDNumber.Length != 13)
            {
                return "Invalid ID. ID number must contain exactly 13 digits.";
            }

            foreach (char c in IDNumber)
            {
                if (!char.IsDigit(c))
                {
                    return "Invalid ID. ID number must contain only numeric characters.";
                }
            }

            if (Age <= 0 || Age > 120)
            {
                return "Invalid ID. Could not determine valid age from ID number.";
            }

            try
            {
                int month = int.Parse(IDNumber.Substring(2, 2));
                int day = int.Parse(IDNumber.Substring(4, 2));

                if (month < 1 || month > 12)
                    return "Invalid ID. Invalid month in ID number.";

                if (day < 1 || day > 31)
                    return "Invalid ID. Invalid day in ID number.";
            }
            catch
            {
                return "Invalid ID. Error parsing date from ID number.";
            }

            return $"Valid ID. Citizen is {Age} years old.";
        }

        public string GenerateProfileSummary()
        {
            string timestamp = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            return $"==== DIGITAL CITIZEN SUMMARY ====\r\n" +
                   $"Name: {FullName}\r\n" +
                   $"ID Number: {IDNumber}\r\n" +
                   $"Age: {Age}\r\n" +
                   $"Citizenship: {CitizenshipStatus}\r\n" +
                   $"Validation: {ValidationResult}\r\n" +
                   $"Processed at: Home Affairs Digital Desk\r\n" +
                   $"Timestamp: {timestamp}";
        }
    }
}