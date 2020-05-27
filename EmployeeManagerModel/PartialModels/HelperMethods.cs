using System;

namespace EmployeeManagerModel
{
    public class HelperMethods
    {
        //Данный метод написан для перегрузки метода Equals() частичных классов модели с целью сохранения принципа DRY
        public static bool CustomStringComparer(string first, string second)
        {
            return string.Compare
                (first?.Trim(), second?.Trim(), StringComparison.InvariantCultureIgnoreCase) == 0 ? true : false;
        }

    }
}
