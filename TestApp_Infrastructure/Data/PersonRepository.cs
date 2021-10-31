using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using TestApp_Core.Entities;
using TestApp_Core.Intefaces;

namespace TestApp_Infrastructure.Data
{
    public class PersonRepository : IPersonRepository
    {
        public async Task SavePersonAsync(Person person)
        {
            var json = JsonSerializer.Serialize(person);
            File.WriteAllText(@$"{Environment.CurrentDirectory}\person.json", json);
        }
    }
}
