namespace ConsoleTest.Trigger
{
    public interface ITrigger<TParam>
    {
        void DoEvent(TParam obj);
    }


    public interface IAfterUpdatRegistration : ITrigger<UpdateRegistrationParameters> { }

 
    public interface IAfterRegistrationTrigger : ITrigger<RegistrationParameters> { }

    public class UpdateRegistrationParameters
    {
    }
    public class RegistrationParameters
    {
    }

}