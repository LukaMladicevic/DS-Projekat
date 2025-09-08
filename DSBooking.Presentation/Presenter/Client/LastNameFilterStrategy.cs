using DSBooking.Application.Service.Client;
using DSBooking.Domain.Object.Client;
using DSBooking.Presentation.Presenter.Client;

public class LastNameFilterStrategy : IFilterStrategy
{
    IClientService _service;
    public LastNameFilterStrategy(IClientService clientService)
    {
        _service = clientService;
    }

    public IEnumerable<ClientObject> Filter(string filterString)
    {
        return _service.GetByLastName(filterString);
    }
}