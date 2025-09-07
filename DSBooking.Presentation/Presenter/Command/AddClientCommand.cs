using System;
using DSBooking.Application.Service.Client;
using DSBooking.Domain.Entity.Client;

namespace DSBooking.Presentation.Presenter.Command
{
    internal class AddClientCommand : ICommand
    {
        private readonly IClientService _service;
        private readonly ClientAddObject _addObject;

        private int? _id;

        public AddClientCommand(IClientService service, ClientAddObject addObject)
        {
            _service = service;
            _addObject = addObject;
            _id = null;
        }

        public void Execute()
        {
            if (_id == null)
            {
                _id = _service.AddClient(_addObject);
            }
        }

        public void Undo()
        {
            if (_id != null)
            {
                _service.RemoveClient(_id.Value);
                _id = null;
            }
        }

        public void Redo()
        {
            if (_id == null)
            {
                _id = _service.AddClient(_addObject);
            }
        }
    }
}