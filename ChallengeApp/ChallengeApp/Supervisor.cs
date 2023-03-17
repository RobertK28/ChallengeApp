
using System.Diagnostics;

namespace ChallengeApp
{
    public class Supervisor : Employee_v2, IEmployee
    {
                       
        public Supervisor()
            : this("no name", "no surname", "no sex")
        { }
        public Supervisor(string name, string surname)
            : this(name, surname, "no sex") 
        { }
        
        public Supervisor(string name, string surname, string sex)
            : base(name, surname)
        {       
        }

        new public void AddGrade(string grade)
        {
           
                switch (grade)
                {
                    case "6":
                        this.grades.Add(100);
                        break;
                    case "-6" or "6-":
                        this.grades.Add(95);
                        break;
                    case "+5" or "5+":
                        this.grades.Add(85);
                        break;
                    case "5":
                        this.grades.Add(80);
                        break;
                    case "-5" or "5-":
                        this.grades.Add(75);
                        break;
                    case "+4" or "4+":
                        this.grades.Add(65);
                        break;
                    case "4":
                        this.grades.Add(60);
                        break;
                    case "-4" or "4-":
                        this.grades.Add(55);
                        break;
                    case "+3" or "3+":
                        this.grades.Add(45);
                        break;
                    case "3":
                        this.grades.Add(40);
                        break;
                    case "-3" or "3-":
                        this.grades.Add(35);
                        break;
                    case "+2" or "2+":
                        this.grades.Add(25);
                        break;
                    case "2":
                        this.grades.Add(20);
                        break;
                    case "-2" or "2-":
                        this.grades.Add(15);
                        break;
                    case "+1" or "1+":
                        this.grades.Add(5);
                        break;
                    case "1":
                        this.grades.Add(0);
                        break;

                    default:
                    if (float.TryParse(grade, out float result))
                    {
                        this.AddGrade(result);
                        throw new Exception("Invalid grade value");
                    }
                    else if (char.TryParse(grade, out char charResult))
                    {

                        switch (charResult)
                        {
                            case 'A':
                            case 'a':
                                this.grades.Add(100);
                                break;
                            case 'B':
                            case 'b':
                                this.grades.Add(80);
                                break;
                            case 'C':
                            case 'c':
                                this.grades.Add(60);
                                break;
                            case 'D':
                            case 'd':
                                this.grades.Add(40);
                                break;
                            case 'E':
                            case 'e':
                                this.grades.Add(20);
                                break;
                            case 'F':
                            case 'f':
                                this.grades.Add(0);
                                break;
                            default:
                                throw new Exception("Wrong Letter");

                        }
                    }
                    else
                    { 
                        throw new Exception("Wrong Grade");
                    }
                    break;
                }
           
        }
        /*
        new public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(90);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(70);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(50);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(30);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(10);
                    break;
                default:
                    throw new Exception("Wrong Letter");

            }
        }
        */
    }
}
