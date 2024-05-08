using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstraindoJogoRpg.src.Entites
{
    public class Ninja : Hero

    {
         public Ninja(string name, int level, string herotype)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType=herotype;
        }
          public override string Attack()
        {
            return this.Name + " Jogou estrelas magicas";
        }
         public  string Attack(int bonus)
        {
            if(bonus > 6){
            return this.Name + " Jogou muitas estrelas um super poder com bonus "+ bonus;
            }
             return this.Name + "Jogou poucas estrelas com bonus  " + bonus;
        }
    }
}