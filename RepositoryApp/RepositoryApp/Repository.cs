using System;
using System.Net;

namespace RepositoryApp
{
    public class Repository : IRepository
    {
        public string GetEntity()
        {
            var wc = new WebClient();
            return wc.DownloadString("http://www.mocky.io/v2/5780d33a100000e801b11cd3");
        }

        public string[] GetEntities()
        {
            var wc = new WebClient();
            return wc.DownloadString("http://www.mocky.io/v2/5780da5b100000b402b11ce0").Split(';');
        }
    }
}
