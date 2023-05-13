using AutoMapper;
using EasyShop.Model;
using System.Security.Cryptography;
using FluentValidation;
using EasyShop.Repository.Interface;
using EasyShop.Service.Interface;
using EasyShop.Validator;
using static EasyShop.Context.DTO.CustomerDto;
using System.Text;

namespace EasyShop.Service.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepository;
        private readonly PasswordValidator _passwordValidator;
        private readonly CpfValidator _cpfValidator;

        public CustomerService(IMapper mapper, 
            ICustomerRepository customerRepository,
            PasswordValidator passwordValidator,
            CpfValidator cpfValidator)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
            _passwordValidator = passwordValidator;
            _cpfValidator = cpfValidator;
        }

        public async Task<IEnumerable<CustomerReadDTO>> GetAllAsync()
        {
            var customers = await _customerRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CustomerReadDTO>>(customers);
        }

        public async Task<CustomerReadDTO> GetByIdAsync(int id)
        {
            var customers = await _customerRepository.GetByIdAsync(id);
            return _mapper.Map<CustomerReadDTO>(customers);
        }

        public async Task AddAsync(CustomerCreateDTO customerCreateDTO)
        {
            var customer = _mapper.Map<Customer>(customerCreateDTO);
            var passwordValidator = new PasswordValidator();
            var validationResultPassword = passwordValidator.Validate(customerCreateDTO.Password);
            var cpfValidator = new CpfValidator();
            var validationResultCpf = cpfValidator.Validate(customer.CPF);

            if (customer != null)
            {
                customer.Birthday = customer.Birthday.Value.Date;
            }

            if (await _customerRepository.GetByUsernameAsync(customer.Username))
            {
                throw new Exception("Username is already in use");
            }

            if (!validationResultPassword)
            {
                throw new ArgumentException("Password does not meet security requirements.");
            }

            if (!validationResultCpf)
            {
                throw new ArgumentException("Invalid CPF");
            }

            string hashedPassword = PasswordHasher(customerCreateDTO.Password);
            customer.Password = hashedPassword;


            await _customerRepository.AddAsync(customer);
        }

        public async Task UpdateAsync(CustomerUpdateDTO customerUpdateDTO)
        {
            var customer = _mapper.Map<Customer>(customerUpdateDTO);
            var passwordValidator = new PasswordValidator();
            var validationResultPassword = passwordValidator.Validate(customer.Password);

            if (await _customerRepository.GetByUsernameAsync(customer.Username))
            {
                throw new Exception("Username is already in use");
            }

            if (!validationResultPassword)
            {
                throw new ArgumentException("Password does not meet security requirements.");
            }

            string hashedPassword = PasswordHasher(customerUpdateDTO.Password);
            customer.Password = hashedPassword;


            await _customerRepository.UpdateAsync(customer);
        }

        public async Task DeleteAsync(int id)
        {
            var customer = await _customerRepository.GetByIdAsync(id);
            await _customerRepository.DeleteAsync(customer);
        }

        private static string PasswordHasher(string password)
        {
            using var sha256 = SHA256.Create();
            var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
        }
    }
}
