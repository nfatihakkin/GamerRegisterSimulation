using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerRegisterSimulation
{
    public interface IGamerService
    {
        string Add(Gamer gamer);
        string Delete(Gamer gamer);
        string Update(Gamer gamer);

    }
}
