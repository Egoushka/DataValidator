using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using DataValidator.Core.Validators;
using DataValidator.Data.Interfaces.Managers;
using DataValidator.Data.Models;
using DataValidator.Data.Repository.Repositories;

namespace DataValidator.Core.Managers
{
    public class CustomerManager : ICustomerManager
    {
        private readonly CustomerRepository _customerRepository;
        private readonly CustomerValidator _customerValidator;
        public CustomerManager(CustomerRepository customerRepository, CustomerValidator customerValidator)
        {
            _customerRepository = customerRepository;
            _customerValidator = customerValidator;
        }


        public async Task<Customer> AddNew(Customer newEntity)
        {
            var answer = await _customerRepository.AddAsync(newEntity);
            return answer;

        }

        public IEnumerable<Customer> GetAll()
        {
            var customers = _customerRepository.GetAll();
            var result = new List<Customer>();

            foreach (var item in customers)
            {
                var validationResult = _customerValidator.Validate(item);
                if (validationResult.IsValid)
                {
                    result.Add(item);
                    continue;
                }

                Console.WriteLine(JsonSerializer.Serialize(item) + " has errors =>");
                foreach (var error in validationResult.Errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
                
            }

            return result;
        }

        public Task<Customer> Update(Customer updateEntity)
        {
            throw new NotImplementedException();
        }
    }
}
