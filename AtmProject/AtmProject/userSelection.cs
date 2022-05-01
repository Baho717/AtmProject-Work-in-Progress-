namespace AtmProject
{
    internal class currentUser
    {
        internal string accountBalance;
        private string v1;
        private double v2;
        private string v3;
        private string v4;
        private string v5;
        private string v6;
        private string v;

        public currentUser(string v1, double v2, string v3, string v4, string v5, string v6)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
        }

        public currentUser(string v1, string v, string v3, string v4, string v5, string v6)
        {
            this.v1 = v1;
            this.v = v;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
        }

        public currentUser(string v1, double v2, string v3, string v4, string v5, string v6) : this(v1, v2, v3, v4, v5, v6)
        {
        }
    }
}