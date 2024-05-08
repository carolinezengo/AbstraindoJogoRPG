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
            return this.Name + " Lançou uma magia ";
        }
         public  string Attack(int bonus)
        {
            if(bonus > 6){
            return this.Name + " Lançou uma magia  supur forte com bonus "+ bonus;
            }
             return this.Name + " Lançou uma magia muito fraca " + bonus;
        }
    }
}