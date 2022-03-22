namespace JogoRPG.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int HitPoint, int MagicPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HitPoint = HitPoint;
            this.MagicPoint = MagicPoint;
        }        

        public Hero()
        {

        }

        public string Name;
        public int Level;
        public string HeroType;
        public int HitPoint;
        public int MagicPoint;       

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;            
        }

        public virtual string Attack()
        {
            return this.Name + "Atacou com a sua espada.";
        }

        public virtual string Cura()
        {
            return this.Name + "Curou o parceiro de luta";
        }


        
        
    }
}