using System;
using System.Collections.Generic;
using System.Reactive;
using System.Threading.Tasks;
using Akavache;
using System.Reactive.Linq;

namespace LeonaStore
{
	public class AkavacheImpl : ICache
	{
		public AkavacheImpl()
		{
			BlobCache.ApplicationName = CacheSetup.AppName;
		}

		public async Task<T> GetObjectAsync<T>(string key)
		{
			T returned;
			try
			{
				returned = await BlobCache.LocalMachine.GetObject<T>(key);
			}
			catch (KeyNotFoundException)
			{
				returned = default(T);
			}

			return returned;
		}

		public async Task<Unit> Insert<T>(string key, T data, DateTimeOffset? absoluteExpiration = default(DateTimeOffset?))
		{
			return await BlobCache.LocalMachine.InsertObject(key, data, absoluteExpiration); 
		}

		public async Task<Unit> Delete(string key)
		{
			return await BlobCache.LocalMachine.Invalidate(key); 
		}

		public async Task Flush()
		{
			await BlobCache.LocalMachine.Flush();
		}
	}
}
