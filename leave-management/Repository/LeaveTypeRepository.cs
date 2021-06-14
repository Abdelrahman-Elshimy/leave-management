using leave_management.Contracts;
using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveTypeRepository(ApplicationDbContext db)
        {
            this._db = db;
        }
        // create new entity
        public bool Create(LeaveType entity)
        {
            _db.LeaveTypes.Add(entity);
            return this.Save();
        }
        // Delete Entity
        public bool Delete(LeaveType entity)
        {
            _db.LeaveTypes.Remove(entity);
            return this.Save();
        }
        // Get All Leave Type
        public ICollection<LeaveType> FindAll()
        {
           ICollection<LeaveType> leaveTypes =  _db.LeaveTypes.ToList();
            return leaveTypes;
        }
        // Get Leave type by id
        public LeaveType FindById(int id)
        {
            LeaveType leaveType = _db.LeaveTypes.Find(id);
            return leaveType;
        }

        public ICollection<LeaveType> GetEmployeeByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        // save changes
        public bool Save()
        {
            return  _db.SaveChanges() > 0;
        }
        // update entity
        public bool Update(LeaveType entity)
        {
            _db.LeaveTypes.Update(entity);
            return this.Save();
        }

    }
}
