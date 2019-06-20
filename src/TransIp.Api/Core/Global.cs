using AutoMapper;

namespace TransIp.Api
{
    public static class Global
    {
        private static bool initialized = false;

        public static void EnsureAutoMapperIsInitialized()
        {
            if (!initialized)
            {
                Mapper.Initialize(cfg =>
                {
                    cfg.AddProfile<DomainServiceMapperProfile>();
                    cfg.AddProfile<VpsServiceMapperProfile>();
                });
            }

        }
    }
}