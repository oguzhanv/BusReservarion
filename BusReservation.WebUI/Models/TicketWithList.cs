using BusReservation.Entity;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusReservation.WebUI.Models
{
    public class TicketWithList
    {
        public List<Ticket> Ticket { get; set; }
        public int TicketId { get; set; }
        public string TicketName { get; set; }
        public string TicketSurname { get; set; }
        public string TicketGender { get; set; }
        public string TicketMail { get; set; }
        public string TicketFromWhere { get; set; }
        public string TicketToWhere { get; set; }
        public string TicketDate { get; set; }
        public double TicketPrice { get; set; }
        public int TicketSeatNo { get; set; }
        public string TicketClock { get; set; }
        public string TicketPnrNo { get; set; }
        public int RouteId { get; set; }

    }
}
