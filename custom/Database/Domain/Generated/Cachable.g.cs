// Allors generated file. 
// Do not edit this file, changes will be overwritten.
namespace Allors.Domain
{
	public partial interface Cachable :  Object, Allors.IObject
	{


		global::System.Guid CacheId 
		{
			get;
			set;
		}

		bool ExistCacheId{get;}

		void RemoveCacheId();

	}

	public partial interface CachableBuilder : ObjectBuilder , global::System.IDisposable
	{	
		global::System.Guid? CacheId {get;}
		

	}

	public partial class Cachables : global::Allors.ObjectsBase<Cachable>
	{
		public Cachables(Allors.ISession session) : base(session)
		{
		}

		public Allors.Meta.MetaCachable Meta
		{
			get
			{
				return Allors.Meta.MetaCachable.Instance;
			}
		}

		public override Allors.Meta.Composite ObjectType
		{
			get
			{
				return Meta.ObjectType;
			}
		}
	}

}