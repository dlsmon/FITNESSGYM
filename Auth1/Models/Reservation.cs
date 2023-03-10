using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FITNESSGYM.Models.Reservation;

namespace FITNESSGYM.Models
{
    //A Resevation is created for a session that will happen at given 
    //One client can make many resevations
    //A Reservation can have many clients. Up to maxParticipants.
    public class Reservation
    {
        public enum eCancelled
        {
            No = 0,
            Yes = 1
        }

        [Key]
        public int Id { get; set; }

        //Cancelled is like a boolean.
        //Reservation was created by client. By Default = 0 
        //Reservation was cancelled by client before the session date= 1 
        //Reservation was created by client but the client didn't participate = 2.
        public eCancelled? Cancelled { get; set; }
        public int? IdSession { get; set; }

        public int? IdClient { get; set; }

        [Timestamp]
        public byte[]? TimeStamp { get; set; }

        //Foreign KEYS
        [ForeignKey("IdSession")]
        public virtual Session? Session { get; set; }

        [ForeignKey("IdClient")]
        public virtual Client? Client { get; set; }

        public Reservation()
        {

        }
        public Reservation(int IdSession, int IdClient)
        {
            this.Cancelled = 0;
            this.IdClient = IdClient;
            this.IdSession = IdSession;
        }

    }
}
