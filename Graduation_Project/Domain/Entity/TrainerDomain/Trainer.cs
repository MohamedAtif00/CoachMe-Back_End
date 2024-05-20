using Graduation_Project.Domain.Abstraction;
using Graduation_Project.Domain.Entity.UserDomain;
using Microsoft.AspNetCore.Identity;

namespace Graduation_Project.Domain.Entity.TrainerDomain
{
    public class Trainer :Entity<TrainerId>
    {
        public Trainer(TrainerId id, string username, string email, byte[] image) : base(id)
        {
            Username = username;
            Email = email;
            this.image = image;
        }
        public string Username { get;private set; }
        public byte[] image { get; private set; }
        public double? AvgRating { get; private set; }
        public string Email { get; private set; }
        public static Trainer Create(Guid userid,string username, byte[] image ,string email)
        {
            return new(TrainerId.Create(userid),username,email,image);
        }

        public void Update(string username, byte[] image, string email)
        {
            Username = username;
            Email = email;
            this.image = image;
        }

        public void ModifyAvgRating(double avg)
        {
            AvgRating = avg;
        }



    }


}
