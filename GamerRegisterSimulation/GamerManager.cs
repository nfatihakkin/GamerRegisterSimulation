using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerRegisterSimulation
{
    public class GamerManager : IGamerService
    {
        ISystemValidationService _systemValidationService;

        public GamerManager(ISystemValidationService systemValidationService)
        {
            _systemValidationService = systemValidationService;
        }

        public string Add(Gamer gamer)
        {
            if (_systemValidationService.Validate(gamer))
            {
                return "Gamer Created !";
            }
            return "          Register Unsuccessful!" + "\n" +
                "(-)Rules:Passwords must be equlas !" + "\n" +
                "(-)Username have to contain 'C'" + "\n" +
                "(-)At least your age have to be 18";

        }

        public string Delete(Gamer gamer)
        {
            return "Gamer Deleted";
        }

        public string Update(Gamer gamer)
        {
            return "Gamer Updated";
        }
    }
}
