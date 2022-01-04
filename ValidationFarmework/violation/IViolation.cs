using System.Reflection;

namespace Project.ValidationFarmework.violation
{
    public interface IViolation
    {
        void setMessage(string message);
        void setValid(bool valid);
        bool getValid();

        string getProp();
        string getMessage();
    }
}