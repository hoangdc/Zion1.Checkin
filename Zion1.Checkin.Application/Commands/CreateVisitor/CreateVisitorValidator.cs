
using FluentValidation;
using System.Text.RegularExpressions;
using Zion1.Checkin.Application.Commands.CreateVisitor;

namespace Zion1.Checkin.Application.Commands.CreateVisistor;

public class CreateVisitorValidator : AbstractValidator<CreateVisitorRequest>
{
    public CreateVisitorValidator()
    {
        RuleLevelCascadeMode = CascadeMode.Stop;

        RuleFor(x => x.FirstName).NotEmpty();
        RuleFor(x => x.LastName).NotEmpty();
        RuleFor(x => x.PhoneNumber)
            .NotEmpty()
            .NotNull()//.WithMessage("Phone Number is required.")
            .MinimumLength(10)//.WithMessage("Phone Number must not be less than 10 characters.")
            .MaximumLength(20)//.WithMessage("Phone Number must not exceed 50 characters.")
            .Matches(new Regex(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}")).WithMessage("'Phone Number' is invalid");
        RuleFor(x => x.Email).EmailAddress().WithMessage("Email is invalid");
    }

}