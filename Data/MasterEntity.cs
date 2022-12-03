namespace LeaveManagemenrSystem.Data
{
    public abstract class MasterEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
