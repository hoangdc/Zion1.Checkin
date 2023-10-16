using Zion1.Checkin.Domain.Entities;
using Zion1.Common.Application.Contracts;

namespace ZionConnect.Checkin.Application.Contracts
{
    public interface ICheckinCommandRepository : ICommandRepository<Visitor>
    {
        
    }
}
