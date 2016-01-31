﻿using Api_Foot_Data.Models.Common;

namespace Api_Foot_Data.Models.Results
{
    public class PlayersResult
    {
        public LinksPlayers _links { get; set; }
        public int count { get; set; }
        public Player[] players { get; set; }

        public string error { get; set; }
    }

    public class LinksPlayers
    {
        public Link self { get; set; }
        public Link team { get; set; }
    }
}