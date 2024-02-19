namespace Formula_de_la_dencidad_de_un_objeto
{
    internal class Mass : volume
    {
        protected double m;

        public double M
        {
            get { return m; }
            set { m = value; }
        }
        public Mass() : base()
        {
            m = 0;
        }
        public Mass(double m) : base()
        {
            this.m = m;
        }
        public override string ToString()
        {
            return "Mass: " + m;
        }
    }
}
