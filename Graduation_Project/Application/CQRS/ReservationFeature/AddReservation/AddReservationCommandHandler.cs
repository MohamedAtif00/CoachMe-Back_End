using Ardalis.Result;
using Graduation_Project.Application.Abstraction;
using Graduation_Project.Domain.Abstraction;
using Graduation_Project.Domain.Entity.PlanDomain;
using Graduation_Project.Domain.Entity.ReservationDomain;
using Graduation_Project.Domain.Entity.TrainerDomain;
using Graduation_Project.Domain.Entity.UserDomain;

namespace Graduation_Project.Application.CQRS.ReservationFeature.AddReservation
{
    public class AddReservationCommandHandler : ICommandHandler<AddReservationCommand>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddReservationCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result> Handle(AddReservationCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var reservation = await _unitOfWork.ReservationRepository.Add(Reservation.Create(
                                                                                                TrainerId.Create(request.trainerId),
                                                                                                UserId.Create(request.trainee),
                                                                                                planId.Create(request.planId)
                                                                                                )
                                                                                );

                int saving = await _unitOfWork.save();

                if (saving == 0) return Result.Error("No changes");

                return Result.Success();
            }catch (Exception ex)
            {
                return Result.Error("System Error");
            }
        }
    }
}
