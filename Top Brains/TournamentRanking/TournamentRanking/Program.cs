using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TournamentRanking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Tournament tournament = new Tournament();
            Team teamA = new Team { Name = "Team Alpha", Points = 0 };
            Team teamB = new Team { Name = "Team Beta", Points = 0 };

            tournament.ScheduleMatch(new Match(teamA, teamB));
            tournament.RecordMatchResult(/* match */, 3, 1); // Team A wins

            var rankings = tournament.GetRankings();
            Console.WriteLine(rankings[0].Name); // Should output: Team Alpha

            tournament.UndoLastMatch();
            Console.WriteLine(teamA.Points); // Should output: 0 (back to original)


        }
    }
}
