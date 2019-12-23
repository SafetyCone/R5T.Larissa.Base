using System;


namespace R5T.Larissa
{
    public interface ISvnOperator
    {
        void Add(string path);
        void Checkout(string repositoryUrl, string localDirectoryPath);
        void Commit(string path, string message, bool directoryOnly = false);
        string GetRemoteRepositoryUrl(string path);
        Version GetVersion();
        void Update(string path);
    }
}
