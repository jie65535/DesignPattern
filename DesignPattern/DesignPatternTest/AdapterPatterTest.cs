using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.AdapterPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTest
{
    [TestClass]
    public class AdapterPatterTest
    {
        [DataTestMethod]
        [DataRow("mp3", "beyond the horizon.mp3")]
        [DataRow("mp4", "alone.mp4")]
        [DataRow("vlc", "far far away.vlc")]
        public void TestMethod1(string audioType, string fileName)
        {
            AudioPlayer audioPlayer = new AudioPlayer();
            Assert.IsTrue(audioPlayer.Play(audioType, fileName));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.ThrowsException<ArgumentException>(() => new AudioPlayer().Play("avi", "mind me.avi"));
        }
    }
}
