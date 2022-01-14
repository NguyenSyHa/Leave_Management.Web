using Leave_Management.Web.Data;
using Leave_Management.Web.Models;

namespace Leave_Management.Web.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task CreateLeaveRequest(LeaveRequestCreateVM request);

        Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();

        Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);

        Task<List<LeaveRequest>> GetAllAsync(string employeeId);

        Task ChangeApprovalStatus(int leaveRequestId, bool approved);

        Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();
    }
}
