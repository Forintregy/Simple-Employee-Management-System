using EmployeeManagerModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeManagerDesktop
{
    public class HelperMethods
    {
        //Метод создания и форматирования таблицы данных главной страницы приложения
        public static DataTable EmployeesToDataTable(IList<Employee> collection) 
        {
            var result = new DataTable();
            result.Columns.Add("Фамилия");
            result.Columns.Add("Имя");
            result.Columns.Add("Дата рождения");
            result.Columns.Add("Отдел");
            result.Columns.Add(new DataColumn {
                ColumnName = "Employee",
                DataType = typeof(Employee)
            });
            foreach (var item in collection)
            {
                var row = result.NewRow();
                row["Фамилия"] = item?.LastName;
                row["Имя"] = item?.FirstName;
                row["Дата рождения"] = item?.DateOfBirth.ToString("dd.MM.yyyy");
                row["Отдел"] = item?.Department?.DepartmentName;
                row["Employee"] = item;
                result.Rows.Add(row);
            }
            return result;
        }

        //Метод расчёта минимальных размеров формы
        public static Size GetMinSize(string text, Font font)
        {
            int width = 0;
            int height = 0;
            width = TextRenderer.MeasureText(text, font).Width;
            height = TextRenderer.MeasureText(text, font).Height;
            return new Size(width, height);
        }
        #region Самый важный метод

        private static List<string> Reasons => new List<string>{
            "Это же незаменимый работник!",
            "Но ведь этот человек в компании с самого дня основания!",
            "Это работник года!",
            "Это же родственник самого Игната Сергеевича!",
            "А кто тогда будет работать?",
            "Весь отдел потеряет любимого коллегу!"
        };

        public static string GenerateVeryImportantReason()
        {
            var random = new Random();
            return Reasons[random.Next(Reasons.Count)];
        }
        #endregion

    }
} 

