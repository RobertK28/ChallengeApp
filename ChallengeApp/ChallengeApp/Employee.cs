namespace ChallengeApp
{
    internal class Employee
    {
        List<int> pointsOfEmployee = new List<int>();
       
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public int PointsOfEmployee
        {
            get
            {
                return pointsOfEmployee.Sum();
            }
        }

        public string DataOfEmployee 
        { 
            get 
            { 
                return this.Name + " " + this.Surname + " " + this.Age + " lat,"; 
            } 
        }
              
        public void AddPointsOfEmployee(int point)
        { 
            this.pointsOfEmployee.Add(point);
        }
      
    }
}
