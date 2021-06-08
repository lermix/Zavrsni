using System;
using static Models.Enums;

namespace Models
{
    public class Partner
    {
        public int id { get; set; }
        public string name { get; set; }
        public string adress { get; set; }
        public string headquarters { get; set; }
        public string phoneNumber { get; set; }
        public string identificationNumber { get; set; }
        public string director { get; set; }
        public PartnerType type { get; set; }
    }
}