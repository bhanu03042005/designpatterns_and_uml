using System;
namespace UAHighschool //Do NOT change the Namespace Name
{
    public class Highschool //Do NOT change the Class Name
    {
        
       private static Highschool _instance;
        // Implement your code here
        
        public string schoolName;

        // Holds the single instance (Singleton backing field)
        

        // Private constructor prevents external instantiation
        private Highschool() { }

        // Public static method to get/create the single instance
        public static Highschool GetSchoolInstance()
        {
            if (_instance == null)
            {
                _instance = new Highschool();
            }
            return _instance;
        }

    }
}
