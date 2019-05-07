namespace AppMobile.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        #region Constructores

        public MainViewModel()
        {
            instance = this;
        }

        #endregion Constructores

        #region Singleton

        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }

            return instance;
        }

        #endregion Singleton
    }
}