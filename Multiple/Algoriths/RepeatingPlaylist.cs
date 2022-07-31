using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Multiple.Algoriths
{
    public class Song
    {
        public String name { get; set; }
        public Song NextSong { get; set; }
        public Song Intersection;
        public Song(string name)
        {
            this.name = name;
        }

        public bool IsRepeatingPlaylist()
        {
            var slow = this.NextSong;
            var fast = slow?.NextSong;

            while (fast != null)
            {
                if (slow == this || slow == fast)
                {
                    MeetingAt(slow);
                    return true;

                }
                    
                slow = slow.NextSong;
                fast = fast.NextSong;
                fast = fast?.NextSong;
            }
            return false;
        }

        private void MeetingAt(Song slow)
        {
            var pointer1 = slow.NextSong;
            var pointer2 = this.NextSong;
            while (true)
            {
                if (pointer1 == pointer2)
                {
                    Intersection = pointer2;
                    return;
                }

                pointer1 = pointer1.NextSong;
                pointer2 = pointer2.NextSong;

            }
        }
    }

    
}
