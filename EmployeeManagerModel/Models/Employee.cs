using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Text;

namespace EmployeeManagerModel
{
    //Здесь и в других Моделях определены аннотации [в квадратных скобках] к полям,
    //позволяющие установить типы данных столбцов и ограничения по ним для таблиц SQL,
    //поскольку по умолчанию Entity Framework не устанавливает эти ограничения, что 
    //может вести к снижению производительности запросов на больших объёмах данных
    //[Key] - превичный ключ таблицы, [ForeignKey] - внешний ключ связынной таблицы
    //[DataType] - дополнительный тип данных столбца (например, DateTime),
    //[TypeName] - тип данных столбца
    public partial class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(1), MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string FirstName { get; set; }
        [MinLength(0), MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string SecondName { get; set; }
        [Required]
        [MinLength(1), MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string LastName { get; set; }
        public string About { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public Address Address { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        [Required]
        public virtual Department Department{ get; set; }
    }
}
