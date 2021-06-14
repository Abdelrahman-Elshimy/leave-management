using leave_management.Contracts;
using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveHistoryRepository(ApplicationDbContext db)
        {
            this._db = db;
        }
        // create new entity
        public bool Create(LeaveHistory entity)
        {
            _db.LeaveHistories.Add(entity);
            return this.Save();
        }
        // Delete Entity
        public bool Delete(LeaveHistory entity)
        {
            _db.LeaveHistories.Remove(entity);
            return this.Save();
        }
        // Get All Leave Histories
        public ICollection<LeaveHistory> FindAll()
        {
            ICollection<LeaveHistory> leaveHistories = _db.LeaveHistories.ToList();
            return leaveHistories;
        }
        // Get Leave History by id
        public LeaveHistory FindById(int id)
        {
            LeaveHistory leaveHistory = _db.LeaveHistories.Find(id);
            return leaveHistory;
        }

        // save changes
        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }
        // update entity
        public bool Update(LeaveHistory entity)
        {
            _db.LeaveHistories.Update(entity);
            return this.Save();
        }
    }
}
