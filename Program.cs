namespace EventAssigment
{
    internal class ProgramChecker
    {
        public delegate void NotifyHandler();
        public event NotifyHandler NotifyOtherClass;


        public void PasswordBreach()
        {
            Console.WriteLine("Password Incorrect");      
        }

        protected virtual void OnpasswordIncorrect()
        {
            NotifyOtherClass?.Invoke();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class PasswordReset
    {
        public void ResetPassword()
        {
            var pass = new ProgramChecker();
            pass.NotifyOtherClass += ForgetPassword;
            pass.NotifyOtherClass += () => Console.WriteLine("Reset password");
            pass.PasswordBreach();
        }

        public void ForgetPassword()
        {
            Console.WriteLine("Do you rember your secret key");
            Console.ReadLine();
        }
    }
}