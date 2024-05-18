using Graduation_Project.Domain.Abstraction;

namespace Graduation_Project.Domain.Entity.PlanDomain
{
    public class Plan : Entity<planId>
    {
        public Plan(planId id, int duration, string focus, int sessions, decimal price) : base(id)
        {
            Duration = duration;
            Focus = focus;
            Sessions = sessions;
            Price = price;
        }

        public int Duration { get; set; }
        public string Focus { get; set; }
        public int Sessions { get; set; }
        public decimal Price { get; set; }



        public static Plan Create(int duration, string focus, int sessions, decimal price)
        {
            return new(planId.CreateUnique(),duration,focus,sessions,price);
        }
    }
}
