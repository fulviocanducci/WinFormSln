using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;

namespace Models.Extensions
{
    public static class ValidationExtension
    {
        public static string ErrorsToString(this List<ValidationFailure> errors)
        {
            return string.Join("\r\n", errors.Select(x => x.ErrorMessage));
        }
    }
}
