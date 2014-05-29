namespace nurl.library.Interface
{
    public interface INurlCommand
    {
        void Parse(string[] args);

        void Save(string content, string path);
    }
}
