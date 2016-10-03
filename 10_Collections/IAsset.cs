using System.Security.Cryptography.X509Certificates;

namespace _10_Collections
{
    public interface IAsset
    {
        double GetValue();
        string GetName();
    }
    
}