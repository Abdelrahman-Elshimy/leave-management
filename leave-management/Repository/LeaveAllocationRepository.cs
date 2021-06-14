using leave_management.Contracts;
using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveAllocationRepository(ApplicationDbContext db)
        {
            this._db = db;
        }
        public bool Create(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Add(entity);
            return this.Save();
        }
        // Delete Entity
        public bool Delete(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Remove(entity);
            return this.Save();
        }
        // Get All Leave Allocations
        public ICollection<LeaveAllocation> FindAll()
        {
            ICollection<LeaveAllocation> leaveAllocations = _db.LeaveAllocations.ToList();
            return leaveAllocations;
        }
        // Get Leave Allocation by id
        public LeaveAllocation FindById(int id)
        {
            LeaveAllocation leaveAllocation = _db.LeaveAllocations.Find(id);
            return leaveAllocation;
        }

        // save changes
        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }
        // update entity
        public bool Update(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Update(entity);
            return this.Save();
        }
    }
}
