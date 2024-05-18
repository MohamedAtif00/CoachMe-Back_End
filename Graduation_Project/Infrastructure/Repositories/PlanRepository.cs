using Graduation_Project.Domain.Entity.PlanDomain;
using Graduation_Project.Domain.Repsitory.PlanRepo;
using Graduation_Project.Infrastructure.Data;
using Graduation_Project.Infrastructure.DomainConfig;

namespace Graduation_Project.Infrastructure.Repositories
{
    public class PlanRepository : GenericRepository<Plan, planId>, IPlanRepository
    {
        public PlanRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
