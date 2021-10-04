using System;
using System.Linq;
using DataValidator.Core.Managers;
using DataValidator.Core.Validators;
using DataValidator.Data.Interfaces.Managers;
using DataValidator.Data.Repository.Repositories;

namespace DataValidator
{
    class Program
    {
        private static readonly ICustomerManager _customerManager;

        static Program()
        {
            _customerManager = new CustomerManager(new CustomerRepository(), new CustomerValidator());

        }
        static void Main(string[] args)
        {
            _customerManager.GetAll().ToList().ForEach(Console.WriteLine);

        }
    }
}