using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerRegisterSimulation
{
    public class Gamer
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string NationalIdentity { get; set; }
        public int BirthYear { get; set; }
        public bool Status { get; set; }
    }
}
