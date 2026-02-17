using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TournamentRanking
{
    public class Tournament
    {

        private SortedList<int, Team> _rankings = new SortedList<int, Team>();
        private LinkedList<Match> _schedule = new LinkedList<Match>();
        private Stack<Match> _undoStack = new Stack<Match>();

        // Add match to schedule
        public void ScheduleMatch(Match match)
        {
            // TODO: Add to linked list
        }

        // Record match result and update rankings
        public void RecordMatchResult(Match match, int team1Score, int team2Score)
        {
            _undoStack.Push(match.Clone());
            // TODO: Update team points and re-sort rankings
        }

        // Undo last match
        public void UndoLastMatch()
        {
            // TODO: Use stack to revert last match
        }

        // Get ranking position using binary search
        public int GetTeamRanking(Team team)
        {
            // TODO: Implement ranking lookup
        }


    }
}
