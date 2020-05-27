namespace EmployeeManagerModel
{
    //Здесь и в остальных моделях - частичные классы хороши для переопределения виртуальных методов,
    //чтобы не загружать лишним кодом основные классы, используемые для генерации Моделей
    public partial class Employee
    {
        public override bool Equals(object obj)
        {
            if (obj as Employee == null) return false;
            var other = (Employee)obj;
            bool firstNamesEqual = HelperMethods.CustomStringComparer(this.FirstName, other.FirstName);
            bool secondNamesEqual = HelperMethods.CustomStringComparer(this.SecondName, other.SecondName);
            bool lastNamesEqual = HelperMethods.CustomStringComparer(this.LastName, other.LastName);
            bool aboutsEqual = HelperMethods.CustomStringComparer(this.About, other.About);

            return  firstNamesEqual && secondNamesEqual && 
                    lastNamesEqual && aboutsEqual &&
                    this.DateOfBirth.Equals(other.DateOfBirth) &&
                    this.Department.Equals(other.Department) &&
                    this.Address.Equals(other.Address);
        }
        
        public override string ToString()
        {
            return $"{LastName} {SecondName??""} {FirstName}, {Department.DepartmentName}";
        }

        //В контексте данной задачи переписывать GetHashCode() нет особого смысла,
        //но VisualStudio упорно предлагала это сделать. Не стал с ней спорить.
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
