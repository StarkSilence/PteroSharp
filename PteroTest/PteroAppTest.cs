using System.IO;
using System.Linq;
using NUnit.Framework;
using PteroSharp;

namespace PteroTest
{
    public class Tests
    {
        private PteroApp _PteroApp;
        
        [SetUp]
        public void Setup()
        {
            var lines = File.ReadLines("server.txt");
            
            _PteroApp = new PteroApp(lines.First(), lines.Last());
        }

        [Test]
        public void GetAllUsers()
        {
            var users = _PteroApp.GetUsers();
            
            Assert.Pass($"User count: {users.Count}");
        }

        [Test]
        public void GetUser()
        {
            _PteroApp.GetUser(1);
            
            Assert.Pass();
        }
    }
}