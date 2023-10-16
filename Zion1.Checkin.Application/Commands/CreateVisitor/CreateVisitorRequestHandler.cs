using MediatR;
using Zion1.Checkin.Application.Commands.CreateVisitor;
using Zion1.Checkin.Application.Mapper;
using Zion1.Checkin.Domain.Entities;
using ZionConnect.Checkin.Application.Contracts;

namespace Zion1.Checkin.Application.Commands.CreateCheckin
{
    public class CreateVisitorRequestHandler : IRequestHandler<CreateVisitorRequest, int>
    {
        private readonly ICheckinCommandRepository _checkinCommandRepository;
        public CreateVisitorRequestHandler(ICheckinCommandRepository checkinCommandRepository)
        {
            _checkinCommandRepository = checkinCommandRepository;
        }

        public async Task<int> Handle(CreateVisitorRequest request, CancellationToken cancellationToken)
        {
            var visitor = CheckinMapper.Mapper.Map<Visitor>(request);
            if (visitor is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newCheckinInfo = await _checkinCommandRepository.AddAsync(visitor);
            return newCheckinInfo.Id;
        }
    }
}
