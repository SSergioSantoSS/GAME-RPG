using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GAME.Entities
{
    public class Monster : Hero
    {
        
        public Monster(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }
        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Lançou uma Pedra ";
        }
        public string Attack(int Bonus)
        {

            if (Bonus > 6)
            {
                return this.Name + " Lançou magia super efetiva com Bonus de Ataque de" + Bonus;

            }
            else
            {
                return this.Name + " Lançou magia com força fraca comBonus de Ataque de" + Bonus;
            }
            

        }
        
    }
}
