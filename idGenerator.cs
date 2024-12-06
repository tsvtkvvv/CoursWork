namespace Process
{
    public class IdGenerator
    {
        private long _id;

        
        public long Id
        {
            get
            {
                if (_id == long.MaxValue)
                {
                    _id = 0; 
                }
                return ++_id;
            }
        }

        
        public IdGenerator Clear()
        {
            _id = 0;
            return this;
        }
    }
}
