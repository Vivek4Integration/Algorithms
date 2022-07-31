using Microsoft.VisualStudio.TestTools.UnitTesting;
using Multiple.Algoriths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Algoriths.Tests
{
    [TestClass()]
    public class SongTests
    {
        [TestMethod()]
        public void IsRepeatingPlaylistTest()
        {
            Song first = new Song("1");
            Song second = new Song("2");
            Song third = new Song("3");
            Song fourth = new Song("4");
            Song fifth = new Song("5");
            Song sixth = new Song("6");
            Song seventh = new Song("7");
            Song eighth = new Song("8");
            Song nineth = new Song("9");
            Song tenth = new Song("10");
            first.NextSong = second;
            second.NextSong = third;
            third.NextSong = fourth;
            fourth.NextSong = fifth;
            fifth.NextSong = sixth;
            sixth.NextSong = seventh;
            seventh.NextSong = eighth;
            eighth.NextSong = nineth;
            nineth.NextSong = tenth;
            tenth.NextSong = sixth;


            Assert.IsTrue(first.IsRepeatingPlaylist());
            Assert.IsTrue(first.Intersection==sixth);
        }
    }
}