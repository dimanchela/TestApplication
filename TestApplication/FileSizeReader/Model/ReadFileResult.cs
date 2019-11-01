using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class ReadFileResult
    {
        public string Name { get; set; }
        public ulong ByteSize { get; set; }
        public string ErrorMessage { get; set; }
    }
}
