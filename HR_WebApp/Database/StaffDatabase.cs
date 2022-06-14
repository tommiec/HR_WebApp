using HR_WebApp.Domain;

namespace HR_WebApp.Database
{
    public class StaffDatabase : IStaffDatabase
    {
        private int counter = 0;
        private List<Staff> staffs;

        public StaffDatabase()
        {
            staffs = new List<Staff>();

            Insert(new Staff
            {
                FirstName = "Thomas",
                LastName = "Coppens",
                Address = "Schildersstraat 2, 9040 Gent",
                DOE = new DateOnly(2022, 02, 11)
            });

            Insert(new Staff
            {
                FirstName = "Lieselot",
                LastName = "Rijckaert",
                Address = "Petite Mormont 11a, 6666 Wibrin",
                DOE = new DateOnly(2022, 02, 11)
            });

        }

        public void Delete(int id)
        {
            var staff = staffs.FirstOrDefault(x => x.Id == id);
            if (staff != null)
            {
                staffs.Remove(staff);
            }
        }

        public IEnumerable<Staff> GetAll()
        {
            return staffs;
        }

        public Staff GetOne(int id)
        {
            return staffs.FirstOrDefault(x => x.Id == id);
        }

        public Staff Insert(Staff staff)
        {
            staff.Id = ++ counter;
            staffs.Add(staff);
            return staff;
        }

        public void update(int id, Staff updatedStaff)
        {
            var staff = staffs.FirstOrDefault(x => x.Id == id);
            if (staff != null)
            {
                staff.FirstName = updatedStaff.FirstName;
                staff.LastName = updatedStaff.LastName;
                staff.Address = updatedStaff.Address;
                staff.DOE = updatedStaff.DOE;
            }
        }
    }
}
