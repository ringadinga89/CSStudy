using Ch06.Sub1;

namespace Ch06.Sub2
{
    internal class Sedan 
    {
        private string v1;
        private string v2;
        private int v3;
        private int v4;

        public Sedan(string v1, string v2, int v3, int v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        internal void SpeedDown(int v)
        {
            throw new NotImplementedException();
        }
    }
}