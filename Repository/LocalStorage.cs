using Entities; 

namespace Repository
{
    public class LocalStorage
    {

        public List<Employe> employes = new List<Employe>();

        private static LocalStorage instance = null;
        private LocalStorage() { }
        public static LocalStorage Instance
        {
            get
            {
                if (instance == null)
                    instance = new LocalStorage();
                return instance;
            }
        }
    }
}
