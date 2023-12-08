using Application.Features.Books.Command.Update;
using FluentValidation;

namespace API.Validation
{
    public class UpdateBookRequestValidator : AbstractValidator<UpdateBookRequest>
    {
        public UpdateBookRequestValidator()
        {
            RuleFor(book => book.ISBN).
                NotEmpty().
                WithMessage("ISBN не может быть пустым.").
                Length(13).
                WithMessage("Длина ISBN должна быть 13");
            RuleFor(book => book.Name).
                NotEmpty().
                WithMessage("Имя не может быть пустым.");
            RuleFor(book => book.Genre).
                NotEmpty().
                WithMessage("Жанр не может быть пустым.");
            RuleFor(book => book.Description).
                NotEmpty().
                WithMessage("Описание не может быть пустым.");
            RuleFor(book => book.Author).
                NotEmpty().
                WithMessage("Автор не может быть пустым.");
            RuleFor(book => book.TimeWhenBookWasTaken).
                LessThan(book => book.TimeWhenBookMustBeReturned).
                WithMessage("Время, когда книга была взята, должно быть меньше времени, когда книгу нужно вернуть.");
        }
    }
}
