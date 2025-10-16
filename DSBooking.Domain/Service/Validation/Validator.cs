using DSBooking.Domain.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Service.Validation
{
    public abstract class Validator<T>
    {
        protected Validator<T>? Next { get; private set; }

        public void SetNext(Validator<T> next)
        {
            Next = next;
        }

        public List<DomainError> Validate(T obj)
        {
            var errors = Handle(obj) ?? new List<DomainError>();

            if (Next != null)
            {
                errors.AddRange(Next.Validate(obj));
            }

            return errors;
        }

        protected abstract List<DomainError>? Handle(T obj);
    }
}
