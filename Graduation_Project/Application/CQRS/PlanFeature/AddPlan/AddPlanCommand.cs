using Graduation_Project.Application.Abstraction;

namespace Graduation_Project.Application.CQRS.PlanFeature.AddPlan
{
    public record AddPlanCommand(int duration, string focus, int sessions, decimal price) :ICommand;
    
    
}
