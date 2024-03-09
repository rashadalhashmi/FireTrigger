namespace ConsoleTest.Trigger
{
    public interface ITrigger<TParam>
    {
        void DoEvent(TParam obj);
    }


    public interface IAfterUpdatRegistrationTrigger : ITrigger<UpdateRegistrationParameters> { }
    public interface IAfterRegistrationTrigger : ITrigger<RegistrationParameters> { }

    public class UpdateRegistrationParameters
    {
    }
    public class RegistrationParameters
    {
    }

}