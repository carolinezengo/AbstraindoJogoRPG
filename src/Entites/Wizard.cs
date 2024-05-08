using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstraindoJogoRpg.src.Entites
{
    public class Wizard : Hero
    {
          public Wizard(string name, int level, string herotype)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType=herotype;
        }
        
        public override string Attack()
        {
            return this.Name + " Lançu magia ";
        }
    }
}