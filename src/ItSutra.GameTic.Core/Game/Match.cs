using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItSutra.GameTic.Game
{
    public class Match : FullAuditedEntity
    {
        [Display(Name = "Player")]
        public virtual int Player1Id { get; set; }
        [ForeignKey("MatchPlayerOneId")]
        public virtual Player PlayerOneId { get; set; }

        [Display(Name = "Player")]
        public virtual int Player2Id { get; set; }
        [ForeignKey("MatchPlayerTwoId")]
        public virtual Player PlayerTwoId { get; set; }

        public bool PlayerOneStatus { get; set; }
        public bool PlayerTwoStatus { get; set; }
        public int Moves { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Duration { get; set; }
        public TaskState State { get; set; }

        public Match()
        {
            CreationTime = DateTime.Now;
            EndTime = DateTime.Now;
            State = TaskState.Open;
        }
    }
    public enum TaskState : byte
    {
        Open = 0,
        Completed = 1
    }
}