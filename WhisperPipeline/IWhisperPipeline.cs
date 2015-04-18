using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Use this interface to implement your new pipeline integration module.
namespace WhisperMessage.Pipeline
{
    public interface IWhisperPipeline
    {
        string Whisper(string message);
    }
}
