namespace JogoRPG.src.Entities
{
    public class Sorcerer : Hero
    {
        public Sorcerer(string Name, int Level, string HeroType, int HitPoint, int MagicPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HitPoint = HitPoint;
            this.MagicPoint = MagicPoint;
        }
        
        public override string Attack()
        {
            return this.Name + " Lançou a sua magia.";
        }
        public string Attack(int Bonus)
        {
            if(Bonus > 20)
            {
                MagicPoint = MagicPoint - 300;
                if(MagicPoint < 300)
                {
                    return this.Name + " Impossivel utilizar a força Bonus ";
                }

                return this.Name + " Lançou a magia com bonus de ataque de " + Bonus + " e " + "ficou com o MP igual a " + MagicPoint;
                
            }
            else
            {   
                return this.Name + " Lançou a sua magia com força fraca com bonus de " + Bonus;
            }           
        }    
    }
}