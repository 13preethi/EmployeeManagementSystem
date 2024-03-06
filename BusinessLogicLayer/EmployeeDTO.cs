using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataAccessLayer;


namespace BusinessLogicLayer
{
  public  class EmployeeDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpCode { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }
        public Nullable<int> DeptCode { get; set; }

        public virtual DeptMaster DeptMaster { get; set; }
        public DateTime DueDate { get; set; }
    }
}
