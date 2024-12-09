namespace CoursWork
{
    public class IdGenerator
    {
        long id;

        public long Id => id == long.MaxValue ? 0 : ++id;

        public IdGenerator Clear()
        {
            id = 0;
            return this;
        }
    }
}