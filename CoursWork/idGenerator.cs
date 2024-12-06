namespace CoursWork
{


    public class IdGenerator
    {
        private long id;

        
        public long Id
        {
            get
            {
                return id == long.MaxValue ? 0 : ++id;
            }
        }

        public Model Model
        {
            get => default;
            set
            {
            }
        }

        public IdGenerator Clear()
        {
            id = 0;
            return this;
        }
    }
}
