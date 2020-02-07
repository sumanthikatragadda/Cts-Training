using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAssgn
{
    abstract class Player
    {
        protected string name;
        protected string tname;
        protected int nmatches;
        public abstract void Displayplayerstatistic();
        public Player(string name,string tname,int nmatches)
        {
            this.name = name;
            this.tname = tname;
            this.nmatches = nmatches;
        }

    }
    class CricketPlayer : Player
    {
        int totalruns;
        int nofwicketstaken;

        public CricketPlayer( string name, string tname, int nmatches, int totalruns, int nofwicketstaken) :base(name, tname,nmatches)
        {
            this.totalruns = totalruns;
            this.nofwicketstaken = nofwicketstaken;

        }
        public override void Displayplayerstatistic()
        {
            Console.WriteLine("name" + this.name + "teamname" + this.tname + "matches" + this.nmatches + "runs" + this.totalruns + "wickets" + this.nofwicketstaken);
        }
    }
    class HockeyPlayer:Player
    {
        string position;
        int goals;

        public HockeyPlayer(string name, string tname, int nmatches, string position, int goals) :base( name,tname,nmatches)
        {
            this.position = position;
            this.goals = goals;

        }
        public override void Displayplayerstatistic()
        {
            Console.WriteLine("name" + this.name + "teamname" + this.tname + "matches" + this.nmatches + "position" + this.position + "goals" + this.goals);
        }
    }
}


