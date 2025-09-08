using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Error;

namespace DSBooking.Application
{
    public class AddResult
    {
        public IEnumerable<DomainError> AddObjectErrors { get; }

        public AddResult(IEnumerable<DomainError> addObjectErrors)
        {
            AddObjectErrors = addObjectErrors;
        }

        public bool IsSuccess()
        {
            return !(AddObjectErrors.Any());
        }
    }
}
