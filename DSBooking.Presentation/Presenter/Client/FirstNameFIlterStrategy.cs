using DSBooking.Application.Service.Client;
using DSBooking.Domain.Object.Client;
using DSBooking.Presentation.Presenter.Client;

public class FirstNameFilterStrategy : IFilterStrategy
{
    IClientService _service;
    public FirstNameFilterStrategy(IClientService clientService)
    {
        _service = clientService;
    }

    public IEnumerable<ClientObject> Filter(string filterString)
    {
        return _service.GetByFirstName(filterString);
    }
}