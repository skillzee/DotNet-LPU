using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentRanking
{
    public class Team : IComparable<Team>
    {
        public string Name { get; set; }
        public int Points { get; set; }

        public int CompareTo(Team other)
        {
            // TODO: Compare by points descending, then by name
        }
    }

}
