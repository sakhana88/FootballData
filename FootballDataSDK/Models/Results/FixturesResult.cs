﻿using FootballDataSDK.Models.Common;

namespace FootballDataSDK.Models.Results
{
    public class FixturesResult
    {
        public Links _links { get; set; }

        public string timeFrameStart { get; set; }
        public string timeFrameEnd { get; set; }
        
        public int count { get; set; }
        public Fixture[] fixtures { get; set; }

        public string error { get; set; }
        

    }
    

}
