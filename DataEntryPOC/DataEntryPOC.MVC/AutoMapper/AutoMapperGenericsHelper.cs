using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataEntryPOC.MVC.AutoMapper
{

    public class AutoMapperGenericsHelper<TSource, TDestination>
    {
        public static TDestination MapViewModelAndEntity(TSource model)
        {           
            return Mapper.Map<TSource, TDestination>(model);
        }
    }

}