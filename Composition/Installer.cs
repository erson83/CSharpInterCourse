namespace Composition

{
    public class Installer
    {


        private readonly Logger _logger;        // passing in Logger variable class here

        public Installer(Logger logger)
        {
            this._logger = logger;
        }

        public void Install()
        {

            _logger.Log("We are installing.");
        }

    }




}