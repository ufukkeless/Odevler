using Ders5Odev5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders5Odev5.Entities
{
    public class Player : IEntity
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
