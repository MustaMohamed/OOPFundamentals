namespace Singleton
{
    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    class Singleton
    {
        private static Singleton _instance;

        // Constructor is 'private'
        private Singleton()
        {
        }

        public static Singleton Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;

            // alternative code 
            // return _instance ?? (_instance = new Singleton());

            // alternative code 
            // return _instance ??= new Singleton();
        }
    }
}