using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace DevXpert.Marketplace.Application.UseCases.Products.Commands;

public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(command => command.IdProduct)
            .NotEmpty().WithMessage("Please enter the CompanyCode");

        RuleFor(command => command.Name)
            .NotEmpty().WithMessage("Please enter the Name")
            .MaximumLength(255).WithMessage("255 Characters");

        RuleFor(command => command.Description)
            .NotEmpty().WithMessage("Please enter the Description")
            .MinimumLength(5).WithMessage("5 Characters")
            .MaximumLength(500).WithMessage("500 Characters");
    }
}
