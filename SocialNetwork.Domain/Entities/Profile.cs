using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SocialNetwork.Domain.Entities
{
    public class Profile
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Biografia { get; set; }
        public string Fundador { get; set; }
        public string PaisFundacao { get; set; }
        public string EstadoFundacao { get; set; }
        public string CidadeFundacao { get; set; }
        public DateTime Fundacao { get; set; }
        public int TotalIgrejas { get; set; }
        public int TotalFieis { get; set; }
        public string Religiao { get; set; }
        public string UriImageProfile { get; set; }
        public string UserId { get; set; }

        [NotMapped]
        public string FullName 
        { 
            get 
            { 
                return $"{Nome}"; 
            }
        }

    }
}
