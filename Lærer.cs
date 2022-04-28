using System;
using System.Collections.Generic;
using System.Text;

namespace Objectorientation
{
    public class Lærer
    {
        public string Navn { get; private set; }
        public bool ErPedagogisk { get; set; }
        private string Kjønn { get; set; }

        public Lærer(string name)
        {
            Navn = name;
        }

        public void ChangeName(string newName)
        {
            Navn = newName;
        }
        public void SetErPedagogisk(bool erPedagogisk)
        {
            ErPedagogisk = ErPedagogisk;
        }
        public void Undervis()
        {

        }
        public void Rådgive()
        {

        }
        public void Motivere()
        {

        }
    }
}
