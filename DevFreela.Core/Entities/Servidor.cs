using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeversVideo.Core.Entities
{
    class Servidor : BaseEntity
    {
        public Servidor(string fullName, string email, DateTime birthDate)
        {
            
            CreateAt = DateTime.Now;
            
            Videos = new List<Video>();
            
        }


        public DateTime CreateAt { get; private set; }

        public List<Video> Videos { get; private set; }


    }
}
