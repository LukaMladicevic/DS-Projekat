using DSBooking.Application.Service.Client;
using DSBooking.Domain.Object.Client;
using DSBooking.Presentation.Presenter.Client;

public class PassportFilterStrategy : IFilterStrategy
{
    IClientService _service;
    public PassportFilterStrategy(IClientService clientService)
    {
        _service = clientService;
    }

    public IEnumerable<ClientObject> Filter(string filterString)
    {
        return _service.GetByPassportNo(filterString);
    }
}