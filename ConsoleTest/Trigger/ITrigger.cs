namespace ConsoleTest.Trigger
{
    public interface ITrigger
    {
        void DoEvent(object obj);
    }


    public interface IAfterUpdatRegistration : ITrigger { }
    public interface IAfterRegistrationTrigger : ITrigger { }
}