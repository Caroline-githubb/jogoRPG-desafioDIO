namespace JogoRPG.src.Entities
{
    public class Wirzard : Hero
    {
        public Wirzard(string Name, int Level, string HeroType, int HitPoint, int MagicPoint)
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
            if(Bonus > 15)
            {
                MagicPoint = MagicPoint - 150;
                if(MagicPoint < 150)
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
        
        public override string Cura()
        {               
            return this.Name + "Curou o parceiro de luta";
        }

        public string Cura(int FeiticoCura)
        {   
            MagicPoint = MagicPoint - FeiticoCura;
            return this.Name + " Curou o parceito de luta e ficou com MP de " + MagicPoint;
        }






        




    }
}