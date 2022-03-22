namespace JogoRPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HitPoint, int MagicPoint)
        {
           this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HitPoint = HitPoint;
            this.MagicPoint = MagicPoint;
        }

        public override string Attack()
        {
            return this.Name + "Atacou com chutes e socos e lançou a sua faca";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 7)
            {
                MagicPoint = MagicPoint - 10;
                return this.Name + " Atacou com a sua espada com bonus de " + Bonus + " e " + "ficou com o MP igual a " + MagicPoint;                
            }

            else
            {                 
                return this.Name + " Atacou com sua espada com uma força mediana com bonus de " + Bonus;
            }  
        }       
    }
}