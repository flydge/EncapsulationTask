using System.Collections.Generic;

namespace EncapsulationTask
{
    public interface ICommunication
    {
        List<string> WordsList { get; set; }

        string Greeting();
        string Parting();
        string Threatening();   
        

    }
}