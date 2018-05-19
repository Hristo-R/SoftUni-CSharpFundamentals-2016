namespace _03.Paths
{
    public class Path3D
    {
        private string sequence;

        public Path3D(string sequence)
        {
            this.Sequence = sequence;
        }

        public string Sequence
        {
            get
            {
                return this.sequence;
            }

            set
            {
                this.sequence = value;
            }
        }

        public override string ToString()
        {
            return this.Sequence;
        }
    }
}
