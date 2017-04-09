using System;
using System.Reactive;
using System.Threading.Tasks;

namespace LeonaStore
{
	public interface ICache
	{
		Task<T> GetObjectAsync<T>(string key);

		Task<Unit> Insert<T>(string key, T data, DateTimeOffset? absoluteExpiration = null);

		Task<Unit> Delete(string key);

		Task Flush();
	}
}
