using System;
namespace API
{
        /* This the where instances of the classes will be run from resource */
        public class Resources
        {
                public static T GetResource<T>() where T : class
                {
                        var page = (T)Activator.CreateInstance(typeof(T));
                        return page;
                }
                public GetSkus GetSkuInfoResource => GetResource<GetSkus>();

                public GetSkusID GetSkuIDInfoResource => GetResource<GetSkusID>();

                public PostSkus PostSkuInfoResource => GetResource<PostSkus>();

                public DeleteSkus DeleteSkuIDInfoResource => GetResource<DeleteSkus>();
        }
}