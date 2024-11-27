﻿using FluentValidation;

namespace QuizGame.Api.Contracts.V1;

/// <summary>
/// The validation rules for the <see cref="AnswerCreateRequest"/> model using FluentValidation. 
/// It ensures that the request data conforms to the expected format before processing.
/// </summary>
public class AnswerCreateRequestValidator : AbstractValidator<AnswerCreateRequest>
{
    public AnswerCreateRequestValidator()
    {
        RuleFor(x => x.QuestionId).NotEmpty();
        RuleFor(x => x.Text).NotEmpty();
        RuleFor(x => x.IsCorrect).NotNull();
    }
}