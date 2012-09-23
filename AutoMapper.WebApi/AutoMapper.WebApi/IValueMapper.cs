using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapper.WebApi {
    public interface IValueMapper<in TSource, TTarget> {
        TTarget Map(TSource source);
        void Release(TTarget target);
    }

    public interface IValueMapper<in TSource> {

        object Map(TSource source, string profile);
        void Release(object target);

    }
}
