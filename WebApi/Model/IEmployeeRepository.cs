// Agora implantaremos o repository, para deixar o código mais profissional separando regra de negócio / arquitetura de bd

namespace WebApi.Model
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);
        List<Employee> Get();

        Employee? Get(int id);
    }
}
