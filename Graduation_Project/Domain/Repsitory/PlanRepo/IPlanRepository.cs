using Graduation_Project.Domain.Abstraction;
using Graduation_Project.Domain.Entity.PlanDomain;

namespace Graduation_Project.Domain.Repsitory.PlanRepo
{
    public interface IPlanRepository : IGenericRepository<Plan,planId>
    {
    }
}
