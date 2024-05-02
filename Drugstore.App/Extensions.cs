using AutoMapper;

namespace Drugstore.Application
{
    public static class GenericMapper<TSource, TDestination>
    {
        private readonly static IMapper _mapper;
        
        static GenericMapper()
        {
            var mapperConfiguration = new MapperConfiguration(config => config.CreateMap<TSource, TDestination>());

            _mapper = new Mapper(mapperConfiguration);
        }

        public static TDestination Map(TSource source) 
        {
            return _mapper.Map<TSource, TDestination>(source);
        }
    }
}
