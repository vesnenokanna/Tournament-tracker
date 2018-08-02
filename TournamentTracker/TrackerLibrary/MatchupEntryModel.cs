﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
   public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one Team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this particular team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchup this team came 
        /// from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

    }
}
