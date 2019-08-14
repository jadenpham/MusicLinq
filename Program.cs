using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = MusicStore.GetData().AllArtists;
            List<Group> Groups = MusicStore.GetData().AllGroups;

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            // Artist MtVernon = Artists.FirstOrDefault(loc => loc.Hometown == "Mount Vernon");
            // System.Console.WriteLine(MtVernon.RealName);

            //Who is the youngest artist in our collection of artists?
            Artist Youngest = Artists.OrderBy(age => age.Age).FirstOrDefault();
            // System.Console.WriteLine(Youngest.ArtistName + " is the youngest at age " + Youngest.Age);

            //Display all artists with 'William' somewhere in their real name
            IEnumerable<Artist> Williams = from temp in Artists.Where(will => will.RealName.Contains("William")) select temp;
            foreach(var william in Williams)
            {
                System.Console.WriteLine(william.RealName);

            }
            //Display the 3 oldest artist from Atlanta
            IEnumerable<Artist> Oldest = Artists.OrderByDescending(age => age.Age).Take(3);
            foreach(var i in Oldest)
            {
                System.Console.WriteLine(i.ArtistName + " " + i.Age);
            }
            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
	        // Console.WriteLine(Groups.Count);
        }
    }
}
