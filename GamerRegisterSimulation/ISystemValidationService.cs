using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerRegisterSimulation
{
    public interface ISystemValidationService
    {
        bool Validate(Gamer gamer);
    }
}
