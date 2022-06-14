using HR_WebApp.Domain;

namespace HR_WebApp.Database
{
    public interface IStaffDatabase
    {
        Staff Insert(Staff staff);
        IEnumerable<Staff> GetAll();
        Staff GetOne(int id);
        void update(int id, Staff staff);
        void Delete(int id);
    }
}
