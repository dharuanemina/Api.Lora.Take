using Api.Lora.Take.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Lora.Take.Interface
{
    /// <summary>
    /// Repository interface facade
    /// </summary>
    public interface IRepositoryFacade
    {
        /// <summary>
        /// Get last x repositories of a especific informed language
        /// </summary>
        /// <returns>Returns a list of repositories</returns>
        Task<IEnumerable<Repository>> GetLastsAsync(RepositoryRequest repositoryRequest);
    }
}
