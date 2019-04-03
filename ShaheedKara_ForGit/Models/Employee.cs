using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShaheedKara_ForGit.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="Employee ID")]
        public int EmpID { get; set; }
        [Required]
        [Display(Name = "Employee First Name")]
        public String FirstName { get; set; }
        [Required]
        [Display(Name = "Employee Last Name")]
        public String LastName { get; set; }
        [Required]
        [Display(Name = "ID Number")]
        public String IDNumber { get; set; }
        [Required]
        [Display(Name = "Employee Cellphone Number")]
        public String CellNum { get; set; }
        [Required]
        [Display(Name = "Employee Department")]
        public String Department { get; set; }
        [Required]
        [Display(Name = "Employee Wage")]
        public double Wage { get; set; }





        public string CalcTotWage()
        {


            DataContext db = new DataContext();
            double Total = 0;
            Employee emp = new Employee();
            var Totwage = from w in db.Employees select w.Wage;
            Totwage.ToList();
             Total = Totwage.Sum();
            double average = Totwage.Average();

            string output = " Total wages    :   " + Total +
                            "\n Average wage   :   " + average;


            return output;
        }
    }

    public class WageViewModel
    {
        [Key]
        public int Key { get; set; }
        public string display { get; set; }

    }



}
