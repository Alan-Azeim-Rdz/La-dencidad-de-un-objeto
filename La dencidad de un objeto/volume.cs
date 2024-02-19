namespace Formula_de_la_dencidad_de_un_objeto
{
    internal class volume
    {
        protected double v;
        public double V
        {
            get { return v; }
            set { v = value; }
        }
        public volume()
        {
            v = 0;
        }
        public volume(double v)
        {
            this.v = v;
        }

        public override string ToString()
        {
            return " volume: " + v;
        }
    }
}
