namespace Composition

{
    public class SystemExceptionMsg
    {
        private readonly StoreErrMsg _storeErrMsg;

        public SystemExceptionMsg(StoreErrMsg storeErrMsg)
        {
            this._storeErrMsg = storeErrMsg;
        }

        public void TriggerSystemExceptionMsg()
        {
            _storeErrMsg.ShowMsg("System execption encountered.");

        }


    }




}