using MediatR;

namespace Zion1.Checkin.Application.Commands.CreateVisitor
{
    public class CreateVisitorRequest : IRequest<int>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
