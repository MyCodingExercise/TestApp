using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp_Core.Entities;

namespace TestApp_Core.Intefaces
{
    public interface IPersonRepository
    {
        Task SavePersonAsync(Person person);

    }
}
