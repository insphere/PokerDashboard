//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PokerDashboard.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Game
    {
        public Game()
        {
            this.GamePlayers = new HashSet<GamePlayer>();
        }
    
        public long Id { get; set; }
        public System.DateTime Date { get; set; }
        public string WinnerHand { get; set; }
        public long BuyInValue { get; set; }
    
        public virtual ICollection<GamePlayer> GamePlayers { get; set; }
    }
}
