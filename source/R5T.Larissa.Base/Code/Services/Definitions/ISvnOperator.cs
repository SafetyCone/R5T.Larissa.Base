using System;using R5T.T0064;


namespace R5T.Larissa
{[ServiceDefinitionMarker]
    public interface ISvnOperator:IServiceDefinition
    {
        void Add(string path);
        void Checkout(string repositoryUrl, string localDirectoryPath, string username, string password);
        void Commit(string path, string message, bool directoryOnly = false);
        string GetRemoteRepositoryUrl(string path);
        Version GetVersion();
        void Update(string path);
    }
}
