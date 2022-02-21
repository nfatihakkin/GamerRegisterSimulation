using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerRegisterSimulation
{
    public class SystemValidationManager : ISystemValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear<=(DateTime.Now.Year-18) && gamer.Username.Contains("C") && gamer.ConfirmPassword == gamer.Password)
            {
                return true;
            }
            return false;
        }
    }
}
