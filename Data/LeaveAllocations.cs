using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagemenrSystem.Data
{
    public class LeaveAllocations : MasterEntity
    {
        public int  NumberOfDays { get; set; }

        [ForeignKey("LeaveType")]
        public LeaveType leaveType { get; set; }
        public int LeaveId { get; set; }

        public string EmployeeId { get; set; }

    }
}
