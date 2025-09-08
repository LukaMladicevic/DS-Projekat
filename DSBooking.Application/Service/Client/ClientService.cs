using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Domain.Error;
using DSBooking.Domain.Object.Client;
using DSBooking.Domain.Service;
using DSBooking.Infrastructure.Repository.Client;

namespace DSBooking.Application.Service.Client
{
    public class ClientService : IClientService
    {
        IClientRepository _clientRepository;
        DomainClientService _domainService;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
            _domainService = new DomainClientService();
        }

        public AddResult AddClient(ClientAddObject client)
        {
            //IEnumerable<DomainError> errors = _domainService.CheckClientAddObject(client);

            //if(!errors.Any())
            //    _clientRepository.AddClient(client);

            //return new AddResult(errors);

            try
            {
                Debug.WriteLine("AddClient called for: " + client.FirstName + " " + client.LastName);

                IEnumerable<DomainError> errors = _domainService.CheckClientAddObject(client);

                if (!errors.Any())

                {
                    Debug.WriteLine("No validation errors, adding client to DB...");
                    _clientRepository.AddClient(client);
                    Debug.WriteLine("Client added successfully.");
                }
                else
                {
                    Debug.WriteLine("Validation errors found");
                }

                return new AddResult(errors);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ERROR in AddClient: " + ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw;
            }
        }

        public IEnumerable<ClientObject> GetByFirstName(string filterString)
        {
            //return _clientRepository.GetByFirstName(filterString);
            try
            {
                Debug.WriteLine($"GetByFirstName called with filter: {filterString}");
                var results = _clientRepository.GetByFirstName(filterString).ToList();
                Debug.WriteLine($"Found {results.Count} clients with first name containing '{filterString}'");
                return results;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ERROR in GetByFirstName: " + ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw;
            }
        }

        public IEnumerable<ClientObject> GetByLastName(string filterString)
        {
            //return _clientRepository.GetByLastName(filterString);
            try
            {
                Debug.WriteLine($"GetByLastName called with filter: {filterString}");
                var results = _clientRepository.GetByLastName(filterString).ToList();
                Debug.WriteLine($"Found {results.Count} clients with last name containing '{filterString}'");
                return results;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ERROR in GetByLastName: " + ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw;
            }
        }

        public IEnumerable<ClientObject> GetByPassportNo(string filterString)
        {
            //return _clientRepository.GetByPassportNo(filterString);
            try
            {
                Debug.WriteLine($"GetByPassportNo called with filter: {filterString}");
                var results = _clientRepository.GetByPassportNo(filterString).ToList();
                Debug.WriteLine($"Found {results.Count} clients with passport number containing '{filterString}'");
                return results;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ERROR in GetByPassportNo: " + ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw;
            }
        }

        public void RemoveClient(int clientId)
        {
            _clientRepository.RemoveClient(clientId);
        }
    }
}
